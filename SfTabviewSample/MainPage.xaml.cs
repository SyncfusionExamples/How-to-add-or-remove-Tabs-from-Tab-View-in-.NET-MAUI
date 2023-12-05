using Syncfusion.Maui.TabView;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SfTabviewSample 
{
    public partial class MainPage : ContentPage {

        ViewModel model;

        public MainPage() {
            InitializeComponent();
            model = new ViewModel();
            this.BindingContext = model;
            model.IsSelected = true;
        }
        private void Additem_Clicked(object sender, EventArgs e) 
        {
            SfTabItem tabitem = new SfTabItem();
            tabitem.Header = "New Item Added";
            StackLayout stacklayout = new StackLayout();
            stacklayout.BackgroundColor = Colors.LightBlue;
            tabitem.Content = stacklayout;
            tabView.Items.Add(tabitem);
        }

        private void Insertitem_Clicked(object sender, EventArgs e) 
        {
            SfTabItem insertitem = new SfTabItem();
            insertitem.Header = "New Item Inserted";
            StackLayout stacklayout1 = new StackLayout();
            stacklayout1.BackgroundColor = Colors.PaleGreen;
            insertitem.Content = stacklayout1;
            if (tabView.Items.Count > 0)
                tabView.Items.Insert(1, insertitem);
            else
                tabView.Items.Insert(0, insertitem);
        }

        private void Removeitem_Clicked(object sender, EventArgs e) 
        {
            if (model.IsSelected && tabView.Items.Count > 0) 
            {
                var s = tabView.SelectedIndex;
                tabView.Items.RemoveAt((int)s);
            }
        }

    }
 
 }

