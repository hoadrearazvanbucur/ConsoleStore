using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2
{
    public class OrderDetail
    {
        private int id;
        private double price;
        private int quantity;

        public OrderDetail(int id, double price, int quantity)
        {
            this.id = id;
            this.price = price;
            this.quantity = quantity;
        }

        public override string ToString()
        {
            string afis = "";
            afis += "ID: " + this.id + "\n";
            afis += "Pret: " + this.price + "\n";
            afis += "Cantitate: " + this.quantity + "\n";
            return afis;
        }

        public override bool Equals(object obj)
        {
            OrderDetail detaliiComanda = obj as OrderDetail;
            return true;
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public double Price
        {
            get => this.price;
            set => this.price = value;
        }
        public int Quantity
        {
            get => this.quantity;
            set => this.quantity = value;
        }
    }
}
