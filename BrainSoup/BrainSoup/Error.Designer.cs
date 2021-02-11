namespace BrainSoup
{
    partial class Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.errorPB = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.okBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorPB
            // 
            this.errorPB.Image = ((System.Drawing.Image)(resources.GetObject("errorPB.Image")));
            this.errorPB.Location = new System.Drawing.Point(12, 47);
            this.errorPB.Name = "errorPB";
            this.errorPB.Size = new System.Drawing.Size(50, 48);
            this.errorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorPB.TabIndex = 0;
            this.errorPB.TabStop = false;
            this.errorPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.errorPB_MouseDown);
            this.errorPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.errorPB_MouseMove);
            this.errorPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.errorPB_MouseUp);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(178, 2);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(48, 24);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Hata";
            this.titleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLbl_MouseDown);
            this.titleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLbl_MouseMove);
            this.titleLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLbl_MouseUp);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.errorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(213)))));
            this.errorLbl.Location = new System.Drawing.Point(94, 65);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(235, 18);
            this.errorLbl.TabIndex = 2;
            this.errorLbl.Text = "Kullanıcı Adınız veya Şifreniz Yanlış";
            this.errorLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.errorLbl_MouseDown);
            this.errorLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.errorLbl_MouseMove);
            this.errorLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.errorLbl_MouseUp);
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(404, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(22, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 18;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // okBtn
            // 
            this.okBtn.AutoSize = true;
            this.okBtn.BackColor = System.Drawing.Color.White;
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(213)))));
            this.okBtn.Location = new System.Drawing.Point(340, 117);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(74, 22);
            this.okBtn.TabIndex = 19;
            this.okBtn.Text = "TAMAM";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            this.okBtn.MouseEnter += new System.EventHandler(this.okBtn_MouseEnter);
            this.okBtn.MouseLeave += new System.EventHandler(this.okBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 25);
            this.panel1.TabIndex = 20;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 148);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.errorPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hata!";
            this.Load += new System.EventHandler(this.Error_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Error_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Error_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Error_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox errorPB;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Label okBtn;
        private System.Windows.Forms.Panel panel1;
    }
}