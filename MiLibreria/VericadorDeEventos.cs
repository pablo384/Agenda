using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MiLibreria;
using primeraAplicacion;

namespace MiLibreria
{
    public class VericadorDeEventos
    {
        private Timer buscador;
        //FunctionAccionSonido Accion;
        private List<Evento> Datos;
        public VericadorDeEventos()
        {
            
        }

        public void startTimer(List<Evento> datos)
        {
            this.Datos = datos;
            this.buscador = new System.Timers.Timer();
            this.buscador.Interval = 1000;
            this.buscador.Elapsed += new System.Timers.ElapsedEventHandler(this.Buscar);
            this.buscador.Start();
        }

        /*public void setAccion(FunctionAccionSonido Accion)
        {
            this.Accion = Accion;
        }*/
        public DateTime TrimMilliseconds(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0);
        }


        public void Buscar(object sender, EventArgs e)
        {
            Console.WriteLine("paso un clic");
            foreach (Evento h in Datos)
            {
                DateTime NowDate = DateTime.Now;
                DateTime enteredDate = h.dateTimeField;
                if (TrimMilliseconds(enteredDate) == TrimMilliseconds(NowDate))
                {
                    Console.WriteLine("Ring Ring desde aca");
                    //Accion(h);
                }
                if (enteredDate == NowDate)
                {
                    Console.WriteLine("Ring Ring desde aca 2");
                    //Accion(h);
                }
            }

            //Console.WriteLine(DateTime.Now.ToLongTimeString());
        }

    }
}
