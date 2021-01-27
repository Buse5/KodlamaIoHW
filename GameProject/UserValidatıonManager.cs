using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidatıonManager : IUserValidation
    {
    

        bool IUserValidation.Validate(Gamer gamer)
        {
            if (gamer.BirdhYear == 1999 && gamer.FirstName=="Buse")
            {
                return true;
            }
            else
            { 
                return false;            
            }
        }
    }
}
