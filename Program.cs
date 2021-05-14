using System;

namespace s4lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new tph();
            tph.Osoby.Add(new Pracownik() { Imie = "Jan", Nazwisko = "Kowalski", DataZatrudnienia = DateTime.Now.AddDays(-15), DataZwolnienia = DateTime.Now });
            tph.Osoby.Add(new Pracownik() { Imie = "Kamil", Nazwisko = "Lewandowski", DataZatrudnienia = DateTime.Now.AddDays(-7), DataZwolnienia = null});
            tph.Osoby.Add(new Pracownik() { Imie = "Jan", Nazwisko = "Walesa", DataZatrudnienia = DateTime.Now.AddDays(-7), DataZwolnienia = null });
            tph.Osoby.Add(new Klient() { Imie = "Janusz", Nazwisko = "Nowak", NrTelefonu = "44 333 555", NrRejestracyjny = "SB 3110" });
            tph.SaveChanges();

            var tpt = new tph();
            tpt.Osoby.Add(new Pracownik() { Imie = "Magda", Nazwisko = "Lewdandowska", DataZatrudnienia = DateTime.Now.AddYears(-1), DataZwolnienia = DateTime.Now.AddDays(28) });
            tpt.Osoby.Add(new Klient() { Imie = "Link4", Nazwisko = "Link4", NrTelefonu = "44 444 4444", NrRejestracyjny = "WI 5221" });
            tpt.Osoby.Add(new Klient() { Imie = "Ola", Nazwisko = "Szczesna", NrTelefonu = "33 444 3333", NrRejestracyjny = "SZY S5S2" });
            tpt.SaveChanges();
        }
    }
}
