using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
//using SQLite;

namespace ConsulterProduit.Model.Entities
{
        [Table("Produit")]
        public class Category : INotifyPropertyChanged
        {
            private int _id;
            [PrimaryKey, AutoIncrement]
            public int Id
            {
                get { return _id; }
                set
                {
                    _id = value;
                    OnPropertyChanged(nameof(_id));
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

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }
    }
}
