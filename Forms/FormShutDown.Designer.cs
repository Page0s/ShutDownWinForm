namespace ShutDownWinForm2.Forms
{
    partial class FormShutDown
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRemove500 = new FontAwesome.Sharp.IconButton();
            this.btnAdd500 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove100 = new FontAwesome.Sharp.IconButton();
            this.btnAdd100 = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartCountdown = new FontAwesome.Sharp.IconButton();
            this.btnStopCountdown = new FontAwesome.Sharp.IconButton();
            this.btnResetCountdown = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTime.Location = new System.Drawing.Point(43, 243);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(509, 107);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00 : 00 : 00";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnResetCountdown);
            this.panel1.Controls.Add(this.btnStopCountdown);
            this.panel1.Controls.Add(this.btnStartCountdown);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.ForeColor = System.Drawing.Color.MediumPurple;
            this.panel1.Location = new System.Drawing.Point(113, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 437);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Location = new System.Drawing.Point(215, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(142, 54);
            this.panel5.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconSize = 16;
            this.btnClear.Location = new System.Drawing.Point(0, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Rotation = 0D;
            this.btnClear.Size = new System.Drawing.Size(142, 54);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 100);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnRemove500);
            this.panel4.Controls.Add(this.btnAdd500);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(287, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 100);
            this.panel4.TabIndex = 1;
            // 
            // btnRemove500
            // 
            this.btnRemove500.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove500.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRemove500.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove500.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnRemove500.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRemove500.IconColor = System.Drawing.Color.Black;
            this.btnRemove500.IconSize = 16;
            this.btnRemove500.Location = new System.Drawing.Point(0, 25);
            this.btnRemove500.Name = "btnRemove500";
            this.btnRemove500.Rotation = 0D;
            this.btnRemove500.Size = new System.Drawing.Size(288, 25);
            this.btnRemove500.TabIndex = 17;
            this.btnRemove500.Text = "- 500 s";
            this.btnRemove500.UseVisualStyleBackColor = true;
            this.btnRemove500.Click += new System.EventHandler(this.btnRemove500_Click);
            // 
            // btnAdd500
            // 
            this.btnAdd500.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd500.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdd500.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd500.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAdd500.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdd500.IconColor = System.Drawing.Color.Black;
            this.btnAdd500.IconSize = 16;
            this.btnAdd500.Location = new System.Drawing.Point(0, 0);
            this.btnAdd500.Name = "btnAdd500";
            this.btnAdd500.Rotation = 0D;
            this.btnAdd500.Size = new System.Drawing.Size(288, 25);
            this.btnAdd500.TabIndex = 15;
            this.btnAdd500.Text = "+ 500 s";
            this.btnAdd500.UseVisualStyleBackColor = true;
            this.btnAdd500.Click += new System.EventHandler(this.btnAdd500_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemove100);
            this.panel3.Controls.Add(this.btnAdd100);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 100);
            this.panel3.TabIndex = 0;
            // 
            // btnRemove100
            // 
            this.btnRemove100.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove100.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRemove100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove100.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnRemove100.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRemove100.IconColor = System.Drawing.Color.Black;
            this.btnRemove100.IconSize = 16;
            this.btnRemove100.Location = new System.Drawing.Point(0, 25);
            this.btnRemove100.Name = "btnRemove100";
            this.btnRemove100.Rotation = 0D;
            this.btnRemove100.Size = new System.Drawing.Size(287, 25);
            this.btnRemove100.TabIndex = 20;
            this.btnRemove100.Text = "- 100 s";
            this.btnRemove100.UseVisualStyleBackColor = true;
            this.btnRemove100.Click += new System.EventHandler(this.btnRemove100_Click);
            // 
            // btnAdd100
            // 
            this.btnAdd100.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd100.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdd100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd100.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAdd100.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdd100.IconColor = System.Drawing.Color.Black;
            this.btnAdd100.IconSize = 16;
            this.btnAdd100.Location = new System.Drawing.Point(0, 0);
            this.btnAdd100.Name = "btnAdd100";
            this.btnAdd100.Rotation = 0D;
            this.btnAdd100.Size = new System.Drawing.Size(287, 25);
            this.btnAdd100.TabIndex = 19;
            this.btnAdd100.Text = "+ 100 s";
            this.btnAdd100.UseVisualStyleBackColor = true;
            this.btnAdd100.Click += new System.EventHandler(this.btnAdd100_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStartCountdown
            // 
            this.btnStartCountdown.Enabled = false;
            this.btnStartCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCountdown.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStartCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCountdown.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStartCountdown.IconColor = System.Drawing.Color.Black;
            this.btnStartCountdown.IconSize = 16;
            this.btnStartCountdown.Location = new System.Drawing.Point(67, 106);
            this.btnStartCountdown.Name = "btnStartCountdown";
            this.btnStartCountdown.Rotation = 0D;
            this.btnStartCountdown.Size = new System.Drawing.Size(142, 54);
            this.btnStartCountdown.TabIndex = 9;
            this.btnStartCountdown.Text = "Start";
            this.btnStartCountdown.UseVisualStyleBackColor = true;
            this.btnStartCountdown.Click += new System.EventHandler(this.btnStartCountdown_Click);
            // 
            // btnStopCountdown
            // 
            this.btnStopCountdown.Enabled = false;
            this.btnStopCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopCountdown.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStopCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopCountdown.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStopCountdown.IconColor = System.Drawing.Color.Black;
            this.btnStopCountdown.IconSize = 16;
            this.btnStopCountdown.Location = new System.Drawing.Point(363, 106);
            this.btnStopCountdown.Name = "btnStopCountdown";
            this.btnStopCountdown.Rotation = 0D;
            this.btnStopCountdown.Size = new System.Drawing.Size(142, 54);
            this.btnStopCountdown.TabIndex = 10;
            this.btnStopCountdown.Text = "Stop";
            this.btnStopCountdown.UseVisualStyleBackColor = true;
            this.btnStopCountdown.Click += new System.EventHandler(this.btnStopCountDown_Click);
            // 
            // btnResetCountdown
            // 
            this.btnResetCountdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetCountdown.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnResetCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCountdown.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnResetCountdown.IconColor = System.Drawing.Color.Black;
            this.btnResetCountdown.IconSize = 16;
            this.btnResetCountdown.Location = new System.Drawing.Point(215, 166);
            this.btnResetCountdown.Name = "btnResetCountdown";
            this.btnResetCountdown.Rotation = 0D;
            this.btnResetCountdown.Size = new System.Drawing.Size(142, 54);
            this.btnResetCountdown.TabIndex = 11;
            this.btnResetCountdown.Text = "Reset";
            this.btnResetCountdown.UseVisualStyleBackColor = true;
            this.btnResetCountdown.Visible = false;
            this.btnResetCountdown.Click += new System.EventHandler(this.btnResetCountdown_Click);
            // 
            // FormShutDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormShutDown";
            this.Text = "Shut Down";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnRemove500;
        private FontAwesome.Sharp.IconButton btnAdd500;
        private FontAwesome.Sharp.IconButton btnAdd100;
        private FontAwesome.Sharp.IconButton btnRemove100;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnStopCountdown;
        private FontAwesome.Sharp.IconButton btnStartCountdown;
        private FontAwesome.Sharp.IconButton btnResetCountdown;
    }
}