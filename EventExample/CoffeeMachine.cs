using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public class CoffeeMachine //PUBLISHER klassen (udløser eventet)
    { 
        //Erklæring af event
        public event EventHandler<CoffeeEventArgs> CoffeeReady;

        public void BrewCoffee(string type)
        {
            Console.WriteLine($"Brewing coffee of type {type}");

            //udløs event
            OnCoffeeReady(type);
        }

        // Beskyttet metode til at fyre eventet af (god praksis i C#)
        protected virtual void OnCoffeeReady(string type)
        {
            CoffeeReady?.Invoke(this, new CoffeeEventArgs { CoffeeType = type});
        }
        // Sikkerhedstjek: 'CoffeeReady?.Invoke' tjekker om der overhovedet er nogen lyttere. 
        // Hvis '?. ' ikke var der, ville programmet crashe med en NullReferenceException, hvis ingen lytter.
        // OBS this i Event sammenhæng peger på senderen, altså dette objekt (kaffemaskinen). 
        // i alm klasser bruger vi typisk this til at pege på instansvariable for ikke at mistake them for parametre.
    }
}
