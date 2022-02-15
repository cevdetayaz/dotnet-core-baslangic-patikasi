// See https://aka.ms/new-console-template for more information
// Net 6.0 sdk kullandığından ötürü namespace, main methodu yazılması şart değil.
// yeni console uygulaması oluşturulduğunda ortaya sadece "Console.WriteLine("Hello, World!");" kodu çıkıyor.
/* Net 5.0 formatında oluştursaydık aşağıdaki gibi olurdu.
using System;

namespace console_programlama // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
} 
*/

Console.WriteLine("Hello, World!");
Console.WriteLine("İsminizi Giriniz:");
string name = Console.ReadLine();
Console.WriteLine("Soyadınızı Giriniz:");
string surname = Console.ReadLine();

Console.WriteLine("Merhaba " + name + " " + surname);