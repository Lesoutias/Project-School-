using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscriptiondb
{
    public partial class FrmInscription : Form
    {
        public FrmInscription()
        {
            InitializeComponent();
        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {
            string[] AnneeAcad = { "2023-2024", "2024-2025", "2025-2026" };
            cmbAnneeAcad.Items.AddRange(AnneeAcad);
        }
    }
}
