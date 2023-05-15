using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3.Inheritance
{
    internal class Team : Sponsor
    {
        private string teamName;
        public string TeamName
        {
            get
            { 
                return teamName; 
            }
            set
            {
                teamName = value;
            }
        }
        public void printInfo()
        {
             Console.WriteLine(string.Concat(owner, TeamName));
             
        }
    }
}
