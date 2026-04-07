using G_Net_34_LINQ01.Models;
using static G_Net_34_LINQ01.DataSources.Source;
namespace G_Net_34_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ////Get all products from the "Seafood" category. Print each product's name and price.
            //var query = ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .Select(p =>$"ProductName :{p.ProductName} | Price : {p.UnitPrice}  ");
            //Helper.Print("Q1", query);
            #endregion
            #region Q2
            /*Get a list of only the product names from ProductList. Print
                each name.
             */
            //var query=ProductList
            //    .Select((p,i) => $"ProductName#{i+1} :"+p.ProductName);
            //Helper.Print("Q2", query);
            #endregion
            #region Q03
            /*Sort all products by UnitPrice (ascending). Print each
            product's name and price.*/
            //var query=ProductList
            //    .OrderBy(p=>p.UnitPrice)
            //    .Select(p => $"ProductName :{p.ProductName} | Price : {p.UnitPrice}  ");
            //Helper.Print("Q3", query);
            #endregion
            #region Q4
            //Get all products where UnitPrice is between 10 and 30
            ////Fluent syntax
            //var query = ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30)
            //    .Select(p=>p);
            //Helper.Print("Q4", query);

            ////Query syntax
            //var query2 = from p in ProductList
            //             where p.UnitPrice >= 10 && p.UnitPrice <= 30
            //             select p;

            
            //Helper.Print("Q4", query2);

            #endregion


        }
    }
}
