using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class UserController
    {
        User _user = new User();

        public void Add(User user)
        {
            if (String.IsNullOrWhiteSpace(user.Name))
            {
                throw new Exception("Erro, o nome não pode ser vazio.");
            }
            else 
            {
                _user.Add(user);
            }
        }
    }
}
