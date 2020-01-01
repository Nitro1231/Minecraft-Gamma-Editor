using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftGammaSetting {
    public partial class main : Form {
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\options.txt";
        private string[] option;
        private int gamma;
       
        private char colon = ':';
        public main() {
            if (!File.Exists(path)) {
                MessageBox.Show("Cannot find .minecraft\\options.txt file.\nThis file is necessary to change the gamma value.\nPlease install the Minecraft, and if you already did, change the Minecraft version or re-install the game.", "File dose not exist.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                option = File.ReadAllLines(path);
                foreach (string l in option) {
                   if (l.Contains("gamma")) {
                        gamma = (int)float.Parse(l.Split(colon)[1]);
                        break;
                    }
                }
            }
            InitializeComponent();
            Utils.smoothBorder(close, close.Width);
            Utils.smoothBorder(min, min.Width);
            Utils.smoothBorder(this, 10);
            gammaTextBox.Text = gamma.ToString();
            gammaBar.Value = gamma;
        }

        private void Set_Click(object sender, EventArgs e) {
            //label3.Text = path;
        }

        private void gammaBar_Scroll(object sender, EventArgs e) {
            gammaTextBox.Text = gammaBar.Value.ToString();
        }

        private void gammaTextBox_TextChanged(object sender, EventArgs e) {
            if (gammaTextBox.Text == "")
                gammaTextBox.Text = "1";
            int v = int.Parse(gammaTextBox.Text);
            if (v < 1) {
                gammaTextBox.Text = "1";
                gammaBar.Value = 1;
            } else if (v > 1000) {
                gammaTextBox.Text = "1000";
                gammaBar.Value = 1000;
            }
            gammaBar.Value = int.Parse(gammaTextBox.Text);
        }

        private void Close_Click(object sender, EventArgs e) { Close(); }
        private void Min_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        private void Main_MouseMove(object sender, MouseEventArgs e) { Utils.mouseMove(Handle); }
        private void gammaTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
                e.Handled = true;
        }
    }
}
