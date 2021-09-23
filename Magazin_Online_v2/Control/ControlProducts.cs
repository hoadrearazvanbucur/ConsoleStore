using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Magazin_Online_v2
{
    public class ControlProducts
    {

        List<Product> produse;

        public ControlProducts()
        {
            produse = new List<Product>();
            load();
        }

        private void load()
        {
            string path = @"D:\1_PROGRAMARE\C#\Programare Orientate Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\produseFisier.txt";
            StreamReader fisier = new StreamReader(path);
            string linie = "";
            while((linie=fisier.ReadLine())!=null){
                string[] produs = linie.Split(',');
                if (produs[0] == "mobila")
                    produse.Add(new Mobila(produs));
                else
                    if (produs[0] == "telefon")
                        produse.Add(new Telefoane(produs));
            }
        }

        private void save()
        {
            string path = @"D:\1_PROGRAMARE\C#\Programare Orientate Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\produseFisier.txt";
            StreamWriter fisier = new StreamWriter(path);
            foreach(Product produs in produse){
                string text = "";
                if (produs.Categorie == "mobila")
                    text = produs.Categorie + "," + produs.Id + "," + produs.Name + "," + produs.Description + "," + produs.Price + "," + produs.Stock + ",";
                else
                    if (produs.Categorie == "telefon")
                    text = produs.Categorie + "," + produs.Id + "," + produs.Name + "," + produs.Description + "," + produs.Price + "," + produs.Stock;
                fisier.WriteLine(text);
            }
        }

        public string afisare()
        {
            string afis = "";
            foreach (Product produs in produse)
            {     
                if (produs is Mobila)
                {
                    Mobila m = produs as Mobila;
                    afis += "Categorie: " + m.Categorie + "\n";
                    afis += "ID: " + m.Id + "\n";
                    afis += "Nume: " + m.Name + "\n";
                    afis += "Descriere: " + m.Description + "\n";
                    afis += "Pret: " + m.Price + "\n";
                    afis += "Stoc: " + m.Stock + "\n";
                    afis += m;
                }
                else
                    if(produs is Telefoane)
                    {
                        Telefoane t = produs as Telefoane;
                    afis += "Categorie: " + t.Categorie + "\n";
                    afis += "ID: " + t.Id + "\n";
                    afis += "Nume: " + t.Name + "\n";
                    afis += "Descriere: " + t.Description + "\n";
                    afis += "Pret: " + t.Price + "\n";
                    afis += "Stoc: " + t.Stock + "\n";
                    afis += t;
                    }

            }
            return afis;
        }

        //Adaugare

        public void adaugare(Product produs)
        {
            this.produse.Add(produs);
        }


        //Stergere

        public void stergere(int id)
        {
            if (verfStergere(id) == true && pozId(id) != -1)
                produse.RemoveAt(pozId(id));
        }

        public bool verfStergere(int id)
        {
            foreach (Product produs in produse)
                if(produs.Id == id)
                    return true;
            return false;
        }

        public int pozId(int id)
        {
            int k = 0;
            foreach (Product produs in produse)
                if (produs.Id == id)     return k;
                else    k++;
            return -1;
        }

       //Modificare

        public void modificare(Product produs,int id)
        {
            if(verfStergere(id))
            {
                if (produs.Categorie != "-1")
                    produse[pozId(id)].Categorie = produs.Categorie;

                if (produs.Id != -1)
                    produse[pozId(id)].Id = produs.Id;

                if (produs.Name != "-1")
                    produse[pozId(id)].Name = produs.Name;

                if (produs.Price != -1)
                    produse[pozId(id)].Price = produs.Price;

                if (produs.Description != "-1")
                    produse[pozId(id)].Description = produs.Description;

                if (produs.Stock != -1)
                    produse[pozId(id)].Stock = produs.Stock;
            }
        }

    }
}
