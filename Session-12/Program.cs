using Session_12 ;
using System.Linq;
namespace Session_12
{
    internal class Program
    {
        public static object GetWords { get; private set; }

        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators - 1. Find all products that are out of stock.

            // Fluent syntax
            //var result = ListGenerator.ProductsList.Where((p) => p.UnitsInStock == 0);

            // Query syntax
            //var result = from p in ListGenerator.ProductsList
            //             where p.UnitsInStock == 0
            //             select p;

            //foreach (var p in result)
            //{
            //    Console.WriteLine(p);
            //}



            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            // Fluent syntax
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            // Query syntax
            //var result = from p in ListGenerator.ProductsList
            //             where p.UnitsInStock > 0 && p.UnitPrice > 3.00m
            //             select p;

            //foreach (var p in result)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion


            #region 3. Returns digits whose name is shorter than their value.
            //string[] Arr ={ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var ressult = Arr.Where(s => s.Length < Array.IndexOf(Arr, s));

            //foreach (var s in ressult)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #endregion



            #region LINQ - Element Operators - 1. Get first Product out of Stock 

            //var result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result);


            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ListGenerator.ProductsList.FirstOrDefault(p=> p.UnitPrice > 1000);
            //Console.WriteLine(result?.ProductName);

            #endregion

            #region 3. Retrieve the second number greater than 5 


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //var result = Arr.Where(n => n > 5).Skip(1).First();

            //Console.WriteLine(result);
            #endregion



            #endregion


            #region  LINQ - Aggregate Operators   -1 Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine(result);

            #region 2. Return a list of customers and how many orders each has.

            //        var result = ListGenerator.CustomersList.Select(c => new
            //{
            //    CustomerName = c.CustomerName,
            //    OrdersCount = c.Orders.Count()
            //});
            #endregion

            #region 3. Return a list of categories and how many products each has  (missed)

            //        var result = ListGenerator.ProductsList .GroupBy(p => p.Category)  .Select(g => new
            //{
            //    Category = g.Key,
            //    ProductsCount = g.Count()
            //});

            #endregion


            #region  4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Sum();
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = GetWords.Sum(w => w.Length);


            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var result = GetWords.Min(w => w.Length);

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result =GetWords.Max(W => W.Length);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result =GetWords.Average(W => W.Length);
            #endregion

            #endregion

        }
    }
}

