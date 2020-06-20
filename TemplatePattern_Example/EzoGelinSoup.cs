/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 20.06.2020
*/

using System;

namespace TemplatePattern_Example
{
    class EzoGelinSoup : Soup
    {
        public override void AddMaterials()
        {
            Console.WriteLine("Adding Materials for EzoGelin Soup...");
            //I also add some other materials except the main materials
            AddSpecialMaterial("Lentils");
        }

        public override void CookSoup()
        {
            Console.WriteLine("EzoGelin Soup is cooking...");
        }
    }
}
