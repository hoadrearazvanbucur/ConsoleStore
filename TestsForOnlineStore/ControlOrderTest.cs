using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;
using Xunit;
using Magazin_Online_v2.Clasa;

namespace TestsForOnlineStore
{
    public class ControlOrderTest
    {
        private readonly ITestOutputHelper outputHelper;

        public ControlOrderTest(ITestOutputHelper output)
        {
            this.outputHelper = output;
        }

        [Fact]

        public void loadTest()
        {
            ControlOrder control = new ControlOrder();
            outputHelper.WriteLine(control.afisare());
        }



        [Fact]
        public void adaugareTest()
        {
            ControlOrder control = new ControlOrder();
            control.adaugare(1, 1,"1",1);
            outputHelper.WriteLine(control.afisare());
        }

        [Fact]
        public void stergereTest()
        {
            ControlOrder control = new ControlOrder();
            control.adaugare(1, 1, "1",1);
            control.adaugare(2, 2, "2",2);
            control.adaugare(3, 3, "3",3);
            control.stergere(2);
            outputHelper.WriteLine(control.afisare());
        }

        [Fact]
        public void modificareTest()
        {
            ControlOrder control = new ControlOrder();
            control.adaugare(1, 1,"1", 1);
            control.adaugare(2, 2,"2", 2);
            control.modificare(1, 1,"2", 0, 2);
            outputHelper.WriteLine(control.afisare());
        }
    }
}
