using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public int Profits { get; set; }
        public int Losses { get; set; }
    }
}



//In ICompany: 

/* Create 2 members that are specific to each every company
 * regardless of vehicle type.
 * Example: public string Logo { get; set; }
 */