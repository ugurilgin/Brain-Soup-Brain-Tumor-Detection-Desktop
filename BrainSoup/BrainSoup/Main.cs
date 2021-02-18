using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainSoup
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

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
            Patient.BackColor = Color.FromArgb(0, 117, 213);
            Patient.ForeColor = Color.FromArgb(255, 255, 255);
            
        }

        private void Hasta_MouseEnter(object sender, EventArgs e)
        {
            
            Patient.ForeColor = Color.FromArgb(255, 255, 255);
           
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
            string sumPatients = Sql.Count("SELECT count(TC) FROM patients WHERE ban LIKE '0' AND doctor LIKE '"+UserInformation.UserKey+"'");
            string sumMR = Sql.Count("SELECT count(id) FROM tumor WHERE ban LIKE '0' AND doctor LIKE '" + UserInformation.UserKey + "'");
            string sumHMR = Sql.Count("SELECT count(TC) FROM tumor WHERE result LIKE 'Negatif' AND ban LIKE '0' AND doctor LIKE  '" + UserInformation.UserKey + "' ");
            string sumTMR = Sql.Count("SELECT count(TC) FROM tumor WHERE result LIKE 'Pozitif' AND ban LIKE '0' AND doctor LIKE  '" + UserInformation.UserKey + "' ");
            string sumMale = Sql.Count("SELECT count(TC) FROM tumor WHERE cinsiyet LIKE 'Erkek' AND ban LIKE '0' AND doctor LIKE  '" + UserInformation.UserKey + "' ");
            string sumFemale = Sql.Count("SELECT count(TC) FROM tumor WHERE cinsiyet LIKE 'Kadın' AND ban LIKE '0' AND doctor LIKE  '" + UserInformation.UserKey + "' ");
            string sum18 = Sql.Count("SELECT count(TC) FROM tumor WHERE TIMESTAMPDIFF(YEAR, birthdate, NOW())<18 AND ban LIKE '0' AND doctor LIKE  '" + UserInformation.UserKey + "' ");
            string sum30 = Sql.Count("SELECT count(TC) FROM tumor WHERE TIMESTAMPDIFF(YEAR, birthdate, NOW())>=18 AND TIMESTAMPDIFF(YEAR, birthdate, NOW())<30 AND ban LIKE '0' AND doctor LIKE  '" + UserInformation.UserKey + "' ");
            string sum35 = Sql.Count("SELECT count(TC) FROM tumor WHERE TIMESTAMPDIFF(YEAR, birthdate, NOW())>=30 AND TIMESTAMPDIFF(YEAR, birthdate, NOW())<65 AND ban LIKE '0' AND doctor LIKE  '" + UserInformation.UserKey + "' ");
            string sum65 = Sql.Count("SELECT count(TC) FROM tumor WHERE TIMESTAMPDIFF(YEAR, birthdate, NOW())>=65  AND ban LIKE '0' AND doctor LIKE  '" + UserInformation.UserKey + "' ");
            SumPatient.Text = sumPatients;
            SumMR.Text = sumMR;
            SumHMR.Text = sumHMR;
            SumTMR.Text = sumTMR;
            this.WindowState = Style.formState;
            oturumuKapatToolStripMenuItem.Text =UserInformation.UserName;
           
            stateCins.Series["Cinsiyet"].Points.Add(Convert.ToInt32(sumFemale));
            stateCins.Series["Cinsiyet"].Points.Add(Convert.ToInt32(sumMale));
            stateCins.Series["Cinsiyet"].Points[0].AxisLabel = "Kadın H. Sayısı :"+sumFemale;
            stateCins.Series["Cinsiyet"].Points[1].AxisLabel = "Erkek H. Sayısı :"+sumMale;
         
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points.Add(Convert.ToInt32(sum18));
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points.Add(Convert.ToInt32(sum30));
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points.Add(Convert.ToInt32(sum35));
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points.Add(Convert.ToInt32(sum65));
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points[0].AxisLabel = "<18 H. Sayısı :"+sum18;
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points[1].AxisLabel = "18-30 H. Sayısı :" + sum30;
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points[2].AxisLabel = "30-65 H. Sayısı:" + sum35;
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points[3].AxisLabel = ">65 H. Sayısı :" + sum65;
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points[0].Color = Color.Green;
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points[1].Color = Color.Chocolate;
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points[2].Color = Color.Orange;
            statePatient.Series["Toplam Hasta Yaş Dağılımı"].Points[3].Color = Color.RoyalBlue;
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

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;

        }

     
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);

        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;

        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);

        }

        private void panel9_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;

        }

        private void stateCins_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void stateCins_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);

        }

        private void stateCins_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;

        }

        private void panel9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfilePage frm = new ProfilePage();
            this.Close();
            frm.Show();
        }

        private void Rapor_Click(object sender, EventArgs e)
        {
            PredictPage frm = new PredictPage();
            frm.Show();
            this.Close();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Style.Maximize(this);
        }

        private void UnsavedMR_Click(object sender, EventArgs e)
        {
            if(Sql.isThere("SELECT * from tumor WHERE TC='00000000000' AND doctor='"+UserInformation.UserKey+"'")==1)
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

        private void MR_Click(object sender, EventArgs e)
        {
            MRViewPage frm = new MRViewPage();
            frm.Show();
            this.Close();
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

        private void mRİnceleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PredictPage frm = new PredictPage();
            frm.Show();
            this.Close();
        }
    }
}
