﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class eProdajaEntities : DbContext
    {
        public eProdajaEntities()
            : base("name=eProdajaEntities")
        {
            Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AkcijskiProizvodi> AkcijskiProizvodis { get; set; }
        public virtual DbSet<Dobavljaci> Dobavljacis { get; set; }
        public virtual DbSet<Greska> Greskas { get; set; }
        public virtual DbSet<GreskaStavke> GreskaStavkes { get; set; }
        public virtual DbSet<Izlazi> Izlazis { get; set; }
        public virtual DbSet<IzlazStavke> IzlazStavkes { get; set; }
        public virtual DbSet<JediniceMjere> JediniceMjeres { get; set; }
        public virtual DbSet<KategorijeProizvoda> KategorijeProizvodas { get; set; }
        public virtual DbSet<Korisnici> Korisnicis { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloges { get; set; }
        public virtual DbSet<Kupci> Kupcis { get; set; }
        public virtual DbSet<NarudzbaStavke> NarudzbaStavkes { get; set; }
        public virtual DbSet<Narudzbe> Narudzbes { get; set; }
        public virtual DbSet<Novosti> Novostis { get; set; }
        public virtual DbSet<Ocjene> Ocjenes { get; set; }
        public virtual DbSet<PrijedlogKupca> PrijedlogKupcas { get; set; }
        public virtual DbSet<PrijedlogKupcaStavke> PrijedlogKupcaStavkes { get; set; }
        public virtual DbSet<Proizvodi> Proizvodis { get; set; }
        public virtual DbSet<Skladista> Skladistas { get; set; }
        public virtual DbSet<Ulazi> Ulazis { get; set; }
        public virtual DbSet<UlazStavke> UlazStavkes { get; set; }
        public virtual DbSet<Uloge> Uloges { get; set; }
    
        public virtual int esp_KorisniciUloge_Insert(Nullable<int> korisnikID, Nullable<int> ulogaID)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var ulogaIDParameter = ulogaID.HasValue ?
                new ObjectParameter("UlogaID", ulogaID) :
                new ObjectParameter("UlogaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_KorisniciUloge_Insert", korisnikIDParameter, ulogaIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> esp_Korisnici_Insert(string ime, string prezime, string email, string telefon, string korisnickoIme, string lozinkaSalt, string lozinkaHash)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            var lozinkaSaltParameter = lozinkaSalt != null ?
                new ObjectParameter("LozinkaSalt", lozinkaSalt) :
                new ObjectParameter("LozinkaSalt", typeof(string));
    
            var lozinkaHashParameter = lozinkaHash != null ?
                new ObjectParameter("LozinkaHash", lozinkaHash) :
                new ObjectParameter("LozinkaHash", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("esp_Korisnici_Insert", imeParameter, prezimeParameter, emailParameter, telefonParameter, korisnickoImeParameter, lozinkaSaltParameter, lozinkaHashParameter);
        }
    
        public virtual ObjectResult<Korisnici> esp_Korisnici_SelectByKorisnickoIme(string korisnickoIme)
        {
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici>("esp_Korisnici_SelectByKorisnickoIme", korisnickoImeParameter);
        }
    
        public virtual ObjectResult<Korisnici> esp_Korisnici_SelectByKorisnickoIme(string korisnickoIme, MergeOption mergeOption)
        {
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici>("esp_Korisnici_SelectByKorisnickoIme", mergeOption, korisnickoImeParameter);
        }
    
        public virtual ObjectResult<Korisnici> esp_Korisnici_SelectByImePrezime(string imePrezime)
        {
            var imePrezimeParameter = imePrezime != null ?
                new ObjectParameter("ImePrezime", imePrezime) :
                new ObjectParameter("ImePrezime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici>("esp_Korisnici_SelectByImePrezime", imePrezimeParameter);
        }
    
        public virtual ObjectResult<Korisnici> esp_Korisnici_SelectByImePrezime(string imePrezime, MergeOption mergeOption)
        {
            var imePrezimeParameter = imePrezime != null ?
                new ObjectParameter("ImePrezime", imePrezime) :
                new ObjectParameter("ImePrezime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici>("esp_Korisnici_SelectByImePrezime", mergeOption, imePrezimeParameter);
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectByVrsta_Result> esp_Proizvodi_SelectByVrsta(Nullable<int> kategorijaID)
        {
            var kategorijaIDParameter = kategorijaID.HasValue ?
                new ObjectParameter("KategorijaID", kategorijaID) :
                new ObjectParameter("KategorijaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectByVrsta_Result>("esp_Proizvodi_SelectByVrsta", kategorijaIDParameter);
        }
    
        public virtual int esp_Proizvodi_Insert(string naziv, string sifra, Nullable<decimal> cijena, Nullable<int> kategorijaID, Nullable<int> jedinicaMjereID, byte[] slika, byte[] slikaThumb)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            var sifraParameter = sifra != null ?
                new ObjectParameter("Sifra", sifra) :
                new ObjectParameter("Sifra", typeof(string));
    
            var cijenaParameter = cijena.HasValue ?
                new ObjectParameter("Cijena", cijena) :
                new ObjectParameter("Cijena", typeof(decimal));
    
            var kategorijaIDParameter = kategorijaID.HasValue ?
                new ObjectParameter("KategorijaID", kategorijaID) :
                new ObjectParameter("KategorijaID", typeof(int));
    
            var jedinicaMjereIDParameter = jedinicaMjereID.HasValue ?
                new ObjectParameter("JedinicaMjereID", jedinicaMjereID) :
                new ObjectParameter("JedinicaMjereID", typeof(int));
    
            var slikaParameter = slika != null ?
                new ObjectParameter("Slika", slika) :
                new ObjectParameter("Slika", typeof(byte[]));
    
            var slikaThumbParameter = slikaThumb != null ?
                new ObjectParameter("SlikaThumb", slikaThumb) :
                new ObjectParameter("SlikaThumb", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Proizvodi_Insert", nazivParameter, sifraParameter, cijenaParameter, kategorijaIDParameter, jedinicaMjereIDParameter, slikaParameter, slikaThumbParameter);
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectById_Result> esp_Proizvodi_SelectById(Nullable<int> proizvodId)
        {
            var proizvodIdParameter = proizvodId.HasValue ?
                new ObjectParameter("ProizvodId", proizvodId) :
                new ObjectParameter("ProizvodId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectById_Result>("esp_Proizvodi_SelectById", proizvodIdParameter);
        }
    
        public virtual ObjectResult<esp_NarudzbaStavke_SelectByNarudzbaID_Result> esp_NarudzbaStavke_SelectByNarudzbaID(Nullable<int> narudzbaID)
        {
            var narudzbaIDParameter = narudzbaID.HasValue ?
                new ObjectParameter("NarudzbaID", narudzbaID) :
                new ObjectParameter("NarudzbaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_NarudzbaStavke_SelectByNarudzbaID_Result>("esp_NarudzbaStavke_SelectByNarudzbaID", narudzbaIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> esp_Narudzbe_Insert(string brojNarudzbe, Nullable<int> kupacID, Nullable<System.DateTime> datum)
        {
            var brojNarudzbeParameter = brojNarudzbe != null ?
                new ObjectParameter("BrojNarudzbe", brojNarudzbe) :
                new ObjectParameter("BrojNarudzbe", typeof(string));
    
            var kupacIDParameter = kupacID.HasValue ?
                new ObjectParameter("KupacID", kupacID) :
                new ObjectParameter("KupacID", typeof(int));
    
            var datumParameter = datum.HasValue ?
                new ObjectParameter("Datum", datum) :
                new ObjectParameter("Datum", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("esp_Narudzbe_Insert", brojNarudzbeParameter, kupacIDParameter, datumParameter);
        }
    
        public virtual ObjectResult<esp_Narudzbe_Aktivne_result> esp_Narudzbe_SelectAktivne()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Narudzbe_Aktivne_result>("esp_Narudzbe_SelectAktivne");
        }
    
        public virtual int esp_NarudzbaStavke_Insert(Nullable<int> narudzbaID, Nullable<int> proizvodID, Nullable<int> kolicina)
        {
            var narudzbaIDParameter = narudzbaID.HasValue ?
                new ObjectParameter("NarudzbaID", narudzbaID) :
                new ObjectParameter("NarudzbaID", typeof(int));
    
            var proizvodIDParameter = proizvodID.HasValue ?
                new ObjectParameter("ProizvodID", proizvodID) :
                new ObjectParameter("ProizvodID", typeof(int));
    
            var kolicinaParameter = kolicina.HasValue ?
                new ObjectParameter("Kolicina", kolicina) :
                new ObjectParameter("Kolicina", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_NarudzbaStavke_Insert", narudzbaIDParameter, proizvodIDParameter, kolicinaParameter);
        }
    
        public virtual ObjectResult<esp_Izlazi_InsertByNarudzbaID_Result> ProcesirajNarudzbu(Nullable<int> narudzbaID, Nullable<decimal> iznosSaPDV, Nullable<decimal> iznosBezPDV, Nullable<int> skladisteID, Nullable<int> korisnikID)
        {
            var narudzbaIDParameter = narudzbaID.HasValue ?
                new ObjectParameter("NarudzbaID", narudzbaID) :
                new ObjectParameter("NarudzbaID", typeof(int));
    
            var iznosSaPDVParameter = iznosSaPDV.HasValue ?
                new ObjectParameter("IznosSaPDV", iznosSaPDV) :
                new ObjectParameter("IznosSaPDV", typeof(decimal));
    
            var iznosBezPDVParameter = iznosBezPDV.HasValue ?
                new ObjectParameter("IznosBezPDV", iznosBezPDV) :
                new ObjectParameter("IznosBezPDV", typeof(decimal));
    
            var skladisteIDParameter = skladisteID.HasValue ?
                new ObjectParameter("SkladisteID", skladisteID) :
                new ObjectParameter("SkladisteID", typeof(int));
    
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Izlazi_InsertByNarudzbaID_Result>("ProcesirajNarudzbu", narudzbaIDParameter, iznosSaPDVParameter, iznosBezPDVParameter, skladisteIDParameter, korisnikIDParameter);
        }
    
        public virtual ObjectResult<esp_AkcijskiProizvodi_SelectTrenutnoAktivni_Result> esp_AkcijskiProizvodi_SelectTrenutnoAktivni()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_AkcijskiProizvodi_SelectTrenutnoAktivni_Result>("esp_AkcijskiProizvodi_SelectTrenutnoAktivni");
        }
    
        public virtual int esp_Dobavljaci_Insert(string naziv, string kontaktOsoba, string adresa, string telefon, string fax, string web, string email, string ziroRacuni, string napomena, Nullable<bool> status)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            var kontaktOsobaParameter = kontaktOsoba != null ?
                new ObjectParameter("KontaktOsoba", kontaktOsoba) :
                new ObjectParameter("KontaktOsoba", typeof(string));
    
            var adresaParameter = adresa != null ?
                new ObjectParameter("Adresa", adresa) :
                new ObjectParameter("Adresa", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var faxParameter = fax != null ?
                new ObjectParameter("Fax", fax) :
                new ObjectParameter("Fax", typeof(string));
    
            var webParameter = web != null ?
                new ObjectParameter("Web", web) :
                new ObjectParameter("Web", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var ziroRacuniParameter = ziroRacuni != null ?
                new ObjectParameter("ZiroRacuni", ziroRacuni) :
                new ObjectParameter("ZiroRacuni", typeof(string));
    
            var napomenaParameter = napomena != null ?
                new ObjectParameter("Napomena", napomena) :
                new ObjectParameter("Napomena", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Dobavljaci_Insert", nazivParameter, kontaktOsobaParameter, adresaParameter, telefonParameter, faxParameter, webParameter, emailParameter, ziroRacuniParameter, napomenaParameter, statusParameter);
        }
    
        public virtual ObjectResult<esp_Dobavljaci_SelectByNaziv_KOsoba_Result> esp_Dobavljaci_SelectByNaziv_KOsoba(string naziv)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Dobavljaci_SelectByNaziv_KOsoba_Result>("esp_Dobavljaci_SelectByNaziv_KOsoba", nazivParameter);
        }
    
        public virtual ObjectResult<esp_IzlaziStavkeByIzlazID_Result> esp_IzlaziStavkeByIzlazID(Nullable<int> izlazID)
        {
            var izlazIDParameter = izlazID.HasValue ?
                new ObjectParameter("IzlazID", izlazID) :
                new ObjectParameter("IzlazID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_IzlaziStavkeByIzlazID_Result>("esp_IzlaziStavkeByIzlazID", izlazIDParameter);
        }
    
        public virtual int esp_KategorijaProiz_Insert(string naziv, Nullable<bool> status)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_KategorijaProiz_Insert", nazivParameter, statusParameter);
        }
    
        public virtual ObjectResult<esp_Korisnici_SelectBy_ImeP_KIme_NeAkt_Result> esp_Korisnici_SelectBy_ImeP_KIme_NeAkt(string imePrezime)
        {
            var imePrezimeParameter = imePrezime != null ?
                new ObjectParameter("ImePrezime", imePrezime) :
                new ObjectParameter("ImePrezime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Korisnici_SelectBy_ImeP_KIme_NeAkt_Result>("esp_Korisnici_SelectBy_ImeP_KIme_NeAkt", imePrezimeParameter);
        }
    
        public virtual ObjectResult<esp_Kupci_SelectByFUsername_Result> esp_Kupci_SelectByFUsername(string imePrezime)
        {
            var imePrezimeParameter = imePrezime != null ?
                new ObjectParameter("ImePrezime", imePrezime) :
                new ObjectParameter("ImePrezime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Kupci_SelectByFUsername_Result>("esp_Kupci_SelectByFUsername", imePrezimeParameter);
        }
    
        public virtual ObjectResult<esp_Narudzbe_SelectByDatum_Result> esp_Narudzbe_SelectByDatum(string datum, Nullable<int> kupacID)
        {
            var datumParameter = datum != null ?
                new ObjectParameter("Datum", datum) :
                new ObjectParameter("Datum", typeof(string));
    
            var kupacIDParameter = kupacID.HasValue ?
                new ObjectParameter("KupacID", kupacID) :
                new ObjectParameter("KupacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Narudzbe_SelectByDatum_Result>("esp_Narudzbe_SelectByDatum", datumParameter, kupacIDParameter);
        }
    
        public virtual ObjectResult<esp_Narudzbe_SelectByKupac_Result> esp_Narudzbe_SelectByKupac(Nullable<int> kupacID)
        {
            var kupacIDParameter = kupacID.HasValue ?
                new ObjectParameter("KupacID", kupacID) :
                new ObjectParameter("KupacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Narudzbe_SelectByKupac_Result>("esp_Narudzbe_SelectByKupac", kupacIDParameter);
        }
    
        public virtual ObjectResult<esp_Narudzbe_SelectByKupacSum_Result> esp_Narudzbe_SelectByKupacSum(Nullable<int> kupacID)
        {
            var kupacIDParameter = kupacID.HasValue ?
                new ObjectParameter("KupacID", kupacID) :
                new ObjectParameter("KupacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Narudzbe_SelectByKupacSum_Result>("esp_Narudzbe_SelectByKupacSum", kupacIDParameter);
        }
    
        public virtual ObjectResult<esp_Narudzbe_SelectByNarudzbaId_Result> esp_Narudzbe_SelectByNarudzbaId(Nullable<int> narudzbaId, Nullable<int> kupacID)
        {
            var narudzbaIdParameter = narudzbaId.HasValue ?
                new ObjectParameter("NarudzbaId", narudzbaId) :
                new ObjectParameter("NarudzbaId", typeof(int));
    
            var kupacIDParameter = kupacID.HasValue ?
                new ObjectParameter("KupacID", kupacID) :
                new ObjectParameter("KupacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Narudzbe_SelectByNarudzbaId_Result>("esp_Narudzbe_SelectByNarudzbaId", narudzbaIdParameter, kupacIDParameter);
        }
    
        public virtual ObjectResult<esp_Ocjene_SelectAll_Result> esp_Ocjene_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Ocjene_SelectAll_Result>("esp_Ocjene_SelectAll");
        }
    
        public virtual ObjectResult<esp_Ocjene_SelectOcjenjeniProizvodiByKupadID_Result> esp_Ocjene_SelectOcjenjeniProizvodiByKupadID(Nullable<int> kupacID)
        {
            var kupacIDParameter = kupacID.HasValue ?
                new ObjectParameter("KupacID", kupacID) :
                new ObjectParameter("KupacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Ocjene_SelectOcjenjeniProizvodiByKupadID_Result>("esp_Ocjene_SelectOcjenjeniProizvodiByKupadID", kupacIDParameter);
        }
    
        public virtual ObjectResult<esp_PrijedlogKupca_SelectAll_Result> esp_PrijedlogKupca_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_PrijedlogKupca_SelectAll_Result>("esp_PrijedlogKupca_SelectAll");
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectAktivni_Result> esp_Proizvodi_SelectAktivni()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectAktivni_Result>("esp_Proizvodi_SelectAktivni");
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectAll_Result> esp_Proizvodi_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectAll_Result>("esp_Proizvodi_SelectAll");
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectByNaziv_Result> esp_Proizvodi_SelectByNaziv(string naziv)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectByNaziv_Result>("esp_Proizvodi_SelectByNaziv", nazivParameter);
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectBySifra_Result> esp_Proizvodi_SelectBySifra(string sifra)
        {
            var sifraParameter = sifra != null ?
                new ObjectParameter("Sifra", sifra) :
                new ObjectParameter("Sifra", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectBySifra_Result>("esp_Proizvodi_SelectBySifra", sifraParameter);
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectBySkladiste_Result> esp_Proizvodi_SelectBySkladiste(Nullable<int> skladisteID)
        {
            var skladisteIDParameter = skladisteID.HasValue ?
                new ObjectParameter("SkladisteID", skladisteID) :
                new ObjectParameter("SkladisteID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectBySkladiste_Result>("esp_Proizvodi_SelectBySkladiste", skladisteIDParameter);
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectNeAktivni_Result> esp_Proizvodi_SelectNeAktivni()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectNeAktivni_Result>("esp_Proizvodi_SelectNeAktivni");
        }
    
        public virtual ObjectResult<esp_SelectProizvod_BySkladisteStanje_Result> esp_SelectProizvod_BySkladisteStanje(Nullable<int> skladisteID)
        {
            var skladisteIDParameter = skladisteID.HasValue ?
                new ObjectParameter("SkladisteID", skladisteID) :
                new ObjectParameter("SkladisteID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_SelectProizvod_BySkladisteStanje_Result>("esp_SelectProizvod_BySkladisteStanje", skladisteIDParameter);
        }
    
        public virtual ObjectResult<esp_Select_NeocjenjeniKupljeniProizvodi_ByKupacID_Result> esp_Select_NeocjenjeniKupljeniProizvodi_ByKupacID(Nullable<int> kupacID)
        {
            var kupacIDParameter = kupacID.HasValue ?
                new ObjectParameter("KupacID", kupacID) :
                new ObjectParameter("KupacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Select_NeocjenjeniKupljeniProizvodi_ByKupacID_Result>("esp_Select_NeocjenjeniKupljeniProizvodi_ByKupacID", kupacIDParameter);
        }
    
        public virtual int esp_Skladiste_Insert(string naziv, string adresa, string opis, Nullable<bool> status)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            var adresaParameter = adresa != null ?
                new ObjectParameter("Adresa", adresa) :
                new ObjectParameter("Adresa", typeof(string));
    
            var opisParameter = opis != null ?
                new ObjectParameter("Opis", opis) :
                new ObjectParameter("Opis", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Skladiste_Insert", nazivParameter, adresaParameter, opisParameter, statusParameter);
        }
    
        public virtual ObjectResult<esp_Skladiste_SelectByNaziv_Result> esp_Skladiste_SelectByNaziv(string naziv)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Skladiste_SelectByNaziv_Result>("esp_Skladiste_SelectByNaziv", nazivParameter);
        }
    
        public virtual int esp_UlaziStavke_Insert(Nullable<int> ulazID, Nullable<int> proizvodID, Nullable<int> kolicina, Nullable<decimal> cijena)
        {
            var ulazIDParameter = ulazID.HasValue ?
                new ObjectParameter("UlazID", ulazID) :
                new ObjectParameter("UlazID", typeof(int));
    
            var proizvodIDParameter = proizvodID.HasValue ?
                new ObjectParameter("ProizvodID", proizvodID) :
                new ObjectParameter("ProizvodID", typeof(int));
    
            var kolicinaParameter = kolicina.HasValue ?
                new ObjectParameter("Kolicina", kolicina) :
                new ObjectParameter("Kolicina", typeof(int));
    
            var cijenaParameter = cijena.HasValue ?
                new ObjectParameter("Cijena", cijena) :
                new ObjectParameter("Cijena", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_UlaziStavke_Insert", ulazIDParameter, proizvodIDParameter, kolicinaParameter, cijenaParameter);
        }
    
        public virtual ObjectResult<esp_UlaziStavke_SelectByUlazID_Result> esp_UlaziStavke_SelectByUlazID(Nullable<int> ulazID)
        {
            var ulazIDParameter = ulazID.HasValue ?
                new ObjectParameter("UlazID", ulazID) :
                new ObjectParameter("UlazID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_UlaziStavke_SelectByUlazID_Result>("esp_UlaziStavke_SelectByUlazID", ulazIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> esp_Ulazi_Insert(string brojFakutre, Nullable<System.DateTime> datum, Nullable<decimal> iznosRacuna, Nullable<decimal> pDV, string napomena, Nullable<int> skladisteID, Nullable<int> korisnikID, Nullable<int> dobavljacID)
        {
            var brojFakutreParameter = brojFakutre != null ?
                new ObjectParameter("BrojFakutre", brojFakutre) :
                new ObjectParameter("BrojFakutre", typeof(string));
    
            var datumParameter = datum.HasValue ?
                new ObjectParameter("Datum", datum) :
                new ObjectParameter("Datum", typeof(System.DateTime));
    
            var iznosRacunaParameter = iznosRacuna.HasValue ?
                new ObjectParameter("IznosRacuna", iznosRacuna) :
                new ObjectParameter("IznosRacuna", typeof(decimal));
    
            var pDVParameter = pDV.HasValue ?
                new ObjectParameter("PDV", pDV) :
                new ObjectParameter("PDV", typeof(decimal));
    
            var napomenaParameter = napomena != null ?
                new ObjectParameter("Napomena", napomena) :
                new ObjectParameter("Napomena", typeof(string));
    
            var skladisteIDParameter = skladisteID.HasValue ?
                new ObjectParameter("SkladisteID", skladisteID) :
                new ObjectParameter("SkladisteID", typeof(int));
    
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var dobavljacIDParameter = dobavljacID.HasValue ?
                new ObjectParameter("DobavljacID", dobavljacID) :
                new ObjectParameter("DobavljacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("esp_Ulazi_Insert", brojFakutreParameter, datumParameter, iznosRacunaParameter, pDVParameter, napomenaParameter, skladisteIDParameter, korisnikIDParameter, dobavljacIDParameter);
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectBySifraList_Result> esp_Proizvodi_SelectBySifraList(string sifra)
        {
            var sifraParameter = sifra != null ?
                new ObjectParameter("Sifra", sifra) :
                new ObjectParameter("Sifra", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectBySifraList_Result>("esp_Proizvodi_SelectBySifraList", sifraParameter);
        }
    }
}
