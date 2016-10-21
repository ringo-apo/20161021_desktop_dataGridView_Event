using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public event DataGridViewCellEventHandler CellContentClick;
//        this.DataGridView1_CellContentClick += new System.EventHandler(this.DataGridView1_CellContentClick);

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            MessageBox.Show("セルがクリックされました1");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("セルがクリックされました2");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("セルがクリックされました3");
        }    
    }
}
