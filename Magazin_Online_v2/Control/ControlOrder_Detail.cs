using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Magazin_Online_v2.Clasa
{
    public class ControlOrder_Detail
    {
        private List<Order_Detail> detaliiComanda;

        public ControlOrder_Detail()
        {
            this.detaliiComanda = new List<Order_Detail>();
            load();
        }

        public void load()
        {
            StreamReader fisier = new StreamReader(@"D:\1_PROGRAMARE\C#\Programare Orientate Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\test.txt");
            string linie = fisier.ReadLine();
            while ((linie = fisier.ReadLine()) != null)
            {
                string[] x = linie.Split(',');
                detaliiComanda.Add(new Order_Detail(int.Parse(x[0]),double.Parse( x[1]), int.Parse(x[2])));
                linie = fisier.ReadLine();
            }
        }

        public void save()
        {
            StreamWriter fisier = new StreamWriter(@"D:\1_PROGRAMARE\C#\Programare Orientate Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\test.txt");
            foreach (Order_Detail detaliiComenzi in this.detaliiComanda)
                fisier.WriteLine(detaliiComenzi.Id+", "+detaliiComenzi.Price+","+detaliiComenzi.Quantity);
        }


        public void adaugare(int id, double price, int quantity)
        {
            this.detaliiComanda.Add(new Order_Detail(id, price, quantity));
        }

        public void stergere(int id)
        {
            this.detaliiComanda.RemoveAt(pozId(id));
        }

        public void modificare(int id, double price, int quantity, int idC)
        {
            foreach (Order_Detail detaliiComenzi in this.detaliiComanda)
                if (detaliiComenzi.Id == idC)
                {
                    if (id != 0) detaliiComenzi.Id = id;
                    if (price != 0) detaliiComenzi.Price = price;
                    if (quantity != 0) detaliiComenzi.Quantity = quantity;
                }
        }

        public string afisare()
        {
            string text = "";
            foreach (Order_Detail detaliiComenzi in detaliiComanda)
                text += detaliiComenzi.ToString() + "\n";
            return text;
        }


        public bool verfStergere(int id)
        {
            foreach (Order_Detail detaliiComenzi in detaliiComanda)
                if (detaliiComenzi.Id == id)
                    return true;
            return false;
        }

        public int pozId(int id)
        {
            int k = 0;
            foreach (Order_Detail detaliiComenzi in detaliiComanda)
                if (detaliiComenzi.Id == id) return k;
                else k++;
            return -1;
        }

        public List<Order_Detail> DetaliiComanda
        {
            get => this.detaliiComanda;
            set => this.detaliiComanda = value;
        }
    }
}
