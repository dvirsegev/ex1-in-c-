using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// dvir segev
// 318651627
namespace Excercise_1
{

    /*
    The main SingleMission class
    Contains a single mission.
*/

    public class SingleMission : IMission
    {
        // members.
        private Calculation mis;
        private string name;
        public event EventHandler<double> OnCalculate;
        // property.

        public String Type { get { return "Single"; } }
        public String Name { get; }

        //Ctor.
        public SingleMission(Calculation mission,string nameFunction)
        {
            name = nameFunction;
            mis = mission; 
        }
        // calculate the mission.
        public double Calculate(double var)
        {
            double result= mis(var);
            OnCalculate?.Invoke(this, mis(var));
            return result;
        }
    }
}
