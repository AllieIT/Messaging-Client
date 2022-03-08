using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingClient
{
    public partial class Form2 : Form
    {
        private List<Image> images = new List<Image>();
        private List<ImageData> iData = new List<ImageData>();
        private int index = 0;
        private string lang = "en_US";

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int CS_DropShadow = 0x00020000;

        [DllImportAttribute("user32.dll")]                                      //Those are for drag detection on panel
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form2()
        {
            InitializeComponent();
            loadImages();
        }

        protected override CreateParams CreateParams                            //Create window shadow
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void pnControls_MouseDown(object sender, MouseEventArgs e)      //Moving the window
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void loadImages()
        {
            images = new List<Image>();
            iData = new List<ImageData>();

            string img_folder = Path.GetFullPath(@"Images");
            string[] paths = Directory.GetFiles(img_folder);
            foreach (string img_path in paths)
            {
                Image image = Image.FromFile(img_path);
                ImageData data = new ImageData(img_path);
                iData.Add(data);
                images.Add(image);
            }
            if(images.Count > 0)
            {
                pictureBox1.Image = images[index];
                try
                {
                    imageData.Text = iData[index].toLabel(lang);
                }
                catch { }
            }
            if (images.Count < 2)
                bNext.Enabled = bPrevious.Enabled = false;
            else
                bNext.Enabled = bPrevious.Enabled = true;

            index = images.Count - 1;
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            index += 1;
            index = index % images.Count;
            pictureBox1.Image = images[index];
            imageData.Text = iData[index].toLabel(lang);
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            index -= 1;
            if (index < 0)
                index += images.Count;
            pictureBox1.Image = images[index];
            imageData.Text = iData[index].toLabel(lang);
        }

        public void setLanguage(string lang)
        {
            this.lang = lang;
        }

        private void bLast_Click(object sender, EventArgs e)
        {
            index = images.Count - 1;
            if (images.Count > 0)
            {
                pictureBox1.Image = images[index];
                imageData.Text = iData[index].toLabel(lang);
            }
        }

        private void bFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            if (images.Count > 0)
            {
                pictureBox1.Image = images[index];
                imageData.Text = iData[index].toLabel(lang);
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete that file?", "Delete", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                string path = iData[index].path;
                images.Remove(images[index]);
                iData.Remove(iData[index]);
                index--;
                if(index < 0)
                    index = 0;
                loadImages();               
            }
        }
    }

    public class ImageData
    {
        public string hourSent;
        public string dateSent;
        public string sender;
        public string path;

        public ImageData(string data)
        {
            path = data;
            string[] split = data.Split('\\');
            Array.Reverse(split, 0, split.Length);
            data = split[0];

            string toParse = "";
            string name = "";

            for (int i = 0; i < 24; i++)
                toParse += data[i];
            for (int i = 24; i < data.Length - 4; i++)
                name += data[i];

            Console.WriteLine(toParse);
            Console.WriteLine(name);

            DateTime dt = DateTime.ParseExact(toParse, "dd_MM_yyyy_HH_mm_ss_ffff", null);

            hourSent = dt.ToString("HH:mm");
            dateSent = dt.ToString("dd.MM.yyyy");
            sender = name;
        }

        public string toLabel(string langCode)
        {
            switch (langCode)
            {
                case "pl_PL":
                    return "Wysłane o " + hourSent + " dnia " + dateSent + " przez " + sender;
                    break;
                case "en_US":
                    return "Sent at " + hourSent + " on " + dateSent + " by " + sender;
                    break;
            }
            return "";
        }
    }
}
