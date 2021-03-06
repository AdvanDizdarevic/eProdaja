//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eProdaja_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ulazi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ulazi()
        {
            this.UlazStavkes = new HashSet<UlazStavke>();
        }
    
        public int UlazID { get; set; }
        public string BrojFakture { get; set; }
        public System.DateTime Datum { get; set; }
        public decimal IznosRacuna { get; set; }
        public decimal PDV { get; set; }
        public string Napomena { get; set; }
        public int SkladisteID { get; set; }
        public int KorisnikID { get; set; }
        public int DobavljacID { get; set; }
    
        public virtual Dobavljaci Dobavljaci { get; set; }
        public virtual Korisnici Korisnici { get; set; }
        public virtual Skladista Skladista { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UlazStavke> UlazStavkes { get; set; }
    }
}
