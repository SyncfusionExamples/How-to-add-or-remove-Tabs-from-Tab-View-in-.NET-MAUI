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
            SfTabItem tabItem = new SfTabItem();
            tabItem.Header = "New Item Added";
            StackLayout stacklayout = new StackLayout();
            stacklayout.BackgroundColor = Colors.LightBlue;
            tabItem.Content = stacklayout;
            tabView.Items.Add(tabItem);
        }

        private void Insertitem_Clicked(object sender, EventArgs e) 
        {
            SfTabItem insertItem = new SfTabItem();
            insertItem.Header = "New Item Inserted";
            StackLayout stacklayout1 = new StackLayout();
            stacklayout1.BackgroundColor = Colors.PaleGreen;
            insertItem.Content = stacklayout1;
            if (tabView.Items.Count > 0)
                tabView.Items.Insert(1, insertItem);
            else
                tabView.Items.Insert(0, insertItem);
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

