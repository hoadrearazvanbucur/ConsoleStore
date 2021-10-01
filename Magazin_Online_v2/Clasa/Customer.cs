using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2
{
    public class Customer
    {
        private int id;
        private string email;
        private string password;
        private string full_name;


        public Customer(int id, string email, string password, string full_name)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.full_name = full_name;
        }


        public override string ToString()
        {
            string afis = "";
            afis += "ID: " + this.id + "\n";
            afis += "Email: " + this.email + "\n";
            afis += "Password: " + this.password + "\n";
            afis += "Nume: " + this.full_name + "\n";
            return afis;
        }

        public override bool Equals(object obj)
        {
            Customer client = obj as Customer;
            return true;
        }


        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string Email
        {
            get => this.email;
            set => this.email = value;
        }
        public string Password
        {
            get => this.password;
            set => this.password = value;
        }
        public string FullName
        {
            get => this.full_name;
            set => this.full_name = value;
        }
    }
}
