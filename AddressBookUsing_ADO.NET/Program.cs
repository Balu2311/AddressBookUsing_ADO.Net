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
            abmodel.First_Name = "Balanagireddy";
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
        }
    }
}
