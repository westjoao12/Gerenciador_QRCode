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
    public partial class FormQRCode : Form
    {
        public FormQRCode(string mensagem)
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

        private void txtTexto_Enter(object sender, EventArgs e)
        {
            if (txtTexto.Text== "Digite aqui o seu texto...")
            {
                txtTexto.Text = "";
            }
        }

        private void txtTexto_Leave(object sender, EventArgs e)
        {
            if (txtTexto.Text=="")
            {
                txtTexto.Text = "Digite aqui o seu texto...";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string pasta = @"C:\Códigos QR";

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);

                GuardarQR(); //Chama a funcao que guarda o QR
            }
            else
            {
                GuardarQR(); //Chama a funcao que guarda o QR
            }

              
        }
        public void GuardarQR()
        {
            if (txtTexto.Text == "" || txtTexto.Text == "Digite aqui o seu texto...")
            {
                MessageBox.Show("Por favor, digite algo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaveFileDialog salvar = new SaveFileDialog()
                {
                    Filter = "Imagen png|*.png",
                    InitialDirectory = @"C:\Códigos QR"
                };
                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(salvar.FileName);
                    MessageBox.Show("Código QR criado com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTexto.Text = "Digite aqui o seu texto...";
                    pictureBox1.Image = null;
                    pictureBox1.Focus();
                }
            }
        }
        private void txtTexto_OnValueChanged(object sender, EventArgs e)
        {
            if (txtTexto.Text!="" && txtTexto.Text!= "Digite aqui o seu texto...")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(txtTexto.Text), 300, 300);
                pictureBox1.Image = bm;
            }
            
        }

    }
}
