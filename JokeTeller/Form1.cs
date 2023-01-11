using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeTeller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetUpBUT_Click(object sender, EventArgs e)
        {
            SetUpLB.Visible = SetUpLB.Visible? false : true;
        }

        private void PunchLineBUT_Click(object sender, EventArgs e)
        {
            PunchLineLB.Visible = PunchLineLB.Visible? false : true;
        }
    }
}
