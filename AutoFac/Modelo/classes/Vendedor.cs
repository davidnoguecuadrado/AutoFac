using AutoFac.Modelo.Intefaces;
using System;


namespace AutoFac.Modelo.classes
{
    class Vendedor : IVendedor
    {
        int precio { get; set; }
        public void getPrecio()
        {
            Console.WriteLine($"El precio es { precio }");
        }

        public void setPrecio(int Precio)
        {
            precio = Precio;
        }
    }
}
