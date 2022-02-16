// See https://aka.ms/new-console-template for more information


try
{
    Console.WriteLine("Bir sayı giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
}
catch(Exception ex)
{
    Console.WriteLine("Hata: "+ ex.Message.ToString());
}
// finally
// {
// Console.Write("işlem tamamlandı.");
// }

try
{
    int a = int.Parse(null);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer giriniz");
    Console.WriteLine(ex);
}

try
{
    int b = int.Parse("test");
}
catch(FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil");
    Console.WriteLine(ex);
}

try
{
    int b = int.Parse("7868231683712687312");
}
catch(OverflowException ex)
{
    Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("işlem başarıyla tamamlandı.");
}


