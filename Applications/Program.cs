namespace Applications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> divide = (x, y) =>
            //{
            //    if (y == 0)
            //    {
            //        throw new DivideByZeroException("Bölen sıfır olamaz.");
            //    }
            //    return x / y;

            //};

            //Console.WriteLine(divide(8, 0));

            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //ProcessNumber(numbers, x => x % 2 == 0);

            //Delegate Kullanımı
            sum sum = (x, y) => x + y;
            Console.WriteLine(sum(5,7));
            Console.WriteLine("--------------");

            //Func kullanımı
            Func<int, int, int> sum2 = (x, y) => x + y;
            Console.WriteLine(sum2(6,8));
            Console.WriteLine("--------------");


            //Action kullanımı

            Action<string> write = x => Console.WriteLine(x);
            write("Hello World");
        }

        public delegate int sum(int x, int y);

        public static void ProcessNumber(List<int> numbers, Func<int,bool> filter)
        {
            foreach (var item in numbers)
            {
                if(filter(item))
                    Console.WriteLine(item);
            }
        }
    }
}
