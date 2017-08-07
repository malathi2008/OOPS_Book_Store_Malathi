using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Book_Store_Malathi
{
    class User
    {
        public List<Author> favoriteAuthors = new List<Author>();
        public List<Book> ShoppingCart = new List<Book>();
        public User()
        { }
        public void AddAuthor(Author author)
        {
            this.favoriteAuthors.Add(author);
        }
        public void AddBook(Book author)
        {
            this.ShoppingCart.Add(author);
        }
        public String GetAuthors()
        {

            String check = "";
            if (favoriteAuthors.Count != 0)
            {
                for (int i = 0; i < favoriteAuthors.Count(); i++)
                {
                    check = check + favoriteAuthors[i].GetName();
                    if (!(i == favoriteAuthors.Count() - 1))
                    {
                        check = check + " , ";
                    }
                }
            }
            else
            {
                check = " Favorite list is empty";
            }
            return check;
        }
        public Book[] GetShoppingCart()
        {
            return ShoppingCart.ToArray();
        }
        public void AddToCart(Book book)
        {
            ShoppingCart.Add(book);
        }
        public void RemoveFromCart(Book book)
        {
            ShoppingCart.Remove(book);
        }
        public void RemoveAuthor(Author author)
        {
            favoriteAuthors.Remove(author);
        }
        public override String ToString()
        {
            String check = "";
            if (ShoppingCart.Count != 0)
            {
                for (int i = 0; i < ShoppingCart.Count(); i++)
                {
                    check = check + ShoppingCart[i].GetName();
                    if (!(i == ShoppingCart.Count() - 1))
                    {
                        check = check + " , ";
                    }
                }
            }
            else
            {
                check = " Shopping Cart is empty";
            }
            return check;
        }
        public String GetShoppingCart1()
        {
            return ShoppingCart.ToArray().ToString();
        }
    }
}
