using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidation
    {
        //Kullanıcı doğrulama Interfacesi
        bool Validate(Gamer gamer);
    }
}
