/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 20.06.2020
*/

using System;

namespace TemplatePattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Template Design Pattern Example - Thecodeprogram";

            TomatoSoup tomSoup = new TomatoSoup();
            tomSoup.GetSoupReady();

            ChickenSoup chickSoup = new ChickenSoup();
            chickSoup.GetSoupReady();

            EzoGelinSoup ezoSoup = new EzoGelinSoup();
            ezoSoup.GetSoupReady();

            OnionSoup onionSoup = new OnionSoup();
            onionSoup.GetSoupReady();

            Console.ReadLine();
        }
    }
}
