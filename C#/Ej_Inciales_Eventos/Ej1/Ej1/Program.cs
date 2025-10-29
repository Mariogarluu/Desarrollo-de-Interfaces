using System;
using System.Threading;

namespace Coding.Exercise
{
    public class Exercise
    {
        // Clase de transacción con sus atributos
        public class Transaccion
        {
            public int identificador { get; set; }
            public string fechaTransaccion { get; set; }
        }

        // EventArgs personalizado para un evento de transacción
        public class TransaccionEventArgs : EventArgs
        {
            public Transaccion transaccion { get; set; }
        }

        // Clase para la gestión de pagos (Pasarela)
        public class PasarelaDePago
        {
            // Evento de fin de transacción
            public event EventHandler<TransaccionEventArgs> TransaccionFinalizada;

            // Método que dispara el evento de fin de transacción
            protected virtual void EnTransaccionFinalizada(Transaccion transaccion_)
            {
                if (TransaccionFinalizada != null)
                    TransaccionFinalizada(this, new TransaccionEventArgs() { transaccion = transaccion_ });
            }

            // Método que procesa el pago mediante una transacción
            public void Pago(Transaccion transaccion_)
            {
                Console.WriteLine("Procesando transacción de pago...");
                Thread.Sleep(2000);

                // Pago aprobado y fin de transacción
                EnTransaccionFinalizada(transaccion_);
            }
        }

        // Clase receptora: gestor de emails
        public class GestorEmail
        {
            // Método que se ejecutará cuando el evento se dispare
            public void EnviarEmail(object sender, TransaccionEventArgs e)
            {
                Console.WriteLine($"Email enviado: Transacción {e.transaccion.identificador} procesada correctamente el {e.transaccion.fechaTransaccion}");
            }
        }

        // Método principal
        public static void Main()
        {
            // TO DO: Crear instancia de la pasarela de pago
            PasarelaDePago pasarela = new PasarelaDePago();

            // TO DO: Crear instancia del gestor de email
            GestorEmail gestor = new GestorEmail();

            // TO DO: Asociar el evento TransaccionFinalizada con el método EnviarEmail del gestor
            pasarela.TransaccionFinalizada += gestor.EnviarEmail;

            // TO DO: Crear una transacción de prueba
            Transaccion transaccion = new Transaccion()
            {
                identificador = 12345,
                fechaTransaccion = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            };

            // TO DO: Procesar el pago (esto disparará el evento)
            pasarela.Pago(transaccion);

            Console.WriteLine("Fin del programa.");
        }
    }
}
