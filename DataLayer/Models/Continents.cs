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
    
    public partial class Continents
    {
        public Continents()
        {
            this.Regions = new HashSet<Regions>();
        }
    
        public int idContinent { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Regions> Regions { get; set; }
    }
}
