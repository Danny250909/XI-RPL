using System;
using System.Windows.Forms;

namespace Pengonversi_Suhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
            comboBoxDari.SelectedIndex = 0;
            comboBoxKe.SelectedIndex = 0;
        }

       
        private void buttonKonversi_Click(object sender, EventArgs e)
        {
        
            if (!double.TryParse(textInput.Text, out double inputSuhu))
            {
                MessageBox.Show("Mohon masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string satuanAsal = comboBoxDari.Text;
            string satuanTujuan = comboBoxKe.Text;

            
            if (string.IsNullOrWhiteSpace(satuanAsal) || string.IsNullOrWhiteSpace(satuanTujuan))
            {
                MessageBox.Show("Silakan pilih satuan asal dan tujuan terlebih dahulu!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (satuanAsal == satuanTujuan)
            {
                labelHasil.Text = $"Hasil : {inputSuhu.ToString("F3")} {satuanAsal}";
                return;
            }

           
            double celcius = 0;
            switch (satuanAsal)
            {
                case "Celcius":
                    celcius = inputSuhu;
                    break;
                case "Reamur":
                    celcius = inputSuhu * 5.0 / 4.0;
                    break;
                case "Fahrenheit":
                    celcius = (inputSuhu - 32) * 5.0 / 9.0;
                    break;
                case "Kelvin":
                    celcius = inputSuhu - 273.15;
                    break;
                default:
                    MessageBox.Show("Silakan pilih Satuan Asal yang valid!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

         
            double hasil = 0;
            switch (satuanTujuan)
            {
                case "Celcius":
                    hasil = celcius;
                    break;
                case "Reamur":
                    hasil = celcius * 4.0 / 5.0;
                    break;
                case "Fahrenheit":
                    hasil = (celcius * 9.0 / 5.0) + 32;
                    break;
                case "Kelvin":
                    hasil = celcius + 273.15;
                    break;
                default:
                    MessageBox.Show("Silakan pilih Satuan Tujuan yang valid!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            
            labelHasil.Text = $"Hasil : {hasil.ToString("F3")} {satuanTujuan}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}