using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmFileName : Form
    {
        public FrmFileName()
        {
            InitializeComponent();
        }

        public static string SetFileName { get; internal set; }

        private void btnOkay_Click(object sender, EventArgs e)//btnOkay Functionality
        {
            SetFileName = txtFileName.Text+".txt";
            Close();

        }
    }
}
