using KnowledgeCheck2.WizardClasses;
using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("How many records do you want to add? ");
        var numberOfWizards = int.Parse(Console.ReadLine());

        var wizardList = new List<GreenWizard>();
        for (int i = 0; i < numberOfWizards; i++)
        {
            //************************************
            //**assuming I'm not supposed to use constructors here???

            // In this loop, populate the object's properties using Console.ReadLine()
            GreenWizard newWizard = new GreenWizard();
            Console.WriteLine("Enter The Value For Name");
            newWizard.Name = Console.ReadLine();
            Console.WriteLine("Enter The Value For Description");
            newWizard.Description = Console.ReadLine();
            Console.WriteLine("Enter The Value For Health Points");
            newWizard.HealthPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value For Magic Attack Level");
            newWizard.MagicAttackPower = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value For Magic Defense Level");
            newWizard.MagicDefense = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Can said Wizard Commune With Nature?");
            string truth = Console.ReadLine();
            if (truth.ToLower().Trim().StartsWith("y")) { newWizard.CommuneWithNature = true; }
            else { newWizard.CommuneWithNature = false; }

            wizardList.Add(newWizard);
        }
        string input;
        do
        {
            Console.WriteLine("Press 1 to view only the names of Green Wizards stored.\n" +
                "Press 2 to view Wizard with properties listed");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":

                    {
                        //just in case this was how it was actually supposed to be executed

                        Console.WriteLine(String.Join("\n----------\n", wizardList.Select(w => w.Name)));
                        continue;
                    }
                case "2":
                    {

                        // Print out the list of records using Console.WriteLine()
                        foreach (var wizard in wizardList)
                        {
                            Console.WriteLine($"*--------------------- Green Wizard ----------------------*");
                            Console.WriteLine($"Properties                    Values                       ");
                            Console.WriteLine($"-----------------------------------------------------------");
                            Console.WriteLine($"Name:                         {wizard.Name}");
                            Console.WriteLine($"Description:                  {wizard.Description}");
                            Console.WriteLine($"Health Points:                {wizard.HealthPoints}");
                            Console.WriteLine($"Magic Attack Power:           {wizard.MagicAttackPower}");
                            Console.WriteLine($"Magic Defense:                {wizard.MagicDefense}");
                            Console.WriteLine($"Able To Commune With Nature:  {wizard.CommuneWithNature}");
                        }
                        continue;
                    }
                case "exit":
                    {
                        Console.WriteLine("Exitting program...");
                        break;
                    }
            }
        } while (input != "exit");
    }
}
