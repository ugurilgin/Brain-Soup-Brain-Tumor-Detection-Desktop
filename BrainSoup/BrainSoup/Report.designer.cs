namespace BrainSoup
{
    partial class Report

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.titleLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Printer = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tumorBox = new System.Windows.Forms.PictureBox();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Img = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.Cinsiyet = new System.Windows.Forms.Label();
            this.TC = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tumorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(398, 1);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(61, 24);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Rapor";
            this.titleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.titleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.titleLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(934, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(22, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 18;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 25);
            this.panel1.TabIndex = 20;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Printer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 27);
            this.panel2.TabIndex = 21;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // Printer
            // 
            this.Printer.BackColor = System.Drawing.Color.White;
            this.Printer.Dock = System.Windows.Forms.DockStyle.Left;
            this.Printer.Image = ((System.Drawing.Image)(resources.GetObject("Printer.Image")));
            this.Printer.Location = new System.Drawing.Point(0, 0);
            this.Printer.Name = "Printer";
            this.Printer.Size = new System.Drawing.Size(29, 27);
            this.Printer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Printer.TabIndex = 51;
            this.Printer.TabStop = false;
            this.Printer.Click += new System.EventHandler(this.Print_Click);
            this.Printer.MouseEnter += new System.EventHandler(this.Print_MouseEnter);
            this.Printer.MouseLeave += new System.EventHandler(this.Print_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tumorBox);
            this.panel3.Controls.Add(this.imgBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.Img);
            this.panel3.Controls.Add(this.Result);
            this.panel3.Controls.Add(this.Date);
            this.panel3.Controls.Add(this.BirthDate);
            this.panel3.Controls.Add(this.Email);
            this.panel3.Controls.Add(this.FullName);
            this.panel3.Controls.Add(this.Cinsiyet);
            this.panel3.Controls.Add(this.TC);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 736);
            this.panel3.TabIndex = 22;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // tumorBox
            // 
            this.tumorBox.Location = new System.Drawing.Point(507, 389);
            this.tumorBox.Name = "tumorBox";
            this.tumorBox.Size = new System.Drawing.Size(392, 335);
            this.tumorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tumorBox.TabIndex = 31;
            this.tumorBox.TabStop = false;
            this.tumorBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.tumorBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.tumorBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(15, 389);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(407, 335);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 31;
            this.imgBox.TabStop = false;
            this.imgBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.imgBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.imgBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(-2, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1006, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "_________________________________________________________________________________" +
    "__________________-";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.label10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.label10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(-2, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1006, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "_________________________________________________________________________________" +
    "__________________-";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(504, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "MR Sonucu Görüntüsü:";
            this.label14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.label14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.label14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // Img
            // 
            this.Img.AutoSize = true;
            this.Img.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Img.ForeColor = System.Drawing.Color.DimGray;
            this.Img.Location = new System.Drawing.Point(12, 368);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(110, 18);
            this.Img.TabIndex = 29;
            this.Img.Text = "MR Görüntüsü:";
            this.Img.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.Img.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.Img.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Result.ForeColor = System.Drawing.Color.DimGray;
            this.Result.Location = new System.Drawing.Point(503, 340);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(91, 18);
            this.Result.TabIndex = 29;
            this.Result.Text = "MR Sonucu:";
            this.Result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.Result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.Result.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Date.ForeColor = System.Drawing.Color.DimGray;
            this.Date.Location = new System.Drawing.Point(11, 340);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(112, 18);
            this.Date.TabIndex = 29;
            this.Date.Text = "MR Kayıt Tarihi:";
            this.Date.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.Date.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.Date.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BirthDate.ForeColor = System.Drawing.Color.DimGray;
            this.BirthDate.Location = new System.Drawing.Point(12, 223);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(163, 18);
            this.BirthDate.TabIndex = 29;
            this.BirthDate.Text = "Hastanın Doğum Tarihi:";
            this.BirthDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.BirthDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.BirthDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Email.ForeColor = System.Drawing.Color.DimGray;
            this.Email.Location = new System.Drawing.Point(503, 193);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(142, 18);
            this.Email.TabIndex = 29;
            this.Email.Text = "Hastanın Mail Adresi";
            this.Email.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.Email.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.Email.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FullName.ForeColor = System.Drawing.Color.DimGray;
            this.FullName.Location = new System.Drawing.Point(12, 193);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(162, 18);
            this.FullName.TabIndex = 29;
            this.FullName.Text = "Hastanın Adı ve Soyadı:";
            this.FullName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.FullName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.FullName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.AutoSize = true;
            this.Cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cinsiyet.ForeColor = System.Drawing.Color.DimGray;
            this.Cinsiyet.Location = new System.Drawing.Point(503, 162);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(129, 18);
            this.Cinsiyet.TabIndex = 29;
            this.Cinsiyet.Text = "Hastanın Cinsiyeti:";
            this.Cinsiyet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.Cinsiyet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.Cinsiyet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // TC
            // 
            this.TC.AutoSize = true;
            this.TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TC.ForeColor = System.Drawing.Color.DimGray;
            this.TC.Location = new System.Drawing.Point(12, 162);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(162, 18);
            this.TC.TabIndex = 29;
            this.TC.Text = "Hastanın TC Kimlik No:";
            this.TC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.TC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.TC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(382, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "MR Bilgileri";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.label9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(382, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Hasta Bilgileri";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(213)))));
            this.label1.Location = new System.Drawing.Point(382, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "MR Raporu";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(213)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Error_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Error_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Error_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Error_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tumorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox tumorBox;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Img;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Cinsiyet;
        private System.Windows.Forms.Label TC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Printer;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}