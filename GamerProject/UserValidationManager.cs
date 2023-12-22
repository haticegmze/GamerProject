using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2002 && gamer.FirstName == "gamze" && gamer.LastName == "korucuk" &&
                gamer.IdentityNumber == 12345 && gamer.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Result MyValidate(Gamer gamer)
        {
           Result result = new Result();
            

            if (gamer.BirthYear == 2002 && gamer.FirstName == "gamze" && gamer.LastName == "korucuk" &&
                gamer.IdentityNumber == 12345 && gamer.Id == 1)
            {
               result.ValidaitonResult= true;
                result.ValidationMessage = "ekleme işlemi başarılı";            }
            else
            {
                result.ValidaitonResult= false;
                result.ValidationMessage = " ekleme işlemi başarısız";
            }
            return result;
        }

    }


}

 