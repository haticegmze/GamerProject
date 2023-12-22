using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
   public  interface IUserValidationService // kullanıcı doğrulama işlemini yapıyoruz
    {
        bool Validate(Gamer gamer);
        Result MyValidate(Gamer gamer);
    }
}
