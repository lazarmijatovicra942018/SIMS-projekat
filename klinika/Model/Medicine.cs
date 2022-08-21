using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klinika.Model
{
    internal class Medicine
    {
        private string id { get; set; }

        private string name { get; set; }

        private string passwor { get; set; }

        private string manufacture { get; set; }

        private IDictionary<string, Component> components { get; set; }

        private int count { get; set; }

        private bool verification { get; set; }

        public string isDeleted { get; set; }




    }
}
