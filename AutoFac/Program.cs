using Autofac;


namespace AutoFac
{
    class Program
    {
        static void Main(string[] args)
        {
            var containre = CointainerConfig.Configure();

            using (var scope = containre.BeginLifetimeScope()) 
            {
                var app = scope.Resolve<IAplication>();
                app.Run();
            }
        }
    }
}
