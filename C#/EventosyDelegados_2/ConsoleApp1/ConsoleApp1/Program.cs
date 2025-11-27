using System;
using System.Collections.Generic;

#region Ejercicio 1 - Producción
public class ProduccionEventArgs : EventArgs
{
    public string Producto { get; }
    public TimeSpan Duracion { get; }

    public ProduccionEventArgs(string producto, TimeSpan duracion)
    {
        Producto = producto;
        Duracion = duracion;
    }
}

public class ProcesoProduccion
{
    public event EventHandler<ProduccionEventArgs> ProduccionCompletada;

    public void IniciarProduccion(string producto, int segundos)
    {
        TimeSpan tiempo = TimeSpan.FromSeconds(segundos);
        Console.WriteLine($"Produciendo {producto}...");
        System.Threading.Thread.Sleep(segundos * 200); // Simulación
        ProduccionCompletada?.Invoke(this, new ProduccionEventArgs(producto, tiempo));
    }
}

public class ServicioNotificacion
{
    public void EnviarNotificacion(object sender, ProduccionEventArgs e)
    {
        Console.WriteLine($"📢 Producción completada: {e.Producto} en {e.Duracion.TotalSeconds} segundos");
    }
}

public class ServicioRegistroProduccion
{
    public void RegistrarProduccion(object sender, ProduccionEventArgs e)
    {
        Console.WriteLine($"📝 Registro guardado: {e.Producto} - Duración {e.Duracion}");
    }
}
#endregion

#region Ejercicio 2 - Streaming
public class TransmisionEventArgs : EventArgs
{
    public string Titulo { get; }
    public TimeSpan Duracion { get; }

    public TransmisionEventArgs(string titulo, TimeSpan duracion)
    {
        Titulo = titulo;
        Duracion = duracion;
    }
}

public class ControlTransmision
{
    public event EventHandler<TransmisionEventArgs> TransmisionFinalizada;

    public void FinalizarTransmision(string titulo, int minutos)
    {
        TransmisionFinalizada?.Invoke(this, new TransmisionEventArgs(titulo, TimeSpan.FromMinutes(minutos)));
    }
}

public class ServicioNotificacionUsuario
{
    public void Notificar(object sender, TransmisionEventArgs e)
    {
        Console.WriteLine($"🎥 Transmisión '{e.Titulo}' finalizada tras {e.Duracion.TotalMinutes} minutos.");
    }
}

public class ServicioRegistroEventos
{
    public void Registrar(object sender, TransmisionEventArgs e)
    {
        Console.WriteLine($"🗂 Evento registrado: {e.Titulo} - Duración {e.Duracion}");
    }
}
#endregion

#region Ejercicio 3 - Restaurante
public class PedidoEventArgs : EventArgs
{
    public string Cliente { get; }
    public string Detalles { get; }

    public PedidoEventArgs(string cliente, string detalles)
    {
        Cliente = cliente;
        Detalles = detalles;
    }
}

public class GestorPedidos
{
    public event EventHandler<PedidoEventArgs> PedidoConfirmado;

    public void ConfirmarPedido(string cliente, string detalles)
    {
        PedidoConfirmado?.Invoke(this, new PedidoEventArgs(cliente, detalles));
    }
}

public class ServicioCocina
{
    public void PrepararPedido(object sender, PedidoEventArgs e)
    {
        Console.WriteLine($"👨‍🍳 Pedido recibido: {e.Cliente} - {e.Detalles}");
    }
}

public class ServicioNotificacionCliente
{
    public void NotificarPedido(object sender, PedidoEventArgs e)
    {
        Console.WriteLine($"📲 Notificación enviada a {e.Cliente}: pedido confirmado ({e.Detalles})");
    }
}
#endregion

#region Ejercicio 4 - Stock
public class StockEventArgs : EventArgs
{
    public string Producto { get; }
    public int Nivel { get; }

    public StockEventArgs(string producto, int nivel)
    {
        Producto = producto;
        Nivel = nivel;
    }
}

public class ControlStock
{
    public event EventHandler<StockEventArgs> StockBajo;

    public void VerificarStock(string producto, int nivel)
    {
        if (nivel < 5)
            StockBajo?.Invoke(this, new StockEventArgs(producto, nivel));
    }
}

public class ServicioPedidoReposicion
{
    public void GenerarPedido(object sender, StockEventArgs e)
    {
        Console.WriteLine($"📦 Pedido de reposición generado para {e.Producto} (nivel {e.Nivel})");
    }
}

public class ServicioAlertaStock
{
    public void EnviarAlerta(object sender, StockEventArgs e)
    {
        Console.WriteLine($"⚠️ Alerta: {e.Producto} con nivel crítico ({e.Nivel})");
    }
}
#endregion

#region Ejercicio 5 - Reservas
public class ReservaEventArgs : EventArgs
{
    public string Cliente { get; }
    public string Habitacion { get; }
    public DateTime Entrada { get; }
    public DateTime Salida { get; }

    public ReservaEventArgs(string cliente, string habitacion, DateTime entrada, DateTime salida)
    {
        Cliente = cliente;
        Habitacion = habitacion;
        Entrada = entrada;
        Salida = salida;
    }
}

public class GestorReservas
{
    public event EventHandler<ReservaEventArgs> ReservaConfirmada;

