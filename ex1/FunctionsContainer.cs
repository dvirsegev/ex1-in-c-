using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// dvir segev
// 318651627
namespace Excercise_1
{
    // public member delegate (type double and get a double variable).
    public delegate double Calculation(double var);
    /**
     * contain a dictionary that connect between string and a function. 
     * */
    public class FunctionsContainer
    {
        private Dictionary<String, Calculation> myDictionary;
        // Ctor
        public FunctionsContainer()
        {
            myDictionary = new Dictionary<String, Calculation>();
        }
        // Indexer declaration.
        public Calculation this[String name]
        {
            get
            {
                Calculation fucntion;
                if(myDictionary.TryGetValue(name,out fucntion)) { return myDictionary[name]; }
                myDictionary.Add(name, x => x);
                return myDictionary[name];
            }
            set {
                if(myDictionary.ContainsKey(name))
                {
                    myDictionary[name] = value;
                }
               else
                    myDictionary.Add(name, value);
            }
  
        }
        // get all the mission
        public List<string> getAllMissions()
        {
            List<string> missions= new List<string>();
            foreach (var item in myDictionary.Keys) {
                missions.Add(item);
            }
            return missions;
        }
    }
}
