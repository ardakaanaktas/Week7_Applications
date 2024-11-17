namespace PatikaFlix
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //TvSeries classlarımızı barındıracak Listemizi oluşturuyoruz.
 List<TvSeries> tvSeriesList = new List<TvSeries>();

 TvSeries tvSeries;
 bool choose = true;
 
 while (choose)
 {
     tvSeries = new TvSeries(); //Her döngüde yeni bir dizi oluşturuyoruz.
     Console.WriteLine("Dizi adı Giriniz:");
     tvSeries.name = Console.ReadLine();//Kullanıcıdan dizi adını alıyoruz.

     Console.WriteLine("Yapım Yılını Giriniz:");
     if (int.TryParse(Console.ReadLine(), out int productYear))
     {
         tvSeries.productYear = productYear;
     }
     else
     {
         Console.WriteLine("Geçersiz yıl girdiniz, lütfen tekrar deneyin.");
         continue; // Geçersiz giriş durumunda döngünün başına dön
     }

     Console.WriteLine("Dizi Türünü Giriniz: ");
     tvSeries.genre = Console.ReadLine();//Kullanıcıdan dizi türünü alıyoruz.

     Console.WriteLine("Yayınlanmaya başlama Yılını Giriniz: ");
     if (int.TryParse(Console.ReadLine(), out int releaseYear))
     {
         tvSeries.release = releaseYear;
     }
     else
     {
         Console.WriteLine("Geçersiz yıl girdiniz, lütfen tekrar deneyin.");
         continue; // Geçersiz giriş durumunda döngünün başına dön
     }

     Console.WriteLine("Yönetmen(leri) orta tire (-) ile yazınız: ");
     tvSeries.directors = Console.ReadLine();//Kullanıcıdan yönetmen(leri) alıyoruz.

     Console.WriteLine("Yayınlandığı Platformu giriniz: ");
     tvSeries.broadcastPlatform = Console.ReadLine();//Kullanıcıdan yayınlandığı platformu alıyoruz.

     tvSeriesList.Add(tvSeries);//Oluşturduğumuz dizi nesnesini listemize ekliyoruz.

     //Daha fazla dizi eklemek isteyip istemediğini soruyoruz.
     Console.WriteLine("Başka dizi eklemek istiyor musunuz? ('e'/'h')");
     var key = Console.ReadKey().Key;//Kullanıcının girdiği tuşu alıyoruz.
     Console.WriteLine();
     if (key == ConsoleKey.H)//Eğer kullanıcı 'h' tuşuna basarsa döngüyü sonlandırıyoruz.
         choose = false;
 }

 Console.WriteLine("---------------------------");
 //Komedi Dizilerini ayrı bir diziye aktarıyoruz.
 var comedySeriesList = new List<ComedySeries>();
 foreach (var item in tvSeriesList)
 {
     if (item.genre.Contains("Komedi"))
     {
         comedySeriesList.Add(new ComedySeries
         {
             name = item.name,
             genre = item.genre,
             directors = item.directors
         });
     }
 }

 var orderedList = comedySeriesList.OrderBy(x => x.name).ThenBy(x=> x.directors).ToList();//Dizileri isim ve yönetmen adına göre sıralıyoruz.

 orderedList.ForEach(x => Console.WriteLine($"Dizi Adı: {x.name} Yönetmen(ler): {x.directors} Dizi Türü: {x.genre} "));
        }
    }
}
