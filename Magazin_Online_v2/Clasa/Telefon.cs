using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2
{
    public class Telefon : Product
    {
        private string numeTelefon;
        private int dimensiuneEcran;
        private int stocare;
        private int capacitateBaterie;

        public Telefon(string categorie, int id, string name, string description, string date, string image, double price, int stock, string numeTelefon, int dimensiuneEcran,int stocare, int capacitateBaterie) : base(categorie,id,name,description,date,image,price,stock)
        {
            this.numeTelefon = numeTelefon;
            this.capacitateBaterie = capacitateBaterie;
            this.stocare = stocare;
            this.dimensiuneEcran = dimensiuneEcran;
        }

        public Telefon(string []text) : base(text[0], int.Parse(text[1]), text[2], text[3], text[4],text[5],double.Parse(text[6]), int.Parse(text[7]))
        {
            this.numeTelefon= text[8];
            this.dimensiuneEcran= int.Parse(text[9]);
            this.stocare= int.Parse(text[10]);
            this.capacitateBaterie= int.Parse(text[11]);
        }


        public override string ToString()
        {
            string afis = "";
            afis += "Nume Telefon: " + this.numeTelefon + "\n";
            afis += "Dimensiune Ecran: " + this.dimensiuneEcran + "\n";
            afis += "Stocare: " + this.stocare + "\n";
            afis += "Capacitate Baterie: " + this.capacitateBaterie + "\n";
            return afis;
        }
        public override bool Equals(object obj)
        {
            Telefon telefon = obj as Telefon;
            return true;
        }


        public string NumeTelefon
        {
            get => this.numeTelefon;
            set => this.numeTelefon = value;
        }
        public int DimensiuneEcran
        {
            get => this.dimensiuneEcran;
            set => this.dimensiuneEcran = value;
        }
        public int Stocare
        {
            get => this.stocare;
            set => this.stocare = value;
        }
        public int CapacitateBaterie
        {
            get => this.capacitateBaterie;
            set => this.capacitateBaterie = value;
        }
    }
}
