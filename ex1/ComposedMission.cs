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
    The main ComposedMission class
    Contains a composite mission.
*/
    public class ComposedMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        // members
        private List<Calculation> listOfFunctions;
        private string name;
        // property
        public String Name { get; }
     
        public String Type { get { return "composed"; } }
        //Ctor
        public ComposedMission(string nameFunc)
        {
            name = nameFunc;
            listOfFunctions = new List<Calculation>();
        }
        // add functions to the list;
        public ComposedMission Add (Calculation function)
        {
            listOfFunctions.Add(function);
            return this;
        }
        // Calculate
        public double Calculate(double val)
        {
            double result = val;
            foreach (Calculation function in listOfFunctions)
            {
                result = function(result);
            }
            OnCalculate?.Invoke(this, result);
            return result;
        }

  
    }
}
