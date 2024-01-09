using System;
using System.Drawing;
using System.Windows.Forms;

namespace Typo_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private bool tabPressed = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int buttonIndex = -1;

            if (e.KeyCode >= Keys.F1 && e.KeyCode <= Keys.F12)
            {
                buttonIndex = (int)e.KeyCode - (int)Keys.F1 + 1;
            }
            else if (e.KeyCode == Keys.Oemtilde)
            {
                buttonIndex = 13;
            }
            else if (e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D9)
            {
                buttonIndex = 14 + (int)e.KeyCode - (int)Keys.D1;
            }
            else if (e.KeyCode == Keys.D0)
            {
                buttonIndex = 23;
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                buttonIndex = 24;
            }
            else if (e.KeyCode == Keys.Oemplus)
            {
                buttonIndex = 25;
            }
            else if (e.KeyCode == Keys.Back)
            {
                buttonIndex = 26;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                buttonIndex = 27;
                tabPressed = true;
            }
            else if (e.KeyCode == Keys.Q)
            {
                buttonIndex = 28;
            }
            else if (e.KeyCode == Keys.W)
            {
                buttonIndex = 29;
            }
            else if (e.KeyCode == Keys.E)
            {
                buttonIndex = 30;
            }
            else if (e.KeyCode == Keys.R)
            {
                buttonIndex = 31;
            }
            else if (e.KeyCode == Keys.T)
            {
                buttonIndex = 32;
            }
            else if (e.KeyCode == Keys.Y)
            {
                buttonIndex = 33;
            }
            else if (e.KeyCode == Keys.U)
            {
                buttonIndex = 34;
            }
            else if (e.KeyCode == Keys.I)
            {
                buttonIndex = 35;
            }
            else if (e.KeyCode == Keys.O)
            {
                buttonIndex = 36;
            }
            else if (e.KeyCode == Keys.P)
            {
                buttonIndex = 37;
            }
            else if (e.KeyCode == Keys.OemOpenBrackets)
            {
                buttonIndex = 38;
            }
            else if (e.KeyCode == Keys.OemCloseBrackets)
            {
                buttonIndex = 39;
            }
            else if (e.KeyCode == Keys.OemPipe)
            {
                buttonIndex = 40;
            }
            else if (e.KeyCode == Keys.CapsLock)
            {
                buttonIndex = 41;
            }
            else if (e.KeyCode == Keys.A)
            {
                buttonIndex = 53;
            }
            else if (e.KeyCode == Keys.S)
            {
                buttonIndex = 51;
            }
            else if (e.KeyCode == Keys.D)
            {
                buttonIndex = 49;
            }
            else if (e.KeyCode == Keys.F)
            {
                buttonIndex = 45;
            }
            else if (e.KeyCode == Keys.G)
            {
                buttonIndex = 52;
            }
            else if (e.KeyCode == Keys.H)
            {
                buttonIndex = 50;
            }
            else if (e.KeyCode == Keys.J)
            {
                buttonIndex = 48;
            }
            else if (e.KeyCode == Keys.K)
            {
                buttonIndex = 44;
            }
            else if (e.KeyCode == Keys.L)
            {
                buttonIndex = 47;
            }
            else if (e.KeyCode == Keys.OemSemicolon)
            {
                buttonIndex = 43;
            }
            else if (e.KeyCode == Keys.OemQuotes)
            {
                buttonIndex = 46;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonIndex = 42;
            }
            else if (e.KeyCode == Keys.ShiftKey)
            {
                buttonIndex = 54;
            }
            else if (e.KeyCode == Keys.Z)
            {
                buttonIndex = 65;
            }
            else if (e.KeyCode == Keys.X)
            {
                buttonIndex = 63;
            }
            else if (e.KeyCode == Keys.C)
            {
                buttonIndex = 61;
            }
            else if (e.KeyCode == Keys.V)
            {
                buttonIndex = 57;
            }
            else if (e.KeyCode == Keys.B)
            {
                buttonIndex = 64;
            }
            else if (e.KeyCode == Keys.N)
            {
                buttonIndex = 62;
            }
            else if (e.KeyCode == Keys.M)
            {
                buttonIndex = 60;
            }
            else if (e.KeyCode == Keys.OemPeriod)
            {
                buttonIndex = 59;
            }
            else if (e.KeyCode == Keys.Oemcomma)
            {
                buttonIndex = 56;
            }
            else if (e.KeyCode == Keys.OemQuestion)
            {
                buttonIndex = 55;
            }
            else if (e.KeyCode == Keys.ControlKey)
            {
                buttonIndex = 58;
            }
            else if (e.KeyCode == Keys.Alt)
            {
                buttonIndex = 66;
            }
            else if (e.KeyCode == Keys.Space)
            {
                buttonIndex = 67;
            }
            else if (e.KeyCode == Keys.Left)
            {
                buttonIndex = 70;
            }
            else if (e.KeyCode == Keys.Up)
            {
                buttonIndex = 68;
            }
            else if (e.KeyCode == Keys.Down)
            {
                buttonIndex = 69;
            }
            else if (e.KeyCode == Keys.Right)
            {
                buttonIndex = 71;
            }

            if (buttonIndex >= 1 && buttonIndex <= 71)
            {
                HighlightButton(buttonIndex);
            }

            if (tabPressed && e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                tabPressed = false;
            }
        }

        private void HighlightButton(int buttonIndex)
        {
            ResetButtonColors();

            Button button = Controls["button" + buttonIndex] as Button;
            if (button != null)
            {
                button.BackColor = Color.Yellow;
            }
        }

        private void ResetButtonColors()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = SystemColors.Control;
                }
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void clearTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void invertColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = InvertColor(richTextBox1.BackColor);
            richTextBox1.ForeColor = InvertColor(richTextBox1.ForeColor);
        }

        private Color InvertColor(Color color)
        {
            return Color.FromArgb(color.ToArgb() ^ 0xFFFFFF);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.ForeColor = colorDialog.Color;
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Font = fontDialog.Font;
                }
            }
        }
    }
}
