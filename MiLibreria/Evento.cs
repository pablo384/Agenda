using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraAplicacion
{
    public class Evento
    {
        private int id;
        private DateTime dateTime;
        private string name;
        private int song;

        public Evento(int id, DateTime dateTime, string name, int song)
        {
            this.id = id;
            this.dateTime = dateTime;
            this.name = name;
            this.song = song;
        }

        public int idField
        {
            get => this.id;
        }
        public DateTime dateTimeField
        {
            get => this.dateTime;
        }
        public string nameField
        {
            get => this.name;
        }
        public int songField
        {
            get => this.song;
        }

    }
}
