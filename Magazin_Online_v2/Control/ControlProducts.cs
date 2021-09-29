﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Magazin_Online_v2
{
    public class ControlProducts
    {

        List<Product> products;

        public ControlProducts()
        {
            products = new List<Product>();
            load();
        }

        public void load()
        {
            StreamReader fisier = new StreamReader(@"D:\1_PROGRAMARE\C#\Programare_Orientate_Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\produseFisier.txt");
            string linie = "";
            while((linie=fisier.ReadLine())!=null){
                string[] linieSplit = linie.Split(',');
                if (linieSplit[0] == "mobila")
                    products.Add(new Mobila(linieSplit));
                else
                    if (linieSplit[0] == "telefon")
                        products.Add(new Telefon(linieSplit));
            }
        }

        private void save()
        {
            string path = @"D:\1_PROGRAMARE\C#\Programare_Orientate_Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\produseFisier.txt";
            StreamWriter fisier = new StreamWriter(path);
            foreach(Product produse in products){
                string text = "";
                if (produse.Categorie == "mobila"){
                    Mobila m = produse as Mobila;
                    text += m.Categorie +" " + m.Id + " " + m.Name + " " + m.Description + " " + m.Date + " " + m.Image + " " + m.Price + " " + m.Stock;
                }
                else
                    if (produse.Categorie == "telefon"){
                        Telefon t = produse as Telefon;
                        text += t.Categorie + " " + t.Id + " " + t.Name + " " + t.Description + " " + t.Date + " " + t.Image + " " + t.Price + " " + t.Stock;
                    }    
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
                    afis += m.ToString();
                }
                else
                    if(produs is Telefon)
                    {
                       Telefon t = produs as Telefon;
                        afis += "Categorie: " + t.Categorie + "\n";
                        afis += "ID: " + t.Id + "\n";
                        afis += "Nume: " + t.Name + "\n";
                        afis += "Descriere: " + t.Description + "\n";
                        afis += "Pret: " + t.Price + "\n";
                        afis += "Stoc: " + t.Stock + "\n";
                        afis += t.ToString();
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

        public int nextId()
        {
            if (this.produse.Count > 0)
            {
                return this.produse[this.produse.Count - 1].Id + 1;
            }
            else
            {
                return 1;
            }
        }

    }
}
