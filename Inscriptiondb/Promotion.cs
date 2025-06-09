using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscriptiondb
{
    internal class Promotion
    {
        int code;
        int option1;
        string designation;

        public int Code { get => code; set => code = value; }
        public int Option1 { get => option1; set => option1 = value; }
        public string Designation { get => designation; set => designation = value; }
    }
}
