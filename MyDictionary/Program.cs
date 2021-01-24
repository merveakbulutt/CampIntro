using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> adYas = new MyDictionary<string,int>();
            adYas.Add("Gözde",20);
            adYas.Add("Merve",23);
            adYas.Add("Ali",25);

            adYas.GetAll();

        }
    }
}
