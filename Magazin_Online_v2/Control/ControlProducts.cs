using System;
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
            fisier.Close();
        }

        private void save()
        {
            string path = @"D:\1_PROGRAMARE\C#\Programare_Orientate_Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\produseFisier.txt";
            StreamWriter fisier = new StreamWriter(path);
            foreach(Product produse in products){
                string text = "";
                if (produse.Categorie == "mobila"){
                    Mobila m = produse as Mobila;
                    text += m.Categorie +" " + m.Id + " " + m.Name + " " + m.Description + " " + m.Date + " " + m.Image + " " + m.Price + " " + m.Stock + " " + m.NumeMobila + " " + m.Culoare + " " + m.Lungime + " " + m.Latime + " " + m.Inaltime;
                }
                else
                    if (produse.Categorie == "telefon"){
                        Telefon t = produse as Telefon;
                        text += t.Categorie + " " + t.Id + " " + t.Name + " " + t.Description + " " + t.Date + " " + t.Image + " " + t.Price + " " + t.Stock + " " + t.NumeTelefon + " " + t.DimensiuneEcran + " " + t.Stocare + " " + t. CapacitateBaterie;
                    }    
                fisier.WriteLine(text);
            }
            fisier.Close();
        }



        public string afisare()
        {
            string afis = "";
            foreach (Product produs in products)
            {
                afis += "Categorie: " + produs.Categorie + "\n";
                afis += "ID: " + produs.Id + "\n";
                afis += "Nume: " + produs.Name + "\n";
                afis += "Descriere: " + produs.Description + "\n";
                afis += "Data: " + produs.Date + "\n";
                afis += "Imagine: " + produs.Image + "\n";
                afis += "Pret: " + produs.Price + "\n";
                afis += "Stoc: " + produs.Stock + "\n";
                if (produs is Mobila){
                    Mobila m = produs as Mobila;
                    afis += m.ToString();
                }
                else
                    if(produs is Telefon){
                       Telefon t = produs as Telefon;
                        afis += t.ToString();
                    }
            }
            return afis;
        }

        public void adaugare(Product produs)
        {
            this.products.Add(produs);
            save();
        }

        public void stergere(int id)
        {
            products.RemoveAt(pozId(id));
            save();
        }

        public void modificare(Product produs, int id)
        {
            if (products[pozId(id)].Categorie != "-1") products[pozId(id)].Categorie = produs.Categorie;
            if (products[pozId(id)].Id != -1) products[pozId(id)].Id = produs.Id;
            if (products[pozId(id)].Name != "-1") products[pozId(id)].Name = produs.Name;
            if (products[pozId(id)].Description != "-1") products[pozId(id)].Description = produs.Description;
            if (products[pozId(id)].Date != "-1") products[pozId(id)].Date = produs.Date;
            if (products[pozId(id)].Image != "-1") products[pozId(id)].Image = produs.Image;
            if (products[pozId(id)].Price != -1) products[pozId(id)].Price = produs.Price;
            if (products[pozId(id)].Stock != -1) products[pozId(id)].Stock = produs.Stock;
            if (produs is Mobila){
                Mobila m = produs as Mobila;
                Mobila m1 = products[pozId(id)] as Mobila;
                if (m1.NumeMobila != "-1") m1.NumeMobila = m.NumeMobila;
                if (m1.Culoare != "-1") m1.Culoare = m.Culoare;
                if (m1.Lungime != -1) m1.Lungime = m.Lungime;
                if (m1.Latime != -1) m1.Latime = m.Latime;
                if (m1.Inaltime != -1) m1.Inaltime = m.Inaltime;       
            }
            else
                if(produs is Telefon){
                    Telefon t = produs as Telefon;
                    Telefon t1 = products[pozId(id)] as Telefon;
                    if (t1.NumeTelefon != "-1") t1.NumeTelefon = t.NumeTelefon;
                    if (t1.DimensiuneEcran != -1) t1.DimensiuneEcran = t.DimensiuneEcran;
                    if (t1.Stocare != -1) t1.Stocare = t.Stocare;
                    if (t1.CapacitateBaterie != -1) t1.CapacitateBaterie = t.CapacitateBaterie;
                }
        }



        public bool verfStergere(int id)
        {
            foreach (Product produs in products)
                if(produs.Id == id)
                    return true;
            return false;
        }

        public int pozId(int id)
        {
            int k = 0;
            foreach (Product produs in products)
                if (produs.Id == id)     return k;
                else    k++;
            return -1;
        }




        public int nextId()
        {
            if (this.products.Count > 0)
            {
                return this.products[this.products.Count - 1].Id + 1;
            }
            else
            {
                return 1;
            }
        }


    }
}
