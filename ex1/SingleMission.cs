using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        // members
        private event EventHandler<double> OnCalculate;
        private Calc mis;
        private string name, value;
        // property

        public String Value { get { return "Single"; } }
        public String Name {
        get { return name; } }
        //Ctor
        public SingleMission(Calc mission,string nameFunction)
        {
            name = nameFunction;
            mis = mission; 
        }
        public double Calculate(double var)
        {
            return mis(var);
        }
    }
}
