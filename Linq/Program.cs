namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable avantajları
            //1-Deferred
            //2-Composable
            //3-Extensible
            //4-Testable
            //5-Readable
            //6-Performance
            //7-Interoperable
            //8-Parallelizable
            //9-Consistent
            //10-Reusable

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Linq Method Syntax
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0); //IEnumeable system altında bir koleksiyondur ve yineleyicidir.

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------");
            //Linq Query Syntax
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            //Linq Basic Querys

            //1-Where
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,-1,-2,-3,-4,-5 };

            var positiveNumbers = numbers2.Where(x => x > 0); //var burada IEnumerable<int> tipinde bir değişken oluşturur.
            //var positiveNumbers = numbers2.Where(x => x > 0).toList();//ToList() metodu ile IEnumerable tipindeki veriyi List tipine çevirebiliriz.

            foreach (var item in positiveNumbers)
            {
                Console.Write(item);
                Console.Write("-");
            }
            Console.WriteLine();
            //2-Select
            Console.WriteLine("--------------");
            var squareNumbers = numbers2.Select(x => x * x);

            foreach (var item in squareNumbers)
            {
                Console.Write(item);
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine("--------------");
            
            var personList = numbers.Select(x => new Person { id = x });

            foreach (var item in personList)
            {
                Console.WriteLine(item);
            }

            //3-OrderBy - OrderByDescending
            Console.WriteLine("--------------");

            var unOrderList = new List<int> { 1, 4, 7, 3, 5, 78, 9, 5, 23, 5, 6, 34, 346, 34567, 456, 3456, 234, 2345, 3 };
            Console.WriteLine("Küçükten Büyüğe Sıralanmış Liste");
            var orderList = unOrderList.OrderBy(x => x);

            foreach (var item in orderList)
            {
                Console.Write(item);
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine("--------------");

            Console.WriteLine("Büyükten Küçüğe Sıralanmış Liste");
            var orderDescList = unOrderList.OrderByDescending(x => x);
            foreach (var item in orderDescList)
            {
                Console.Write(item);
                Console.Write("-");
            }

            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine("Person Ascending Sıralama");

            var personListASC = personList.OrderBy(x => x);

            foreach (var item in personListASC)
            {
                Console.WriteLine(item);
            }


            //Than ile karşılaştırma yapmak için yeni bilgiler ile Liste oluşturduk.
            var people = new List<Person>
            {
                new Person { id = 1, age = 20, name = "Ali" },
                new Person { id = 2, age = 25, name = "Veli" },
                new Person { id = 3, age = 30, name = "Deli" },
                new Person { id = 4, age = 35, name = "Meli" },
                new Person { id = 5, age = 40, name = "Zeli" },
                new Person { id = 6, age = 45, name = "Keli" },
                new Person { id = 7, age = 50, name = "Leli" },
                new Person { id = 8, age = 55, name = "Neli" },
                new Person { id = 9, age = 60, name = "Peli" },
                new Person { id = 10, age = 65, name = "Reli" }
            };
            Console.WriteLine("--------------");

            var sortedPeople = people.OrderBy(x => x.age)
                                     .ThenBy(x => x.name); //age'ye göre sıraladıktan sonra name'e göre sıralama yapar.
            Console.WriteLine("Önce Yaşa Sonra İsme göre Sıralanmış Liste");
            foreach (var item in sortedPeople)
            {
                Console.WriteLine(item.name + " " + item.age);
            }


            Console.WriteLine("--------------");
            Console.WriteLine("Kitap sınıfı ile GroupBy kullanımı - Fiyata göre");

            //GroupBy
            var books = new List<Book>
            {
                new Book { id = 1, name = "Book1", author = "Author1", price = 20 },
                new Book { id = 2, name = "Book2", author = "Author2", price = 100 },
                new Book { id = 3, name = "Book3", author = "Author3", price = 30 },
                new Book { id = 4, name = "Book4", author = "Author4", price = 100 },
                new Book { id = 5, name = "Book5", author = "Author5", price = 50 },
                new Book { id = 6, name = "Book6", author = "Author6", price = 80 },
                new Book { id = 7, name = "Book7", author = "Author7", price = 70 },
                new Book { id = 8, name = "Book8", author = "Author8", price = 80 },
                new Book { id = 9, name = "Book9", author = "Author9", price = 90 },
                new Book { id = 10, name = "Book10", author = "Author10", price = 100 }
            };

            var groupByPrice = books.GroupBy(x => x.price);

            foreach (var group in groupByPrice)
            {
                Console.WriteLine(group.Key);
                foreach (var book in group)
                {
                    Console.Write("-");
                    Console.Write(book.name);
                }
                Console.WriteLine();
            }














            Console.WriteLine("--------------");
            //Rastgele 11 haneli tc kimlik no üretimi ve bunları Perrson id 'sine atıp Listede tutma işlemi
            List<long> persons = new List<long>();
            
            var person_id = Enumerable.Range(0, 10).Select(x => new Person { id = generate_id() }).ToList();


            int i = 1;
            foreach (var item in person_id)
            {
                Console.WriteLine($"{i} - "+item.id);
                i++;
            }

            
        }

        //Rastgele 11 haneli tc kimlik no üretimi
        public static long generate_id()
        {
            Random random = new Random();
            return random.NextInt64(10000000000, 99999999999);
        }
    }
}
