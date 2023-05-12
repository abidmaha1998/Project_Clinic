using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Project_Clinic.Doctor_Forms
{
    public partial class Doc_RendezVous : DevExpress.XtraEditors.XtraForm
    {
        BD_ClinicEntities5 ctx = new BD_ClinicEntities5();
        public int S { get; }
        public Doc_RendezVous(int s)
        {
            InitializeComponent();
            var req = from v in ctx.RendezVous.Where(d => d.Id_Doc == s) select v;
 
            rendezVousBindingSource.DataSource = req.ToList();
            dg.DataSource = rendezVousBindingSource;
        }
        private RendezVous FindRendezVousByDate(BD_ClinicEntities5 context, DateTime dat)
        {
            return context.RendezVous.FirstOrDefault(d => d.Date_rdv == dat);
        }
        private RendezVous FindPatientByCIN(BD_ClinicEntities5 context, String cin)
        {
            return context.RendezVous.FirstOrDefault(d => d.Cin_pat == cin);
        }
        //Rechercher par CIN patient
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
        //Rechercher par date RendezVous
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
         
            try
            {
                using (var context = new BD_ClinicEntities5())
                {
                    Console.WriteLine($"txt_cin.Text: {txt_cin.Text}");

                    if (!string.IsNullOrWhiteSpace(txt_cin.Text))
                    {


                        var patients = FindRendezVousByDate(context, Convert.ToDateTime(dateTimePicker1.Text));
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