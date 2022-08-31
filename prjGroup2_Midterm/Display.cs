using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjGroup2_Midterm
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            Modify m = new Modify();
            m.Show();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {

        }
    }
}
