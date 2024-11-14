namespace Patikafy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir Liste Tanımlayarak içerisine 11 adet Album class verimizi Giriyoruz.
            var albumList = new List<Album>
            {
                new Album { Singer = "Ajda Pekkan", musicGenre = "Pop", release = 1968, salesAmount = 20000000 },
                new Album { Singer = "Sezen Aksu", musicGenre = "Türk Halk Müziği / Pop", release = 1971, salesAmount = 10000000 },
                new Album { Singer = "Funda Arar", musicGenre = "Pop", release = 1999, salesAmount = 3000000 },
                new Album { Singer = "Sertab Erener", musicGenre = "Pop", release = 1994, salesAmount = 5000000 },
                new Album { Singer = "Sıla", musicGenre = "Pop", release = 2009, salesAmount = 3000000 },
                new Album { Singer = "Serdar Ortaç", musicGenre = "Pop", release = 1994, salesAmount = 10000000 },
                new Album { Singer = "Tarkan", musicGenre = "Pop", release = 1992, salesAmount = 40000000 },
                new Album { Singer = "Hande Yener", musicGenre = "Pop", release = 1999, salesAmount = 7000000 },
                new Album { Singer = "Hadise", musicGenre = "Pop", release = 2005, salesAmount = 5000000 },
                new Album { Singer = "Gülben Ergen", musicGenre = "Türk Halk Müziği / Pop", release = 1997, salesAmount = 10000000 },
                new Album { Singer = "Neşet Ertaş", musicGenre = "Türk Halk Müziği / Türk Sanat Müziği", release = 1960, salesAmount = 2000000 }
            };

            //Adı 'S' ile başlayan sanatçıların isimlerini listeleyen sorgu
            Console.WriteLine("Adı 'S' ile Başlayan Sanatçılar:");
            albumList.Where(x => x.Singer.StartsWith("S")).Select(x => x.Singer).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----------------");

            //Albüm satışları 10 milyonun üzerinde olan sanatçılar
            Console.WriteLine("Albüm Satışları 10 Milyonun Üzerinde Olan Sanatçılar:");
            albumList.Where(x => x.salesAmount > 10000000).Select(x => x.Singer).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----------------");

            //2000 yılı öncesi çıkış yapmış ve pop müzik türünde albümler(Çıkış yılına göre gruplanmış,alfebetik sıra ile yardırılmış)
            Console.WriteLine("2000 Yılı Öncesi Çıkış Yapmış ve Pop Müzik Türünde Albümler:");
            albumList.Where(x => x.release < 2000 && x.musicGenre.Contains("Pop")).OrderBy(x => x.Singer).ToList().ForEach(x => Console.WriteLine(x.Singer +" - "+x.musicGenre));

            //En çok albüm satışı yapan sanatçı
            Console.WriteLine("En Çok Albüm Satışı Yapan Sanatçı:");
            Console.WriteLine(albumList.OrderByDescending(x => x.salesAmount).First().Singer);
            Console.WriteLine("-----------------");

            //En yeni çıkış yapan sanatçı ve en eski çıkış yapan sanatçı
            Console.WriteLine("En Yeni Çıkış Yapan Sanatçı:");
            Console.WriteLine(albumList.OrderByDescending(x => x.release).First().Singer);
            Console.WriteLine("-----------------");
            Console.WriteLine("En Eski Çıkış Yapan Sanatçı:");
            Console.WriteLine(albumList.OrderBy(x => x.release).First().Singer);
            Console.WriteLine("-----------------");
        }
    }
}
