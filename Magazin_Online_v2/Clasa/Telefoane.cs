using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2
{
    public class Telefoane : Product
    {
        private string numeTelefon;
        private int dimensiuneEcran;
        private int stocare;
        private int capacitateBaterie;

        public Telefoane(int id, string name, string description, double price, int stock, string numeTelefon, int dimensiuneEcran,int stocare, int capacitateBaterie) : base("telefon",id,name, description,price, stock)
        {
            this.numeTelefon = numeTelefon;
            this.capacitateBaterie = capacitateBaterie;
            this.stocare = stocare;
            this.dimensiuneEcran = dimensiuneEcran;
        }

        public Telefoane(string []text) : base("mobila", int.Parse(text[1]), text[2], text[3], double.Parse(text[4]), int.Parse(text[5]))
        {
            this.numeTelefon= text[6];
            this.dimensiuneEcran= int.Parse(text[7]);
            this.stocare= int.Parse(text[8]);
            this.capacitateBaterie= int.Parse(text[9]);
        }


        public override string ToString()
        {
            string afis = "";
            afis += "Nume Telefon: " + this.numeTelefon + "\n";
            afis += "Dimensiune Ecran: " + this.dimensiuneEcran + "\n";
            afis += "Stocare: " + this.stocare + "\n";
            afis += "Capacitate Baterie: " + this.capacitateBaterie + "\n\n\n";
            return afis;
        }

        public override bool Equals(object obj)
        {
            Telefoane telefon = obj as Telefoane;
            return true;
        }

        public string NumeTelefon
        {
            get => this.numeTelefon;
            set => this.numeTelefon = value;
        }
        public int CapacitateBaterie
        {
            get => this.capacitateBaterie;
            set => this.capacitateBaterie = value;
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
    }
}
