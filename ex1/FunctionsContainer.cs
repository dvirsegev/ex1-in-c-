using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    // the delegate of the function.
    public delegate double Calc(double var);
    public class FunctionsContainer
    {
        private Dictionary<string, Calc> myDic;
        public FunctionsContainer()
        {
            myDic = new Dictionary<string, Calc>();
        }
        // Indexer declaration.
        public Calc this[string name]
        {
            get
            {
                if(myDic[name]!= null) { return myDic[name]; }
                return null;
            }
            set { myDic.Add(name, value); }
  
        }
    }
}
