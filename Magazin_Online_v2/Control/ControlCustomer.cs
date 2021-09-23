using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Magazin_Online_v2.Clasa
{
    public class ControlCustomer
    {
        private List<Customer> clienti;

        public ControlCustomer()
        {
            this.clienti = new List<Customer>();
            load();
        }

        public void load()
        {
            StreamReader fisier = new StreamReader(@"D:\1_PROGRAMARE\C#\Programare Orientate Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\test.txt");
            string linie;
            while ((linie = fisier.ReadLine())!=null)
            {
                string[] x = linie.Split(',');
                clienti.Add(new Customer(int.Parse(x[0]), x[1], x[2], x[3]));
                linie = fisier.ReadLine();
            }
        }

        public void save()
        {
            StreamWriter fisier = new StreamWriter(@"D:\1_PROGRAMARE\C#\Programare Orientate Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\test.txt");
            foreach (Customer customers in this.clienti)
                fisier.WriteLine(customers.Id+","+customers.Name+","+customers.Password+","+customers.Address);
            fisier.Close();
        }

        public void adaugare(int id, string name, string password, string address)
        {
            this.clienti.Add(new Customer(id, name, password, address));
        }

        public void stergere(int id)
        {
            this.clienti.RemoveAt(pozId(id));
        }

        public void modificare(int id, string name, string password, string address, int idC)
        {
            foreach (Customer customers in this.clienti)
                if (customers.Id == idC)
                {
                    if (id != 0) customers.Id = id;
                    if (name.ToLower() != "") customers.Name = name;
                    if (password != "") customers.Password = password;
                    if (address.ToLower() != "") customers.Address = address;
                }
        }

        public string afisare()
        {
            string text = "";
            foreach (Customer customers in clienti)
                text += customers.ToString() + "\n";
            return text;
        }

        public int pozId(int id)
        {
            int k = 0;
            foreach (Customer customers in this.clienti)
            {
                if (customers.Id == id)
                    return k;
                k++;
            }
            return -1;
        }

        public List<Customer> Clienti
        {
            get => this.clienti;
            set => this.clienti = value;
        }
    }
}
