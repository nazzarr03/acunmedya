// See https://aka.ms/new-console-template for more information

using acunmedya.Odev1.Classes;

Insan insanObj = new Insan();
Console.WriteLine("Yaşınızı giriniz : ");
insanObj.yas = int.Parse(Console.ReadLine());
string gelenSonuc = insanObj.yasKategoriBelirle(insanObj.yas);
Console.WriteLine(gelenSonuc);