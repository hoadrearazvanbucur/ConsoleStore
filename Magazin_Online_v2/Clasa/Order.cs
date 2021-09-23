using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2
{
    public class Order
    {
        private int id;
        private int ammount;
        private string order_address;
        private int order_status;

        public Order(int id, int ammount, string order_address, int order_status)
        {
            this.id = id;
            this.ammount = ammount;
            this.order_address = order_address;
            this.order_status = order_status;
        }

        public override string ToString()
        {
            string afis = "";
            afis += "ID: " + this.id + "\n";
            afis += "Cantitate: " + this.ammount + "\n";
            afis += "Adresa cumparator: " + this.order_address + "\n";
            afis += "Status comanda: " + this.order_status + "\n";
            return afis;
        }

        public override bool Equals(object obj)
        {
            Order comanda = obj as Order;
            return true;
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public int Ammount
        {
            get => this.ammount;
            set => this.ammount = value;
        }
        public string Order_Address
        {
            get => this.order_address;
            set => this.order_address = value;
        }
        public int Order_Status
        {
            get => this.order_status;
            set => this.order_status = value;
        }
    }
}
