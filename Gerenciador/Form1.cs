using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador.FormsAuxiliares;

namespace Gerenciador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioPreto.Checked = true;
            panelSlide.Width = 0;

            if (radioBranco.Checked==true)
            {
                openChildForm(new FormCasa("TemaBranco"));
            }
            else if (radioPreto.Checked==true)
            {
                openChildForm(new FormCasa("TemaPreto"));
            }
            


        }

       


        public void TemaBranco()
        {
            #region Paineis
            panelCabecario.BackColor = Color.FromArgb(240, 240, 240);
            panelLatera.BackColor = Color.FromArgb(240, 240, 240);
            panelSlide.BackColor = Color.WhiteSmoke;
            panelBotoes.BackColor = Color.FromArgb(240, 240, 240);
            panelDefinicao.BackColor = Color.FromArgb(240, 240, 240);
            panelexe.BackColor = Color.White;
            #endregion

            #region Labels

            lblTitulo.ForeColor = Color.Black;
            lblsubtitulo.ForeColor = Color.Black;
            lblTema.ForeColor = Color.Black;
            lblTemaBranco.ForeColor = Color.Black;
            lblTemaPreto.ForeColor = Color.Black;
            lblTransparencia.ForeColor = Color.Black;
            #endregion

            #region Botao Home
            btnCasa.OnHovercolor= Color.White;
            btnCasa.Activecolor= Color.WhiteSmoke;
            btnCasa.Iconimage = Properties.Resources.HomePreto;
            #endregion

            #region Botao QR
            btnQrCode.OnHovercolor = Color.White;
            btnQrCode.Activecolor = Color.WhiteSmoke;
            btnQrCode.Iconimage = Properties.Resources.QRPreto;
            #endregion

            #region Botao Definicao
            btnDefinicao.OnHovercolor = Color.White;
            btnDefinicao.Activecolor = Color.WhiteSmoke;
            btnDefinicao.Iconimage = Properties.Resources.definicaoPreto;
            #endregion

            #region Abrir Gerenciador
            btnAbrirGerenciador.OnHovercolor = Color.White;
            btnAbrirGerenciador.Activecolor = Color.White;
            btnAbrirGerenciador.Iconimage = Properties.Resources.CreatePreto;
            btnAbrirGerenciador.Text = "                 Criar código QR";
            btnAbrirGerenciador.Textcolor = Color.Black;

            #endregion

            #region Abrir Visualizador
            btnVisualizar.OnHovercolor = Color.White;
            btnVisualizar.Activecolor = Color.White;
            btnVisualizar.Iconimage = Properties.Resources.VerPreto;
            btnVisualizar.Text = "                    Visualizar";
            btnVisualizar.Textcolor = Color.Black;
            #endregion

            #region Barra Processo da opacidade
            BarraProgressoOpacity.IndicatorColor = Color.Black;
            #endregion



        }

        public void TemaPreto()
        {
            #region Paineis
            panelCabecario.BackColor = Color.FromArgb(60, 60, 60);
            panelLatera.BackColor = Color.FromArgb(60, 60, 60);
            panelSlide.BackColor = Color.FromArgb(37, 37, 38);
            panelBotoes.BackColor = Color.FromArgb(60, 60, 60);
            panelDefinicao.BackColor = Color.FromArgb(60, 60, 60);
            panelexe.BackColor = Color.FromArgb(30,30,30);
            #endregion

            #region Labels

            lblTitulo.ForeColor = Color.White;
            lblsubtitulo.ForeColor = Color.White;
            lblTema.ForeColor = Color.White;
            lblTemaBranco.ForeColor = Color.White;
            lblTemaPreto.ForeColor = Color.White;
            lblTransparencia.ForeColor = Color.White;
            #endregion

            #region Botao Home
            btnCasa.OnHovercolor = Color.FromArgb(37, 37, 38);
            btnCasa.Activecolor = Color.FromArgb(30, 30, 30);
            btnCasa.Iconimage = Properties.Resources.HomeBranco;
            #endregion

            #region Botao QR
            btnQrCode.OnHovercolor = Color.FromArgb(37, 37, 38);
            btnQrCode.Activecolor = Color.FromArgb(30, 30, 30);
            btnQrCode.Iconimage = Properties.Resources.QRBranco;
            #endregion

            #region Botao Definicao
            btnDefinicao.OnHovercolor = Color.FromArgb(37, 37, 38);
            btnDefinicao.Activecolor = Color.FromArgb(30, 30, 30);
            btnDefinicao.Iconimage = Properties.Resources.DefinicaoBranco;
            #endregion

            #region Botao Abrir Gerenciador
            btnAbrirGerenciador.OnHovercolor = Color.FromArgb(30, 30, 30);
            btnAbrirGerenciador.Activecolor = Color.FromArgb(30, 30, 30);
            btnAbrirGerenciador.Iconimage = Properties.Resources.CreateBranco;
            btnAbrirGerenciador.Text = "                 Criar código QR";
            btnAbrirGerenciador.Textcolor = Color.White;

            #endregion

            #region Abrir Visualizador
            btnVisualizar.OnHovercolor = Color.FromArgb(30, 30, 30);
            btnVisualizar.Activecolor = Color.FromArgb(30, 30, 30);
            btnVisualizar.Iconimage = Properties.Resources.VerBranco;
            btnVisualizar.Text = "                    Visualizar";
            btnVisualizar.Textcolor = Color.White;
            #endregion

            #region Barra Processo da opacidade
            BarraProgressoOpacity.IndicatorColor = Color.White;
            #endregion



        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            if (panelSlide.Width==0)
            {
                panelSlide.Width = 194;

                panelBotoes.Visible = true;
                panelDefinicao.Visible = false;

                panelSlide.Visible = false;
                bunifuTransition1.ShowSync(panelSlide);
                
            }
            else if (panelSlide.Width== 194)
            {
                panelSlide.Width = 0;
            }
        }

        private void btnAbrirGerenciador_Click(object sender, EventArgs e)
        {
            panelSlide.Width = 0;

            if (radioBranco.Checked == true)
            {
                openChildForm(new FormQRCode("TemaBranco"));
            }
            else if (radioPreto.Checked == true)
            {
                openChildForm(new FormQRCode("TemaPreto"));
            }

            panelexe.Visible = false;
            TransitionPanelExe.ShowSync(panelexe);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            panelSlide.Width = 0;

            if (radioBranco.Checked == true)
            {
                openChildForm(new FormVisualizar("TemaBranco"));
            }
            else if (radioPreto.Checked == true)
            {
                openChildForm(new FormVisualizar("TemaPreto"));
            }

            panelexe.Visible = false;
            TransitionPanelExe.ShowSync(panelexe);
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelexe.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            panelSlide.Width = 0;


            if (radioBranco.Checked == true)
            {
                openChildForm(new FormCasa("TemaBranco"));
            }
            else if (radioPreto.Checked == true)
            {
                openChildForm(new FormCasa("TemaPreto"));
            }

            panelexe.Visible = false;
            TransitionPanelExe.ShowSync(panelexe);
        }

        private void btnDefinicao_Click(object sender, EventArgs e)
        {
            if (panelSlide.Width == 0)
            {
                panelSlide.Width = 194;

                panelBotoes.Visible = false;
                panelDefinicao.Visible = true;

                panelSlide.Visible = false;
                bunifuTransition1.ShowSync(panelSlide);
            

            }
            else if (panelSlide.Width == 194)
            {
                panelSlide.Width = 0;
            }
        }

        private void BarraProgressoOpacity_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = BarraProgressoOpacity.Value;       
        }

        private void radioBranco_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBranco.Checked==true)
            {
                TemaBranco();
               
                openChildForm(new FormCasa("TemaBranco"));

                panelexe.Visible = false;
                TransitionPanelExe.ShowSync(panelexe);
            }
            else if(radioPreto.Checked==true)
            {
                TemaPreto();
               // panelSlide.Width = 0;
                openChildForm(new FormCasa("TemaPreto"));

                panelexe.Visible = false;
                TransitionPanelExe.ShowSync(panelexe);
            }
        }

        private void radioPreto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPreto.Checked==true)
            {
                TemaPreto();
            }
            else if (radioBranco.Checked==true)
            {
                TemaBranco();
            }
        }
    }
}
