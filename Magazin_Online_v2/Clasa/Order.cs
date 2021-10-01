using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2
{
    public class Order
    {
        private int id;
        private int customer_id;
        private int ammount;
        private string order_address;


        public Order(int id, int customer_id,int ammount, string order_address)
        {
            this.id = id;
            this.ammount = ammount;
            this.order_address = order_address;
            this.customer_id = customer_id;
        }


        public override string ToString()
        {
            string afis = "";
            afis += "ID: " + this.id + "\n";
            afis += "Id cumparator: " + this.customer_id + "\n";
            afis += "Adresa cumparator: " + this.order_address + "\n";
            afis += "Cantitate: " + this.ammount + "\n";
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
        public int Custormer_id
        {
            get => this.customer_id;
            set => this.customer_id = value;
        }
    }
}
