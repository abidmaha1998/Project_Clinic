//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Clinic
{
    using System;
    using System.Collections.Generic;
    
    public partial class RendezVous
    {
        public int Id_rdv { get; set; }
        public Nullable<System.DateTime> Date_rdv { get; set; }
        public Nullable<int> Heure_rdv { get; set; }
        public Nullable<int> Id_Doc { get; set; }
        public string Cin_pat { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}