/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 20.06.2020
*/

using System;

namespace TemplatePattern_Example
{
    class ChickenSoup : Soup
    {
        public override void AddMaterials()
        {
            Console.WriteLine("Adding Essential Materials for Chicken Soup...");
            //I also add some other materials except the main materials
            AddSpecialMaterial("Delicious Chicken meat");
        }

        public override void CookSoup()
        {
            Console.WriteLine("Chicken Soup is cooking...");
        }
    }
}
