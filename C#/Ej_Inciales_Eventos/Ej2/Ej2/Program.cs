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

        // Nueva clase receptora: gestor de facturación
        public class GestorDeFacturacion
        {
            // Método que se ejecutará cuando el evento se dispare
            public void EmitirFactura(object sender, TransaccionEventArgs e)
            {
                Console.WriteLine($"La factura correspondiente a la transacción {e.transaccion.identificador} fue emitida con fecha {e.transaccion.fechaTransaccion}.");
            }
        }

        // Método principal
        public static void Main()
        {
            // TO DO: Crear instancia de la pasarela de pago
            PasarelaDePago pasarela = new PasarelaDePago();

            // TO DO: Crear instancia del gestor de email
            GestorEmail gestorEmail = new GestorEmail();

            // TO DO: Crear instancia del gestor de facturación
            GestorDeFacturacion gestorFacturacion = new GestorDeFacturacion();

            // TO DO: Asociar el evento TransaccionFinalizada con ambos métodos receptores
            pasarela.TransaccionFinalizada += gestorEmail.EnviarEmail;
            pasarela.TransaccionFinalizada += gestorFacturacion.EmitirFactura;

            // TO DO: Crear una transacción de prueba
            Transaccion transaccion = new Transaccion()
            {
                identificador = 71645331,
                fechaTransaccion = "30/06/2010"
            };

            // TO DO: Procesar el pago (esto disparará el evento y ejecutará ambos métodos)
            pasarela.Pago(transaccion);

            Console.WriteLine("\nFin del programa.");
        }
    }
}
