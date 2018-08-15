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
    public partial class Pokemones : Form
    {
        DBConnection ConnectionTemp;
        public Pokemones(DBConnection Connection)
        {
            ConnectionTemp = Connection;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionTemp.SelectQuery("INSERT INTO pokemones VALUES(NULL, '" + textBox1.Text + "',"
                + numericUpDown1.Value + ", "
                + numericUpDown2.Value + ", '"
                + textBox2.Text + "', '"
                + textBox3.Text + "', '"
                + textBox4.Text + "', '"
                + textBox5.Text + "', '"
                + textBox6.Text + "', '"
                + textBox7.Text + "', '"
                + textBox8.Text + "') ");
            Form1 Tabla = new Form1();
            this.Hide();
            Tabla.Show();

        }
    }
}
