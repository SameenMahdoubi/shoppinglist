using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ShoppingList
{
    public class ShoppingListData : INotifyPropertyChanged
    {
        List<string> items = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<string> Items => items.ToArray(); // this property is a copy of items, rather than a regular property (this preserves data hiding)

        public void Add(string item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

        }

        public void Remove(string item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
