// See https://aka.ms/new-console-template for more information

using acunmedya.Odev1.Classes;
using acunmedya.Odev2.Classes;
using acunmedya.Odev4.Classes;
using acunmedya.Odev5.Classes;

Insan insanObj = new Insan();
Console.WriteLine("Yaşınızı giriniz : ");
insanObj.yas = int.Parse(Console.ReadLine());
string gelenSonuc = insanObj.yasKategoriBelirle(insanObj.yas);
Console.WriteLine(gelenSonuc);


ArabaDurumu arabaDurumuObj = new ArabaDurumu();
Console.WriteLine("Araba yaşını giriniz : ");
arabaDurumuObj.yas = int.Parse(Console.ReadLine());

// if-else kullanımı
string gelenSonuc2 = arabaDurumuObj.arabaDurumuBelirle(arabaDurumuObj.yas);
Console.WriteLine(gelenSonuc2);

// switch case kullanımı
string gelenSonuc3 = arabaDurumuObj.arabaDurumuBelirle2(arabaDurumuObj.yas);
Console.WriteLine(gelenSonuc3);



//while döngüsü: koşulu en başta kontrol eder
int sayi1 = 4;
while (sayi1 > 0)
{
    Console.WriteLine("Sayi1 değeri : " + sayi1);
    sayi1--;
}


//do-while dönngüsü: koşulu en sonda kontrol eder
int sayi2 = 0;
// sayi2 değeri koşulu sağlamamasına rağmen console yazdırılır
do
{
    Console.WriteLine("Sayi2 değeri : " + sayi2);
    sayi2--;
} while (sayi2 > 0);



// ödev-4
GenelMudur gm = new GenelMudur();
gm.ad = "Ali";
gm.soyad = "Yıldız";
gm.departman = "Yönetim";
gm.meslek = "Genel Müdür";
//gm.calisanBilgileri(gm.ad, gm.soyad, gm.meslek, gm.maasinizNedir(), gm.departman);

Mudur mu = new Mudur();
mu.ad = "Elif";
mu.soyad = "Acar";
mu.departman = "Yönetim";
mu.meslek = "Müdür";
//mu.calisanBilgileri(mu.ad, mu.soyad, mu.meslek, mu.maasinizNedir(), mu.departman);

Programci pr = new Programci();
pr.ad = "Nazar";
pr.soyad = "Arık";
pr.departman = "Bilişim";
pr.meslek = "Programcı";
//pr.calisanBilgileri(pr.ad, pr.soyad, pr.meslek, pr.maasinizNedir(), pr.departman);

Stajyer s = new Stajyer();
s.ad = "Ayşe";
s.soyad = "kurt";
s.departman = "Staj";
s.meslek = "Stajyer";
//s.calisanBilgileri(s.ad, s.soyad, s.meslek, s.maasinizNedir(), s.departman);

Calisan[] calisanList = {gm, mu, pr, s};

// calışan bilgilerini döngü ile yazdırdım
for (int j = 0; j < calisanList.Length; j++)
{
    calisanList[j].calisanBilgileri(
        calisanList[j].ad,
        calisanList[j].soyad,
        calisanList[j].meslek,
        calisanList[j].maasinizNedir(),
        calisanList[j].departman
    );
}

// toplam maaş hesaplama
double toplamMaas = 0.0;
for (int i = 0; i < calisanList.Length; i++)
{
    toplamMaas += calisanList[i].maasinizNedir();
}
Console.WriteLine("Toplam maaş: " + toplamMaas);



// ödev-5
Audi audiObj = new Audi();
Ford fordObj = new Ford();
Toyota toyotaObj = new Toyota();
Araba[] arabaList = {audiObj, fordObj, toyotaObj};

double toplamBenzin = 0.0;
for (int k = 0; k < arabaList.Length; k++)
{
    toplamBenzin += arabaList[k].benzinTüketimi();
}
Console.WriteLine("Toplam benzin: " + toplamBenzin);