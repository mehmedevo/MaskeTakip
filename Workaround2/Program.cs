
using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;


namespace Workaround
{
    public class Program
    {
        private IApplicantService _applicantService;
        static void Main(string[] args)
        {

            SelamVer();
            
            Person person1 = new Person();
            person1.FirstName = "MEHMET OSMAN";
            person1.LastName = "ŞENTÜRK";
            person1.DateOfBirthYear = 1995;
            person1.NationalIdentity = 123;

            

            PttManager pttmanager = new(new PersonManager());
            pttmanager.GiveMask(person1);

            
            

        }

        static void SelamVer(string isim = "isimsiz")
        {

            Console.WriteLine("Merhaba" + " " + isim);
        }




    }
}