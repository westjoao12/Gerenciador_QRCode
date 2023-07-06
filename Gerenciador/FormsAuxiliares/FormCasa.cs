using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.FormsAuxiliares
{
    public partial class FormCasa : Form
    {
        public FormCasa(string mensagem)
        {
            InitializeComponent();

            if (mensagem=="TemaBranco")
            {
                TemaBranco();
            }
            else if (mensagem=="TemaPreto")
            {
                TemaPreto();
            }
        }

        public void TemaBranco()
        {
            this.BackColor = Color.White;
        }

        public void TemaPreto()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
        }
    }
}
