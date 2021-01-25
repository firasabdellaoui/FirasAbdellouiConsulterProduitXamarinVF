using ConsulterProduit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ConsulterProduit.ModelView;
namespace ConsulterProduit.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsulterProduits : ContentPage
    {
        public ConsulterProduits()
        {
            InitializeComponent();
            BindingContext = new ProduitsModelView();
        }
     
    }
}