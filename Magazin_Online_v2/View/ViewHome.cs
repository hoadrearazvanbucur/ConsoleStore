using Magazin_Online_v2.Clasa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazin_Online_v2.View
{
    public class ViewHome
    {
        private  ControlProducts controlProduscts;

        private ControlOrder controlOrder;


        private ControlOrderDetail controlDetail;


        private Customer customer;


        private Order order;




        public ViewHome( Customer customer)
        {
          
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
                    case 2:
                        viewAdaugare();
                        break;
                    case 3:
                        viewStergere();
                        break;
                    case 4:
                        viewModificare();
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
