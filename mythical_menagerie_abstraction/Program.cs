﻿using System;
using System.Collections.Generic;

namespace mythical_menagerie_abstraction
{
    //private string name;
    //private string affiliatedDiety;
    //private string area;
    //private string alignment;
    //private string specialAbility;
    public class Program
    {

        static void Main()
        {
            var cerberus = new Cerberus();
            var hydra = new Hydra();
            var cyclops = new Cyclops();
            var medusa = new Medusa();
            var pegasus = new Pegasus();

            Console.WriteLine(cerberus.ToString());
            Console.WriteLine($"{cerberus.Name} {cerberus.Alignment}");
            
            
            
            
            Console.WriteLine(hydra.ToString());
            Console.WriteLine(cyclops.ToString());
            Console.WriteLine(medusa.ToString());
            Console.WriteLine(pegasus.ToString());
        }


        public static void MainMenuOptions()
        {
            //var creatureList = new List<MythicalCreature>();
            //var choice = "";

            //while (true)
            //{
            //    Console.WriteLine("Would you like to create a mythical creature? Y/N");
            //    choice = Console.ReadLine();
            //    if (choice == "N")
            //    {
            //        break;
            //    }

            //    Console.WriteLine("Type in the name of creature: ");
            //    var name = Console.ReadLine();

            //    Console.WriteLine("Type in affiliated deity: ");
            //    var affiliatedDiety = Console.ReadLine();

            //    Console.WriteLine("Type in desired area:");
            //    var area = Console.ReadLine();

            //    Console.WriteLine("Type in chosen alignment: ");
            //    var alignment = Console.ReadLine();

            //    Console.WriteLine("Type in special ability: ");
            //    var specialAbility = Console.ReadLine();

            //    var mythicalCreature = new MythicalCreature(name, affiliatedDiety, area, alignment, specialAbility);
            //    creatureList.Add(mythicalCreature);

            //    foreach (var creature in creatureList)
            //    {
            //        Console.WriteLine(creature.ToString());
            //    }


            //}
            return;
        }
    }
}

