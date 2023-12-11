namespace Learning_Game
{
    partial class frm_puzzle
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
            this.listone = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.Label();
            this.btn_return = new Guna.UI2.WinForms.Guna2Button();
            this.btn_hint = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listone
            // 
            this.listone.AutoSize = true;
            this.listone.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listone.Location = new System.Drawing.Point(12, 666);
            this.listone.Name = "listone";
            this.listone.Size = new System.Drawing.Size(224, 37);
            this.listone.TabIndex = 0;
            this.listone.Text = "Current Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1363, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFIle);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(314, 666);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1037, 37);
            this.status.TabIndex = 2;
            this.status.Text = "Status";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Transparent;
            this.btn_return.BorderRadius = 15;
            this.btn_return.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_return.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_return.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_return.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_return.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btn_return.Font = new System.Drawing.Font("Impact", 24F);
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_return.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_return.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_return.Location = new System.Drawing.Point(1249, 416);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(153, 47);
            this.btn_return.TabIndex = 8;
            this.btn_return.Text = "Return";
            this.btn_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_return.UseTransparentBackground = true;
            // 
            // btn_hint
            // 
            this.btn_hint.BackColor = System.Drawing.Color.Transparent;
            this.btn_hint.BorderRadius = 15;
            this.btn_hint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btn_hint.Font = new System.Drawing.Font("Impact", 24F);
            this.btn_hint.ForeColor = System.Drawing.Color.White;
            this.btn_hint.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_hint.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_hint.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_hint.Location = new System.Drawing.Point(1249, 340);
            this.btn_hint.Name = "btn_hint";
            this.btn_hint.Size = new System.Drawing.Size(153, 47);
            this.btn_hint.TabIndex = 8;
            this.btn_hint.Text = "HINT";
            this.btn_hint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_hint.UseTransparentBackground = true;
            this.btn_hint.Click += new System.EventHandler(this.btn_hint_Click);
            // 
            // frm_puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1363, 712);
            this.Controls.Add(this.btn_hint);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.status);
            this.Controls.Add(this.listone);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_puzzle";
            this.Text = "Puzzle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label status;
        private Guna.UI2.WinForms.Guna2Button btn_return;
        private Guna.UI2.WinForms.Guna2Button btn_hint;
    }
}