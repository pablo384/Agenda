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
    public partial class EventosGuardados : Form
    {
        public EventosGuardados()
        {
            InitializeComponent();
        }

        private void EventosGuardados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSetFinal.evento' Puede moverla o quitarla según sea necesario.
            this.eventoTableAdapter.Fill(this.agendaDataSetFinal.evento);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
