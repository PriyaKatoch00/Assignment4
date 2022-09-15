using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class BookStore
    {
        string isbn;
        string BookName;
        string BookAuthor;
        int quantity;
        int price;

        public string ISBN { get { return isbn; } set { isbn = value; } }
        public string BOOKNAME { get { return BookName; } set { BookName = value; } }
        public string BOOKAUTHOR { get { return BookAuthor; } set { BookAuthor = value; } }
        public int QUANTITY { get { return quantity; } set { quantity = value; } }
        public int PRICE { get { return price; } set { price = value; } }

    }
    class BookStore_Test
    {
        static void Main()
        {
            BookStore[] b = new BookStore[3];
            b[0] = new BookStore();
            b[0].ISBN = "01";
            b[0].BOOKNAME = "Abc";
            b[0].BOOKAUTHOR = "Xyz";
            b[0].QUANTITY = 1;
            b[0].PRICE = 200;

            b[1] = new BookStore();
            b[1].ISBN = "02";
            b[1].BOOKNAME = "Def";
            b[1].BOOKAUTHOR = "Zyx";
            b[1].QUANTITY = 15;
            b[1].PRICE = 1400;

            b[2] = new BookStore();
            b[2].ISBN = "03";
            b[2].BOOKNAME = "GHI";
            b[2].BOOKAUTHOR = "Yxz";
            b[2].QUANTITY = 20;
            b[2].PRICE = 500;

            int bill = 0, i;
            for (i = 0; i < 3; i++)
            {
                bill = bill + (b[i].QUANTITY * b[i].PRICE);

            }
            Console.WriteLine("Total=" + bill);
        }
    }
}
