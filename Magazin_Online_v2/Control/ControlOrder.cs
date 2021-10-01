using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Magazin_Online_v2.Clasa
{
    public class ControlOrder
    {
        private List<Order> comenzi;

        public ControlOrder()
        {
            this.comenzi = new List<Order>();
            load();
        }

        public void load()
        {
            StreamReader fisier = new StreamReader(@"D:\1_PROGRAMARE\C#\Programare_Orientate_Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\orderFisier.txt");
            string linie = fisier.ReadLine();
            while ((linie = fisier.ReadLine()) != null)
            {
                string[] x = linie.Split(',');
                comenzi.Add(new Order(int.Parse(x[0]),int.Parse( x[1]),int.Parse( x[2]), x[3]));
                linie = fisier.ReadLine();
            }
            fisier.Close();
        }

        public void save()
        {
            StreamWriter fisier = new StreamWriter(@"D:\1_PROGRAMARE\C#\Programare_Orientate_Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\orderFisier.txt");
            foreach (Order orders in this.comenzi)
                fisier.WriteLine(orders.Id+", "+orders.Ammount+","+orders.Order_Address+","+orders.Custormer_id);
        }

        public void adaugare(int id, int ammount, string order_address, int customer_id)
        {
            this.comenzi.Add(new Order(id,customer_id,ammount,order_address));
        }

        public void stergere(int id)
        {
            this.comenzi.RemoveAt(pozId(id));
        }

        public void modificare(int id, int ammount, string order_address, int customer_id, int idC)
        {
            foreach (Order orders in this.comenzi)
                if (orders.Id == idC)
                {
                    if (id != 0) orders.Id = id;
                    if (ammount != -1) orders.Ammount = ammount;
                    if (order_address != "") orders.Order_Address = order_address;
                    if (customer_id != -1) orders.Custormer_id = customer_id;
                }
        }

        public string afisare()
        {
            string text = "";
            foreach (Order orders in comenzi)
                text += orders.ToString() + "\n";
            return text;
        }

        public int pozId(int id)
        {
            int k = 0;
            foreach (Order orders in this.comenzi)
            {
                if (orders.Id == id)
                    return k;
                k++;
            }
            return -1;
        }

        public List<Order> Comenzi
        {
            get => this.comenzi;
            set => this.comenzi = value;
        }


        public  int nextId()
        {
            if (this.comenzi.Count > 0)
            {
                return this.comenzi[this.comenzi.Count - 1].Id + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}
