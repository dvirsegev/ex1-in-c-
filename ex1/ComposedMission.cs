using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private event EventHandler<double> OnCalculate;
        // members
        private List<Calc> listOfFunctions;
        private string name;
        // property
        public String Name { get { return name; } }
     
        public String Value { get { return "composed"; } }
        //Ctor
        public ComposedMission(string nameFunc)
        {
            name = nameFunc;
        }
        // add functions to the list;
        public ComposedMission Add (Calc function)
        {
            listOfFunctions.Add(function);
            return this;
        }
        // Calculate
        public double Calculate(double val)
        {
            double result = val;
            foreach(Calc function in listOfFunctions)
            {
                result = function(result);
            }
            return result;
        }
    }
}
