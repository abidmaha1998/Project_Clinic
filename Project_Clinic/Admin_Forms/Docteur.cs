using DevExpress.ChartRangeControlClient.Core;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.CodeParser;
using DevExpress.Utils.Design;
using DevExpress.Xpo;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Implementation;
using Project_Clinic.Admin_Forms.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static DevExpress.XtraPrinting.Native.PageSizeInfo;
using iTextSharp.text.pdf;
using iTextSharp.text;
using DevExpress.XtraReports.Wizards;
using DevExpress.XtraReports.UI;

namespace Project_Clinic
{
    public partial class Docteur : DevExpress.XtraEditors.XtraForm
    {
        BD_ClinicEntities5 ctx = new BD_ClinicEntities5();
        //private Doctor id_Doc;

        public Docteur()
        {
            InitializeComponent();
            Docteur_Load();
            lb_total.Text = " Total Docteur : " + ctx.Doctor.Count().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        public void ViderChamps()
        {
            try
            {


                txt_adress.Text = "";
                txt_nom.Text = "";
                txt_prenom.Text = "";
                txt_recherche_admin_Doc.Text = "";
                txt_tele.Text = "";
                txt_pass.Text = "";
                txt_date.Value = DateTime.Now;
                txt_experience.Text = "";
                pictureBox.Image = null;
                txt_experience.Value = 0;
            }

            catch (Exception ex)
            {

                MessageBox.Show($" Exception :  {ex}");

            }
        }

        //RefreshData
        public void RefreshData()
        {
            dg_admin_doc.DataSource = ctx.Doctor.Select(d => new
            {
                ID = d.Id_Doc,
                Nom = d.Nom_Doc,
                Prenom = d.Prenom_Doc,
                Date_Naissance = d.DateNaissance_Doc,
                Specialité = d.Doc_specialite,
                Expérience = d.Doc_experience,
                Adresse = d.Doc_addr,
                Téléphone = d.Doc_phone,
                Password = d.Doc_pass,
                Image = d.Doc_Image


            }).ToList();
            //refresh total record
            lb_total.Text = " Total Docteur : " + ctx.Doctor.Count().ToString();

        }

        //check fields
        public bool VerifieChamps()
        {
            if (txt_nom.Text == string.Empty || txt_prenom.Text == string.Empty || txt_date.Value.ToString() == string.Empty || txt_experience.Value == 0 || txt_pass.Text == string.Empty || txt_tele.Text == string.Empty || txt_experience.Text == string.Empty || pictureBox.Image == null)
                return false;
            return true;


        }
        private void bt_aj_img_Click(object sender, EventArgs e)
        {
            try
            {
                //Image insertion
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = System.Drawing.Image.FromFile(ofd.FileName);
                    System.Drawing.Image image = System.Drawing.Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($" Exception :  {ex}");

            }
        }

        private void Docteur_Load( )
        {

            BD_ClinicEntities5 ctx = new BD_ClinicEntities5();
            var req = from v in ctx.Doctor select v;
            doctorBindingSource.DataSource = req.ToList();
            dg_admin_doc.DataSource = doctorBindingSource;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string nom = txt_nom.Text.ToString();
            string prenom = txt_prenom.Text.ToString();
            DateTime date = Convert.ToDateTime(txt_date.Value.Date);
            int telephone =  int.Parse(txt_tele.Text);
            int experience = int.Parse(txt_experience.Text);
            string specialite = txt_specialite.Text.ToString();
            string password = txt_pass.Text.ToString();
            string adresse = txt_adress.Text.ToString();
            //image 
            System.Drawing.Image img = pictureBox1.Image;
            ImageConverter converter = new ImageConverter();
            byte[] imagebyte = (byte[])converter.ConvertTo(img, typeof(byte[]));


            //check if record already exist in database
            
                Doctor doc = new Doctor(1,nom, prenom, date, specialite, experience, telephone, adresse, password, imagebyte);
                ctx.Doctor.Add(doc);
            ctx.SaveChanges();
            //clear and refresh data
            //ViderChamps();
            RefreshData();
                MessageBox.Show("Docteur bien ajouté!");
            


            /*try
            {
                if (VerifieChamps())
                {
                    string nom = txt_nom.Text.ToString();
                    string prenom = txt_prenom.Text.ToString();
                    DateTime date = Convert.ToDateTime(txt_date.Value.Date);
                    string telephone = txt_tele.Text;
                    int experience = int.Parse(txt_experience.Text);
                    string specialite = txt_experience.Text.ToString();
                    string password = txt_pass.Text.ToString();
                    string adresse = txt_adress.Text.ToString();
                    //image 
                    Image img = pictureBox1.Image;
                    ImageConverter converter = new ImageConverter();
                    byte[] imagebyte = (byte[])converter.ConvertTo(img, typeof(byte[]));


                    //check if record already exist in database
                    if (!ctx.Doctors.Any(c => c.Nom_Doc == txt_nom.Text && c.Prenom_Doc == txt_prenom.Text))
                    {
                        Doctor doc = new Doctor(nom, prenom, date, specialite, experience, telephone, adresse, password, imagebyte);
                        ctx.Doctors.Add(doc);

                        //clear and refresh data
                        //ViderChamps();
                        RefreshData();
                        MessageBox.Show("Docteur bien ajouté!");
                    }
                    else
                    {
                        MessageBox.Show("Cet Docteur existe déja  !");
                    }



                }
                else
                {
                    MessageBox.Show("Remplir les champs!");

                }

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show($"SQL Exception :  {sqlex}");
            }
            catch (Exception ex)
            {

                MessageBox.Show($" Exception :  {ex}");

            }*/
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openDialog.FileName);
            }
        }

