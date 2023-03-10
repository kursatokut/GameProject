using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "Kürşat" &&
             gamer.LastName == "Okut" && gamer.IdentityNumber == 123456789)
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