using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appii
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btbuscar_Click(object sender, EventArgs e)
        {
            string pokemonName = textBox1.Text.ToLower();
            string url = $"https://pokeapi.co/api/v2/pokemon/{pokemonName}";

            try
            {
                string response = await client.GetStringAsync(url);
                JObject json = JObject.Parse(response);

                iblpeso.Text = $"Peso: {json["weight"]}";
                iblaltura.Text = $"Altura: {json["height"]}";
                ibltipo.Text = $"Tipo: {json["types"][0]["type"]["name"]}";
                string imagenUrl = json["sprites"]["front_default"]?.ToString();
                pictureBox1.Load(imagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la informacion del pokemon: " + ex.Message);
            }
        }
    }
}
