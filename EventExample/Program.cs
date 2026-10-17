namespace EventExample
{
    internal class Program
    {
        // TRIN 1: Opret en klasse, der arver fra EventArgs til at holde på data
        // TRIN 2: Opret PUBLISHER klassen. Herunder
        //      Erklær eventet med EventHandler<T>
        //      Lav en metode, hvor noget sker. 
        //      Lav en protected metode, der sender en besked ud med et nyt [Type]EventArg object (dvs data), HVIS der er subscribers til eventet.
        // TRIN 3: Opret SUBSCRIBER klassen ned to metoder
        //      SubscribeToMachine(CoffeeMachine machine) Lyt til eventet, dvs machine.CoffeeReady += HandleCoffeeReady;
        //      definer metoden der udløses, når eventet finder sted HandleCoffeeReady(object sender, CoffeeEventArgs e){...};
        static void Main(string[] args)  // Programmet der binder det hele sammen
        {
            //Opret objekterne
            CoffeeMachine machine = new CoffeeMachine();
            Waiter waiter = new Waiter();

            //subscriber begynder at lytte til publisher (tjener-maskine)
            waiter.SubscribeToMachine(machine);
            //maskinen sættes igang. Hver gang vil tjeneren reagere automatisk.
            machine.BrewCoffee("espresso");
            machine.BrewCoffee("latte");

        }
    }
}