using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZXing;

namespace Gerenciador.FormsAuxiliares
{
    public partial class FormVisualizar : Form
    {
        public FormVisualizar(string mensagem)
        {
            InitializeComponent();

            if (mensagem == "TemaBranco")
            {
                TemaBranco();
            }
            else if (mensagem == "TemaPreto")
            {
                TemaPreto();
            }
        }


        #region Procedimentos
        public void TemaBranco()
        {
            this.BackColor = Color.White;
            txtTexto.BackColor = Color.White;
            lblTitulo.ForeColor = Color.Black;
            txtTexto.ForeColor = Color.Black;
        }

        public void TemaPreto()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            txtTexto.BackColor = Color.FromArgb(30, 30, 30);
            lblTitulo.ForeColor = Color.White;
            txtTexto.ForeColor = Color.White;
        }

        #endregion

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string pasta = @"C:\Códigos QR";

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);

                AbrirQR(); //Chama a funcao que vai ao directorio QR
            }
            else
            {
                AbrirQR(); //Chama a funcao que guarda o QR
            }       
        }

        public void AbrirQR()
        {
            try
            {
                OpenFileDialog abrir = new OpenFileDialog()
                {
                    Filter = "Imagem png|*.png",
                    InitialDirectory = @"C:\Códigos QR"
                };
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(abrir.FileName);
                    BarcodeReader br = new BarcodeReader();
                    string texto = br.Decode((Bitmap)pictureBox1.Image).ToString();
                    txtTexto.Text = texto;

                }
            }
            catch (Exception)
            {

                pictureBox1.Image = null;
                MessageBox.Show("Selecione Apenas a imagem que contem Qr", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
