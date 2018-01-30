using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace primeraAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine(this.textTitle.Text);
            string format = "yyyy-MM-dd HH:mm:ss";
            Console.WriteLine(this.datePicker.Value.ToString(format));
            Console.WriteLine(this.dateHourPicker.Text.Split(':')[0]);
            try{
                TimeSpan ts = new TimeSpan(Convert.ToInt16(this.dateHourPicker.Text.Split(':')[0]), Convert.ToInt16(this.dateHourPicker.Text.Split(':')[1]), Convert.ToInt16(this.dateHourPicker.Text.Split(':')[2]));
                Console.WriteLine(this.datePicker.Value.Date + ts);
                string query = "insert into evento (dateEvent, name) values ('" + this.datePicker.Value.ToString(format) + "','" + this.textTitle.Text + "')";
                try
                {
                    Utilidades.EjecutarInsert(query);
                    MessageBox.Show("Evento guardado");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en registro de evento");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca la hora correctamente");
            }            
            
            
        }

        private void btnEventView_Click(object sender, EventArgs e)
        {
            List<Evento> misEventos = Utilidades.EjecutarSelectAll("select * from evento");
            Eventos_guardados even = new Eventos_guardados();
            even.Show();
            /*foreach (Evento item in misEventos)
            {
                Console.WriteLine("Mis eventos " + item.nameField);
            }*/
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
