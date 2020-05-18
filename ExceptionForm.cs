using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOX_Generator
{
    public partial class ExceptionForm : Form
    {
        public ExceptionForm(string exc)
        {
            InitializeComponent();
            excPrint.ScrollBars = ScrollBars.Vertical;
            excPrint.ReadOnly = true;
            excPrint.Text = exc;
        }

        private void copyClick(object sender, EventArgs e)
        {
            Clipboard.SetText(excPrint.Text);
        }

        private void closeClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
