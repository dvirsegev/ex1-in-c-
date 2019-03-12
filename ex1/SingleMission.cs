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
        private Calculation mis;
        private string name;
        public event EventHandler<double> OnCalculate;
        // property

        public String Type { get { return "Single"; } }
        public String Name {
        get { return name; } }

        //Ctor
        public SingleMission(Calculation mission,string nameFunction)
        {
            name = nameFunction;
            mis = mission; 
        }
        public double Calculate(double var)
        {
            double result= mis(var);
            OnCalculate?.Invoke(this, mis(var));
            return result;
        }
    }
}
