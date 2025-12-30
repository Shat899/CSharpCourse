using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    // clas can contain fields, properties, methods, events, and constructors
    // clas as default is internaln
    // clas don't can by primitive type and protected
    public class Character
    {

        private int health = 100; // field

        public int Health // declare property / property always start with uppercase letter / property usually used to access private fields
        {
            get 
            {
                return health; // return the value of health field
            }
            private set // as default is public / private set --> can be set only within the class
            {
              health = value; // set the value of health field
            }
        }

        //void --> method doesn't return any value
        // When method dont't have any access modifier, it is private by default
        // private method can be accessed only within the same class
        // protected is accessible within its class and by derived class instances legacy
        // internal is accessible only within files in the same assembly
        // public is accessible from any other code 
        public void Hit (int damage) // method 
        {                     //C# contns only methods, no functions / / functions are part of other languages / functions are similar to methods, but they are not associated with any class or object.
            health -= damage; // decrease health by damage

        }

    }
}
