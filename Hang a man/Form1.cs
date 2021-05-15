using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hang_a_man
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameLogic.WinGame = false;
            GameLogic.CountChances = 0;

            MessageBox.Show(GameLogic.CountChances.ToString(), "Message");
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
