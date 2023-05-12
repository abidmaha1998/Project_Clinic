using System;
using System.Windows.Forms;

namespace Project_Clinic.Doctor_Forms
{
    public partial class Doctor_Dashbord : DevExpress.XtraEditors.XtraForm
    {
        Form activeForm;
        

        public Doctor_Dashbord(int str,string nom,string prenom )
        {
            InitializeComponent();
            label1.Text= "Bienvenue: "+nom+ prenom;            
            textBox1.Text = str.ToString();

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.layoutControl1.Controls.Add(childForm);
            this.layoutControl1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void sidePanel2_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Test(), sender);
        }

        private void sidePanel3_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Test(), sender);
        }

        private void sidePanel4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel6_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            OpenChildForm(new Doc_RendezVous(int.Parse(str)), sender);
        }

        private void sidePanel4_Click_1(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            OpenChildForm(new Doc_Test(int.Parse(str)), sender);
        }

        private void sidePanel8_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            OpenChildForm(new Doc_Patient(int.Parse(str)), sender);
        }

        private void sidePanel5_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            OpenChildForm(new Ord_med(int.Parse(str)), sender);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_Dashbord_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}