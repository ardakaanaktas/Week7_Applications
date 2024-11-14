namespace Practise_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random  random = new Random();
            List<int> numbers = new List<int>();// Random numaraları eklediğimiz base Listemiz.

            for (int i = 0; i < 10; i++) //10 tane random sayı ekliyoruz.
            {
                numbers.Add(random.Next(-100, 100));// -100 ile 100 arasında random sayılar ekliyoruz.
            }

            Console.WriteLine("Üretilern random sayılarımızın tamamı: ");
            numbers.ForEach(x => Console.WriteLine(x)); //Listedeki tüm elemanları yazdırır.
            Console.WriteLine("----------------------");

            Console.WriteLine("Listedeki Çift Sayılar:");
            numbers.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x)); //Çift sayıları yazdırır.
            Console.WriteLine("----------------------");

            Console.WriteLine("Listedeki tek sayılar:");
            numbers.Where(x => x % 2 != 0).ToList().ForEach(x => Console.WriteLine(x)); //Tek sayıları yazdırır.    
            Console.WriteLine("----------------------");

            Console.WriteLine("Negatif sayılar:");
            numbers.Where(x => x < 0).ToList().ForEach(x => Console.WriteLine(x)); //Negatif sayıları yazdırır.
            Console.WriteLine("----------------------");

            Console.WriteLine("Pozitif sayılar:");
            numbers.Where(x => x > 0).ToList().ForEach(x => Console.WriteLine(x)); //Pozitif sayıları yazdırır.
            Console.WriteLine("----------------------");

            Console.WriteLine("15'ten Büyük ve 22'den küçük sayılar:");
            numbers.Where(x => x > 15 && x < 22).ToList().ForEach(x => Console.WriteLine(x)); //15'ten büyük ve 22'den küçük sayıları yazdırır.
            Console.WriteLine("----------------------");

            Console.WriteLine("Listedeki sayıların karesi:");
            numbers.Select(x => x * x).ToList().ForEach(x => Console.WriteLine(x)); //Listedeki tüm sayıların karesini alır.
            Console.WriteLine("----------------------");
        }
    }
}
