using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public  class ProductReview
    {
        public int productID{get;set;}
        public int userID{get;set;}
        public double rating{get;set;}
        public string review{get;set;}
        public bool isLiked { get;set;}

        public override string ToString()
        {
            return $"productID:{productID}\t userID:{userID}\t rating:{rating}\t review:{review}\t isliked:{isLiked}"; 
        }
    }

    class ProductReviewManager
    {
        List<ProductReview> list = new List<ProductReview>();
        internal void test()
        {
            AddProducts(list);
            //PrintTopThreeRatings();
            //RetrieveParticularData();
            //printNumberOfReviews();
            //skipTop3();
            DataTable dt = createTable();
            printTable(dt);

        }
        public void printTable(DataTable dt)
        {

            foreach (DataColumn col in dt.Columns)
            {
                Console.Write(col.ColumnName+"\t");
            }

            Console.WriteLine();
            foreach (DataRow dr in dt.Rows)
            {
                foreach (var item in dr.ItemArray)
                {
                    Console.Write(item.ToString() + "\t");
                }
                Console.WriteLine();
            }

        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("productID",typeof(int));
            dt.Columns.Add("userID",typeof(int));
            dt.Columns.Add("rating",typeof(double));
            dt.Columns.Add("review",typeof(string));
            dt.Columns.Add("isLiked",typeof(bool));

            foreach(var data in list)
            {
                dt.Rows.Add(data.productID,data.userID,data.rating,data.review,data.isLiked);
            }
            return dt;
        }

        public void skipTop3()
        {
            var res = (from prod in list
                       orderby prod.rating descending
                       select prod).Skip(3).ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void printNumberOfReviews()
        {
            var res = list.GroupBy(x => x.productID).Select(p => new { productID = p.Key, count = p.Count() });
            foreach (var item in res)
            {
                Console.WriteLine($"productID: {item.productID} count:{item.count}");
            }
        }

        public void RetrieveParticularData()
        {
            var data = (from prod in list
                        where prod.productID==1 && prod.rating > 3 select prod).ToList();
            print(data);
        }

        public void PrintTopThreeRatings()
        {
            var sorted = list.OrderByDescending(p=>p.rating).Take(3).ToList();
            print(sorted);
        }

        public static void print(List<ProductReview> prods)
        {
            foreach (ProductReview p in prods)
            {
                Console.WriteLine(p.ToString());
            }
        }
        static void AddProducts(List<ProductReview> list)
        {
            list.Add(new ProductReview { productID = 0, userID = 0, rating = 4, review = "Nice product", isLiked=true });
            list.Add(new ProductReview { productID = 2, userID = 1, rating = 3, review = "good product", isLiked=false});
            list.Add(new ProductReview { productID = 1, userID = 0, rating = 5, review = "awesome product", isLiked=true});
            list.Add(new ProductReview { productID = 2, userID = 2, rating = 1, review = "bad", isLiked = false});
            list.Add(new ProductReview { productID = 2, userID = 2, rating = 3, review = "nice", isLiked = false});
            list.Add(new ProductReview { productID = 1, userID = 1, rating = 4, review = "nice", isLiked = true});
            list.Add(new ProductReview { productID = 1, userID = 1, rating = 2, review = "ok product", isLiked = false});
            list.Add(new ProductReview { productID = 3, userID = 4, rating = 2, review = "ok prod", isLiked = false});
            list.Add(new ProductReview { productID = 4, userID = 2, rating = 3, review = "ok prod", isLiked = false});
        }
    }
}
