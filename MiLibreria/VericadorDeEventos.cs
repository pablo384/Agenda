using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using MiLibreria;
using primeraAplicacion;

namespace MiLibreria
{
   
    public class VericadorDeEventos
    {
        int weeks;
        string[] today;
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
            
            set { /*this.Datos.RemoveAll(dato => dato.repeatField.ToString().StartsWith("1")); this.Datos.AddRange(value); */this.Datos.RemoveAll(dato => dato.dateTimeField.ToString().StartsWith("1")); this.Datos.AddRange(value); }
        }
        /*public void setAccion(FunctionAccionSonido Accion)
        {
            this.Accion = Accion;
        }*/
        public DateTime TrimMilliseconds(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0);
        }
        public DateTime TrimTime(DateTime dt)
        {
            return new DateTime(dt.Hour, dt.Minute, dt.Second);
        }
        public void week()
        {
            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Monday : weeks = 1; break;
                case DayOfWeek.Tuesday: weeks = 2; break;
                case DayOfWeek.Wednesday: weeks = 3; break;
                case DayOfWeek.Thursday: weeks = 4; break;
                case DayOfWeek.Friday: weeks = 5; break;
                case DayOfWeek.Saturday: weeks = 6; break;
                case DayOfWeek.Sunday: weeks = 7; break;
            }


            //ahora vas a llenar un array para comparar ok
            foreach (Evento h in Datos)
            {
                string cadena = h.repeatField.ToString();
                int x = -1;
                today = new string[8];
                foreach (char element in cadena)
                {
                    x += 1;
                    today[x] = Convert.ToString( element);
                }

            }

        }
        public void Buscar(object sender, EventArgs e)
        {
            week();
            //Console.WriteLine("paso un clic");
            foreach (Evento h in Datos)
            {
                DateTime NowDate = DateTime.Now;
                DateTime enteredDate = h.dateTimeField;
                string query = "DELETE FROM EVENTOS WHERE ID = " + h.idField + "";

                if (TrimMilliseconds(enteredDate) == TrimMilliseconds(NowDate))
                {
                    Console.WriteLine("Ring Ring desde aca");
                    this.Soonar(h.songField);
                    
                    // MessageBox.Show("");//aqui tienes que reemplazar esto por el cuadro de aplazar evento.
                    //using (primeraAplicacion.alerta sd = new primeraAplicacion.alerta())
                    //  sd.Show();
                    DialogResult res = MessageBox.Show("Posponer?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                        );
                    if (res == DialogResult.Yes)
                    {
                        Console.WriteLine("Posponiendo");
                        enteredDate.AddMinutes(5);
                        string format = "yyyy-MM-dd HH:mm:ss";
                        Console.WriteLine("esto es la fecha: " + enteredDate.AddMinutes(5).ToString(format));
                        Utilidades.EjecutarInsert("UPDATE EVENTOS SET dateEvent = '" + enteredDate.AddMinutes(5).ToString(format)+"' WHERE Id="+ h.idField);
                      
                    }
                    else
                    {
                        Utilidades.EjecutarInsert(query);
                        Console.WriteLine("no pasa nada");
                    }
                    //Accion(h);
                }
                
                if (today[weeks] == "1" && TrimMilliseconds(enteredDate).Hour == TrimMilliseconds(NowDate).Hour && TrimMilliseconds(enteredDate).Minute == TrimMilliseconds(NowDate).Minute && TrimMilliseconds(enteredDate).Second == TrimMilliseconds(NowDate).Second)
                {
                    Console.WriteLine("Ring Ring desde aca");
                    this.Soonar(h.songField);
                    MessageBox.Show("Sonando");
                    
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
