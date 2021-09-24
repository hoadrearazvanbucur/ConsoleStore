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
        private double price;
        private int stock;

        public Product(string categorie,int id, string name, string description, double price,  int stock)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.description = description;
            this.stock = stock;
            this.categorie = categorie;
            
            //Console.WriteLine(this.categorie);
            //if (this.categorie == "mobila")
            //{
            //    Console.WriteLine(ToString());
            //    Mobila m = this as Mobila;
            //    Console.WriteLine(ToString());
            //}
        }

        public override string ToString()
        {
            string afis = "";
            afis += "Categorie: " + this.categorie + "\n";
            afis += "ID: " + this.id + "\n";
            afis += "Nume: " + this.name + "\n";
            afis += "Descriere: " + this.description + "\n";
            afis += "Pret: " + this.price + "\n";
            afis += "Stoc: " + this.stock + "\n";
            return afis;
        }

        public override bool Equals(object obj)
        {
            Product produs = obj as Product;
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
        public double Price
        {
            get => this.price;
            set => this.price = value;
        }
        public string Description
        {
            get => this.description;
            set => this.description = value;
        }
        public int Stock
        {
            get => this.stock;
            set => this.stock = value;
        }
        public string Categorie
        {
            get => this.categorie;
            set => this.categorie = value;
        }
    }
}
