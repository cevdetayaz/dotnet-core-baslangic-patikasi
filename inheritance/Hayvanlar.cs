public class Hayvanlar:Canlilar
{
    protected void Adaptasyon(){
        Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        
    }
}

public class Surungenler:Hayvanlar{
    public Surungenler(){
        base.Adaptasyon();
    }
    public void SurunerekHareketEderler()
    {
        Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        
    }
}

public class Kuslar:Hayvanlar{
    public Kuslar(){
        base.Adaptasyon();
        base.Beslenme();
        base.Solunum();
        base.Bosaltim();
    }
    public void Ucmak()
    {
        Console.WriteLine("Kuşlar uçar.");
        
    }
}