    public void ConfirmarReserva(string cliente, string habitacion, DateTime entrada, DateTime salida)
    {
        ReservaConfirmada?.Invoke(this, new ReservaEventArgs(cliente, habitacion, entrada, salida));
    }
}

public class ServicioLimpieza
{
    public void ProgramarLimpieza(object sender, ReservaEventArgs e)
    {
        Console.WriteLine($"🧹 Limpieza programada para {e.Habitacion} (entrada {e.Entrada:d})");
    }
}

public class ServicioNotificacionReservas
{
    public void NotificarReserva(object sender, ReservaEventArgs e)
    {
        Console.WriteLine($"📲 Notificación enviada a {e.Cliente}: reserva confirmada en {e.Habitacion} ({e.Entrada:d} - {e.Salida:d})");
    }
}
#endregion

#region Ejercicio 6 - Incidencias
public class IncidenciaEventArgs : EventArgs
{
    public int Id { get; }
    public string Cliente { get; }
    public string Descripcion { get; }

    public IncidenciaEventArgs(int id, string cliente, string descripcion)
    {
        Id = id;
        Cliente = cliente;
        Descripcion = descripcion;
    }
}

public class GestorIncidencias
{
    public event EventHandler<IncidenciaEventArgs> IncidenciaReportada;
    private string[] tecnicos = { "Carlos", "María", "Lucía", "Javier" };
    private Random random = new Random();

    public void ReportarIncidencia(int id, string cliente, string descripcion)
    {
        IncidenciaReportada?.Invoke(this, new IncidenciaEventArgs(id, cliente, descripcion));
        string tecnico = tecnicos[random.Next(tecnicos.Length)];
        Console.WriteLine($"🔧 Técnico asignado: {tecnico}");
    }
}

public class ServicioRegistroIncidencias
{
    public void Registrar(object sender, IncidenciaEventArgs e)
    {
        Console.WriteLine($"📋 Incidencia #{e.Id} registrada: {e.Cliente} - {e.Descripcion}");
    }
}

public class ServicioNotificacionIncidencia
{
    public void NotificarCliente(object sender, IncidenciaEventArgs e)
    {
        Console.WriteLine($"📩 Cliente {e.Cliente} notificado sobre su incidencia #{e.Id}");
    }
}
#endregion

#region Main - Menú
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== MENÚ DE EVENTOS =====");
            Console.WriteLine("1. Producción");
            Console.WriteLine("2. Streaming");
            Console.WriteLine("3. Restaurante");
            Console.WriteLine("4. Stock");
            Console.WriteLine("5. Reservas");
            Console.WriteLine("6. Incidencias");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    var produccion = new ProcesoProduccion();
                    var notif = new ServicioNotificacion();
                    var regProd = new ServicioRegistroProduccion();
                    produccion.ProduccionCompletada += notif.EnviarNotificacion;
                    produccion.ProduccionCompletada += regProd.RegistrarProduccion;
                    produccion.IniciarProduccion("Coche", 3);
                    break;

                case "2":
                    var control = new ControlTransmision();
                    var notifUsr = new ServicioNotificacionUsuario();
                    var regEvt = new ServicioRegistroEventos();
                    control.TransmisionFinalizada += notifUsr.Notificar;
                    control.TransmisionFinalizada += regEvt.Registrar;
                    control.FinalizarTransmision("Concierto en vivo", 45);
                    break;

                case "3":
                    var gestorPedidos = new GestorPedidos();
                    var cocina = new ServicioCocina();
                    var notifCli = new ServicioNotificacionCliente();
                    gestorPedidos.PedidoConfirmado += cocina.PrepararPedido;
                    gestorPedidos.PedidoConfirmado += notifCli.NotificarPedido;
                    gestorPedidos.ConfirmarPedido("Mario", "Pizza y refresco");
                    break;

                case "4":
                    var controlStock = new ControlStock();
                    var pedidoRepo = new ServicioPedidoReposicion();
                    var alerta = new ServicioAlertaStock();
                    controlStock.StockBajo += pedidoRepo.GenerarPedido;
                    controlStock.StockBajo += alerta.EnviarAlerta;
                    controlStock.VerificarStock("Monitores", 3);
                    break;

                case "5":
                    var reservas = new GestorReservas();
                    var limpieza = new ServicioLimpieza();
                    var notifRes = new ServicioNotificacionReservas();
                    reservas.ReservaConfirmada += limpieza.ProgramarLimpieza;
                    reservas.ReservaConfirmada += notifRes.NotificarReserva;
                    reservas.ConfirmarReserva("Ana", "Suite Deluxe",
                        DateTime.Now.AddDays(2), DateTime.Now.AddDays(5));
                    break;

                case "6":
                    var gestorIncidencias = new GestorIncidencias();
                    var notifInci = new ServicioNotificacionIncidencia();
                    var registroInci = new ServicioRegistroIncidencias();
                    gestorIncidencias.IncidenciaReportada += notifInci.NotificarCliente;
                    gestorIncidencias.IncidenciaReportada += registroInci.Registrar;
                    gestorIncidencias.ReportarIncidencia(1001, "Laura", "Problema con la conexión");
                    break;

                case "0":
                    return;
            }
        }
    }
}
#endregion
