using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colmeia_c_Mel
{
    public partial class Form1 : Form
    {
        Worker[] workers = new Worker[4];
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            workers[0] = new Worker(158, new string[] 
            { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(145, new string[]
            { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(160, new string[]
            { "Hive maintenance", "Sting patrol" } );
            workers[3] = new Worker( 195,new string[]
            { "Nectar collector", "Honey manufacturing",
                "Hive maintenance", "Sting patrol",
                "Egg care", "Baby bee tutoring" });

            queen = new Queen(workers);

        }

        private void BntAssing_Click(object sender, EventArgs e)
        {
            if (queen.AssisgnWork(CoBoxtarefas.Text, (int)NumberShift.Value) == false)
            {
                MessageBox.Show("No workers are available to do the job"
                    + CoBoxtarefas.Text+ " The Queen says...");
            }
            else
            {
                MessageBox.Show("The Job " + CoBoxtarefas.Text +
                    "will be done in " + NumberShift.Value + " The Queen says...");
            }
        }

        private void BntWork_Click(object sender, EventArgs e)
        {
            TxReport.Text = queen.WorkTheNextShift();
            texBTotalMel.Text = queen.TotalQueen.ToString();
        }
    }
}
