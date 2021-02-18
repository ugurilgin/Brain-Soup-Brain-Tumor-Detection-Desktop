using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace BrainSoup
{
    public partial class PredictPage : Form
    {
        public PredictPage()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }
        bool isImage;
        string filePath = "";
        //Resize Form
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }
        //Resize Form Finish

        private void Hasta_MouseLeave(object sender, EventArgs e)
        {
            Hasta.BackColor = Color.FromArgb(0, 117, 213);
            Hasta.ForeColor = Color.FromArgb(255, 255, 255);
            
        }

        private void Hasta_MouseEnter(object sender, EventArgs e)
        {
            
            Hasta.ForeColor = Color.FromArgb(255, 255, 255);
           
        }

        private void MR_MouseEnter(object sender, EventArgs e)
        {
            MR.ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void MR_MouseLeave(object sender, EventArgs e)
        {
            MR.BackColor = Color.FromArgb(0, 117, 213);
            MR.ForeColor = Color.FromArgb(255, 255, 255);
            
        }

        private void Rapor_MouseEnter(object sender, EventArgs e)
        {
            
            Rapor.ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void Rapor_MouseLeave(object sender, EventArgs e)
        {
            Rapor.BackColor = Color.FromArgb(0, 117, 213);
            Rapor.ForeColor = Color.FromArgb(255, 255, 255);
            
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.BackColor = Color.DarkRed;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = Color.FromArgb(0, 117, 213);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_MouseEnter(object sender, EventArgs e)
        {
            Maximize.BackColor = Color.FromArgb(30, 137, 233);
        }

        private void Maximize_MouseLeave(object sender, EventArgs e)
        {
            Maximize.BackColor = Color.FromArgb(0, 117, 213);
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            Style.Maximize(this);
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(30, 137, 233);
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(0, 117, 213);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            Style.Minimize(this);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);

        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            this.WindowState = Style.formState;
            oturumuKapatToolStripMenuItem.Text =UserInformation.UserName;
        }

        private void title_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void menuStrip1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void panel4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

     
        private void oturumuKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginPage frm = new LoginPage();
            frm.Show();
            this.Close();
        }

        private void Hasta_Click(object sender, EventArgs e)
        {
            PatientPage frm = new PatientPage();
            frm.Show();
            this.Close();
        }

        private void profilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfilePage frm = new ProfilePage();
            frm.Show();
            this.Close();
        }

      

        


        private void panel5_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop,false)==true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        private string getFileName(string path)
        {
            return Path.GetFileName(path);
        }
        private void panel5_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach(string file in droppedFiles)
            {
                filePath = file;
                string filename = getFileName(file);
                fileName.Text = "Dosya Adı : " + filename;
                try { 
                predictImage.Image = Image.FromFile(file);
                predictImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    isImage = true;
                }
                catch
                {
                    Style.Error("Lütfen Resim Dosyası Seçiniz.");
                    isImage = false;
                }
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;

        }



        private void panel5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void Anamenu_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfilePage frm = new ProfilePage();
            frm.Show();
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "http://192.168.1.70:5000/apiDesktop";
                BrainSoupRequest request = new BrainSoupRequest();
                string response = request.SendImage(url, filePath);
                MRJson mRJson = JsonConvert.DeserializeObject<MRJson>(response);
                if (Sql.isThere("SELECT * from tumor WHERE TC='00000000000' AND doctor='" + UserInformation.UserKey + "'") == 1)
                {
                    try { 
                        Sql.UpdateMR("UPDATE tumor  SET imgloc = '" + mRJson.imgLoc + "' ,tumorloc ='" + mRJson.tumorLoc + "',result = '" + mRJson.result + "' WHERE ban = '1' AND  TC = '00000000000' AND doctor LIKE '" + UserInformation.UserKey + "' ");
                        UnsavedPage frm = new UnsavedPage();
                        frm.Show();
                        this.Close();
                    }

                    catch
                    {
                        Style.Error("Resim Kaydedilemedi");
                    }

                }
                else
                {
                    try { 
                        Sql.UpdateMR("INSERT INTO `tumor` (TC,date,imgloc,tumorloc,doctor,result,ban) VALUES('00000000000','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + mRJson.imgLoc + "','" + mRJson.tumorLoc + "','" + UserInformation.UserKey + "','" + mRJson.result + "','1')");
                        UnsavedPage frm = new UnsavedPage();
                        frm.Show();
                        this.Close();
                    }
                    catch
                    {

                        Style.Error("Resim Kaydedilemedi");
                    }

                }
            }
            catch
            {
                Style.Error("Resim Yüklenemedi");
            }
            
        }

        private void Searh_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.Title = "MR Görüntüsü Seçiniz";
            openFileDialog1.DefaultExt = "png";
            openFileDialog1.Filter = "Resim Dosyaları (*.jpg, *.jpeg,   *.png) | *.jpg; *.jpeg;  *.png"; ;
            openFileDialog1.Multiselect = false;
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                 filePath = openFileDialog1.FileName;
                
              
                try
                {
                    
                    predictImage.Image = Image.FromFile(filePath);
                    predictImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    isImage = true;
                   
                }
                catch
                {
                    Style.Error("Lütfen Resim Dosyası Seçiniz.");
                    isImage = false;
                }
            }
            string filename = getFileName(filePath);
            fileName.Text = "Dosya Adı : " + filename;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientPage frm = new PatientPage();
            frm.Show();
            this.Close();
        }

        private void hastalarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientPage frm = new PatientPage();
            frm.Show();
            this.Close();
        }

        private void hastalarıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientPage frm = new PatientPage();
            frm.Show();
            this.Close();
        }

        private void hastaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientPage frm = new PatientPage();
            frm.Show();
            this.Close();
        }

        private void mRSonuçlarınıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MRViewPage frm = new MRViewPage();
            frm.Show();
            this.Close();
        }

        private void MR_Click(object sender, EventArgs e)
        {
            MRViewPage frm = new MRViewPage();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Sql.isThere("SELECT * from tumor WHERE TC='00000000000' AND doctor='" + UserInformation.UserKey + "'") == 1)
            {
                UnsavedPage frm = new UnsavedPage();
                frm.Show();
                this.Close();
            }
            else
            {
                Style.Error("Kaydedilmemiş Kayıt Bulunamadı");
            }
        }

        private void kaydedilmemişMRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sql.isThere("SELECT * from tumor WHERE TC='00000000000' AND doctor='" + UserInformation.UserKey + "'") == 1)
            {
                UnsavedPage frm = new UnsavedPage();
                frm.Show();
                this.Close();
            }
            else
            {
                Style.Error("Kaydedilmemiş Kayıt Bulunamadı");
            }
        }
    }
}
