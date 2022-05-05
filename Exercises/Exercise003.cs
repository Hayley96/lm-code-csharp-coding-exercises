using System;
namespace Exercises
{
    public class Exercise003
    {
        // define iceCreamFlavours array
        public string[] IceCreamFlavours = {
            "Pistachio",
            "Raspberry Ripple",
            "Vanilla",
            "Mint Chocolate Chip",
            "Chocolate",
            "Mango Sorbet"};

        // return index of ice cream item in IceCreamFlavours where item value/name matches input parameter iceCreamFlavour
        public int IceCreamCode(string iceCreamFlavour) => Array.IndexOf(IceCreamFlavours, iceCreamFlavour);

    }
}