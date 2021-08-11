using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinTestAPI.Services
{
    class Order : INotifyPropertyChanged
    {
        public Order()
        {
        }

        public string ProductName
        {
            get;
            set;
        }

        private int qty;

        public int Quantity
        {
            get { return qty; }
            set
            {
                if (value != qty)
                {
                    qty = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quantity"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
