using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComplier
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;

        public Form1()
        {
            InitializeComponent();
        }

        #region 实现行号

        private void Txt_input_TextChanged(object sender, EventArgs e)
        {
            ShowRow(Txt_input.GetLineFromCharIndex(Txt_input.Text.Length) + 1);
            ShowCursorLine();
        }

        private void ShowRow(int line)
        {
            Txt_row.Text = "";
            for (int i = 1; i <= line; i++)
                Txt_row.Text += i.ToString() + "\r\n";
            Txt_row.TextAlign = HorizontalAlignment.Left;
        }

        private void ShowCursorLine()
        {
            int col = Txt_input.SelectionStart - Txt_input.GetFirstCharIndexOfCurrentLine() + 1;
            int row = this.Txt_input.GetLineFromCharIndex(this.Txt_input.SelectionStart) + 1;
            toolStripStatusLabel1.Text = "Line: " + row.ToString() + " Col: " + col.ToString();
        }

        private void Txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down ||
                e.KeyData == Keys.Left || e.KeyData == Keys.Right)
                ShowCursorLine();
        }

        private void Txt_input_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down ||
                e.KeyData == Keys.Left || e.KeyData == Keys.Right)
                ShowCursorLine();
        }

        private void Txt_input_MouseDown(object sender, MouseEventArgs e)
        {
            ShowCursorLine();
        }
        #endregion

        /// <summary>
        /// 词法分析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LexingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txt_lex.Text = String.Empty;
            string sourceFilePath = @"E:\2.txt";
            LexAnalyser lexAnalyser = new LexAnalyser(sourceFilePath, Txt_lex);
            lexAnalyser.Scan();
        }

        /// <summary>
        /// 语法分析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParsingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"E:\\",
                Filter = "C source file (*.c)|*.c|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                Txt_input.Text = String.Empty;
                Txt_input.Text += File.ReadAllText(fileName);
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog != null)
            {
                File.WriteAllText(openFileDialog.FileName, Txt_input.Text);
            }
            else
            {
                AToolStripMenuItem.PerformClick();
            }
        }

        /// <summary>
        /// 另存为
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "C source file (*.c)|*.c|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, Txt_input.Text);
            }
        }
    }
}