using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace uwp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void menu_click(object sender, EventArgs e)
        {
            var info = ((Button)sender).ClassId.ToString();            
            switch (info)
            {
                case "q1":
                    Switch((new view1(this.MainWrapper, this.MenuWrapper)).View);
                    break;
                case "q2":
                    Switch((new view2(this.MainWrapper, this.MenuWrapper)).View);
                    break;
                case "q3":
                    Switch((new view3(this.MainWrapper, this.MenuWrapper)).View);
                    break;
                default:
                    break;
            }
        }
        private void Switch(View _new)
        {
            MainWrapper.Children.Clear();
            MainWrapper.Children.Add(_new);
        }
    }
}
