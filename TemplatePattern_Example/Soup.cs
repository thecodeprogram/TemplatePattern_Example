/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 20.06.2020
*/

using System;

namespace TemplatePattern_Example
{
    /*
     First I need to define my abstract class for my operation.
     In here I have two essential methods and I defined is as abstract
     Also There is a virtual methods for optional operations,
     I declared as virtual method. The derived class does not havve to
     use it. 
     And last I have a method which perform all required tasks.
    */
    public abstract class Soup
    {
        //My abstract methods
        public abstract void AddMaterials();
        public abstract void CookSoup();

        //My virtual method
        public virtual void AddSpecialMaterial(string specialMaterial)
        {
            Console.WriteLine("The Special material " + specialMaterial + " for " + GetType().Name + " has been added");
        }

        //My get Ready method.
        public void GetSoupReady()
        {
            AddMaterials();
            CookSoup();

            Console.WriteLine(GetType().Name + " is ready... Enjoooy :)");
            Console.WriteLine("-----------------------------" + Environment.NewLine);
        }
    }
}
