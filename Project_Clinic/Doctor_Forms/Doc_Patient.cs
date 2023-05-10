using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Clinic.Doctor_Forms
{
    public partial class Doc_Patient : DevExpress.XtraEditors.XtraForm
    {
        BD_ClinicEntities5 ctx = new BD_ClinicEntities5();
        public Doc_Patient()
        {
            InitializeComponent();
            var req = from v in ctx.Patient select v;
            patientBindingSource.DataSource = req.ToList();
            dg_patient.DataSource = patientBindingSource;
        }
        private Patient FindPatientByCIN(BD_ClinicEntities5 context, String cin)
        {
            return context.Patient.FirstOrDefault(d => d.CIN == cin);
        }


        private Patient FindPatientByName(BD_ClinicEntities5 context, String Nom)
        {
            return context.Patient.FirstOrDefault(d => d.Nom == Nom);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new BD_ClinicEntities5())
                {
                    Console.WriteLine($"txt_cin.Text: {txt_cin.Text}");

                    if (!string.IsNullOrWhiteSpace(txt_cin.Text))
                    {

                       
                        var patients = FindPatientByCIN(context, txt_cin.Text);
                        if (patients != null)
                        {
                            dg_patient.DataSource = new List<Patient>() { patients };
                        }
                        else
                        {
                            dg_patient.DataSource = null;
                        }
                        

                    }
                    else
                    {
                        dg_patient.DataSource = context.Patient
                            .Select(p => new
                            {
                                CIN = p.CIN,
                                Nom = p.Nom,
                                Prenom = p.Prénom,
                                Genre = p.Genre,
                                Date_Naissance = p.Date_Naissance,
                                Adresse = p.Adresse,
                                Phone = p.Phone,
                                Maladie = p.Ordonnance.Maladie
                            })
                            .ToList();
                    }

                    Console.WriteLine($"dg_patient.DataSource: {dg_patient.DataSource}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new BD_ClinicEntities5())
                {
                    Console.WriteLine($"txt_cin.Text: {txt_nom.Text}");

                    if (!string.IsNullOrWhiteSpace(txt_nom.Text))
                    {


                        var patients = FindPatientByName(context, txt_nom.Text);
                        if (patients != null)
                        {
                            dg_patient.DataSource = new List<Patient>() { patients };
                        }
                        else
                        {
                            dg_patient.DataSource = null;
                        }


                    }
                    else
                    {
                        dg_patient.DataSource = context.Patient
                            .Select(p => new
                            {
                                CIN = p.CIN,
                                Nom = p.Nom,
                                Prenom = p.Prénom,
                                Genre = p.Genre,
                                Date_Naissance = p.Date_Naissance,
                                Adresse = p.Adresse,
                                Phone = p.Phone,
                                Maladie = p.Ordonnance.Maladie
                            })
                            .ToList();
                    }

                    Console.WriteLine($"dg_admin_doc.DataSource: {dg_patient.DataSource}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}