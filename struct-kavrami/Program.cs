// See https://aka.ms/new-console-template for more information

Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.kisaKenar = 3;
dikdortgen.uzuNkenar = 4;
Console.WriteLine("Class Alan Hesabı : {0}", dikdortgen.AlanHesapla());

Dikdortgen_Struct dikdortgen_Struct; // new Dikdortgen_Struct(); new yazmadan da oluşturulabiliyor. 
dikdortgen_Struct.kisaKenar = 3;
dikdortgen_Struct.uzuNkenar = 4;
Console.WriteLine("Struct Alan Hesabı : {0}", dikdortgen_Struct.AlanHesapla());





class Dikdortgen
{
    public int kisaKenar;
    public int uzuNkenar;
    public Dikdortgen()
    {
        kisaKenar = 3;
        uzuNkenar = 4;
    }
    public long AlanHesapla()
    {
        return this.kisaKenar * this.uzuNkenar;
    }
}

struct Dikdortgen_Struct
{
    public int kisaKenar;
    public int uzuNkenar;
    public Dikdortgen_Struct(int kisaKenar, int uzuNkenar)
    {
        this.kisaKenar = kisaKenar;
        this.uzuNkenar = uzuNkenar;
    }
    public long AlanHesapla()
    {
        return this.kisaKenar * this.uzuNkenar;
    }
}
