using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainSoup
{
    public partial class PatientPage : Form
    {
        public PatientPage()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }
        string id;
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
            string query = "SELECT id AS 'ID',TC AS 'TC',name AS 'İsim',surname AS 'Soyisim',email AS 'E-Mail',birthdate AS 'Doğum Tarihi',date AS 'Kayıt Tarihi',cinsiyet AS 'Cinsiyeti' from patients WHERE ban='0' AND doctor = '" + UserInformation.UserKey + "'";
            Sql.Select(query, DataView);
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

        }

        private void profilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfilePage frm = new ProfilePage();
            frm.Show();
            this.Close();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void Anamenu_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Close();
        }

        private void Search_MouseEnter(object sender, EventArgs e)
        {
            Search.BackColor = Color.FromArgb(30, 137, 233);
        }


        private void Search_MouseLeave(object sender, EventArgs e)
        {
            Search.BackColor = Color.FromArgb(0, 117, 213);
        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            Delete.BackColor = Color.DarkRed;
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.BackColor = Color.FromArgb(0, 117, 213);

        }

        private void label4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            string query = "SELECT id AS 'ID',TC AS 'TC',name AS 'İsim',surname AS 'Soyisim',email AS 'E-Mail',birthdate AS 'Doğum Tarihi',date AS 'Kayıt Tarihi',cinsiyet AS 'Cinsiyeti' from patients WHERE ban='0' AND doctor = '" + UserInformation.UserKey+"'";
            Sql.Select(query, DataView);
            NameT.Text = "";
            Surname.Text = "";
            TCSearch.Text = "";
            TC.Text = "";
            Email.Text = "";
            Cinsiyet.Text = "";
            Update.Visible = false;
            Submit.Visible = true;
            
        }

        private void TCSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT id AS 'ID',TC AS 'TC',name AS 'İsim',surname AS 'Soyisim',email AS 'E-Mail',birthdate AS 'Doğum Tarihi',date AS 'Kayıt Tarihi',cinsiyet AS 'Cinsiyeti' from patients WHERE ban='0' AND TC LIKE '%" + TCSearch.Text + "%' AND doctor = '" + UserInformation.UserKey + "'";
            Sql.Select(query, DataView);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string query = "SELECT id AS 'ID',TC AS 'TC',name AS 'İsim',surname AS 'Soyisim',email AS 'E-Mail',birthdate AS 'Doğum Tarihi',date AS 'Kayıt Tarihi',cinsiyet AS 'Cinsiyeti' from patients WHERE ban='0' AND TC LIKE '%" + TCSearch.Text + "%' AND doctor = '" + UserInformation.UserKey + "'";
            Sql.Select(query, DataView);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(TCSearch.Text !="")
            { 
            try { Sql.DeletePatients(id,TCSearch.Text);
                Refresh_Click(sender, e);
                Style.Message("Silme İşlemi Başarılı");
            }
            catch { Style.Error("Kayıt Silinemedi"); }
            }
            else
            {
                 Style.Error("Kayıt Silinemedi"); 
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (TC.Text == "" || NameT.Text == "" | Surname.Text == "" || Cinsiyet.Text == "" || Email.Text == ""|| TCSearch.Text=="")
            {
                Style.Error("Tüm Alanlar Doldurulmalıdır.Arama Bilgisini Giriniz.");
               
            }
            else
            {
                if (MailSender.GetValidEmail(Email.Text) == "valid")
                {
                    Sql.UpdatePatients(id,TC.Text, NameT.Text, Surname.Text, Cinsiyet.Text, DateT.Value.Date.ToString("yyyy-MM-dd"), Email.Text, TCSearch.Text);
                Refresh_Click(sender, e);
                    Style.Message("Güncelleme Başarılı");
                }
                else
                {
                Style.Error("Lütfen Geçerli Mail Adresi Giriniz.");

                }
        }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(TC.Text==""|| NameT.Text=="" | Surname.Text==""|| Cinsiyet.Text==""|| Email.Text=="")
            {
                Style.Error("Tüm Alanlar Doldurulmalıdır");
            }
            else
            {
                string query = "SELECT id AS 'ID',TC AS 'TC',name AS 'İsim',surname AS 'Soyisim',email AS 'E-Mail',birthdate AS 'Doğum Tarihi',date AS 'Kayıt Tarihi',cinsiyet AS 'Cinsiyeti' from patients WHERE ban='0' AND TC LIKE '%" + TC.Text + "%' AND doctor = '" + UserInformation.UserKey + "'";
               
                if (Sql.isThere(query)==0)
                {
                    if (MailSender.GetValidEmail(Email.Text) == "valid")
                    {
                        Sql.InsertPatients(TC.Text, NameT.Text, Surname.Text, Cinsiyet.Text, DateT.Value.Date.ToString("yyyy-MM-dd"), Email.Text);
                        Refresh_Click(sender, e);
                        Style.Message("Kayıt Başarılı");
                    }
                    else
                    {
                        Style.Error("Lütfen Geçerli Mail Adresi Giriniz.");

                    }
                }
                else
                    Style.Error("Bu Hasta Zaten Kayıtlı.");
            }
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Update.Visible = true;
            Submit.Visible = false;
            id= DataView.CurrentRow.Cells[0].Value.ToString();
            TC.Text=DataView.CurrentRow.Cells[1].Value.ToString();
            TCSearch.Text = DataView.CurrentRow.Cells[1].Value.ToString();
            NameT.Text= DataView.CurrentRow.Cells[2].Value.ToString();
            Surname.Text = DataView.CurrentRow.Cells[3].Value.ToString();
            Email.Text = DataView.CurrentRow.Cells[4].Value.ToString();
            DateT.Value = Convert.ToDateTime(DataView.CurrentRow.Cells[5].Value.ToString());
            Cinsiyet.Text =  DataView.CurrentRow.Cells[7].Value.ToString();
        }

        private void Anamenu_MouseEnter(object sender, EventArgs e)
        {

            Anamenu.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void Anamenu_MouseLeave(object sender, EventArgs e)
        {
            Anamenu.BackColor = Color.FromArgb(0, 117, 213);
            Anamenu.ForeColor = Color.FromArgb(255, 255, 255);
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

        private void Rapor_Click(object sender, EventArgs e)
        {
            PredictPage frm = new PredictPage();
            frm.Show();
            this.Close();
        }

        private void mRİnceleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PredictPage frm = new PredictPage();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfilePage frm = new ProfilePage();
            frm.Show();
            this.Close();
        }
    }
}
