using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace uwp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class view1 : ViewCell
    {
        private StackLayout Back;
        private View View_back;
        public view1(StackLayout back_lay, View back_view)
        {
            InitializeComponent();
            Back = back_lay;
            View_back = back_view;
        }

        private void back(object sender, EventArgs e)
        {
            Switch(View_back);
        }

        private void refresh(object sender, EventArgs e)
        {
            grid.ItemsSource = new List<Request>()
            {
                new Request { Id = "1", About = "about1" },
                new Request { Id = "2", About = "about2" },
                new Request { Id = "3", About = "about3" },
                new Request { Id = "4", About = "about4" },
                new Request { Id = "5", About = "about5" }
            };
        }

        private void Switch(View _new)
        {
            Back.Children.Clear();
            Back.Children.Add(_new);
            
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var info = e.Item;
        }
    }
}