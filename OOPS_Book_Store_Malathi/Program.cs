using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Book_Store_Malathi
{
    class Program
    {
        Book[] bookslist = new Book[20];
        Author[] authorslist = new Author[6];
        User userdetails = new User();

        static void Main(string[] args)
        {
            Program selection = new Program();
            selection.FillData();
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("WELCOME TO THE OOPS BOOK STORE . . . . . . . . . !" + Environment.NewLine);
                Console.Write(Environment.NewLine);

                Console.ForegroundColor = ConsoleColor.Cyan;

                int input = 0;
                Console.WriteLine("Select the appropriate numbers from 1 to 4 option and press enter:");
                Console.Write(Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Select option 1 and press enter to see list of Authors");
                Console.WriteLine("Select option 2 and press enter to see list of Books");
                Console.WriteLine("Select option 3 and press enter to add book to your Shopping Cart ");
                Console.WriteLine("Select option 4 and press enter to add Authors to your favorite list ");

                bool flag = false;
                int i = 0;
                while (flag == false)
                {

                    if (i < 5)
                    {
                        input = int.Parse(Console.ReadLine());
                        if (input == 1 || input == 2 || input == 3 || input == 4)
                        {
                            flag = true;
                            switch (input)
                            {
                                case 1:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("List of Authors . . . . . . . ");
                                        for (int j = 0; j < selection.authorslist.Length; j++)
                                        {
                                            String authorselect = selection.authorslist[j].GetName();
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("  " + (j + 1) + "  " + authorselect);

                                        }
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Select Authors in the above list from 1 to " + selection.authorslist.Length);
                                        Console.WriteLine("Choose appropriate number and press enter to select the Author");
                                    again3:
                                        int authorcount = int.Parse(Console.ReadLine());
                                        if (authorcount >= 1 && authorcount <= selection.authorslist.Length)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Yellow;

                                            Console.WriteLine(selection.authorslist[authorcount - 1].ToString());
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.White;
                                            if (!selection.userdetails.favoriteAuthors.Contains(selection.authorslist[authorcount - 1]))
                                            {
                                            loopcheck:
                                                Console.Write("To add author " + selection.authorslist[authorcount - 1].GetName() + " to your favorite list select y / n.");
                                                Console.WriteLine();
                                                char userinput = char.Parse(Console.ReadLine());

                                                if (userinput == 'y')
                                                {
                                                    selection.addfavauthor(selection, selection.authorslist[authorcount - 1]);
                                                }
                                                else if (userinput == 'n')
                                                { }
                                                else
                                                {
                                                    Console.WriteLine("You have entered the wrong letter! Please enter y/n. ");
                                                    goto loopcheck;
                                                }
                                            }
                                            else
                                            {
                                                Console.Write("Selected Author " + selection.authorslist[authorcount - 1].GetName() + " to add to your favorite list.");
                                                Console.WriteLine();
                                            }


                                            Book[] book = selection.authorslist[authorcount - 1].GetBook();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("List of books written by " + selection.authorslist[authorcount - 1].GetName());
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            for (int booksbyauthor = 0; booksbyauthor < book.Length; booksbyauthor++)
                                            {
                                                Console.WriteLine("  " + (booksbyauthor + 1) + "  " + selection.authorslist[authorcount - 1].GetBook()[booksbyauthor].GetName());
                                            }
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                        again4:
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Select Books in the above list from 1 to " + book.Length);

                                            Console.WriteLine("Choose appropriate number and press enter to select the Book.  ");
                                            int bookinput = int.Parse(Console.ReadLine());
                                            if (bookinput >= 1 && bookinput <= book.Length)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("   " + selection.authorslist[authorcount - 1].GetBook()[bookinput - 1]);
                                                Console.ForegroundColor = ConsoleColor.White;



                                                if (!selection.userdetails.ShoppingCart.Contains(selection.authorslist[authorcount - 1].GetBook()[bookinput - 1]))
                                                {
                                                loopcheck3:
                                                    Console.Write("Select book " + (selection.authorslist[authorcount - 1].GetBook()[bookinput - 1]).GetName() + " to add to your shopping cart y / n.  ");
                                                    Console.WriteLine();
                                                    char userinput = char.Parse(Console.ReadLine());

                                                    if (userinput == 'y')
                                                    {
                                                        selection.addtocart(selection, (selection.authorslist[authorcount - 1].GetBook()[bookinput - 1]));
                                                    }
                                                    else if (userinput == 'n')
                                                    { }
                                                    else
                                                    {
                                                        Console.WriteLine("You have entered the wrong letter! Please enter y/n. ");
                                                        goto loopcheck3;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Write("Selected book \"" + (selection.authorslist[authorcount - 1].GetBook()[bookinput - 1]).GetName() + "\" is added to your shopping cart ");
                                                    Console.WriteLine();
                                                }



                                            }
                                            else
                                            {
                                                Console.WriteLine("You have entered the wrong letter! Please enter y/n.");
                                                goto again4;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You have entered the wrong letter! Please enter y/n.");
                                            goto again3;
                                        }


                                        break;
                                    }
                                case 2:
                                    {
                                        for (int k = 0; k < selection.bookslist.Length; k++)
                                        {
                                            String bookselect = selection.bookslist[k].GetName();
                                            Console.WriteLine("  " + (k + 1) + "  " + bookselect);
                                        }
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Select Books in the above list from 1 to  " + selection.bookslist.Length);
                                        Console.WriteLine("Choose appropriate number and press enter to select the Book.  ");
                                    again1:
                                        input = int.Parse(Console.ReadLine());
                                        if (input >= 1 && input <= 20)
                                        {
                                        again:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Select 1 and press enter for details of the book ");
                                            Console.WriteLine("Select 2 and Press enter for details of the Author ");
                                            int input2 = int.Parse(Console.ReadLine());
                                            if (input2 >= 1 && input2 <= 2)
                                            {

                                                switch (input2)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine();
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.WriteLine(selection.bookslist[input - 1].ToString());
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            Console.WriteLine(); Console.WriteLine();
                                                            if (!selection.userdetails.ShoppingCart.Contains(selection.bookslist[input - 1]))
                                                            {
                                                            loopcheck2:
                                                                Console.Write("Select y / n for the Book  " + selection.bookslist[input - 1].GetName() + " to add to your shopping cart.  ");
                                                                Console.WriteLine();
                                                                char userinput = char.Parse(Console.ReadLine());

                                                                if (userinput == 'y')
                                                                {
                                                                    selection.addtocart(selection, selection.bookslist[input - 1]);
                                                                }
                                                                else if (userinput == 'n')
                                                                { }
                                                                else
                                                                {
                                                                    Console.WriteLine("You have entered the wrong letter! Please enter y/n. ");
                                                                    goto loopcheck2;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.Write(" \"" + selection.bookslist[input - 1].GetName() + "\" is in your cart ");
                                                                Console.WriteLine();
                                                            }
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.WriteLine();
                                                            Console.WriteLine("  " + selection.bookslist[input - 1].GetName() + " has " + selection.bookslist[input - 1].GetAuthor().Length + " Author ");
                                                            Console.WriteLine();
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            for (int ik = 0; ik < (selection.bookslist[input - 1].GetAuthor().Length); ik++)
                                                            {
                                                                Author[] authordetail = selection.bookslist[input - 1].GetAuthor();
                                                                Console.WriteLine(authordetail[ik].ToString());
                                                                Console.WriteLine();
                                                                Console.WriteLine();
                                                                Console.ForegroundColor = ConsoleColor.White;
                                                                if (!selection.userdetails.favoriteAuthors.Contains(authordetail[ik]))
                                                                {
                                                                loopcheck1:
                                                                    Console.Write("Select (y / n) for the Author " + authordetail[ik].GetName() + " to add to your favorite list.   ");
                                                                    Console.WriteLine();
                                                                    char userinput = char.Parse(Console.ReadLine());

                                                                    if (userinput == 'y')
                                                                    {
                                                                        selection.addfavauthor(selection, authordetail[ik]);
                                                                    }
                                                                    else if (userinput == 'n')
                                                                    { }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("You have entered the wrong letter! Please enter y/n. ");
                                                                        goto loopcheck1;
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.Write("Selected Author " + authordetail[ik].GetName() + " is in your favorite list of Authors ");
                                                                    Console.WriteLine();
                                                                }
                                                            }


                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            break;
                                                        }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("You have entered the wrong letter! Please enter y/n. ");
                                                goto again;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("You have entered the wrong letter! Please enter y/n. ");
                                            goto again1;
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(selection.userdetails.ToString());
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(selection.userdetails.GetAuthors());
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }

                        }
                        else
                        {
                            Console.WriteLine("You have entered the wrong letter! Please enter y/n. ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your input is wrong! Try again later. ");
                        flag = true;
                    }

                    i++;

                }



                Console.Write("To continue please press any key . . . . . . .  ");
                Console.ReadKey(true);
            }
        }

        public void addtocart(Program param, Book favbook)
        {
            param.userdetails.AddBook(favbook);
        }
        public void addfavauthor(Program param, Author favauth)
        {
            param.userdetails.AddAuthor(favauth);
        }

        public void FillData()
        {


            authorslist[0] = new Author("Arthur Conan Doyle", "contact@arthurconandoyle.com", 'm');
            authorslist[1] = new Author("Rebecca Joan Anderson", "contact@rj-anderson.com", 'f');
            authorslist[2] = new Author("Bella Forrest", "info@bellaforrest.net", 'f');
            authorslist[3] = new Author("Peter James", "info@peterjames.com", 'm');
            authorslist[4] = new Author("Stephen King", "contact@stephenking.com", 'm');
            authorslist[5] = new Author("Chetan Bhagat", "Bhagat@hotmail.com", 'm');


            bookslist[0] = new Book("A Study in Scarlet (Sherlock Holmes #1)", 28.98, 6, authorslist[0]);
            bookslist[1] = new Book("The Adventures of Sherlock Holmes (Sherlock Holmes #3)", 37.65, 8, authorslist[0]);
            bookslist[2] = new Book("The Hound of the Baskervilles (Sherlock Holmes #5)", 25.28, 4, authorslist[0]);
            bookslist[3] = new Book("The Valley of Fear (Sherlock Holmes #7)", 18.98, 2, authorslist[0]);
            bookslist[4] = new Book("A Little Taste of Poison", 22.52, 5, authorslist[1]);
            bookslist[5] = new Book("A Pocket Full of Murder", 17.65, 10, authorslist[1]);
            bookslist[6] = new Book("Quicksilver", 15.78, 4, authorslist[1]);
            bookslist[7] = new Book("Ultraviolet", 18.88, 5, authorslist[1]);
            bookslist[8] = new Book("The Secret of Spellshadow Manor", 13.49, 15, authorslist[2]);
            bookslist[9] = new Book("A Shade of Vampire 47: A Pasage of Threats", 11.69, 8, authorslist[2]);
            bookslist[10] = new Book("The Girl Who Dared to Think", 15.19, 10, authorslist[2]);
            bookslist[11] = new Book("Billionaire", 16.68, 4, authorslist[3]);
            bookslist[12] = new Book("Atom Bomb Angel", 18.28, 12, authorslist[3]);
            bookslist[13] = new Book("Dear Letter Drop", 12.25, 25, authorslist[3]);
            bookslist[14] = new Book("Bag of Bones", 36.65, 20, authorslist[4]);
            bookslist[15] = new Book("Black House", 42.25, 18, authorslist[4]);
            bookslist[16] = new Book("The Dead Zone", 22.48, 15, authorslist[4]);
            bookslist[17] = new Book("The End of Eternity", 15.65, 12, authorslist[5]);
            bookslist[18] = new Book("The Gods Themselves", 12.48, 8, authorslist[5]);
            bookslist[19] = new Book("Earth is Room Enough", 29.86, 20, authorslist[5]);

            authorslist[0].SetDOB(new Date(22, 05, 1859));
            authorslist[1].SetDOB(new Date(05, 09, 1970));
            authorslist[2].SetDOB(new Date(28, 12, 1976));
            authorslist[3].SetDOB(new Date(02, 07, 1970));
            authorslist[4].SetDOB(new Date(31, 10, 1968));
            authorslist[5].SetDOB(new Date(02, 01, 1920));

            authorslist[0].SetBooks(bookslist[0], bookslist[1], bookslist[2], bookslist[3]);
            authorslist[1].SetBooks(bookslist[4], bookslist[5], bookslist[6], bookslist[7]);
            authorslist[2].SetBooks(bookslist[8], bookslist[9], bookslist[10]);
            authorslist[3].SetBooks(bookslist[11], bookslist[12], bookslist[13]);
            authorslist[4].SetBooks(bookslist[14], bookslist[15], bookslist[16]);
            authorslist[5].SetBooks(bookslist[17], bookslist[18], bookslist[19]);

        }
    }
}
