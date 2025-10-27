using System;
using System.Threading;

class Reloj
{
    public delegate void SegundoCambiadoHandler(object sender, EventArgs e);
    public event SegundoCambiadoHandler SegundoCambiado;

    public void Iniciar()
    {
        while (true)
        {
            Thread.Sleep(1000);
            OnSegundoCambiado();
        }
    }

    protected virtual void OnSegundoCambiado()
    {
        if (SegundoCambiado != null)
        {
            SegundoCambiado(this, EventArgs.Empty);
        }
    }
}

class Program
{
    static void Main()
    {
        Reloj reloj = new Reloj();
        reloj.SegundoCambiado += Reloj_SegundoCambiado;

        reloj.Iniciar();
    }

    static void Reloj_SegundoCambiado(object sender, EventArgs e)
    {
        Console.WriteLine("¡Ha pasado un segundo!");
    }
}
