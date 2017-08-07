using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Book_Store_Malathi
{
    class Author
    {
        String name;
        Book[] books;
        String email;
        Date DOB;
        char gender;
        public Author(String name, String email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }
        public Author(String name, String email, char gender, params Book[] books)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.books = books;
        }
        public String GetName()
        {
            return name;
        }
        public Book[] GetBook()
        {
            return books;
        }

        public void SetBooks(params Book[] book)
        {
            books = new Book[book.Length];
            for (int i = 0; i < book.Length; i++)
            {
                try
                {
                    this.books[i] = book[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
        }

        public Date GetDOB()
        {
            return DOB;
        }
        public void SetDOB(Date date)
        {
            this.DOB = date;
        }
        public String GetEmail()
        {
            return email;
        }
        public void SetEmail(String email)
        {
            this.email = email;
        }
        public char GetGender()
        {
            return gender;
        }
        public void SetGender(char gender)
        {
            this.gender = gender;
        }
        public override String ToString()
        {
            int age = 2017 - DOB.GetYear();
            String sex = "";
            if (gender == 'm')
            {
                sex = "male";
            }
            else
            {
                sex = "female";
            }

            String verb = "";
            if (gender == 'm')
            {
                verb = "his";
            }
            else
            {
                verb = "her";
            }

            String check = "";
            for (int i = 0; i < books.Length; i++)
            {
                check = check + books[i].GetName();
                if (!(i == books.Length - 1))
                {
                    check = check + " , ";
                }
            }
            return ("  Author " + name + " is " + age + " year old " + sex + " writer " + Environment.NewLine + " born on " + DOB + " , " + verb + " email address is " + email + Environment.NewLine + "   and " + name + " has wrote " + check);
        }
        public String GetBookNames()
        {
            return name;
        }
    }
}
