using System;

namespace AutoFac.Modelo.classes
{
    class Cliente : ICliente
    {
        String Name { get; set;}

        public void setName(string name) {
            Name = name;
        }
        public void getName(){
            Console.WriteLine(Name);
        }


    }
}
