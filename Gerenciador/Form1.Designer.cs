namespace Gerenciador
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelexe = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panelDefinicao = new System.Windows.Forms.Panel();
            this.lblTransparencia = new System.Windows.Forms.Label();
            this.radioPreto = new System.Windows.Forms.RadioButton();
            this.lblTemaPreto = new System.Windows.Forms.Label();
            this.lblTemaBranco = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioBranco = new System.Windows.Forms.RadioButton();
            this.BarraProgressoOpacity = new Bunifu.Framework.UI.BunifuSlider();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnVisualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAbrirGerenciador = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelLatera = new System.Windows.Forms.Panel();
            this.btnDefinicao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCasa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQrCode = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelCabecario = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSair = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseBotaoSair = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipseBotaoMini = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timerMostrar = new System.Windows.Forms.Timer(this.components);
            this.timerOcultar = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TransitionPanelExe = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelForm.SuspendLayout();
            this.panelSlide.SuspendLayout();
            this.panelDefinicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.panelLatera.SuspendLayout();
            this.panelCabecario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelForm.Controls.Add(this.panelexe);
            this.panelForm.Controls.Add(this.panelSlide);
            this.panelForm.Controls.Add(this.panelLatera);
            this.panelForm.Controls.Add(this.panelCabecario);
            this.TransitionPanelExe.SetDecoration(this.panelForm, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelForm, BunifuAnimatorNS.DecorationType.None);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(954, 550);
            this.panelForm.TabIndex = 0;
            // 
            // panelexe
            // 
            this.panelexe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TransitionPanelExe.SetDecoration(this.panelexe, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelexe, BunifuAnimatorNS.DecorationType.None);
            this.panelexe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelexe.Location = new System.Drawing.Point(246, 25);
            this.panelexe.Name = "panelexe";
            this.panelexe.Size = new System.Drawing.Size(708, 525);
            this.panelexe.TabIndex = 4;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panelSlide.Controls.Add(this.panelDefinicao);
            this.panelSlide.Controls.Add(this.lblsubtitulo);
            this.panelSlide.Controls.Add(this.panelBotoes);
            this.TransitionPanelExe.SetDecoration(this.panelSlide, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelSlide, BunifuAnimatorNS.DecorationType.None);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(52, 25);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(194, 525);
            this.panelSlide.TabIndex = 3;
            // 
            // panelDefinicao
            // 
            this.panelDefinicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelDefinicao.Controls.Add(this.lblTransparencia);
            this.panelDefinicao.Controls.Add(this.radioPreto);
            this.panelDefinicao.Controls.Add(this.lblTemaPreto);
            this.panelDefinicao.Controls.Add(this.lblTemaBranco);
            this.panelDefinicao.Controls.Add(this.pictureBox2);
            this.panelDefinicao.Controls.Add(this.lblTema);
            this.panelDefinicao.Controls.Add(this.pictureBox1);
            this.panelDefinicao.Controls.Add(this.radioBranco);
            this.panelDefinicao.Controls.Add(this.BarraProgressoOpacity);
            this.TransitionPanelExe.SetDecoration(this.panelDefinicao, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelDefinicao, BunifuAnimatorNS.DecorationType.None);
            this.panelDefinicao.Location = new System.Drawing.Point(0, 157);
            this.panelDefinicao.Name = "panelDefinicao";
            this.panelDefinicao.Size = new System.Drawing.Size(194, 234);
            this.panelDefinicao.TabIndex = 4;
            // 
            // lblTransparencia
            // 
            this.lblTransparencia.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTransparencia, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this.lblTransparencia, BunifuAnimatorNS.DecorationType.None);
            this.lblTransparencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransparencia.ForeColor = System.Drawing.Color.White;
            this.lblTransparencia.Location = new System.Drawing.Point(38, 167);
            this.lblTransparencia.Name = "lblTransparencia";
            this.lblTransparencia.Size = new System.Drawing.Size(120, 19);
            this.lblTransparencia.TabIndex = 12;
            this.lblTransparencia.Text = "Transparência";
            // 
            // radioPreto
            // 
            this.radioPreto.AutoSize = true;
            this.radioPreto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.radioPreto, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this.radioPreto, BunifuAnimatorNS.DecorationType.None);
            this.radioPreto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPreto.ForeColor = System.Drawing.Color.White;
            this.radioPreto.Location = new System.Drawing.Point(151, 128);
            this.radioPreto.Name = "radioPreto";
            this.radioPreto.Size = new System.Drawing.Size(14, 13);
            this.radioPreto.TabIndex = 11;
            this.radioPreto.UseVisualStyleBackColor = true;
            this.radioPreto.CheckedChanged += new System.EventHandler(this.radioPreto_CheckedChanged);
            // 
            // lblTemaPreto
            // 
            this.lblTemaPreto.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTemaPreto, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this.lblTemaPreto, BunifuAnimatorNS.DecorationType.None);
            this.lblTemaPreto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemaPreto.ForeColor = System.Drawing.Color.White;
            this.lblTemaPreto.Location = new System.Drawing.Point(132, 48);
            this.lblTemaPreto.Name = "lblTemaPreto";
            this.lblTemaPreto.Size = new System.Drawing.Size(51, 21);
            this.lblTemaPreto.TabIndex = 10;
            this.lblTemaPreto.Text = "Preto";
            // 
            // lblTemaBranco
            // 
            this.lblTemaBranco.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTemaBranco, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this.lblTemaBranco, BunifuAnimatorNS.DecorationType.None);
            this.lblTemaBranco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemaBranco.ForeColor = System.Drawing.Color.White;
            this.lblTemaBranco.Location = new System.Drawing.Point(6, 48);
            this.lblTemaBranco.Name = "lblTemaBranco";
            this.lblTemaBranco.Size = new System.Drawing.Size(65, 21);
            this.lblTemaBranco.TabIndex = 9;
            this.lblTemaBranco.Text = "Branco";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(125, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 50);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTema, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this.lblTema, BunifuAnimatorNS.DecorationType.None);
            this.lblTema.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.Color.White;
            this.lblTema.Location = new System.Drawing.Point(65, 16);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(59, 19);
            this.lblTema.TabIndex = 7;
            this.lblTema.Text = "Temas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(8, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // radioBranco
            // 
            this.radioBranco.AutoSize = true;
            this.radioBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.radioBranco, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this.radioBranco, BunifuAnimatorNS.DecorationType.None);
            this.radioBranco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBranco.ForeColor = System.Drawing.Color.White;
            this.radioBranco.Location = new System.Drawing.Point(28, 128);
            this.radioBranco.Name = "radioBranco";
            this.radioBranco.Size = new System.Drawing.Size(14, 13);
            this.radioBranco.TabIndex = 5;
            this.radioBranco.UseVisualStyleBackColor = true;
            this.radioBranco.CheckedChanged += new System.EventHandler(this.radioBranco_CheckedChanged);
            // 
            // BarraProgressoOpacity
            // 
            this.BarraProgressoOpacity.BackColor = System.Drawing.Color.Transparent;
            this.BarraProgressoOpacity.BackgroudColor = System.Drawing.Color.DarkGray;
            this.BarraProgressoOpacity.BorderRadius = 0;
            this.TransitionPanelExe.SetDecoration(this.BarraProgressoOpacity, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.BarraProgressoOpacity, BunifuAnimatorNS.DecorationType.None);
            this.BarraProgressoOpacity.IndicatorColor = System.Drawing.Color.White;
            this.BarraProgressoOpacity.Location = new System.Drawing.Point(6, 192);
            this.BarraProgressoOpacity.MaximumValue = 100;
            this.BarraProgressoOpacity.Name = "BarraProgressoOpacity";
            this.BarraProgressoOpacity.Size = new System.Drawing.Size(182, 30);
            this.BarraProgressoOpacity.TabIndex = 4;
            this.BarraProgressoOpacity.Value = 100;
            this.BarraProgressoOpacity.ValueChanged += new System.EventHandler(this.BarraProgressoOpacity_ValueChanged);
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblsubtitulo, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this.lblsubtitulo, BunifuAnimatorNS.DecorationType.None);
            this.lblsubtitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblsubtitulo.Location = new System.Drawing.Point(46, 7);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(78, 19);
            this.lblsubtitulo.TabIndex = 2;
            this.lblsubtitulo.Text = "QR Code";
            // 
            // panelBotoes
            // 
            this.panelBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelBotoes.Controls.Add(this.btnVisualizar);
            this.panelBotoes.Controls.Add(this.btnAbrirGerenciador);
            this.TransitionPanelExe.SetDecoration(this.panelBotoes, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelBotoes, BunifuAnimatorNS.DecorationType.None);
            this.panelBotoes.Location = new System.Drawing.Point(0, 111);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(194, 80);
            this.panelBotoes.TabIndex = 1;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisualizar.BorderRadius = 0;
            this.btnVisualizar.ButtonText = "           Visualizar";
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanelExe.SetDecoration(this.btnVisualizar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnVisualizar, BunifuAnimatorNS.DecorationType.None);
            this.btnVisualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnVisualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVisualizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Iconimage")));
            this.btnVisualizar.Iconimage_right = null;
            this.btnVisualizar.Iconimage_right_Selected = null;
            this.btnVisualizar.Iconimage_Selected = null;
            this.btnVisualizar.IconMarginLeft = 0;
            this.btnVisualizar.IconMarginRight = 0;
            this.btnVisualizar.IconRightVisible = true;
            this.btnVisualizar.IconRightZoom = 0D;
            this.btnVisualizar.IconVisible = true;
            this.btnVisualizar.IconZoom = 50D;
            this.btnVisualizar.IsTab = false;
            this.btnVisualizar.Location = new System.Drawing.Point(-1, 43);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVisualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnVisualizar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVisualizar.selected = false;
            this.btnVisualizar.Size = new System.Drawing.Size(196, 38);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "           Visualizar";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.Textcolor = System.Drawing.Color.White;
            this.btnVisualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnAbrirGerenciador
            // 
            this.btnAbrirGerenciador.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAbrirGerenciador.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirGerenciador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirGerenciador.BorderRadius = 0;
            this.btnAbrirGerenciador.ButtonText = "     Criar código QR";
            this.btnAbrirGerenciador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanelExe.SetDecoration(this.btnAbrirGerenciador, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnAbrirGerenciador, BunifuAnimatorNS.DecorationType.None);
            this.btnAbrirGerenciador.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbrirGerenciador.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbrirGerenciador.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAbrirGerenciador.Iconimage")));
            this.btnAbrirGerenciador.Iconimage_right = null;
            this.btnAbrirGerenciador.Iconimage_right_Selected = null;
            this.btnAbrirGerenciador.Iconimage_Selected = null;
            this.btnAbrirGerenciador.IconMarginLeft = 0;
            this.btnAbrirGerenciador.IconMarginRight = 0;
            this.btnAbrirGerenciador.IconRightVisible = true;
            this.btnAbrirGerenciador.IconRightZoom = 0D;
            this.btnAbrirGerenciador.IconVisible = true;
            this.btnAbrirGerenciador.IconZoom = 50D;
            this.btnAbrirGerenciador.IsTab = false;
            this.btnAbrirGerenciador.Location = new System.Drawing.Point(-1, 0);
            this.btnAbrirGerenciador.Name = "btnAbrirGerenciador";
            this.btnAbrirGerenciador.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAbrirGerenciador.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAbrirGerenciador.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAbrirGerenciador.selected = false;
            this.btnAbrirGerenciador.Size = new System.Drawing.Size(196, 38);
            this.btnAbrirGerenciador.TabIndex = 2;
            this.btnAbrirGerenciador.Text = "     Criar código QR";
            this.btnAbrirGerenciador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirGerenciador.Textcolor = System.Drawing.Color.White;
            this.btnAbrirGerenciador.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirGerenciador.Click += new System.EventHandler(this.btnAbrirGerenciador_Click);
            // 
            // panelLatera
            // 
            this.panelLatera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelLatera.Controls.Add(this.btnDefinicao);
            this.panelLatera.Controls.Add(this.btnCasa);
            this.panelLatera.Controls.Add(this.btnQrCode);
            this.TransitionPanelExe.SetDecoration(this.panelLatera, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelLatera, BunifuAnimatorNS.DecorationType.None);
            this.panelLatera.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLatera.Location = new System.Drawing.Point(0, 25);
            this.panelLatera.Name = "panelLatera";
            this.panelLatera.Size = new System.Drawing.Size(52, 525);
            this.panelLatera.TabIndex = 1;
            // 
            // btnDefinicao
            // 
            this.btnDefinicao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDefinicao.BackColor = System.Drawing.Color.Transparent;
            this.btnDefinicao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefinicao.BorderRadius = 0;
            this.btnDefinicao.ButtonText = "";
            this.btnDefinicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanelExe.SetDecoration(this.btnDefinicao, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnDefinicao, BunifuAnimatorNS.DecorationType.None);
            this.btnDefinicao.DisabledColor = System.Drawing.Color.Gray;
            this.btnDefinicao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDefinicao.Iconimage = global::Gerenciador.Properties.Resources.DefinicaoBranco;
            this.btnDefinicao.Iconimage_right = null;
            this.btnDefinicao.Iconimage_right_Selected = null;
            this.btnDefinicao.Iconimage_Selected = null;
            this.btnDefinicao.IconMarginLeft = 0;
            this.btnDefinicao.IconMarginRight = 0;
            this.btnDefinicao.IconRightVisible = true;
            this.btnDefinicao.IconRightZoom = 0D;
            this.btnDefinicao.IconVisible = true;
            this.btnDefinicao.IconZoom = 50D;
            this.btnDefinicao.IsTab = false;
            this.btnDefinicao.Location = new System.Drawing.Point(0, 118);
            this.btnDefinicao.Name = "btnDefinicao";
            this.btnDefinicao.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDefinicao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnDefinicao.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDefinicao.selected = false;
            this.btnDefinicao.Size = new System.Drawing.Size(53, 40);
            this.btnDefinicao.TabIndex = 2;
            this.btnDefinicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefinicao.Textcolor = System.Drawing.Color.White;
            this.btnDefinicao.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefinicao.Click += new System.EventHandler(this.btnDefinicao_Click);
            // 
            // btnCasa
            // 
            this.btnCasa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCasa.BackColor = System.Drawing.Color.Transparent;
            this.btnCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCasa.BorderRadius = 0;
            this.btnCasa.ButtonText = "";
            this.btnCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanelExe.SetDecoration(this.btnCasa, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnCasa, BunifuAnimatorNS.DecorationType.None);
            this.btnCasa.DisabledColor = System.Drawing.Color.Gray;
            this.btnCasa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCasa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCasa.Iconimage")));
            this.btnCasa.Iconimage_right = null;
            this.btnCasa.Iconimage_right_Selected = null;
            this.btnCasa.Iconimage_Selected = null;
            this.btnCasa.IconMarginLeft = 0;
            this.btnCasa.IconMarginRight = 0;
            this.btnCasa.IconRightVisible = true;
            this.btnCasa.IconRightZoom = 0D;
            this.btnCasa.IconVisible = true;
            this.btnCasa.IconZoom = 50D;
            this.btnCasa.IsTab = false;
            this.btnCasa.Location = new System.Drawing.Point(0, 27);
            this.btnCasa.Name = "btnCasa";
            this.btnCasa.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCasa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnCasa.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCasa.selected = false;
            this.btnCasa.Size = new System.Drawing.Size(53, 40);
            this.btnCasa.TabIndex = 1;
            this.btnCasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCasa.Textcolor = System.Drawing.Color.White;
            this.btnCasa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasa.Click += new System.EventHandler(this.btnCasa_Click);
            // 
            // btnQrCode
            // 
            this.btnQrCode.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnQrCode.BackColor = System.Drawing.Color.Transparent;
            this.btnQrCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQrCode.BorderRadius = 0;
            this.btnQrCode.ButtonText = "";
            this.btnQrCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanelExe.SetDecoration(this.btnQrCode, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnQrCode, BunifuAnimatorNS.DecorationType.None);
            this.btnQrCode.DisabledColor = System.Drawing.Color.Gray;
            this.btnQrCode.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQrCode.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQrCode.Iconimage")));
            this.btnQrCode.Iconimage_right = null;
            this.btnQrCode.Iconimage_right_Selected = null;
            this.btnQrCode.Iconimage_Selected = null;
            this.btnQrCode.IconMarginLeft = 0;
            this.btnQrCode.IconMarginRight = 0;
            this.btnQrCode.IconRightVisible = true;
            this.btnQrCode.IconRightZoom = 0D;
            this.btnQrCode.IconVisible = true;
            this.btnQrCode.IconZoom = 50D;
            this.btnQrCode.IsTab = false;
            this.btnQrCode.Location = new System.Drawing.Point(0, 72);
            this.btnQrCode.Name = "btnQrCode";
            this.btnQrCode.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQrCode.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnQrCode.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnQrCode.selected = false;
            this.btnQrCode.Size = new System.Drawing.Size(53, 40);
            this.btnQrCode.TabIndex = 0;
            this.btnQrCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQrCode.Textcolor = System.Drawing.Color.White;
            this.btnQrCode.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQrCode.Click += new System.EventHandler(this.btnQrCode_Click);
            // 
            // panelCabecario
            // 
            this.panelCabecario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelCabecario.Controls.Add(this.lblTitulo);
            this.panelCabecario.Controls.Add(this.btnMinimizar);
            this.panelCabecario.Controls.Add(this.btnSair);
            this.TransitionPanelExe.SetDecoration(this.panelCabecario, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelCabecario, BunifuAnimatorNS.DecorationType.None);
            this.panelCabecario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecario.Location = new System.Drawing.Point(0, 0);
            this.panelCabecario.Name = "panelCabecario";
            this.panelCabecario.Size = new System.Drawing.Size(954, 25);
            this.panelCabecario.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(386, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 21);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Gerenciador de QRCode";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Green;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanelExe.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(896, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanelExe.SetDecoration(this.btnSair, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnSair, BunifuAnimatorNS.DecorationType.None);
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageActive = null;
            this.btnSair.Location = new System.Drawing.Point(924, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(22, 20);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 1;
            this.btnSair.TabStop = false;
            this.btnSair.Zoom = 10;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipseBotaoSair
            // 
            this.bunifuElipseBotaoSair.ElipseRadius = 200;
            this.bunifuElipseBotaoSair.TargetControl = this.btnSair;
            // 
            // bunifuElipseBotaoMini
            // 
            this.bunifuElipseBotaoMini.ElipseRadius = 200;
            this.bunifuElipseBotaoMini.TargetControl = this.btnMinimizar;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelCabecario;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblTitulo;
            this.bunifuDragControl2.Vertical = true;
            // 
            // TransitionPanelExe
            // 
            this.TransitionPanelExe.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.TransitionPanelExe.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.TransitionPanelExe.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(954, 550);
            this.Controls.Add(this.panelForm);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanelExe.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelForm.ResumeLayout(false);
            this.panelSlide.ResumeLayout(false);
            this.panelSlide.PerformLayout();
            this.panelDefinicao.ResumeLayout(false);
            this.panelDefinicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            this.panelLatera.ResumeLayout(false);
            this.panelCabecario.ResumeLayout(false);
            this.panelCabecario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelCabecario;
        private Bunifu.Framework.UI.BunifuImageButton btnSair;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseBotaoSair;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseBotaoMini;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private System.Windows.Forms.Panel panelLatera;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnQrCode;
        private System.Windows.Forms.Panel panelBotoes;
        private Bunifu.Framework.UI.BunifuFlatButton btnVisualizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbrirGerenciador;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Panel panelexe;
        private System.Windows.Forms.Timer timerMostrar;
        private System.Windows.Forms.Timer timerOcultar;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuFlatButton btnCasa;
        private BunifuAnimatorNS.BunifuTransition TransitionPanelExe;
        private Bunifu.Framework.UI.BunifuFlatButton btnDefinicao;
        private System.Windows.Forms.Panel panelDefinicao;
        private System.Windows.Forms.RadioButton radioBranco;
        private Bunifu.Framework.UI.BunifuSlider BarraProgressoOpacity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioPreto;
        private System.Windows.Forms.Label lblTemaPreto;
        private System.Windows.Forms.Label lblTemaBranco;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblTransparencia;
    }
}

