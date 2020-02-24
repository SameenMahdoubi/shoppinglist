using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for AddItemControl.xaml
    /// </summary>
    public partial class AddItemControl : UserControl
    {
        public AddItemControl()
        {
            InitializeComponent();
            AddItemButton.Click += OnAddItemButtonClick;
        }

        protected void OnAddItemButtonClick(object sender, RoutedEventArgs e)
        {   /*
            var item = ItemToAdd.Text;
            var data = (ShoppingListData)DataContext;
            var data2 = DataContext as ShoppingListData;
            if (data2 != null)
            {
                // safe to work with data2
            }
            */
            if (DataContext is ShoppingListData data3)
            {
                // makes data3 if the casting is successful, local variable for that block of code
                data3.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }
        }
    }
}
