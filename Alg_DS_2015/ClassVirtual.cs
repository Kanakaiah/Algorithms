using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_DS_2015
{
    public class Asset
    {
        public string Name { get; set; }

        public virtual decimal Liability => 1234;
    }

    public class House : Asset
    {
        public decimal Mortagage;
        //public sealed override decimal Liability => Mortagage;
        public sealed override decimal Liability => base.Liability + Mortagage;

    }


    public class Community : House
    {
        public decimal MortagageShare;
        //public override decimal Liability => MortagageShare;
        //Severity	Code	Description	Project	File	Line
        //Error CS0239	'Community.Liability': cannot override inherited member 'House.Liability' because it is sealed Alg_DS_2015 c:\users\kk\documents\visual studio 2015\Projects\Alg_DS_2015\Alg_DS_2015\ClassVirtual.cs	26
        //public sealed override decimal Liability => base.Liability + Mortagage;


    }

}
