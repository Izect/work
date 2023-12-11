namespace WinFormsApp2
{
    partial class frm_color
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_color));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.choicesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreboardListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.PLAYTIME = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_return = new Guna.UI2.WinForms.Guna2Button();
            this.PLAYTIME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            resources.ApplyResources(this.scoreLabel, "scoreLabel");
            this.scoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreLabel.Name = "scoreLabel";
            // 
            // colorLabel
            // 
            resources.ApplyResources(this.colorLabel, "colorLabel");
            this.colorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.colorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.colorLabel.Name = "colorLabel";
            // 
            // choicesListBox
            // 
            this.choicesListBox.BackColor = System.Drawing.Color.GhostWhite;
            this.choicesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.choicesListBox, "choicesListBox");
            this.choicesListBox.FormattingEnabled = true;
            this.choicesListBox.Name = "choicesListBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // scoreboardListBox
            // 
            resources.ApplyResources(this.scoreboardListBox, "scoreboardListBox");
            this.scoreboardListBox.FormattingEnabled = true;
            this.scoreboardListBox.Name = "scoreboardListBox";
            // 
            // inputTextBox
            // 
            resources.ApplyResources(this.inputTextBox, "inputTextBox");
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // PLAYTIME
            // 
            this.PLAYTIME.BackColor = System.Drawing.Color.Transparent;
            this.PLAYTIME.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.PLAYTIME.Controls.Add(this.choicesListBox);
            this.PLAYTIME.Controls.Add(this.inputTextBox);
            this.PLAYTIME.Controls.Add(this.scoreboardListBox);
            this.PLAYTIME.Controls.Add(this.label1);
            this.PLAYTIME.Controls.Add(this.pictureBox2);
            this.PLAYTIME.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.PLAYTIME.FillColor = System.Drawing.Color.Thistle;
            resources.ApplyResources(this.PLAYTIME, "PLAYTIME");
            this.PLAYTIME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PLAYTIME.Name = "PLAYTIME";
            this.PLAYTIME.ShadowDecoration.BorderRadius = 20;
            this.PLAYTIME.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.PLAYTIME.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(15);
            this.PLAYTIME.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.PLAYTIME.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.PLAYTIME.UseTransparentBackground = true;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Transparent;
            this.btn_return.BorderRadius = 15;
            this.btn_return.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_return.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_return.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_return.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.btn_return, "btn_return");
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_return.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_return.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_return.Name = "btn_return";
            this.btn_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_return.UseTransparentBackground = true;
            this.btn_return.Click += new System.EventHandler(this.btn_color_return_Click);
            // 
            // frm_color
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(180)))), ((int)(((byte)(124)))));
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PLAYTIME);
            this.Name = "frm_color";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PLAYTIME.ResumeLayout(false);
            this.PLAYTIME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ListBox choicesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox scoreboardListBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private Guna.UI2.WinForms.Guna2GroupBox PLAYTIME;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btn_return;
    }
}