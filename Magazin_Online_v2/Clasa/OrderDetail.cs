using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2
{
    public class OrderDetail
    {
        private int id;
        private int order_id;
        private int product_id;
        private double price;
        private int quantity;

        public OrderDetail(int id, int order_id,int product_id,double price, int quantity)
        {
            this.id = id;
            this.price = price;
            this.quantity = quantity;
            this.order_id = order_id;
            this.product_id = product_id;
        }


        public override string ToString()
        {
            string afis = "";
            afis += "ID: " + this.id + "\n";
            afis += "Comanda ID: " + this.order_id + "\n";
            afis += "Produs ID: " + this.product_id + "\n";
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
        public int Order_id
        {
            get => this.id;
            set => this.id = value;
        }
        public int Product_id
        {
            get => this.product_id;
            set => this.product_id = value;
        }
    }
}
