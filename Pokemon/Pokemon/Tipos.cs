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
    public partial class Tipos : Form
    {
        DBConnection ConnectionTemp;
        public Tipos(DBConnection Connection)
        {
            ConnectionTemp = Connection;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Tabla = new Form1();
            ConnectionTemp.SelectQuery("INSERT INTO Tipos VALUES(NULL, '" + textBox1.Text + "' )");
            this.Hide();
            Tabla.Show();
        }
    }
}
