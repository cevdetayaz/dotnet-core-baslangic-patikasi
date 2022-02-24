// See https://aka.ms/new-console-template for more information

// Söz Dizisi

// class SinifAdi
// {
//     [erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
//     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAadı(Parametre Listesi)
//     {
//         metot komutları
//     }
// }


// Erişim Belirleyiciler
// * Public
// * Private
// * Internal
// * Protected

Console.WriteLine("***** Çalışan 1*****");

Calisan calisan1 = new Calisan("Ayşe","Kara",23425634,"insan Kaynakları");
calisan1.CalisanBilgileri();

// calisan1.Ad = "Ayşe";
// calisan1.Soyad = "Kara";
// calisan1.No = 23425634;
// calisan1.Departman = "İnsan Kaynakları";
// calisan1.CalisanBilgileri();

Console.WriteLine("*****Çalışan 2 *****");
Calisan calisan2 = new Calisan();
calisan2.Ad = "Deniz";
calisan2.Soyad = "Arda";
calisan2.No = 25646789;
calisan2.Departman ="Satın Alma";
calisan2.CalisanBilgileri();

Calisan calisan3 = new Calisan("Zikriye","Ürkmez");
calisan3.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string Departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = Departman;
    }

      public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public Calisan(){}

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: {0}", Ad);
        Console.WriteLine("Çalışan Adı: {0}", Soyad);
        Console.WriteLine("Çalışan Adı: {0}", No);
        Console.WriteLine("Çalışan Adı: {0}", Departman);        
    }
}