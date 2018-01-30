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
        Timer buscador;
        //FunctionAccionSonido Accion;
        private List<Evento> Datos;
        public VericadorDeEventos(List<Evento> datos)
        {
            this.Datos = datos;
            buscador = new System.Timers.Timer();
            buscador.Interval = 1000;
            buscador.Elapsed += new System.Timers.ElapsedEventHandler(this.Buscar);
            buscador.Start();
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
            //aGENDA_DE_EVENTOBindingSource.List
            if ((Datos == null) || (Datos.LongCount() > 0))
                return;
            foreach (Evento h in Datos)
            {
                DateTime NowDate = DateTime.Now;
                DateTime enteredDate = h.dateTimeField;
                if (TrimMilliseconds(enteredDate) == TrimMilliseconds(NowDate))
                {
                    Console.WriteLine("Ring Ring desde aca");
                    //Accion(h);
                }
            }

            //Console.WriteLine(DateTime.Now.ToLongTimeString());
        }

    }
}
