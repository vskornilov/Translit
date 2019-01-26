using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Translit
{
    public partial class fTranslit : Form
    {
        Translit Translit = new Translit();

        public fTranslit()
        {
            InitializeComponent();
        }

        private void tbInputText_TextChanged(object sender, EventArgs e)
        {

            var Text = tbInputText.Text;

            tbResultText.Text = Translit.TrRusEng(Text);

        }

        private void tbResultText_MouseClick(object sender, MouseEventArgs e)
        {
            tbResultText.SelectAll();
            Clipboard.SetText(tbResultText.Text);
            lbCopyBuffer.Text = "Скопировано в буфер обмена";
        }
    }
}