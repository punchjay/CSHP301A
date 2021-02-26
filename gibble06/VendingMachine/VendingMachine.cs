// Exercise 06
// Gibble, Jay ejg2
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VendingMachine
{
    public class VendingMachine : INotifyPropertyChanged
    {
        public VendingMachine()
        { 
        
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
