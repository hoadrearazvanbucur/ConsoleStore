using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Magazin_Online_v2.Clasa
{
    public class ControlCustomer
    {
        List<Customer> clienti;

        public ControlCustomer()
        {
            clienti = new List<Customer>();
            load();
        }


        public void load()
        {
            StreamReader fisier = new StreamReader(@"D:\1_PROGRAMARE\C#\Programare_Orientate_Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\customerFisier.txt");
            string linie = "";
            while ((linie = fisier.ReadLine()) != null)
            {
                string[] linieSplit = linie.Split(',');
                clienti.Add(new Customer(int.Parse(linieSplit[0]),linieSplit[1], linieSplit[2], linieSplit[3]));
            }
            fisier.Close();
        }

        private void save()
        {
            string path = @"D:\1_PROGRAMARE\C#\Programare_Orientate_Obiect\Polimorfism\Magazin_Online_v2\Magazin_Online_v2\Fisier\customerFisier.txt";
            StreamWriter fisier = new StreamWriter(path);
            foreach (Customer customers in clienti)
            {
                string text = "";
                text += customers.Id + "," + customers.Email + "," + customers.Password + "," + customers.FullName;
                fisier.WriteLine(text);
            }
            fisier.Close();
        }


        public string afisare()
        {
            string afis = "";
            foreach (Customer customers in clienti)
            {
                afis += "ID: " + customers.Id + "\n";
                afis += "Email: " + customers.Email + "\n";
                afis += "Password: " + customers.Password + "\n";
                afis += "Numele full: " + customers.FullName + "\n";
            }
            return afis;
        }
        public void adaugare(Customer customer)
        {
            this.clienti.Add(customer);
            save();
        }
        public void stergere(int id)
        {
            clienti.RemoveAt(pozId(id));
            save();
        }
        public void modificare(Customer customers, int id)
        {
            if (clienti[pozId(id)].Id != -1) clienti[pozId(id)].Id = customers.Id;
            if (clienti[pozId(id)].Email != "-1") clienti[pozId(id)].Email = customers.Email;
            if (clienti[pozId(id)].Password != "-1") clienti[pozId(id)].Password = customers.Password;
            if (clienti[pozId(id)].FullName != "-1") clienti[pozId(id)].FullName = customers.FullName;
        }


        public bool verfStergere(int id)
        {
            foreach (Customer customers in clienti)
                if (customers.Id == id)
                    return true;
            return false;
        }
        public int pozId(int id)
        {
            int k = 0;
            foreach (Customer customers in clienti)
                if (customers.Id == id) return k;
                else k++;
            return -1;
        }



        public int nextId()
        {
            if (this.clienti.Count > 0)
            {
                return this.clienti[this.clienti.Count - 1].Id + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}
