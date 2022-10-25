using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    public class Users
    {

        public string name;
        public string email;
        public string password;
        public byte age;
        public Admin administrator = new Admin();

        public void setAll(string _name, string _email, string _pass, byte _age)
        {
            name = _name;
            email = _email;
            password = _pass;
            age = _age;
        }

        public void setEmail(string _email)
        {
            email = _email;
        }

        public void setAdmin(string _role)
        {
            administrator.role = _role;
        }

        public void printAll()
        {
            Console.WriteLine($"Имя: {name}, email: {email}, пароль: {password}, возраст: {age}");
        }

    }
}
