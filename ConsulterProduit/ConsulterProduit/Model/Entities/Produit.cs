using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
//using SQLite;

namespace ConsulterProduit.Model
{
        [Table("Produit")]
        public class Produit : INotifyPropertyChanged
        {
            private int _id;
            [PrimaryKey, AutoIncrement]
        public int Id { get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(_id));
            }
            }

        private string _photo;
        public string Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanged(nameof(_photo));
            }
        }
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set
            {
                _nom = value;
                OnPropertyChanged(nameof(_nom));
            }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(_description));
            }
        }

        private Boolean _disponible;
        public Boolean Disponible
        {
            get { return _disponible; }
            set
            {
                _disponible = value;
                OnPropertyChanged(nameof(_disponible));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }
    }
}
