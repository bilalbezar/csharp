using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Message Clicked" );
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose( true );
        }

        private void aboutVPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "This is VP Course" );
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Tool Item New Clicked" );
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
