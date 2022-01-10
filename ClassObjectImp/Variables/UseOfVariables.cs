using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectImp.Variables
{
    internal class UseOfVariables
    {
        /* Instance variables
         * Instance variables creates a copy for every Object.
         * Instance variables life span is within the class.
         * After use of instance variable its got deleted from memory.
         * we can access Instance variables In different class using class object reference.
         */
        public int age;
        public string name;
        public double height;

        /* Static variables
         * it creates a single copy for whole class objects.
         * its life span is too within class only.
         * to access static variables, we need to use class reference
         */
        public static int _age;
        public static string _name;
        public static double _height;

        /* Constant Variables
         * keyword to use Constant is const.
         * constants cann't be modified after declaration
         * constant Variables values intilized while declaring.
         * To access Const Variables, we need to use Class reference.
         */
        public const int ageNumber = 24;
        public const double percentage = 66.6;

        /* ReadOnly Variables
         * keyword to use ReadOnly is readonly. 
         * readonly variables is like Constant var, it cann't be modified.
         * readonly can be initialized after declaration.
         * Behaviour of readonly variable is like Instance variables.
         */
    }
}
