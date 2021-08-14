using System;

namespace AddressBookUsing_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AddressBook_Using_Ado.Net ");
            AddressBookRepo abrepo = new AddressBookRepo();
            //abrepo.CheckConnection();
            AddressBookModel abmodel = new AddressBookModel();
            AddressBookModel abmodel1 = new AddressBookModel();
            while (true)
            {
                Console.WriteLine("\nEnter Choice  \n1.Add Contact \n2.Edit Contact  \n3.Exit ");
                int choise = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choise)
                    {
                        case 1:
                            //AddressBookModel abmodel = new AddressBookModel();
                            abmodel.First_Name = "Vishal";
                            abmodel.Last_Name = "Vallem";
                            abmodel.Address = "kdkr";
                            abmodel.City = "Ongl";
                            abmodel.State = "andhrapradesh";
                            abmodel.Zip = "523117";
                            abmodel.Phone_Number = "9492407486";
                            abmodel.Email = "vbnreddys@gmail.com";
                            abmodel.BookName = "address002";
                            abmodel.AddressbookType = "family";
                            bool result = abrepo.AddContact(abmodel);

                            if (result)
                                Console.WriteLine("Record added successfully...");
                            else
                                Console.WriteLine("Some problem is there...");
                            Console.ReadKey();
                            break;
                        case 2:
                            // Update recods
                            //AddressBookModel abmodel1 = new AddressBookModel();
                            abmodel1.First_Name = "Balu";
                            abmodel1.Last_Name = "kumar";
                            abmodel1.City = "Nuziveedu";
                            abmodel1.State = "AndhraPradesh";
                            abmodel1.Email = "dk@gmail.com";
                            abmodel1.BookName = "address001";
                            abmodel1.AddressbookType = "office";
                            abrepo.EditContactUsingFirstName(abmodel1);
                            Console.ReadKey();
                            break;

                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter The Valid Choise");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }

            }
        }
    }
}
