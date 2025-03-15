namespace acunmedya.Odev4.Classes;

public abstract class Calisan
{
    public string ad;
    public string soyad;
    public string meslek;
    public abstract double maasinizNedir();
    public string departman;

    public void calisanBilgileri(string ad, string soyad, string meslek, double maas, string departman)
    {
        Console.WriteLine("Adı: " + ad + ", Soyadı: " + soyad);
        Console.WriteLine("Departmanı: " + departman + ", Mesleği: " + meslek + ", Maaşı: " + maas);
        Console.WriteLine("");
    }
}