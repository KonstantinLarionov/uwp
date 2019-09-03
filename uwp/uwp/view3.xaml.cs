using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace uwp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class view3 : ViewCell
    {
        private StackLayout Back;
        private View View_back;
        public view3(StackLayout back_lay, View back_view)
        {
            InitializeComponent();
            Back = back_lay;
            View_back = back_view;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Switch(View_back);
        }

        private void Switch(View _new)
        {
            Back.Children.Clear();
            Back.Children.Add(_new);
        }
    }
}