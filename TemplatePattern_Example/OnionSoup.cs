/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 20.06.2020
*/

using System;

namespace TemplatePattern_Example
{
    class OnionSoup : Soup
    {
        public override void AddMaterials()
        {
            Console.WriteLine("Adding Materials for Onion Soup...");
        }

        public override void CookSoup()
        {
            Console.WriteLine("Onion Soup is cooking...");
        }
    }
}
