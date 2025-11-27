using System;
using System.IO;
using System.Threading;

namespace ej3
{
        /*
         * Implementa un sistema que gestione la creación de copias de seguridad. La clase
         * GestorBackups debe emitir el evento BackupCompletado cuando un archivo se haya
         * respaldado. BackupEventArgs incluye el nombre del archivo y la fecha. Crea
         * ServicioNotificacion para enviar una notificación y ServicioLog para registrar la
         * operación de respaldo
         */

    // Argumentos del evento con nombre del archivo y fecha
    public class BackupEventArgs : EventArgs
    {
        public string NombreArchivo { get; }
        public DateTime Fecha { get; }

        public BackupEventArgs(string nombreArchivo, DateTime fecha)
        {
            NombreArchivo = nombreArchivo;
            Fecha = fecha;
        }
    }

    // Gestor que realiza backups y emite el evento cuando se completa uno
    public class GestorBackups
    {
        // Evento que notifica cuando un backup ha terminado
        public event EventHandler<BackupEventArgs> BackupCompletado;

        // Simula o realiza la operación de backup
        public void RealizarBackup(string nombreArchivo)
        {
            // Simulación: crear carpeta Backups y un archivo que representa la copia
            try
            {
                Directory.CreateDirectory("Backups");
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string backupName = $"{Path.GetFileName(nombreArchivo)}.{timestamp}.bak";
                string backupPath = Path.Combine("Backups", backupName);

                // Escritura de un archivo simulado como copia de seguridad
                File.WriteAllText(backupPath, $"Copia de seguridad de '{nombreArchivo}' realizada el {DateTime.Now:O}");

                // Simular tiempo de proceso
                Thread.Sleep(300);

                // Disparar evento
                OnBackupCompletado(new BackupEventArgs(nombreArchivo, DateTime.Now));
            }
            catch (Exception ex)
            {
                // En un caso real, manejar errores (log, reintento, etc.)
                Console.WriteLine($"Error al realizar backup de '{nombreArchivo}': {ex.Message}");
            }
        }

        protected virtual void OnBackupCompletado(BackupEventArgs e)
        {
            BackupCompletado?.Invoke(this, e);
        }
    }

    // Servicio que muestra una notificación (por consola en este ejemplo)
    public class ServicioNotificacion
    {
        public void OnBackupCompletado(object sender, BackupEventArgs e)
        {
            Console.WriteLine($"[Notificación] El archivo '{e.NombreArchivo}' se respaldó correctamente en {e.Fecha:yyyy-MM-dd HH:mm:ss}.");
        }
    }

    // Servicio que registra la operación de respaldo en un fichero de log
    public class ServicioLog
    {
        private readonly string _rutaLog;

        public ServicioLog(string rutaLog = "backup.log")
        {
            _rutaLog = rutaLog;
        }

        public void OnBackupCompletado(object sender, BackupEventArgs e)
        {
            string linea = $"{e.Fecha:O} | Backup completado | Archivo: {e.NombreArchivo}";
            try
            {
                File.AppendAllText(_rutaLog, linea + Environment.NewLine);
            }
            catch (Exception)
            {
                // En un escenario real se trataría la excepción (p. ej. fallback)
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var gestor = new GestorBackups();
            var notificador = new ServicioNotificacion();
            var logger = new ServicioLog("backup.log");

            // Suscribir servicios al evento
            gestor.BackupCompletado += notificador.OnBackupCompletado;
            gestor.BackupCompletado += logger.OnBackupCompletado;

            // Ejemplo: realizar varios backups
            string[] archivos = { "documento.txt", "imagen.png", "basedatos.db" };

            foreach (var archivo in archivos)
            {
                gestor.RealizarBackup(archivo);
            }

            Console.WriteLine("Operaciones de backup finalizadas. Pulsa Enter para salir.");
            Console.ReadLine();
        }
    }
}
