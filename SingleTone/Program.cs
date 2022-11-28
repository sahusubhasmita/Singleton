using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConsoleApp
{

    public class Singleton
    {
        private static Singleton _instance;     //Static property with


        private Singleton() 
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null) 
                
                _instance = new Singleton();


                return _instance;
            }
        }

        public void DoSingletonOperation() { 
            
            Console.WriteLine("singleton operation");      
            }  
    }    
    
  class Program  
  {        
        static void Main(string[] args)     
        {


        Singleton singletonOld = Singleton.Instance;


        Singleton singletonNew = Singleton.Instance;


         Console.WriteLine(singletonOld == singletonNew);  
            
         Console.ReadLine();

        }
  }
}



