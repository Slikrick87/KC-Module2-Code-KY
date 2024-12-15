using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2.WizardClasses.WizardMethods
{
    public class WizardFunctions
    { public GreenWizard CreateGreenWizard()
        {
            GreenWizard newWizard = new GreenWizard();
            bool itWorked = false;
            do
            {
                try
                {

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
                    string? truth = Console.ReadLine();
                    if (truth.ToLower().Trim().StartsWith("y")) { newWizard.CommuneWithNature = true; }
                    else { newWizard.CommuneWithNature = false; }
                    itWorked = true;
                }
                catch { Console.WriteLine("Invalid input Try Again!"); }
            } while (itWorked == false);

    {

            }
            return newWizard;
        }
        public void DisplayGreenWizard(GreenWizard wizard)
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
        //public bool CheckInput()
        //{
        //    if()
        //}
    }
}
