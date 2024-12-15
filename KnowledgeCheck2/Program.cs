using KnowledgeCheck2.WizardClasses;
using System;
using System.Reflection.Metadata.Ecma335;
using KnowledgeCheck2.WizardClasses.WizardMethods;

class Program
{
    static void Main(string[] args)
    {
        //laziness kept me from implementing an IServiceProvider
        var wizardClass = new WizardFunctions();
        
        string? numberOfWizardInput;
        int numberOfWizardOutput;
        do
        {
            Console.WriteLine("How many records do you want to add? ");
            numberOfWizardInput = Console.ReadLine();
        } while (!int.TryParse(numberOfWizardInput, out numberOfWizardOutput));
        int numberOfWizards = numberOfWizardOutput;
        var wizardList = new List<GreenWizard>();

        for (int i = 0; i < numberOfWizards; i++)
        {
            //************************************
            //**assuming I'm not supposed to use constructors here???
            // In this loop, populate the object's properties using Console.ReadLine()

            wizardList.Add(wizardClass.CreateGreenWizard());
        }
        string? input;
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
                            wizardClass.DisplayGreenWizard(wizard);
                        }
                        continue;
                    }
                case "exit":
                    {
                        Console.WriteLine("Exiting program...");
                        break;
                    }
            }
        } while (input != "exit");
    }
}
