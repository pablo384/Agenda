using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeraAplicacion
{
    public partial class Eventos_guardados : Form
    {
        public Eventos_guardados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Eventos_guardados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSet.evento' Puede moverla o quitarla según sea necesario.
            this.eventoTableAdapter.Fill(this.agendaDataSet.evento);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
