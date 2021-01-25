using ConsulterProduit.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ConsulterProduit.ModelView
{
    public class ProduitVM : BindableObject
    {
        // à refaire
        private string _id;

        private string _nom;

        private string _description;
        private Boolean _disponible;
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");

            }
        }
        public string Nom { 
            get { return _nom; }
            set
            {
                _nom = value;
                OnPropertyChanged("Nom");

            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");

            }
        }

        public bool Disponible {
            get { return _disponible; }
            set
            {
                _disponible = value;
                OnPropertyChanged("Disponible");

            }
        }

        // command

        public ICommand Delete { get; set; }
   
        public ProduitVM(Produit produit)
        {
            this.Id = (produit.Id).ToString();
            this.Nom = produit.Nom;
            this.Description = produit.Description;
            this.Disponible = produit.Disponible;
            //Delete = new Relaycommand(DeleteProduct);
        }

        private void DeleteProduct(object obj)
        {

        }
      
    }
}
