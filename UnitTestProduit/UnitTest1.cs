using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NSubstitute;
using ConsulterProduit.ModelView;
using ConsulterProduit.Model.Entities;
using ConsulterProduit.Model.Interface;

namespace UnitTestProduit
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void productviewmodeltest()
        {
            //arrange
            var ProduitVM = Substitute.For<ProduitsModelView>();
           //     var pagevm = Substitute.For<ProduitVM>();
            var pd_vm = new ProduitsModelView();

            //act
            pd_vm.Produits._id = 0;
            pd_vm.SaveCommand.Execute(null);
            pd_vm.LoadDataCommand.Execute(null);
            //var result =cal.
            //assert
            Assert.that(pd_vm.Produits.Count>0)
        }
        
       
    }
}
