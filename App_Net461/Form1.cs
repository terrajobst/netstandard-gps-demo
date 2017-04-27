using System;
using System.Windows.Forms;
using Gps;

namespace App_Net461
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var geo = await GpsLocation.GetCoordinates();

            label1.Text = $"You're at ({geo.latitude:N2}, {geo.longitude:N2})";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
