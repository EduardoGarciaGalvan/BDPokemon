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
    public partial class Form1 : Form
    {
        DBConnection connection;
        bool entrenadores;
        bool pokemones;
        bool tipos;

        public Form1()
        {
            entrenadores = false;
            pokemones = false;
            tipos = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string errorMsg = string.Empty;
            connection = new DBConnection("138.68.20.16", "egarcia_pfinal", "egarcia", "1234567890");

            if (connection.Connect(ref errorMsg))
            {

            }
            else
            {
                MessageBox.Show("Conection Failure: " + errorMsg);
                Close();
            }
        }

    private void UpdateTable()
        {

            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            if (entrenadores)
            {
                DataTable entrenadores = connection.SelectQuery("select * from entrenadores");
                dataGridView1.DataSource = entrenadores;

            }
            else if (pokemones)
            {
                DataTable pokemones = connection.SelectQuery("select * from pokemones");
                dataGridView1.DataSource = pokemones;
            }
            else if (tipos)
            {
                DataTable tipos = connection.SelectQuery("select * from Tipos");
                dataGridView1.DataSource = tipos;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            entrenadores = true;
            pokemones = false;
            tipos = false;
            UpdateTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entrenadores = false;
            pokemones = true;
            tipos = false;
            UpdateTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entrenadores = false;
            pokemones = false;
            tipos = true;
            UpdateTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (entrenadores)
            {
                Entrenadores addEntrenadores = new Entrenadores(connection);
                this.Hide();
                addEntrenadores.Show();
            }
            if (pokemones)
            {
                Pokemones addPokemones = new Pokemones(connection);
                this.Hide();
                addPokemones.Show();
            }
            if (tipos)
            {
                Tipos addEspecies = new Tipos(connection);
                this.Hide();
                addEspecies.Show();
            }
        }
    }
}
