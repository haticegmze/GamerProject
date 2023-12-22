using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    public class GamerManager : IGamerService  // IGamerService'implemente etmek için manager sınıfını oluşturduk.
    {
       IUserValidationService _userValidationService;
        //IUserValidationu zorunlu kıldık kullanması için.
        public GamerManager(IUserValidationService userValidationService) // gamer manager'ın içinde doğrulama servisini kullanıcam demektir.
            
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {

            Result MyResult = _userValidationService.MyValidate(gamer);

            Console.WriteLine(MyResult.ValidationMessage);
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("KAYIT SİLİNDİ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("KAYIT GÜNCELLENDİ");
        }
    }
}