        /* private void txt_recherche_admin_Doc_TextChanged(object sender, EventArgs e)
         {

         }*/
        private Doctor FindDoctorById(BD_ClinicEntities5 context, int id)
        {
            return context.Doctor.FirstOrDefault(d => d.Id_Doc == id);
        }


        private Doctor FindDoctorByName(BD_ClinicEntities5 context, String Nom)
        {
            return context.Doctor.FirstOrDefault(d => d.Nom_Doc == Nom);
        }
        private void txt_recherche_admin_Doc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new BD_ClinicEntities5())
                {
                    Console.WriteLine($"txt_recherche_admin_Doc.Text: {txt_recherche_admin_Doc.Text}");

                    if (!string.IsNullOrWhiteSpace(txt_recherche_admin_Doc.Text))
                    {
                        int id;
                        bool isId = int.TryParse(txt_recherche_admin_Doc.Text, out id);

                        if (isId)
                        {
                            var doctor = FindDoctorById(context, id);
                            if (doctor != null)
                            {
                                dg_admin_doc.DataSource = new List<Doctor>() { doctor };
                            }
                            else
                            {
                                dg_admin_doc.DataSource = null;
                            }
                        }
                        else
                        {
                            var doctors = FindDoctorByName(context, txt_recherche_admin_Doc.Text);
                            if (doctors != null)
                            {
                                dg_admin_doc.DataSource = new List<Doctor>() { doctors };
                            }
                            else
                            {
                                dg_admin_doc.DataSource = null;
                            }
                        }
                    }
                    else
                    {
                        dg_admin_doc.DataSource = context.Doctor
                            .Select(d => new
                            {
                                ID = d.Id_Doc,
                                Nom = d.Nom_Doc,
                                Prenom = d.Prenom_Doc,
                                Date_Naissance = d.DateNaissance_Doc,
                                Specialité = d.Doc_specialite,
                                Expérience = d.Doc_experience,
                                Adresse = d.Doc_addr,
                                Téléphone = d.Doc_phone,
                                Image = d.Doc_Image
                            })
                            .ToList();
                    }

                    Console.WriteLine($"dg_admin_doc.DataSource: {dg_admin_doc.DataSource}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_tele_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_specialite_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_experience_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_total_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(" Voulez vous vraiment modifier cet agent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var objectToModify = (Doctor)doctorBindingSource.Current as Doctor;


                var objetDansContexte = new Doctor { Id_Doc = objectToModify.Id_Doc };

                objectToModify.Nom_Doc = txt_nom.Text;
                objectToModify.Prenom_Doc = txt_prenom.Text;

                ctx.Doctor.Attach(objetDansContexte);
                ctx.Entry(objetDansContexte).CurrentValues.SetValues(objectToModify);
                ctx.SaveChanges();
                var entry = ctx.Entry(objetDansContexte);
                entry.State = EntityState.Detached;
            }






            }
        private void dg_admin_doc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dg_admin_doc.Rows[index];
                row.Selected = true;
            }
        }
        private  void button3_Click(object sender, EventArgs e)
        {
            //Delete data from binding source, then save to sql database
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //BD_ClinicEntities5 ctx = new BD_ClinicEntities5();
                var objectToDelete = (Doctor)doctorBindingSource.Current as Doctor;
                var objetDansContexte = new Doctor { Id_Doc = objectToDelete.Id_Doc };
                ctx.Doctor.Attach(objetDansContexte);
                ctx.Entry(objetDansContexte).State = EntityState.Deleted;
                ctx.SaveChanges();           

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BD_ClinicEntities5 ctx = new BD_ClinicEntities5();
            var req = from v in ctx.Doctor select v;
            doctorBindingSource.DataSource = req.ToList();
            dg_admin_doc.DataSource = doctorBindingSource;
            lb_total.Text = " Total Docteur : " + ctx.Doctor.Count().ToString();
        }

        private void dg_admin_doc_Click(object sender, EventArgs e)
        {

            
        }

        private void doctorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dg_admin_doc_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            /*var objectToPrint = (Doctor)doctorBindingSource.Current as Doctor;
            var doc = new Doctor { Id_Doc = objectToPrint.Id_Doc };
            int i = doc.Id_Doc;
             
            DoctorDetails report = new  DoctorDetails();
            report.Parameters["Id_Doc"].Value = i;
            report.CreateDocument();
            report.ShowPreview();*/
             
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var objectToPrint = (Doctor)doctorBindingSource.Current as Doctor;
            var doc = new Doctor { Id_Doc = objectToPrint.Id_Doc };
            int i = doc.Id_Doc;

            DoctorDetails report = new DoctorDetails();
            report.Parameters["Id_Doc"].Value = i;
            report.CreateDocument();
            report.ShowPreview();
        }
        //Ajouter Docteur
        private void button11_Click(object sender, EventArgs e)
        {
            string nom = txt_nom.Text.ToString();
            string prenom = txt_prenom.Text.ToString();
            DateTime date = Convert.ToDateTime(txt_date.Value.Date);
            int telephone = int.Parse(txt_tele.Text);
            int experience = int.Parse(txt_experience.Text);
            string specialite = txt_specialite.Text.ToString();
            string password = txt_pass.Text.ToString();
            string adresse = txt_adress.Text.ToString();
            //Inserer image 
            System.Drawing.Image img = pictureBox1.Image;
            ImageConverter converter = new ImageConverter();
            byte[] imagebyte = (byte[])converter.ConvertTo(img, typeof(byte[]));


            //check if record already exist in database

            Doctor doc = new Doctor(1, nom, prenom, date, specialite, experience, telephone, adresse, password, imagebyte);
            ctx.Doctor.Add(doc);
            ctx.SaveChanges();

            //clear and refresh data
            //ViderChamps();
            RefreshData();
            MessageBox.Show("Docteur bien ajouté!");
            Docteur_Load();
        }

        //Modifier Docteur
        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Voulez vous vraiment modifier cet agent?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var objectToModify = (Doctor)doctorBindingSource.Current as Doctor;


                var objetDansContexte = new Doctor { Id_Doc = objectToModify.Id_Doc };

                objectToModify.Nom_Doc = txt_nom.Text;
                objectToModify.Prenom_Doc = txt_prenom.Text;

                ctx.Doctor.Attach(objetDansContexte);
                ctx.Entry(objetDansContexte).CurrentValues.SetValues(objectToModify);
                ctx.SaveChanges();
                var entry = ctx.Entry(objetDansContexte);
                entry.State = EntityState.Detached;
            }
            Docteur_Load();
        }

        //Delete Docteur
        private void button2_Click_1(object sender, EventArgs e)
        {
             if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
 
                var objectToDelete = (Doctor)doctorBindingSource.Current as Doctor;
                var objetDansContexte = new Doctor { Id_Doc = objectToDelete.Id_Doc };
                ctx.Doctor.Attach(objetDansContexte);
                ctx.Entry(objetDansContexte).State = EntityState.Deleted;
                ctx.SaveChanges();

            }
            Docteur_Load();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ViderChamps();
        }

        //Imprimer
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var objectToPrint = (Doctor)doctorBindingSource.Current as Doctor;
            

            DoctorsList report = new DoctorsList();
            
            report.CreateDocument();
            report.ShowPreview();
        }
    }

    
    }