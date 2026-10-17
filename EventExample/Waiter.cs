using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EventExample
{
    //Subscriber-klassen (Den der lytter og reagerer)
    public class Waiter
    {
        // Vi kobler vores egen metode (HandleCoffeeReady) på maskinens event ved hjælp af +=
        public void SubscribeToMachine(CoffeeMachine machine)
        {
            machine.CoffeeReady += HandleCoffeeReady;
        }

        // Denne metode SKAL matche den signatur, som EventHandler kræver: 
        // (object sender, [DinType]EventArgs e)
        private void HandleCoffeeReady(object sender, CoffeeEventArgs e)
        {
            Console.WriteLine($"Besked modtaget. Tjener vil servere kaffen {e.CoffeeType} fra {sender.GetType()}");
        }
    }
}
