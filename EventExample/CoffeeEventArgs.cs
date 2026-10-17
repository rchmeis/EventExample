using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public class CoffeeEventArgs : EventArgs
    {
        public string CoffeeType { get; set; }
    }
}
