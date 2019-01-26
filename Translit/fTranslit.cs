using System;
using System.Windows.Forms;

namespace Translit
{
    public partial class fTranslit : Form
    {
        private Translit Translit = new Translit();

        public fTranslit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ввод текста и одновременный вывод результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbInputText_TextChanged(object sender, EventArgs e)
        {
            var Text = tbInputText.Text;    //Сохранение текста в переменной "Text"
            tbResultText.Text = Translit.TrRusEng(Text);    //Транслитирация и вывод
        }

        /// <summary>
        /// Метод копирования в буфер обмена.
        /// Выделения всей строки.
        /// Сообщение о успешной операции.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbResultText_MouseClick(object sender, MouseEventArgs e)
        {
            tbResultText.SelectAll();   //Выделение всей строки
            Clipboard.SetText(tbResultText.Text);   //Копирование в буффер обмена
            lbCopyBuffer.Text = "Скопировано в буфер обмена";   //Сообщение о успешной операции
        }
    }
}