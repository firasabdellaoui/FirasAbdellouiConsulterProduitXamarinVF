using ConsulterProduit.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
namespace ConsulterProduit.Model.Interface
{
    public interface IDAO
    {
        Task<ObservableCollection<Produit>> LoadProductByCat();

        //Task<ObservableCollection<Produit>> LoadProductByCat(Category cat);
    }
}
