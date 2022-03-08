using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace MessagingClient
{
    public partial class Form1 : Form
    {
        Form2 gallery = new Form2();
        private BinaryReader reading = null;
        private BinaryWriter writing = null;
        private TcpClient client = null;
        private bool activeCall = false;
        private bool toSend = false;
        private Dictionary<string, Dictionary<string, string>> langDict = new Dictionary<string, Dictionary<string, string>>();
        private OpenFileDialog ofd = new OpenFileDialog();
        public string lang = "en_US";
        public string CLIENT_VERSION = "0.7";
        public string RELEASE_DATE = "01.03.2021";
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int CS_DropShadow = 0x00020000;

        [DllImportAttribute("user32.dll")]                                      //Those are for drag detection on panel
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            InitializeLang();
            SetLanguage("en_US");
            label6.Text = "Simplicity communicator v " + CLIENT_VERSION + " (Release " + RELEASE_DATE + ")";
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

        private void Disconnect()
        {
            activeCall = false;
            tbMessage.Invoke(new MethodInvoker(delegate
            {
                tbMessage.Text = null;
                tbMessage.Enabled = false;
            }));
            lbMessage.Invoke(new MethodInvoker(delegate
            {
                lbMessage.Items.Clear();
            }));
            tbName.Invoke(new MethodInvoker(delegate
            {
                tbName.Text = null;
            }));
            pMessage.Invoke(new MethodInvoker(delegate
            {
                pMessage.BackColor = Color.FromArgb(240, 240, 240);
            }));
            bPolish.Invoke(new MethodInvoker(delegate
            {
                bPolish.Enabled = true;
            }));
            bEnglish.Invoke(new MethodInvoker(delegate
            {
                bEnglish.Enabled = true;
            }));
            bSend.Invoke(new MethodInvoker(delegate
            {
                bSend.Enabled = false;
            }));
            bAttach.Invoke(new MethodInvoker(delegate
            {
                bAttach.Enabled = false;
            }));
            bConnect.Invoke(new MethodInvoker(delegate
            {
                bConnect.Text = "Connect";
            }));
            try 
            {
                client.Close();
            }
            catch { }
            client = null;
            bwReceive.CancelAsync();
            bgMessaging.CancelAsync();
        }

        private void Connect()
        {
            string name = tbName.Text;
            if (name != "")
            {
                string host = tbHostAddress.Text;
                int port = System.Convert.ToInt16(nUDPort.Value);
                try
                {
                    client = new TcpClient(host, port);
                    lbMessage.Items.Add(langDict[lang]["CONNECTION_1"] + host + langDict[lang]["CONNECTION_2"] + port);
                    reading = new BinaryReader(client.GetStream());
                    writing = new BinaryWriter(client.GetStream());
                    writing.Write(CLIENT_VERSION);
                    writing.Write(name);
                    writing.Write(lang);
                    activeCall = true;
                    tbMessage.Enabled = true;
                    pMessage.BackColor = Color.White;
                    bPolish.Enabled = false;
                    bEnglish.Enabled = false;
                    bConnect.Text = langDict[lang]["DISCONNECT"];
                    bSend.Enabled = true;
                    bAttach.Enabled = true;
                    bgMessaging.RunWorkerAsync();
                    bwReceive.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    lbMessage.Items.Add(langDict[lang]["E_CONNECT"]);
                    MessageBox.Show(ex.ToString(), langDict[lang]["E"]);
                    Disconnect();
                }
            }
            else
            {
                MessageBox.Show(langDict[lang]["E_NAME"], langDict[lang]["E"]);
            }
        }
        private void bConnect_Click(object sender, EventArgs e)
        {
            if (activeCall)
                writing.Write("/disconnect");
            else
                Connect();
        }

        private void bgMessaging_DoWork(object sender, DoWorkEventArgs e)
        {
            while (activeCall)
            {
                if (toSend)
                {
                    toSend = false;
                    string messageSent = tbMessage.Text;

                    if (messageSent.EndsWith("\r\n")) 
                    {
                        messageSent = TruncateString(messageSent);
                    }

                    tbMessage.Invoke(new MethodInvoker(delegate
                    {
                        tbMessage.Text = null;
                    }));

                    if (messageSent.Length >= 1)
                    {
                        writing.Write(messageSent);
                    }
                }
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            toSend = true;
        }

        private void bwReceive_DoWork(object sender, DoWorkEventArgs e)
        {
            while (activeCall)
            {
               //try
               //{
                    string messageReceived;
                    while ((messageReceived = reading.ReadString()) != "END" && activeCall)
                    {
                        if(messageReceived == ("SERVER_DISCONNECT"))
                        {
                            Disconnect();
                            break;
                        }
                        else if(messageReceived == ("/img"))
                        {
                            string imgSender = reading.ReadString();
                            int length = reading.ReadInt32();
                            byte[] byteImage = reading.ReadBytes(length);
                            ImageHelper ih = new ImageHelper();
                            ih.saveImageFromByteArray(byteImage, imgSender);
                            gallery.loadImages();
                        }
                        else
                        {
                            lbMessage.Invoke(new MethodInvoker(delegate
                            {
                                lbMessage.Items.Add(messageReceived);
                            }));
                        }
                    }
                //}
                /*catch 
                {
                    MessageBox.Show(langDict[lang]["E_DISCONNECT"], langDict[lang]["E"]);
                    Disconnect();
                }*/
            }
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bSend_Click(this, new EventArgs());
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

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bConnect_Click(this, new EventArgs());
            }
        }

        private void InitializeLang()
        {
            langDict.Add("pl_PL", new Dictionary<string, string>()
            {
                {"S_CONNECT", "Połącz z serwerem"},
                {"CONNECTION_1", "[KLIENT] Nawiązano połączenie z ["},
                {"CONNECTION_2", "] na porcie: "},
                {"IP", "Adres IP" },
                {"PORT", "Port" },
                {"NAME", "Nick" },
                {"CONNECT", "Połącz" },
                {"DISCONNECT", "Rozłącz" },
                {"E", "Błąd" },
                {"E_DISCONNECT", "Rozłączono z serwerem" },
                {"E_NAME", "Podaj poprawny nick!" },
                {"E_CONNECT", "Nie można połączyć z serwerem!" }
            });
            langDict.Add("en_US", new Dictionary<string, string>()
            {
                {"S_CONNECT", "Connect to server"},
                {"CONNECTION_1", "[CLIENT] Established connection with ["},
                {"CONNECTION_2", "] on port: "},
                {"IP", "IP Address" },
                {"PORT", "Port" },
                {"NAME", "Name" },
                {"CONNECT", "Connect" },
                {"DISCONNECT", "Disconnect" },
                {"E", "Error" },
                {"E_DISCONNECT", "Disconnected from server" },
                {"E_NAME", "Please enter valid name!" },
                {"E_CONNECT", "Couldn't connect to server!" }
            });
        }

        private void SetLanguage(string langCode)
        {
            lang = langCode;
            bConnect.Text = langDict[langCode]["CONNECT"];
            label1.Text =  langDict[langCode]["IP"];
            label2.Text = langDict[langCode]["PORT"];
            label3.Text = langDict[langCode]["NAME"];
            label5.Text = langDict[langCode]["S_CONNECT"];
        }

        private void bPolish_Click(object sender, EventArgs e)
        {
            SetLanguage("pl_PL");
        }

        private void bEnglish_Click(object sender, EventArgs e)
        {
            SetLanguage("en_US");
        }

        private string TruncateString(string s)
        {
            int len = s.Length;
            string ret = "";

            for(int i = 0; i < len-2; i++)
            {
                ret += s[i];
            }

            return ret;
        }

        private void bAttach_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //lbMessage.Items.Add(ofd.FileName);
                Image toSend = Image.FromFile(ofd.FileName);
                ImageHelper ih = new ImageHelper();
                byte[] imageArray = ih.imgToByteArray(toSend);
                writing.Write("/img");
                writing.Write(imageArray.Length);
                writing.Write(imageArray);
            }
        }

        private void bGallery_Click(object sender, EventArgs e)
        {
            gallery.Show();
            gallery.setLanguage(lang);
            gallery.loadImages();
        }
    }

    public class ImageHelper
    {
        public ImageHelper()
        {

        }

        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        public void saveImageFromByteArray(byte[] byteArrayIn, string sender)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            { 
                string path = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_ffff");
                Random rand = new Random();
                Image img = Image.FromStream(mStream);
                img.Save("Images/" + path + sender + ".png", ImageFormat.Png);
            }
        }
    }

}
