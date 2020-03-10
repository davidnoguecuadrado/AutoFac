using AutoFac.Modelo;

namespace AutoFac
{
    public class Aplication : IAplication
    {
        readonly IBusinesLogic _businesLogic;
        public Aplication(IBusinesLogic businesLogic)
        {
            _businesLogic = businesLogic;
        }

        public void Run()
        {
            _businesLogic.ProcessData();
        }
    }
}
