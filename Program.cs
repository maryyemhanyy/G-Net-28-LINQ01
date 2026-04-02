using System.Diagnostics;
using System.Xml.Linq;
using static LINQSession1.Source;


namespace LINQSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Get all products from the "Seafood" category. Print each product's name and price

            //var result = ProductList.Where(p => p.Category == "Seafood")
            //                        .Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2
            //Get a list of only the product names from ProductList. Print each name.

            //var result = ProductList.Select(p => p.ProductName);

            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q3
            //Sort all products by UnitPrice (ascending). Print each product's name and price.

            //var result = ProductList.OrderBy(p => p.UnitPrice).Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4
            //Get all products where UnitPrice is between 10 and 30

            //var result = ProductList.Where(p => p.UnitPrice>=10 && p.UnitPrice<=30)
            //                        .Select(p => new { Name = p.ProductName, Price = p.UnitPrice });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Q5
            //Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.

            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments")
            //                        .Select(p => new { Name = p.ProductName, Category = p.Category , Stock = p.UnitsInStock });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q6
            /*6. Create a new anonymous type with three properties:
              ● Name → the product name
              ● Price → the unit price
              ● StockStatus → a string: "Available" if UnitsInStock > 0,
              otherwise "Out of Stock"
              ● Print the result.*/

            //var result = ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q7
            //Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.

            //var result = ProductList.Select((p , i) => $"{i+1}.{p.ProductName}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q8
            //Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.

            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }
}
