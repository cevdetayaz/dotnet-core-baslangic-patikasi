public class Bitkiler:Canlilar
{
    protected void FotosentezYapmak()
    {
        Console.WriteLine("Bitkiler fotosentez yapar.");
    }
}

public class TohumluBitkiler:Bitkiler{
    public void TohumlaCogalma()
    {
        Console.WriteLine("Tohumlu Bitkiler tohumla çoğalır.");
        
    }

    public TohumluBitkiler(){
        base.FotosentezYapmak();
        base.Beslenme();
        base.Solunum();
        base.Bosaltim();

    }
}

public class TohumsuzBitkiler:Bitkiler{

    public TohumsuzBitkiler(){
        base.FotosentezYapmak();
        base.Beslenme();
        base.Solunum();
        base.Bosaltim();
        
    }
    public void SporlaCogalma()
    {
        Console.WriteLine("Tohumsuz Bitkiler sporla çoğalır.");
        
    }
}