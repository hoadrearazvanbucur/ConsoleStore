using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2
{
    public class Product
    {
        private string categorie;
        private int id;
        private string name;
        private string description;
        private string date;
        private string image;
        private double price;
        private int stock;


        public Product(string categorie,int id,string name,string description,string date,string image,double price,int stock)
        {
            this.categorie = categorie;
            this.id = id;
            this.name = name;
            this.description = description;
            this.date = date;
            this.image = image;
            this.price = price;
            this.stock = stock;
        }


        public override string ToString()
        {
            string afis = "";
            afis += "Categorie: " + this.categorie + "\n";
            afis += "ID: " + this.id + "\n";
            afis += "Nume: " + this.name + "\n";
            afis += "Descriere: " + this.description + "\n";
            afis += "Data creare: " + this.date + "\n";
            afis += "Imagine path: " + this.image + "\n";
            afis += "Pret: " + this.price + "\n";
            afis += "Stoc: " + this.stock + "\n";
            return afis;
        }
        public override bool Equals(object obj)
        {
            Product produs = obj as Product;
            return true;
        }


        public string Categorie
        {
            get => this.categorie;
            set => this.categorie = value;
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
        public string Description
        {
            get => this.description;
            set => this.description = value;
        }
        public string Date
        {
            get => this.date;
            set => this.date = value;
        }
        public string Image
        {
            get => this.image;
            set => this.image = value;
        }
        public double Price
        {
            get => this.price;
            set => this.price = value;
        }   
        public int Stock
        {
            get => this.stock;
            set => this.stock = value;
        }       
    }
}
