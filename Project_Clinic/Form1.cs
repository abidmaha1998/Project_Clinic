using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Clinic
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private string valeurDeRetour = "Maha";
        BD_ClinicEntities5 ctx = new BD_ClinicEntities5();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void txt_mot_pass_IconRightClick(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                if (textBox2.UseSystemPasswordChar)
                {
                    textBox2.UseSystemPasswordChar = false;
                }
                else
                {
                    textBox2.UseSystemPasswordChar = true;
                }
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox2.Text != "")
            {

                if (rd_docteur.Checked)
                {
                    var login_docteur = ctx.Doctor.Where(d => d.Nom_Doc.Equals(textBox1.Text) && d.Doc_pass.Equals(textBox2.Text)).FirstOrDefault();

                    if (login_docteur != null)
                    {
                        int vr=login_docteur.Id_Doc;
                        string nom = login_docteur.Nom_Doc;

                        string prenom = login_docteur.Prenom_Doc;
                        Doctor_Forms.Doctor_Dashbord doctor = new Doctor_Forms.Doctor_Dashbord(vr, nom,prenom);



                        doctor.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Password or username incorrect");
                    }

                }
                else if (rd_agent.Checked)
                {
                    var login_agent = ctx.Agent.Where(a => a.Nom_ag.Equals(textBox1.Text) && a.Password_ag.Equals(textBox2.Text)).FirstOrDefault();

                    if (login_agent != null)
                    {


                        Agent_Forms.Agent_Dashboard agent = new Agent_Forms.Agent_Dashboard();
                        agent.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Password or username incorrect");
                    }


                }
                else if (rd_admin.Checked)
                {
                    var login_admin = ctx.Admin.Where(ad => ad.nom_admin.Equals(textBox1.Text) && ad.password_admin.Equals(textBox2.Text)).FirstOrDefault();

                    if (login_admin != null)
                    {
                        Admin_Forms.AdminDashboard admin = new Admin_Forms.AdminDashboard();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password or username incorrect");

                    }

                }


            }
            else
            {
                
                MessageBox.Show("Verifies les champs !");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rd_admin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
