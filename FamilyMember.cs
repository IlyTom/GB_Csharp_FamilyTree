using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    internal class FamilyMember
    {
        public string Name { get; set; }        
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }        
        public void Info(int indent)
        {
            Console.WriteLine($"{new String(' ', indent)} {this.Name}");
        }
        public virtual void Print(int indent = 0)
        {
            Info(indent);
        }

    }
}
