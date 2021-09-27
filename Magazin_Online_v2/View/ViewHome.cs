using Magazin_Online_v2.Clasa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2.View
{
    public class ViewHome
    {
        private Customer customer;
        private ControlProducts controlProducts;
        private ControlOrder controlOrder;
        private ControlOrderDetail controlDetail;
        private Order order;

        public ViewHome(Customer customer)
        {

            this.customer = customer;
            this.controlProducts = new ControlProducts();
            this.controlOrder = new ControlOrder();
            this.controlDetail = new ControlOrderDetail();
            this.order = new Order(controlOrder.nextId(),customer.Address,1);


            
        }

        public void meniu()
        {
            Console.WriteLine("Apasati 1 pentru a afisa produsul");
           
           
        }

        public void home()
        {
            meniu();
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                switch (n)
                {
                    case 1:
                        viewAfisare();
                        break;
                   
                 
                }
                meniu();
                n = int.Parse(Console.ReadLine());
            }
        }

        public void viewAfisare()
        {
            Console.WriteLine("Acestea sunt toate produsele");
            Console.WriteLine(controlProduscts.afisare());
        }

        public void viewAdaugare()
        {
           
        }   
        
    

    }
}
