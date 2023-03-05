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
        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formInfo = new Form1();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK)
            {
                Player newPlayer = formInfo.getPlayer();
                //Add new Player to List
                this.list.Add(newPlayer);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = list;

                //Add list to Ditagrid view
                formInfo.Close();
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Player item in list)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6}",
                            item.Name,
                            item.LastName,
                            item.Major,
                            item.Studentid,
                            item.Mail,
                            item.Phone,                            
                            item.Age));
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Player selectPlayer = (Player)row.DataBoundItem;

                this.tbN.Text = selectPlayer.Name;
            }
        }
    }
}
