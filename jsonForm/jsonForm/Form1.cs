using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace jsonForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("urunler.json");
            List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(json);

            lstUrunler.Items.Clear();
            foreach (var u in urunler)
            {
                lstUrunler.Items.Add($"{u.UrunAdi} - {u.Fiyat} TL");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Urun
    {
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }
    }
}