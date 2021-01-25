using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsulterProduit.Droid;
using ConsulterProduit.Model;
using ConsulterProduit.Model.Entities;
using ConsulterProduit.Model.Interface;
using SQLite;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ConsulterProduit.Service;
//using SQLitePCL;
namespace ConsulterProduit.Service
{
    class DAOSqlLite : IDAO
    {
        private readonly SQLiteAsyncConnection connection;
        public DAOSqlLite()
        {
            connection = DependencyService.Get<ISQLiteService>().GetConnection("firas.db");
            connection.CreateTableAsync<Produit>().Wait();
            connection.InsertAsync(new Produit
            {
                Nom = "Produit1",
                Description = ".....",
                Disponible = true,
            });
            connection.InsertAsync(new Produit
            {
                Nom = "Produit2",
                Description = ".....",
                Disponible = true,
            });
            //connection.InsertAsync(new Contact { Name = "Mike", Number = "123-456-7896" });
        }
        public async Task<ObservableCollection<Produit>> LoadProductByCat()
        {

            var produits = await connection.Table<Produit>().ToListAsync();

            return new ObservableCollection<Produit>(produits);
        }
        public void LoadProductByCat(Category cat)
        {


        }
    }
}
