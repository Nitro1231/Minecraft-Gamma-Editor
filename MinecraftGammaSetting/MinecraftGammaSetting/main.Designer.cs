namespace MinecraftGammaSetting
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.close = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gammaBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gammaTextBox = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gammaBar)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.topPanel.Controls.Add(this.close);
            this.topPanel.Controls.Add(this.min);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(350, 24);
            this.topPanel.TabIndex = 3;
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.close.Location = new System.Drawing.Point(4, 4);
            this.close.Margin = new System.Windows.Forms.Padding(4, 4, 2, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.TabIndex = 4;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.min.Location = new System.Drawing.Point(24, 4);
            this.min.Margin = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(16, 16);
            this.min.TabIndex = 5;
            this.min.Click += new System.EventHandler(this.Min_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minecraft Gamma Editor";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // gammaBar
            // 
            this.gammaBar.Location = new System.Drawing.Point(10, 58);
            this.gammaBar.Maximum = 1000;
            this.gammaBar.Minimum = 1;
            this.gammaBar.Name = "gammaBar";
            this.gammaBar.Size = new System.Drawing.Size(330, 45);
            this.gammaBar.TabIndex = 4;
            this.gammaBar.Value = 1;
            this.gammaBar.Scroll += new System.EventHandler(this.gammaBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Change Gamma value to: ";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Set_Click);
            // 
            // gammaTextBox
            // 
            this.gammaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gammaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gammaTextBox.ForeColor = System.Drawing.Color.White;
            this.gammaTextBox.Location = new System.Drawing.Point(172, 35);
            this.gammaTextBox.Multiline = true;
            this.gammaTextBox.Name = "gammaTextBox";
            this.gammaTextBox.Size = new System.Drawing.Size(35, 17);
            this.gammaTextBox.TabIndex = 7;
            this.gammaTextBox.Text = "1";
            this.gammaTextBox.TextChanged += new System.EventHandler(this.gammaTextBox_TextChanged);
            this.gammaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gammaTextBox_KeyPress);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(350, 155);
            this.Controls.Add(this.gammaTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gammaBar);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "MinecraftGammaSetting";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gammaBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel topPanel;
        private System.Windows.Forms.Panel close;
        private System.Windows.Forms.Panel min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar gammaBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox gammaTextBox;
    }
}

