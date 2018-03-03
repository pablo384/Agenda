using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace primeraAplicacion
{
    public partial class Form1 : Form
    {
        
        private VericadorDeEventos verificador;
        public Form1()
        {
            InitializeComponent();
            List<Evento> misEventos = Utilidades.EjecutarSelectAll("Select * From EVENTOS");
            verificador = new VericadorDeEventos();
            verificador.startTimer(misEventos);

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
        public string repeatpicker()
        {
            string days = "1";
            if (checkMONDAY.Checked){days += "1";}else{ days += "0"; }
            if (checkTUESDAY.Checked) { days += "1"; } else { days += "0"; }
            if (checkWEDNESDAY.Checked) { days += "1"; } else { days += "0"; }
            if (checkTHURSDAY.Checked) { days += "1"; } else { days += "0"; }
            if (checkFRIDAY.Checked) { days += "1"; } else { days += "0"; }
            if (checkSATURDAY.Checked) { days += "1"; } else { days += "0"; }
            if (checkSUNDAY.Checked) { days += "1"; } else { days += "0"; }
            return days;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            repeatpicker();
            Console.WriteLine(this.textTitle.Text);
            string format = "yyyy-MM-dd HH:mm:ss";
            Console.WriteLine(this.datePicker.Value.ToString(format));
            Console.WriteLine(this.dateHourPicker.Text.Split(':')[0]);
            try{
                TimeSpan ts = new TimeSpan(Convert.ToInt16(this.dateHourPicker.Text.Split(':')[0]), Convert.ToInt16(this.dateHourPicker.Text.Split(':')[1]), Convert.ToInt16(this.dateHourPicker.Text.Split(':')[2]));
                Console.WriteLine(this.datePicker.Value.Date + ts);
                string query = "insert into EVENTOS (dateEvent, name,description,repeat, song) values ('" + (this.datePicker.Value.Date + ts).ToString(format) + "','" + this.textTitle.Text + "','" + this.tbdescription.Text + "','" + repeatpicker() + "',"+Convert.ToInt16(this.songSelected.Text) +")";
                Console.WriteLine("se guardara esto " + (this.datePicker.Value.Date + ts).ToString(format));
                try
                {
                    Utilidades.EjecutarInsert(query);
                    MessageBox.Show("Evento guardado");
                    try
                    {
                        List<Evento> misEventos = Utilidades.EjecutarSelectAll("select * from EVENTOS");
                         this.verificador.setDatos = misEventos;
                    } catch (Exception)
                    {
                        MessageBox.Show("Error poniendo a la escucha");
                    }
                    
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
            
            EventosGuardados even = new EventosGuardados();
            even.Show();
            /*foreach (Evento item in misEventos)
            {
                Console.WriteLine("Mis eventos " + item.nameField);
            }*/
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoundPlayer Player = new SoundPlayer();
            VericadorDeEventos refs = new VericadorDeEventos();
            refs.LoadAsyncSound(this.songSelected.SelectedIndex);
            Player.Play();
            Console.WriteLine(this.songSelected.Text);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            MessageBox.Show("Creado y desarrollado por: \n Pablo Reinoso (pablo384) 2016-1357 \n Cristian Mejia 2016-");
        }

        private void textTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkMONDAY_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
