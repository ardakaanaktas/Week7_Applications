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
                tvSeries.productYear = Convert.ToInt32(Console.ReadLine());//Kullanıcıdan yapım yılını alıyoruz.

                Console.WriteLine("Dizi Türünü Giriniz: ");
                tvSeries.genre = Console.ReadLine();//Kullanıcıdan dizi türünü alıyoruz.

                Console.WriteLine("Yayınlanmaya başlama Yılını Giriniz: ");
                tvSeries.release = Convert.ToInt32(Console.ReadLine());//Kullanıcıdan yayınlanmaya başlama yılını alıyoruz.

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

            comedySeriesList.ForEach(x => Console.WriteLine($"Dizi Adı: {x.name} Yönetmen(ler): {x.directors} Dizi Türü: {x.genre} "));
        }
    }
}
