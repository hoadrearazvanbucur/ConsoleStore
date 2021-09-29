using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2
{
    public class Mobila : Product
    {
        private string numeMobila;
        private string culoare; 
        private int lungime;
        private int latime;
        private int inaltime;

        public Mobila(int id, string name, string description, string date, string image, double price, int stock, string numeMobila,string culoare,int lungime,int latime,int inaltime) : base("mobila",id,name,description,date,image,price,stock)
        {
            this.numeMobila = numeMobila;
            this.culoare = culoare;
            this.lungime = lungime;
            this.latime = latime;
            this.inaltime = inaltime;
        }

        public Mobila(string[] text):base("mobila",int.Parse(text[1]),text[2],text[3],text[4],text[5],double.Parse(text[6]),int.Parse(text[7]))
        {
            this.numeMobila = text[8];
            this.culoare= text[9];
            this.lungime= int.Parse(text[10]);
            this.latime= int.Parse(text[11]);
            this.inaltime = int.Parse(text[12]);
        }

        public override string ToString()
        {
            string afis = "";
            afis += "Nume mobila: " + this.NumeMobila + "\n";
            afis += "Culoare: " + this.Culoare + "\n";
            afis += "Lungime: " + this.Lungime + "\n";
            afis += "Latime: " + this.Latime + "\n";
            afis += "Inaltime: " + this.Inaltime + "\n\n\n";
            return afis;
        }

        public override bool Equals(object obj)
        {
            Mobila mobila = obj as Mobila;
            return true;
        }

        public string NumeMobila
        {
            get => this.numeMobila;
            set => this.numeMobila = value;
        }
        public string Culoare
        {
            get => this.culoare;
            set => this.culoare = value;
        }
        public int Latime
        {
            get => this.latime;
            set => this.latime = value;
        }
        public int Lungime
        {
            get => this.lungime;
            set => this.lungime = value;
        }
        public int Inaltime
        {
            get => this.inaltime;
            set => this.inaltime = value;
        }
    }
}
