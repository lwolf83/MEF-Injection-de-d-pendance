using System.ComponentModel.Composition.Hosting;
using System;

namespace MusicApp
{
    class Program
    {
        private MefHost _host;

        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }

        private void Run()
        {
            _host = new MefHost();
            _host.Container.GetExportedValue<HelloSayer>().SayHello();
        }
    }

    internal class MefHost
    {
        public CompositionContainer Container
        {
            get
            {
                if (_container == null)
                {
                    var catalog = new DirectoryCatalog(".", "MusicApp.*");
                    _container = new CompositionContainer(catalog);
                }
                return _container;
            }
        }
        private CompositionContainer _container = null;
    }
}