using HashiCorp.Cdktf;
using System;
using System.IO;

namespace MyCompany.MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            AppOptions options = new AppOptions()
            {
                Outdir = Path.Join(Environment.ExpandEnvironmentVariables(@"%TEMP%"), "outdir.out")
            };
            Console.WriteLine($" - AppOptions.Outdir: {options.Outdir}");
            App app = new App(options);
            Console.WriteLine($" - App.Outdir: {app.Outdir}");
            new MainStack(app, "outdir-test");
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}