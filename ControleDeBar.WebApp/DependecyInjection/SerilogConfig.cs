using Serilog.Events;
using Serilog;

namespace ControleDeBar.WebApp.DependecyInjection
{
    public static class SerilogConfig
    {
        public static void AddSerilogConfig(this IServiceCollection services, ILoggingBuilder logging)
        {
            var caminhoAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var caminhoArquivoLogs = Path.Combine(caminhoAppData, "ControleDeBar", "logs.txt");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File(caminhoArquivoLogs, LogEventLevel.Error)
                .CreateLogger();

            logging.ClearProviders();
            services.AddSerilog();
        }

    }
}
