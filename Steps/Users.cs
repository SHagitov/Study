using System;

namespace Steps
{
    public class Users
    {

        private string name;
        private string email;
        private string password;
        private sbyte age;

        public sbyte Age
        {
            get
            {
                age++;
                return age;
            }
            set => age = value < 0 ? (sbyte)1 : value;
        }

        private readonly Admin administrator = new Admin();

        public static int count;

        public Users(string name, string email, string password, sbyte age)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            Age = age;

            printAll();

            count++;
        }

        public Users(string _name, string _email, string _pass, sbyte _age, string role)
        {
            name = _name;
            email = _email;
            password = _pass;
            Age = _age;
            Admin.role = role;

            printAll();
            count++;
        }

        public Users()
        {
            count++;
        }

        public void setAll(string _name, string _email, string _pass, sbyte _age)
        {
            name = _name;
            email = _email;
            password = _pass;
            Age = _age;
        }

        public void setEmail(string _email)
        {
            email = _email;
        }

        public void setAdmin(string _role)
        {
            Admin.role = _role;
        }

        public void printAll()
        {
            Console.WriteLine($"Имя: {name}, email: {email}, пароль: {password}, возраст: {Age}");
        }

        public string getAdminRole()
        {
            return Admin.role;
        }

        public static void print()
        {
            Console.WriteLine($"Количество элементов: {count}");
        }

    }
}
