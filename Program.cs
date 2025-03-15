// See https://aka.ms/new-console-template for more information

using acunmedya.Odev1.Classes;
using acunmedya.Odev2.Classes;

Insan insanObj = new Insan();
Console.WriteLine("Yaşınızı giriniz : ");
insanObj.yas = int.Parse(Console.ReadLine());
string gelenSonuc = insanObj.yasKategoriBelirle(insanObj.yas);
Console.WriteLine(gelenSonuc);


Araba arabaObj = new Araba();
Console.WriteLine("Araba yaşını giriniz : ");
arabaObj.yas = int.Parse(Console.ReadLine());

// if-else kullanımı
string gelenSonuc2 = arabaObj.arabaDurumuBelirle(arabaObj.yas);
Console.WriteLine(gelenSonuc2);

// switch case kullanımı
string gelenSonuc3 = arabaObj.arabaDurumuBelirle2(arabaObj.yas);
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
