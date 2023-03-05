using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{

    public partial class GG : Form
    {
        List<Player> list = new List<Player>();
        public GG()
        {
            InitializeComponent();
            dataGridView1.DataSource = list;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formInfo = new Form1();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK)
            {
                Player newPlayer = formInfo.getPlayer();
                //Add new Player to List
                this.list.Add(newPlayer);

                this.dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
                //Add list to Ditagrid view
                formInfo.Close();
            }
        }
    }
}
