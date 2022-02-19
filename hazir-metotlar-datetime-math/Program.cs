// See https://aka.ms/new-console-template for more information

// DateTime Kütüphanesi

Console.WriteLine("\nDateTime Kütüphanesi\n");

Console.WriteLine(DateTime.Now); // günün tarihini getirir. tarih ve saat
Console.WriteLine(DateTime.Now.Date); // gün getirir ve saati 00.00.00 olarak getirir
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(10));
Console.WriteLine(DateTime.Now.AddMilliseconds(5000));

// DateTime Format

Console.WriteLine(DateTime.Now.ToString("dd")); // sadece günün sayısını getirir. 19
Console.WriteLine(DateTime.Now.ToString("ddd")); // haftanın günü kısaltılmış Cmt
Console.WriteLine(DateTime.Now.ToString("dddd")); // haftanın günü açık Cumartesi


Console.WriteLine(DateTime.Now.ToString("MM")); // 02
Console.WriteLine(DateTime.Now.ToString("MMM")); // Sub
Console.WriteLine(DateTime.Now.ToString("MMMM")); // Subat

Console.WriteLine(DateTime.Now.ToString("yy")); // 22
Console.WriteLine(DateTime.Now.ToString("yyy")); // 2022

// Math Kütüphanesi
Console.WriteLine("\nMath Kütüphanesi\n");

Console.WriteLine(Math.Abs(-25)); // 25
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));

Console.WriteLine(Math.Ceiling(22.3)); // 23
Console.WriteLine(Math.Round(22.3)); // 22
Console.WriteLine(Math.Round(22.7)); // 23
Console.WriteLine(Math.Floor(22.7)); // 22

Console.WriteLine(Math.Max(2,6)); // 6 
Console.WriteLine(Math.Min(2,6)); // 2

Console.WriteLine(Math.Pow(3,4)); // 3^4 ü verir. 81.
Console.WriteLine(Math.Sqrt(9)); // karekök alır. 3
Console.WriteLine(Math.Log(9)); // 9'un e tabanındaki logaritmik karşılığını verir.
Console.WriteLine(Math.Exp(3)); // e üzeri 3 verir.
Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı













