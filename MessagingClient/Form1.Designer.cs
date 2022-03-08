
namespace MessagingClient
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bConnect = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.nUDPort = new System.Windows.Forms.NumericUpDown();
            this.tbHostAddress = new System.Windows.Forms.TextBox();
            this.bgMessaging = new System.ComponentModel.BackgroundWorker();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.bwReceive = new System.ComponentModel.BackgroundWorker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bEnglish = new System.Windows.Forms.Button();
            this.bPolish = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnControls = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pMessage = new System.Windows.Forms.Panel();
            this.bAttach = new System.Windows.Forms.Button();
            this.bGallery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnControls.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // bConnect
            // 
            this.bConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.bConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bConnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConnect.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bConnect.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bConnect.Location = new System.Drawing.Point(721, 130);
            this.bConnect.Margin = new System.Windows.Forms.Padding(2);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(101, 73);
            this.bConnect.TabIndex = 14;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = false;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbMessage.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.ItemHeight = 23;
            this.lbMessage.Location = new System.Drawing.Point(15, 20);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(565, 161);
            this.lbMessage.TabIndex = 13;
            // 
            // nUDPort
            // 
            this.nUDPort.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nUDPort.Location = new System.Drawing.Point(593, 130);
            this.nUDPort.Margin = new System.Windows.Forms.Padding(2);
            this.nUDPort.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nUDPort.Name = "nUDPort";
            this.nUDPort.Size = new System.Drawing.Size(88, 25);
            this.nUDPort.TabIndex = 11;
            this.nUDPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tbHostAddress
            // 
            this.tbHostAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHostAddress.Location = new System.Drawing.Point(338, 130);
            this.tbHostAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbHostAddress.Name = "tbHostAddress";
            this.tbHostAddress.Size = new System.Drawing.Size(121, 25);
            this.tbHostAddress.TabIndex = 8;
            this.tbHostAddress.Text = "127.0.0.1";
            // 
            // bgMessaging
            // 
            this.bgMessaging.WorkerSupportsCancellation = true;
            this.bgMessaging.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgMessaging_DoWork);
            // 
            // tbMessage
            // 
            this.tbMessage.AcceptsReturn = true;
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMessage.Enabled = false;
            this.tbMessage.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbMessage.Location = new System.Drawing.Point(15, 10);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(446, 55);
            this.tbMessage.TabIndex = 15;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // bSend
            // 
            this.bSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSend.BackgroundImage")));
            this.bSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSend.Enabled = false;
            this.bSend.FlatAppearance.BorderSize = 0;
            this.bSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSend.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSend.Location = new System.Drawing.Point(721, 462);
            this.bSend.Margin = new System.Windows.Forms.Padding(2);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(48, 51);
            this.bSend.TabIndex = 16;
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bwReceive
            // 
            this.bwReceive.WorkerSupportsCancellation = true;
            this.bwReceive.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwReceive_DoWork);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.Location = new System.Drawing.Point(338, 178);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(343, 26);
            this.tbName.TabIndex = 12;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bEnglish);
            this.panel1.Controls.Add(this.bPolish);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(168, 515);
            this.panel1.TabIndex = 18;
            // 
            // bEnglish
            // 
            this.bEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.bEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bEnglish.FlatAppearance.BorderSize = 0;
            this.bEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnglish.Font = new System.Drawing.Font("Candara", 12F);
            this.bEnglish.ForeColor = System.Drawing.Color.White;
            this.bEnglish.Location = new System.Drawing.Point(53, 453);
            this.bEnglish.Name = "bEnglish";
            this.bEnglish.Size = new System.Drawing.Size(104, 32);
            this.bEnglish.TabIndex = 20;
            this.bEnglish.Text = "English";
            this.bEnglish.UseVisualStyleBackColor = false;
            this.bEnglish.Click += new System.EventHandler(this.bEnglish_Click);
            // 
            // bPolish
            // 
            this.bPolish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.bPolish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPolish.FlatAppearance.BorderSize = 0;
            this.bPolish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPolish.Font = new System.Drawing.Font("Candara", 12F);
            this.bPolish.ForeColor = System.Drawing.Color.White;
            this.bPolish.Location = new System.Drawing.Point(53, 410);
            this.bPolish.Name = "bPolish";
            this.bPolish.Size = new System.Drawing.Size(104, 32);
            this.bPolish.TabIndex = 2;
            this.bPolish.Text = "Polski";
            this.bPolish.UseVisualStyleBackColor = false;
            this.bPolish.Click += new System.EventHandler(this.bPolish_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(31, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "SIMPLICITY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 94);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(213, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(468, 41);
            this.label5.TabIndex = 20;
            this.label5.Text = "Connect to server";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(216, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(514, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(216, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // pnControls
            // 
            this.pnControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.pnControls.Controls.Add(this.label6);
            this.pnControls.Controls.Add(this.btMinimize);
            this.pnControls.Controls.Add(this.btClose);
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControls.Location = new System.Drawing.Point(0, 0);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(891, 42);
            this.pnControls.TabIndex = 23;
            this.pnControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnControls_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Simplicity communicator v 0.4 (Release 25.02.2021)";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            // 
            // btMinimize
            // 
            this.btMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.btMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btMinimize.BackgroundImage")));
            this.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Location = new System.Drawing.Point(759, 0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(63, 42);
            this.btMinimize.TabIndex = 1;
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.btClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClose.BackgroundImage")));
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(828, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(63, 42);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbMessage);
            this.panel2.Location = new System.Drawing.Point(220, 228);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(602, 200);
            this.panel2.TabIndex = 24;
            // 
            // pMessage
            // 
            this.pMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pMessage.Controls.Add(this.tbMessage);
            this.pMessage.Location = new System.Drawing.Point(220, 448);
            this.pMessage.Margin = new System.Windows.Forms.Padding(6);
            this.pMessage.Name = "pMessage";
            this.pMessage.Padding = new System.Windows.Forms.Padding(4);
            this.pMessage.Size = new System.Drawing.Size(473, 75);
            this.pMessage.TabIndex = 25;
            // 
            // bAttach
            // 
            this.bAttach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAttach.BackgroundImage")));
            this.bAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bAttach.Enabled = false;
            this.bAttach.FlatAppearance.BorderSize = 0;
            this.bAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAttach.ForeColor = System.Drawing.SystemColors.Control;
            this.bAttach.Location = new System.Drawing.Point(788, 448);
            this.bAttach.Name = "bAttach";
            this.bAttach.Size = new System.Drawing.Size(34, 32);
            this.bAttach.TabIndex = 26;
            this.bAttach.UseVisualStyleBackColor = true;
            this.bAttach.Click += new System.EventHandler(this.bAttach_Click);
            // 
            // bGallery
            // 
            this.bGallery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bGallery.BackgroundImage")));
            this.bGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bGallery.FlatAppearance.BorderSize = 0;
            this.bGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGallery.ForeColor = System.Drawing.SystemColors.Control;
            this.bGallery.Location = new System.Drawing.Point(788, 491);
            this.bGallery.Name = "bGallery";
            this.bGallery.Size = new System.Drawing.Size(34, 32);
            this.bGallery.TabIndex = 27;
            this.bGallery.UseVisualStyleBackColor = true;
            this.bGallery.Click += new System.EventHandler(this.bGallery_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(891, 553);
            this.Controls.Add(this.bGallery);
            this.Controls.Add(this.bAttach);
            this.Controls.Add(this.pMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.nUDPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHostAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "TCPClient";
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnControls.ResumeLayout(false);
            this.pnControls.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pMessage.ResumeLayout(false);
            this.pMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.NumericUpDown nUDPort;
        private System.Windows.Forms.TextBox tbHostAddress;
        private System.ComponentModel.BackgroundWorker bgMessaging;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSend;
        private System.ComponentModel.BackgroundWorker bwReceive;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pMessage;
        private System.Windows.Forms.Button bEnglish;
        private System.Windows.Forms.Button bPolish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bAttach;
        private System.Windows.Forms.Button bGallery;
    }
}

