using log4net;
using System;
using System.Reflection;
using System.Threading;

namespace Log4NetConsole.Classic
{
    class Program
    {
        /// <summary>
        /// Instância para log4net.
        /// </summary>
        private static readonly ILog _log =
            LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            ImplementLoggingFuntion();
        }

        #region Métodos estáticos.

        /// <summary>
        /// Nós temos 5 níveis de mensagem de log:
        /// FATAL
        /// ERROR
        /// WARN
        /// INFO
        /// DEBUG
        /// </summary>
        private static void ImplementLoggingFuntion()
        {
            // Tempo em segundos.
            var seg = 3;
            _log.Fatal("Iniciar log FATAL...");
            Console.WriteLine("Iniciar log FATAL...");
            Thread.Sleep(TimeSpan.FromSeconds(seg));

            _log.Error("Iniciar log ERROR...");
            Console.WriteLine("Iniciar log ERROR...");
            Thread.Sleep(TimeSpan.FromSeconds(seg));

            _log.Warn("Iniciar log WARN...");
            Console.WriteLine("Iniciar log WARN...");
            Thread.Sleep(TimeSpan.FromSeconds(seg));

            _log.Info("Iniciar log INFO...");
            Console.WriteLine("Iniciar log INFO...");
            Thread.Sleep(TimeSpan.FromSeconds(seg));

            _log.Debug("Iniciar log DEBUG...");
            Console.WriteLine("Iniciar log DEBUG...");
            Thread.Sleep(TimeSpan.FromSeconds(seg));

            Console.WriteLine("Pressione qualquer tecla para fechar o aplicativo.");
            Console.ReadKey();
        }

        #endregion
    }
}
