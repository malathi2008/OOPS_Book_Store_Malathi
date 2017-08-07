using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Book_Store_Malathi
{
    class Book
    {
        String name;
        Author[] authors;
        double price;
        Date publication;
        int qty = 0;

        public Book(String name, Author[] authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
        }

        public Book(String name, double price, int qty, params Author[] authors)
        {
            this.name = name;
            this.qty = qty;
            this.price = price;
            this.authors = new Author[authors.Length];
            for (int i = 0; i < authors.Length; i++)
            {
                try
                {
                    this.authors[i] = authors[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }

        }

        public String GetName()
        {
            return name;
        }

        public Author[] GetAuthor()
        {
            return this.authors;
        }
        public Date GetPublicationDate()
        {
            return publication;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetPublicationDate(Date Date)
        {
            this.publication = Date;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public int GetQty()
        {
            return qty;
        }
        public void SetQty(int qty)
        {
            this.qty = qty;

        }
        public override String ToString()
        {
            String check = "";
            for (int i = 0; i < authors.Length; i++)
            {
                check = check + authors[i].GetName();
                if (!(i == authors.Length - 1))
                {
                    check = "   " + check + Environment.NewLine;
                }
            }
            return (" This book " + name + " is written by " + authors.Length + " author " + Environment.NewLine + "   " + check + Environment.NewLine + "  and the price of this book is $" + price + Environment.NewLine + "  and we have " + qty + " books in the stock.");
        }
        public String GetAuthorNames()
        {
            return ("");
        }

    }
}
