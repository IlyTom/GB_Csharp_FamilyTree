using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    internal class AdultFamilyMember : FamilyMember
    {
        public FamilyMember[] Children { get; set; }
        public AdultFamilyMember Spouse { get; set; }

        public override void Print(int indent = 0)
        {
            if (Spouse != null)
            {
                Console.WriteLine($"{new String(' ', indent)}|-- {this.Name} |-- Супруг(а) {Spouse.Name}");
            }
            else
            {
                base.Print(indent);
            }
            foreach (var child in Children)
                child.Print(indent + 2);
        }
    }
}
