using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerManager
    {
        IUserValidation _userValidation;
        public GamerManager(IUserValidation userValidation) 
        {
           _userValidation = userValidation;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Olundu.");
            }
            else 
            {
                Console.WriteLine("Doğrulama başarısız.,Kayıt başarısız.");

            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }
    }
}
