using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager= new GamerManager(new UserValidationManager());
            // gamermanager'ı çalıştırabilmek için bir doğrulama servisine ihtiyaç olduğundan new uservalidationmanageri yazarak test ediyoruz.
            gamerManager.Add
                
            (new Gamer
            {
                Id = 1,
                BirthYear = 2002,
                FirstName = "gamze",
                LastName = "korucuk",
                IdentityNumber = 12345
            });
            

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
