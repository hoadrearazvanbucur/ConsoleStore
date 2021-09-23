using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;
using Xunit;
using Magazin_Online_v2.Clasa;

namespace TestsForOnlineStore
{
    public class ControlCustomerTest
    {
        private readonly ITestOutputHelper outputHelper;

        public ControlCustomerTest(ITestOutputHelper output)
        {
            this.outputHelper = output;
        }

        [Fact]

        public void loadTest()
        {
            ControlCustomer control = new ControlCustomer();
            outputHelper.WriteLine(control.afisare());
        }



        [Fact]
        public void adaugareTest()
        {
            ControlCustomer control = new ControlCustomer();
            control.adaugare(1, "1", "1", "1");
            outputHelper.WriteLine(control.afisare());
        }

        [Fact]
        public void stergereTest()
        {
            ControlCustomer control = new ControlCustomer();
            control.adaugare(1, "1", "1","1");
            control.adaugare(2, "2", "2", "2");
            control.adaugare(3, "3", "3", "3");
            control.stergere(2);
            outputHelper.WriteLine(control.afisare());
        }

        [Fact]
        public void modificareTest()
        {
            ControlCustomer control = new ControlCustomer();
            control.adaugare(1, "1", "1", "1");
            control.adaugare(2, "2", "2", "2");
            control.modificare(1, "1", "2", "0", 2);
            outputHelper.WriteLine(control.afisare());
        }
    }
}
