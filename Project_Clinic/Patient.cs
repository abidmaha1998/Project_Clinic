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
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.RendezVous = new HashSet<RendezVous>();
        }
    
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public string Genre { get; set; }
        public Nullable<System.DateTime> Date_Naissance { get; set; }
        public string Adresse { get; set; }
        public string Phone { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> Ord_Num { get; set; }
        public Nullable<int> IdDoc { get; set; }
    
        public virtual Ordonnance Ordonnance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RendezVous> RendezVous { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
