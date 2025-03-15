namespace acunmedya.Odev1.Classes;

public class Insan
{
    public int yas;
    
    public string yasKategoriBelirle(int yas)
    {
        string sonuc = "";
        if (yas >= 0 && yas <= 18)
        {
            sonuc = "Küçüksünüz";
        }
        else if (yas > 18 && yas <= 35)
        {
            sonuc = "Gençsiniz";
        }
        else if (yas > 35 && yas <= 55)
        {
            sonuc = "Yetişkinsiniz";
        }
        else if (yas > 55 && yas <= 75)
        {
            sonuc = "Yaşlısınız";
        }
        else if (yas > 75 && yas <= 99)
        {
            sonuc = "Çok yaşlısınız";
        }
        else
        {
            sonuc = "Ya hiç doğmadınız ya da çoktan öldünüz...";
        }

        return sonuc;
    }
}