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
    public partial class Doc_RendezVous : DevExpress.XtraEditors.XtraForm
    {
        BD_ClinicEntities5 ctx = new BD_ClinicEntities5();
        public Doc_RendezVous()
        {
            InitializeComponent();
            var req = from v in ctx.RendezVous select v;
            rendezVousBindingSource.DataSource = req.ToList();
            dg.DataSource = rendezVousBindingSource;
        }
        private RendezVous FindRendezVousByDate(BD_ClinicEntities5 context, DateTime Nom)
        {
            return context.RendezVous.FirstOrDefault(d => d.Date_rdv == Nom);
        }
        private RendezVous FindPatientByCIN(BD_ClinicEntities5 context, String cin)
        {
            return context.RendezVous.FirstOrDefault(d => d.Cin_pat == cin);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //
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
                            dg.DataSource = new List<RendezVous>() { patients };
                        }
                        else
                        {
                            dg.DataSource = null;
                        }


                    }
                    else
                    {
                        dg.DataSource = context.RendezVous
                            .Select(p => new
                            {
                                id = p.Id_rdv,
                                date = p.Date_rdv,
                                heure = p.Heure_rdv,                           
                                doc=p.Id_Doc,
                                pat = p.Cin_pat

                            })
                            .ToList();
                    }

                    Console.WriteLine($"dg.DataSource: {dg.DataSource}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new BD_ClinicEntities5())
                {
                    Console.WriteLine($"dateTimePicker1.Text: {dateTimePicker1.Text}");

                    if (!string.IsNullOrWhiteSpace(dateTimePicker1.Text))
                    {


                        var rds = FindRendezVousByDate(context, Convert.ToDateTime(dateTimePicker1.Text));
                        if (rds != null)
                        {
                            dg.DataSource = new List<RendezVous>() { rds };
                        }
                        else
                        {
                            dg.DataSource = null;
                        }


                    }
                    else
                    {
                        dg.DataSource = context.RendezVous
                            .Select(p => new
                            {
                                id = p.Id_rdv,
                                date = p.Date_rdv,
                                heure = p.Heure_rdv,
                                doc = p.Id_Doc,
                                pat = p.Cin_pat

                            })
                            .ToList();
                    }

                    Console.WriteLine($"dg.DataSource: {dg.DataSource}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}