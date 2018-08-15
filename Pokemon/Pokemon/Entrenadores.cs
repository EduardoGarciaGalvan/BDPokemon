using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Entrenadores : Form
    {
        DBConnection ConnectionTemp;
        public Entrenadores(DBConnection Connection)
        {
            ConnectionTemp = Connection;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Tabla = new Form1();
            ConnectionTemp.SelectQuery("INSERT INTO entrenadores VALUES(NULL, '" + textBox1.Text + "', " + numericUpDown1.Value + ", " + numericUpDown2.Value + " )");
            this.Hide();
            Tabla.Show();
        }
    }
}
