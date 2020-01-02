// Program Ver: 1
// Last Update: 01/02/2020
// Developer: Nitro
// E-Mail: nitro0@naver.com
// License: MIT License
// Open-Source: https://github.com/Nitro1231/Minecraft-Gamma-Editor

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MinecraftGammaSetting {
    public partial class main : Form {
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\options.txt";
        private string[] option;
        private int gamma, gammaIndex;
        private bool infoButton = false;

        private char colon = ':';
        public main() {
            if (!File.Exists(path)) {
                MessageBox.Show("Error: File dose not exist.\nCannot find .minecraft\\options.txt file.\nThis file is necessary to change the gamma value.\nPlease install the Minecraft, and if you already did, change the Minecraft version or re-install the game.", "Minecraft Gamma Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                option = File.ReadAllLines(path);
                int i = 0;
                foreach (string l in option) {
                    if (l.Contains("gamma")) {
                        gamma = (int)float.Parse(l.Split(colon)[1]);
                        gammaIndex = i;
                        break;
                    }
                    i++;
                }
            }
            InitializeComponent();
            Height = 155;
            Utils.smoothBorder(this, 10);
            Utils.smoothBorder(close, close.Height);
            Utils.smoothBorder(min, min.Height);
            Utils.smoothBorder(info, info.Height);
            gammaTextBox.Text = gamma.ToString();
            gammaBar.Value = gamma;
        }

        private void setButton_Click(object sender, EventArgs e) {
            if (!File.Exists(path)) {
                MessageBox.Show("Error: File dose not exist.\nCannot find .minecraft\\options.txt file.\nThis file is necessary to change the gamma value.\nPlease install the Minecraft, and if you already did, change the Minecraft version or re-install the game.", "Minecraft Gamma Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                option[gammaIndex] = $"gamma:{gamma}";
                try {
                    File.WriteAllLines(path, option);
                    MessageBox.Show($"Gamma value has been changed successfully!\nIf you are playing Minecraft now, please restart the game.", "Minecraft Gamma Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception ex) {
                    MessageBox.Show($"An error has occurred while changing the gamma value.\nDetail information: {ex.ToString()}", "Minecraft Gamma Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gammaBar_Scroll(object sender, EventArgs e) {
            gamma = int.Parse(gammaBar.Value.ToString());
            gammaTextBox.Text = gamma.ToString();
        }

        private void gammaTextBox_TextChanged(object sender, EventArgs e) {
            if (gammaTextBox.Text == "")
                gammaTextBox.Text = "1";
            gamma = int.Parse(gammaTextBox.Text);
            if (gamma < 1) {
                gamma = 1;
                gammaTextBox.Text = "1";
                gammaBar.Value = 1;
            } else if (gamma > 1000) {
                gamma = 1000;
                gammaTextBox.Text = "1000";
                gammaBar.Value = 1000;
            }
            gammaBar.Value = gamma;
        }

        private void Info_Click(object sender, EventArgs e) {
            if (!infoButton) {
                while (Height <= 296) {
                    Height += 4;
                    Refresh();
                }
                Height = 300;
                infoButton = true;
            } else {
                while (Height >= 159) {
                    Height -= 4;
                    Refresh();
                }
                Height = 155;
                infoButton = false;
            }
        }

        private void Close_Click(object sender, EventArgs e) { Close(); }
        private void Min_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        private void Main_MouseMove(object sender, MouseEventArgs e) { Utils.mouseMove(Handle); }
        private void PictureBox1_Click(object sender, EventArgs e) { Process.Start("https://github.com/Nitro1231/Minecraft-Gamma-Editor"); }
        private void PictureBox2_Click(object sender, EventArgs e) { Process.Start("https://nitro1231.github.io/"); }
        private void PictureBox3_Click(object sender, EventArgs e) { Process.Start("https://nitr0.tistory.com/"); }
        private void Label3_Click(object sender, EventArgs e) { Process.Start("https://icons8.com/"); }
        private void gammaTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
                e.Handled = true;
        }
        private void Main_Resize(object sender, EventArgs e) {
            Utils.smoothBorder(this, 10);
            Refresh();
        }
    }
}