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
    
    public partial class Izlazi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Izlazi()
        {
            this.IzlazStavkes = new HashSet<IzlazStavke>();
        }
    
        public int IzlazID { get; set; }
        public string BrojRacuna { get; set; }
        public System.DateTime Datum { get; set; }
        public int KorisnikID { get; set; }
        public bool Zakljucen { get; set; }
        public decimal IznosBezPDV { get; set; }
        public decimal IznosSaPDV { get; set; }
        public Nullable<int> NarudzbaID { get; set; }
        public int SkladisteID { get; set; }
    
        public virtual Korisnici Korisnici { get; set; }
        public virtual Narudzbe Narudzbe { get; set; }
        public virtual Skladista Skladista { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IzlazStavke> IzlazStavkes { get; set; }
    }
}
