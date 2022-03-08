
namespace MessagingClient
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnControls = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bPrevious = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImageRefresh = new System.ComponentModel.BackgroundWorker();
            this.imageData = new System.Windows.Forms.Label();
            this.bLast = new System.Windows.Forms.Button();
            this.bFirst = new System.Windows.Forms.Button();
            this.pnControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.pnControls.TabIndex = 24;
            this.pnControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnControls_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Image gallery";
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
            // bNext
            // 
            this.bNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.bNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bNext.FlatAppearance.BorderSize = 0;
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bNext.ForeColor = System.Drawing.Color.White;
            this.bNext.Location = new System.Drawing.Point(769, 207);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(83, 73);
            this.bNext.TabIndex = 3;
            this.bNext.Text = "⯈";
            this.bNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPrevious
            // 
            this.bPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.bPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPrevious.FlatAppearance.BorderSize = 0;
            this.bPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrevious.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPrevious.ForeColor = System.Drawing.Color.White;
            this.bPrevious.Location = new System.Drawing.Point(36, 207);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(83, 73);
            this.bPrevious.TabIndex = 25;
            this.bPrevious.Text = "⯇";
            this.bPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bPrevious.UseVisualStyleBackColor = false;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(161, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // ImageRefresh
            // 
            this.ImageRefresh.WorkerSupportsCancellation = true;
            // 
            // imageData
            // 
            this.imageData.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imageData.ForeColor = System.Drawing.Color.White;
            this.imageData.Location = new System.Drawing.Point(157, 418);
            this.imageData.Name = "imageData";
            this.imageData.Size = new System.Drawing.Size(563, 83);
            this.imageData.TabIndex = 27;
            this.imageData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imageData.UseMnemonic = false;
            // 
            // bLast
            // 
            this.bLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.bLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bLast.FlatAppearance.BorderSize = 0;
            this.bLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLast.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLast.ForeColor = System.Drawing.Color.White;
            this.bLast.Location = new System.Drawing.Point(769, 357);
            this.bLast.Name = "bLast";
            this.bLast.Size = new System.Drawing.Size(83, 58);
            this.bLast.TabIndex = 28;
            this.bLast.Text = "⯈⯈";
            this.bLast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bLast.UseVisualStyleBackColor = false;
            this.bLast.Click += new System.EventHandler(this.bLast_Click);
            // 
            // bFirst
            // 
            this.bFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.bFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bFirst.FlatAppearance.BorderSize = 0;
            this.bFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFirst.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFirst.ForeColor = System.Drawing.Color.White;
            this.bFirst.Location = new System.Drawing.Point(36, 357);
            this.bFirst.Name = "bFirst";
            this.bFirst.Size = new System.Drawing.Size(83, 58);
            this.bFirst.TabIndex = 29;
            this.bFirst.Text = "⯇⯇";
            this.bFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bFirst.UseVisualStyleBackColor = false;
            this.bFirst.Click += new System.EventHandler(this.bFirst_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(891, 553);
            this.Controls.Add(this.bFirst);
            this.Controls.Add(this.bLast);
            this.Controls.Add(this.imageData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.pnControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.pnControls.ResumeLayout(false);
            this.pnControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker ImageRefresh;
        private System.Windows.Forms.Label imageData;
        private System.Windows.Forms.Button bLast;
        private System.Windows.Forms.Button bFirst;
    }
}