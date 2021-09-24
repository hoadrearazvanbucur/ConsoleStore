using System;
using Magazin_Online_v2;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace TestsForOnlineStore
{
    public class ControlProdusTest
    {
        private readonly ITestOutputHelper outputHelper;

        public ControlProdusTest(ITestOutputHelper output)
        {
            this.outputHelper = output;
        }

        [Fact]

        public void loadTest()
        {
            ControlProducts control = new ControlProducts();
            outputHelper.WriteLine(control.afisare());
        }



        [Fact]
        public void adaugareTest()
        {
            ControlProducts control = new ControlProducts();
            control.adaugare(new Product("a",1,"a","a",1,1));
            outputHelper.WriteLine(control.afisare());
        }

        [Fact]
        public void stergereTest()
        {
            ControlProducts control = new ControlProducts();
            control.adaugare(new Product("telefon", 1, "Samsung", "Foarte bun", 12.5, 2));
            control.adaugare(new Product("mobila", 2, "Dedeman", "Sticla buna", 112.5, 6));
            control.adaugare(new Product("mobila", 3, "Dedeman", "Lemn masiv", 694.3, 1112));
            control.stergere(2);
            outputHelper.WriteLine(control.afisare());
        }

        [Fact]
        public void modificareTest()
        {
            ControlProducts control = new ControlProducts();
            control.adaugare(new Product("telefon", 1, "Samsung", "Foarte bun", 12.5, 2));

            control.modificare(new Product("telefon", 3, "Samsung", "Foarte bun", 12.5, 2), 1);
            outputHelper.WriteLine(control.afisare());
        }


    }
}
