using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2
{
    public class Customer
    {
        private int id;
        private string name;
        private string password;
        private string address;

        public Customer(int id, string name, string password, string address)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.address = address;
        }

        public override string ToString()
        {
            string afis = "";
            afis += "ID: " + this.id + "\n";
            afis += "Name: " + this.name + "\n";
            afis += "Password: " + this.password + "\n";
            afis += "Address: " + this.address + "\n";
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
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public string Password
        {
            get => this.password;
            set => this.password = value;
        }
        public string Address
        {
            get => this.address;
            set => this.address = value;
        }
    }
}
