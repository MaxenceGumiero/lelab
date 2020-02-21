using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Views
{
    public class Article
    {
        public string Nom { get; set; }
        public string Prix { get; set; }
        public string Description { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        List<Article> articles;
        public ListPage()
        {
            InitializeComponent();

            articles = new List<Article>();
            articles.Add(new Article { Nom = "Lait", Prix = "0.90 €", Description="Pack de lait" });
            articles.Add(new Article { Nom = "Chocolat", Prix = "2.60 €", Description = "80% de cacao" });
            articles.Add(new Article { Nom = "Pain", Prix = "1.80 €", Description = "Pain aux céréales" });
            articles.Add(new Article { Nom = "Beurre", Prix = "1.50 €", Description = "Beurre demi-sel" });
            articles.Add(new Article { Nom = "Sucre", Prix = "1 €", Description = "Sucre de canne" });

            maListView.ItemsSource = articles;

            maListView.ItemSelected += (sender, e) =>
            {
                if (maListView.SelectedItem != null) 
                {
                    Article item = maListView.SelectedItem as Article;

                    DisplayAlert(item.Nom, item.Description, "Retour");
                    maListView.SelectedItem = null;
                }
            };
        }
    }
}