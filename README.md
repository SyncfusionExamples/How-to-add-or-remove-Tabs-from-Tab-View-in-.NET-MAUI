# How-to-add-or-remove-Tabs-from-Tab-View-in-.NET-MAUI
This section explains how to add or remove Tabs from Tab View in .NET MAUI

#   Getting Started with .NET MAUI Tab View (SfTabView)

##  Adding a .NET MAUI Tab View reference
Syncfusion .NET MAUI controls are available in Nuget.org. To add .NET MAUI Tab View to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.TabView and then install it.

## Create a simple .NET MAUI Tab View
This section explains how to create a .NET MAUI Tab View and configure it. The control can be configured entirely in C# code or by the XAML markup.

## Creating the project
Create a new .NET MAUI application in Visual Studio

## Adding a .NET MAUI Tab View control
*   Step 1: Add the NuGet to the project as discussed in the above reference section.

*   Step 2: Add the namespace as shown in the following code sample.

**XAML**

```
xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView"
```

*   Step 3: Set the control to content in ContentPage.

**XAML**
```
<ContentPage.Content> 
        <tabView:SfTabView /> 
</ContentPage.Content>  

```

#   Populate Tab Items in .NET MAUI Tab View
Tab items can be added to the control using the Items property of SfTabView.

**XAML**
```
 <ContentPage.Content> 
        <tabView:SfTabView x:Name="tabView">
            <tabView:SfTabView.Items>
                <tabView:SfTabItem Header="Call">
                    <tabView:SfTabItem.Content>
                        <Grid BackgroundColor="Red" />
                    </tabView:SfTabItem.Content>
                </tabView:SfTabItem>

                <tabView:SfTabItem Header="Favorites">
                    <tabView:SfTabItem.Content>
                        <Grid BackgroundColor="Green"/>
                    </tabView:SfTabItem.Content>
                </tabView:SfTabItem>

                <tabView:SfTabItem Header="Contacts">
                    <tabView:SfTabItem.Content>
                        <Grid BackgroundColor="Blue"/>
                    </tabView:SfTabItem.Content>
                </tabView:SfTabItem>
            </tabView:SfTabView.Items>
        </tabView:SfTabView>
    </ContentPage.Content>  
</ContentPage>
```

#   To add or remove Tabs from Tab View in .NET MAUI

**XAML**
```
 <ContentPage.Content>
     <Grid>
         <Grid.RowDefinitions>
             <RowDefinition Height="0.1*"/>
             <RowDefinition Height="0.9*"/>
         </Grid.RowDefinitions>
         <Grid Grid.Row="0">
             <Grid.ColumnDefinitions>
                 <ColumnDefinition Width="*"/>
                 <ColumnDefinition Width="*"/>
                 <ColumnDefinition Width="*"/>
             </Grid.ColumnDefinitions>
             <Button Text="Add TabItem" Grid.Column="0" x:Name="Additem" Clicked="Additem_Clicked"/>
             <Button Text="Remove TabItem" Grid.Column="1" x:Name="Removeitem" Clicked="Removeitem_Clicked"/>
             <Button Text="Insert TabItem" Grid.Column="2" x:Name="Insertitem" Clicked="Insertitem_Clicked"/>
         </Grid>
         <StackLayout Grid.Row="1">
             <tabView:SfTabView x:Name="tabView" VerticalOptions="FillAndExpand">
                 <tabView:SfTabItem Header="Contacts">
                     <tabView:SfTabItem.Content>
                         <ListView Margin="0,20,0,0" RowHeight="70" x:Name="listView" ItemsSource="{Binding ContactList}">
                             <ListView.ItemTemplate>
                                 <DataTemplate>
                                     <ViewCell>
                                         <StackLayout Orientation="Vertical" Margin="30,0,0,0">
                                             <Label Text="{Binding Name}" FontSize="24" />
                                             <Label Text="{Binding Number}" FontSize="20" TextColor="LightSlateGray" />
                                         </StackLayout>
                                     </ViewCell>
                                 </DataTemplate>
                             </ListView.ItemTemplate>
                         </ListView>
                     </tabView:SfTabItem.Content>
                 </tabView:SfTabItem>
                 <tabView:SfTabItem Header="Calls">
                     <tabView:SfTabItem.Content>
                         <StackLayout BackgroundColor="LightGray"  x:Name="AllCallsGrid">
                         </StackLayout>
                     </tabView:SfTabItem.Content>
                 </tabView:SfTabItem>
                 <tabView:SfTabItem Header="Favorites">
                     <tabView:SfTabItem.Content>
                         <Grid BackgroundColor="LightGreen"  x:Name="FavoritesGrid" />
                     </tabView:SfTabItem.Content>
                 </tabView:SfTabItem>
             </tabView:SfTabView>
         </StackLayout>
     </Grid>
 </ContentPage.Content>
 ```

 **C#**

 ```
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
 ```