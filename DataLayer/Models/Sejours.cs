//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sejours
    {
        public Sejours()
        {
            this.Produits = new HashSet<Produits>();
        }
    
        public int IdSejour { get; set; }
        public int IdHotel { get; set; }
        public byte Duree { get; set; }
    
        public virtual Hotels Hotels { get; set; }
        public virtual ICollection<Produits> Produits { get; set; }
    }
}
