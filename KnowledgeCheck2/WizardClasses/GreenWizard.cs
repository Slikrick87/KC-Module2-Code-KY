using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using KnowledgeCheck2.WizardClasses;

namespace KnowledgeCheck2.WizardClasses
{
    public class GreenWizard : Wizard
    {
        public bool CommuneWithNature {  get; set; }
        //public GreenWizard(string name, string description, int healthPoints, 
        //    decimal magicAttackPower, decimal magicDefense, bool communeWithNature) 
        //    : base (name, description, healthPoints, magicAttackPower, magicDefense)
        //{
        //    this.CommuneWithNature = communeWithNature;
        //}
    }
}
