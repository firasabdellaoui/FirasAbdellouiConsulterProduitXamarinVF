using App4.commun;
using ConsulterProduit.Model;
using ConsulterProduit.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ConsulterProduit.ModelView
{
    public class ProduitsModelView:BindableObject
    {
        private string _name;
        private ObservableCollection<ProduitVM> _produits;
        public ObservableCollection<ProduitVM> Produits
        {
            get { return _produits; }
            set
            {
                _produits = value;
                OnPropertyChanged("Produits");
                
            }
        }
        private ProduitVM _selectCategory { get; set; }
        public ProduitVM SelectCategory
        {
            get { return _selectCategory; }
            set
            {
                if (_selectCategory != value) { 
                _selectCategory = value;
                    Category = _selectCategory.Nom;
                }
            }
        }
        public string Name {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");

            }
        }
        private String _category;
        private ProduitsModelView produitVM;

        public string Category
        {
            get { return _category; }
            set
            {
                _category = value;
                OnPropertyChanged("Category");

            }
        }
        public ProduitsModelView()
        {

            DaoProduit _context = new DaoProduit();

            IList<ProduitVM> produitsVM = new List<ProduitVM>();
            foreach (var Produit in _context.produits)
            {
                
               produitsVM.Add(new ProduitVM(Produit));
           }
            DAOSqlLite dao = new DAOSqlLite();
            Produits = new ObservableCollection<ProduitVM>(produitsVM);

            /*foreach (var produit in _context.produits)
            {
                Produits.Add(produit);
            }*/
        }

        public ProduitsModelView(ProduitsModelView produitVM)
        {
            this.produitVM = produitVM;
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Produit selectedItem = e.SelectedItem as Produit;
            this._name = selectedItem.Nom;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Produit tappedItem = e.Item as Produit;
            
        }
    }
}
