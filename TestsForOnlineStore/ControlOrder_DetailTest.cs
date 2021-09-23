using Magazin_Online_v2;
using Magazin_Online_v2.Clasa;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace TestsForOnlineStore
{
    public class ControlOrder_DetailTest
    {
        private readonly ITestOutputHelper outputHelper;

        public ControlOrder_DetailTest(ITestOutputHelper output)
        {
            this.outputHelper = output;
        }

        [Fact]

        public void loadTest()
        {
            ControlOrder_Detail control = new ControlOrder_Detail();
            outputHelper.WriteLine(control.afisare());
        }



        [Fact]
        public void adaugareTest()
        {
            ControlOrder_Detail control = new ControlOrder_Detail();
            control.adaugare(1,1,1);
            outputHelper.WriteLine(control.afisare());
        }

        [Fact]
        public void stergereTest()
        {
            ControlOrder_Detail control = new ControlOrder_Detail();
            control.adaugare(1,1,1);
            control.adaugare(2,2,2);
            control.adaugare(3,3,3);
            control.stergere(2);
            outputHelper.WriteLine(control.afisare());
        }

        [Fact]
        public void modificareTest()
        {
            ControlOrder_Detail control = new ControlOrder_Detail();
            control.adaugare(1, 1, 1);
            control.adaugare(2, 2, 2);
            control.modificare(1, 1, 0, 2);
            outputHelper.WriteLine(control.afisare());
        }
    }
}
