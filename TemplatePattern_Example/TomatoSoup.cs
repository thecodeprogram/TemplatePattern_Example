/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 20.06.2020
*/

using System;

namespace TemplatePattern_Example
{
    class TomatoSoup : Soup
    {
        public override void AddMaterials()
        {
            Console.WriteLine("Adding Essential Materials for Tomato Soup...");
        }

        public override void CookSoup()
        {
            Console.WriteLine("Tomato Soup is cooking...");
        }
    }
}
