using Autofac;
using static System.Console;

namespace _03.WithDependencyInjection
{
    public interface IReportingService
    {
        void Report();
    }

    public class ReportingService : IReportingService
    {
        public void Report()
        {
            WriteLine("Here is your report");
        }
    }

    public class ReportingServiceWithLog : IReportingService
    {
        private IReportingService decorated;

        public ReportingServiceWithLog(IReportingService decorated)
        {
            this.decorated = decorated;
        }

        public void Report()
        {
            WriteLine("Commencing log...");
            decorated.Report();
            WriteLine("Ending log...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var b = new ContainerBuilder();
            b.RegisterType<ReportingService>().Named<IReportingService>("reporting");
            b.RegisterDecorator<IReportingService>((context, service) 
                => new ReportingServiceWithLog(service), "reporting"
            );

            using(var c = b.Build())
            {
                var r = c.Resolve<IReportingService>();
                r.Report();
            }

            ReadKey();
        }
    }
}
