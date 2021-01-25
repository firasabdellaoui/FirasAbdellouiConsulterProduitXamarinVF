using ConsulterProduit.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ConsulterProduit.Service
{
    public class DaoProduit 
    {
        public IList<Produit> produits { get;  set ; }

        public DaoProduit()
        {
            produits = new List<Produit>();
            produits.Add(new Produit
            {
                Id = 0,
                Nom = "Produit1",
                Description = ".....",
                Disponible = true,
            });
            produits.Add(new Produit
            {
                Id = 1,
                Nom = "Produit2",
                Description = ".....",
                Disponible = true,
            });

        }

    }
}