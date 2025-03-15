namespace acunmedya.Odev2.Classes;

public class ArabaDurumu
{
    public int yas;
    
    // if-else
    public string arabaDurumuBelirle(int yas)
    {
        string sonuc = "";
        if (yas >= 0 && yas <= 10)
        {
            sonuc = "Arabanız yeni";
        }
        else if (yas > 10 && yas <= 20)
        {
            sonuc = "Servise götürmeniz gerekebilir";
        }
        else if (yas > 20 && yas <= 30)
        {
            sonuc = "Arabanız hurdaya çıkabilir";
        }
        else
        {
            sonuc = "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        }

        return sonuc;
    }

    // switch case
    public string arabaDurumuBelirle2(int yas)
    {
        string sonuc = "";
        switch (yas)
        {
            case >= 0 and <= 10:
                sonuc = "Arabanız yeni";
                break;
            case > 10 and <= 20:
                sonuc = "Servise götürmeniz gerekebilir";
                break;
            case > 20 and <= 30:
                sonuc = "Arabanız hurdaya çıkabilir";
                break;
            default:
                sonuc = "Ya hiç üretilmedi ya da trafikten men edilmiştir";
                break;
        }
        
        return sonuc;
    }
}