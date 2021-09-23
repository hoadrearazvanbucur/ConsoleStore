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
            StreamReader fisier = new StreamReader(@"D:\1_PROGRAMARE\C#\Programare Orientate Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\test.txt");
            string linie = fisier.ReadLine();
            while ((linie = fisier.ReadLine()) != null)
            {
                string[] x = linie.Split(',');
                comenzi.Add(new Order(int.Parse(x[0]),int.Parse( x[1]), x[2], int.Parse(x[3])));
                linie = fisier.ReadLine();
            }
            fisier.Close();
        }

        public void save()
        {
            StreamWriter fisier = new StreamWriter(@"D:\1_PROGRAMARE\C#\Programare Orientate Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\test.txt");
            foreach (Order orders in this.comenzi)
                fisier.WriteLine(orders.Id+", "+orders.Ammount+","+orders.Order_Address+","+orders.Order_Status);
        }

        public void adaugare(int id, int ammount, string order_address, int order_status)
        {
            this.comenzi.Add(new Order(id, ammount, order_address, order_status));
        }

        public void stergere(int id)
        {
            this.comenzi.RemoveAt(pozId(id));
        }

        public void modificare(int id, int ammount, string order_address, int order_status, int idC)
        {
            foreach (Order orders in this.comenzi)
                if (orders.Id == idC)
                {
                    if (id != 0) orders.Id = id;
                    if (ammount != -1) orders.Ammount = ammount;
                    if (order_address != "") orders.Order_Address = order_address;
                    if (order_status != -1) orders.Order_Status = order_status;
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
    }
}
