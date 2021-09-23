using Magazin_Online_v2;
using System;
using Xunit;
using Xunit.Abstractions;

namespace TestsForOnlineStore
{
    public class ProductsTests
    {
        private readonly ITestOutputHelper outputHelper;
       
        public ProductsTests(ITestOutputHelper output)
        {
            this.outputHelper = output;
        }

        [Fact]
        public void testDescription()
        {
            //Preconditie
            Product produs = new Product("telefon",1,"Samsung","Foarte bun",12.5,2);
            //Actiune
            produs.Categorie = "mobila";
            produs.Id = 1;
            produs.Name = "1";
            produs.Description = "1";
            produs.Price = 1;      
            produs.Stock = 1;
            //Rezultat
            Assert.Equal("mobila", produs.Categorie);
            Assert.Equal(1, produs.Id);
            Assert.Equal(1, int.Parse(produs.Name));
            Assert.Equal(1, produs.Price);
            Assert.Equal(1, int.Parse(produs.Description));
            Assert.Equal(1, produs.Stock);
        }

        [Fact]
        public void afisare()
        {
            Product produs = new Product("telefon", 1, "Samsung", "Foarte bun", 12.5, 2);
            outputHelper.WriteLine(produs.ToString());      
        }


    }
}
