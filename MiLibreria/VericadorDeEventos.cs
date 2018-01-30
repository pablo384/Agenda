using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MiLibreria;
using primeraAplicacion;

namespace MiLibreria
{
    public class VericadorDeEventos
    {
        private SoundPlayer Player = new SoundPlayer();
        private System.Timers.Timer buscador;
        //FunctionAccionSonido Accion;
        private List<Evento> Datos;
        public VericadorDeEventos()
        {
            this.Player.LoadCompleted += new AsyncCompletedEventHandler(Player_LoadCompleted);
        }

        public void startTimer(List<Evento> datos)
        {
            this.Datos = datos;
            this.buscador = new System.Timers.Timer();
            this.buscador.Interval = 1000;
            this.buscador.Elapsed += new System.Timers.ElapsedEventHandler(this.Buscar);
            this.buscador.Start();
        }
        public List<Evento> setDatos {
            
            set { this.Datos.RemoveAll(dato => dato.dateTimeField.ToString().EndsWith("0")); this.Datos.AddRange(value); }
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
            //Console.WriteLine("paso un clic");
            foreach (Evento h in Datos)
            {
                DateTime NowDate = DateTime.Now;
                DateTime enteredDate = h.dateTimeField;
                if (TrimMilliseconds(enteredDate) == TrimMilliseconds(NowDate))
                {
                    Console.WriteLine("Ring Ring desde aca");
                    this.Soonar(h.songField);
                    //Accion(h);
                }
            }

            //Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
        private void Soonar (int song)
        {
            this.LoadAsyncSound(song);            
        }

        public void LoadAsyncSound(int song)
        {
            try
            {
                // Replace this file name with a valid file name.
                if (song == 1)
                {
                    this.Player.SoundLocation = @"c:\Windows\Media\Alarm01.wav";
                }
                else
                {
                    this.Player.SoundLocation = @"c:\Windows\Media\Alarm02.wav";
                }
                
                this.Player.LoadAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading sound");
            }
        }

        // This is the event handler for the LoadCompleted event.
        void Player_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (Player.IsLoadCompleted)
            {
                try
                {
                    this.Player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error playing sound");
                }
            }
        }

    }
}
