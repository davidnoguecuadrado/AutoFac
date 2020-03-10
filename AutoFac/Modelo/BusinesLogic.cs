using AutoFac.Modelo.Intefaces;
using System;


namespace AutoFac.Modelo
{
    public class BusinesLogic : IBusinesLogic
    {
        readonly IVendedor _vendedor;
        readonly ICliente _cliente;
        public BusinesLogic(IVendedor venderdor, ICliente cliente)
        {
            _vendedor = venderdor;
            _cliente = cliente;
        }
        public void ProcessData()
        {
            _cliente.setName("Juan");
            _cliente.getName();
            _vendedor.setPrecio(34);
            _vendedor.getPrecio();
            Console.ReadLine();
        }
    }
}
