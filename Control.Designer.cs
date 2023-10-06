
namespace KosarVezerlo
{
    partial class Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.home1btn = new System.Windows.Forms.Button();
            this.home2btn = new System.Windows.Forms.Button();
            this.home3btn = new System.Windows.Forms.Button();
            this.homeM1btn = new System.Windows.Forms.Button();
            this.away1btn = new System.Windows.Forms.Button();
            this.awayM1btn = new System.Windows.Forms.Button();
            this.away2btn = new System.Windows.Forms.Button();
            this.away3btn = new System.Windows.Forms.Button();
            this.q1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.home0btn = new System.Windows.Forms.Button();
            this.away0btn = new System.Windows.Forms.Button();
            this.homeRadio = new System.Windows.Forms.RadioButton();
            this.awayRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(103, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(347, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Away";
            // 
            // home1btn
            // 
            this.home1btn.Location = new System.Drawing.Point(108, 250);
            this.home1btn.Name = "home1btn";
            this.home1btn.Size = new System.Drawing.Size(50, 50);
            this.home1btn.TabIndex = 2;
            this.home1btn.Tag = "home";
            this.home1btn.Text = "+1";
            this.home1btn.UseVisualStyleBackColor = true;
            this.home1btn.Click += new System.EventHandler(this.newValueAdd);
            // 
            // home2btn
            // 
            this.home2btn.Location = new System.Drawing.Point(164, 250);
            this.home2btn.Name = "home2btn";
            this.home2btn.Size = new System.Drawing.Size(50, 50);
            this.home2btn.TabIndex = 2;
            this.home2btn.Tag = "home";
            this.home2btn.Text = "+2";
            this.home2btn.UseVisualStyleBackColor = true;
            this.home2btn.Click += new System.EventHandler(this.newValueAdd);
            // 
            // home3btn
            // 
            this.home3btn.Location = new System.Drawing.Point(220, 250);
            this.home3btn.Name = "home3btn";
            this.home3btn.Size = new System.Drawing.Size(50, 50);
            this.home3btn.TabIndex = 2;
            this.home3btn.Tag = "home";
            this.home3btn.Text = "+3";
            this.home3btn.UseVisualStyleBackColor = true;
            this.home3btn.Click += new System.EventHandler(this.newValueAdd);
            // 
            // homeM1btn
            // 
            this.homeM1btn.Location = new System.Drawing.Point(108, 306);
            this.homeM1btn.Name = "homeM1btn";
            this.homeM1btn.Size = new System.Drawing.Size(50, 50);
            this.homeM1btn.TabIndex = 2;
            this.homeM1btn.Tag = "home";
            this.homeM1btn.Text = "-1";
            this.homeM1btn.UseVisualStyleBackColor = true;
            this.homeM1btn.Click += new System.EventHandler(this.newValueAdd);
            // 
            // away1btn
            // 
            this.away1btn.Location = new System.Drawing.Point(350, 250);
            this.away1btn.Name = "away1btn";
            this.away1btn.Size = new System.Drawing.Size(50, 50);
            this.away1btn.TabIndex = 2;
            this.away1btn.Tag = "away";
            this.away1btn.Text = "+1";
            this.away1btn.UseVisualStyleBackColor = true;
            this.away1btn.Click += new System.EventHandler(this.newValueAdd);
            // 
            // awayM1btn
            // 
            this.awayM1btn.Location = new System.Drawing.Point(350, 306);
            this.awayM1btn.Name = "awayM1btn";
            this.awayM1btn.Size = new System.Drawing.Size(50, 50);
            this.awayM1btn.TabIndex = 2;
            this.awayM1btn.Tag = "away";
            this.awayM1btn.Text = "-1";
            this.awayM1btn.UseVisualStyleBackColor = true;
            this.awayM1btn.Click += new System.EventHandler(this.newValueAdd);
            // 
            // away2btn
            // 
            this.away2btn.Location = new System.Drawing.Point(406, 250);
            this.away2btn.Name = "away2btn";
            this.away2btn.Size = new System.Drawing.Size(50, 50);
            this.away2btn.TabIndex = 2;
            this.away2btn.Tag = "away";
            this.away2btn.Text = "+2";
            this.away2btn.UseVisualStyleBackColor = true;
            this.away2btn.Click += new System.EventHandler(this.newValueAdd);
            // 
            // away3btn
            // 
            this.away3btn.Location = new System.Drawing.Point(462, 250);
            this.away3btn.Name = "away3btn";
            this.away3btn.Size = new System.Drawing.Size(50, 50);
            this.away3btn.TabIndex = 2;
            this.away3btn.Tag = "away";
            this.away3btn.Text = "+3";
            this.away3btn.UseVisualStyleBackColor = true;
            this.away3btn.Click += new System.EventHandler(this.newValueAdd);
            // 
            // q1
            // 
            this.q1.Location = new System.Drawing.Point(596, 250);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(50, 50);
            this.q1.TabIndex = 2;
            this.q1.Text = "+";
            this.q1.UseVisualStyleBackColor = true;
            this.q1.Click += new System.EventHandler(this.setQuarter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(591, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quarters";
            // 
            // home0btn
            // 
            this.home0btn.Location = new System.Drawing.Point(164, 306);
            this.home0btn.Name = "home0btn";
            this.home0btn.Size = new System.Drawing.Size(50, 50);
            this.home0btn.TabIndex = 2;
            this.home0btn.Tag = "home";
            this.home0btn.Text = "0";
            this.home0btn.UseVisualStyleBackColor = true;
            this.home0btn.Click += new System.EventHandler(this.newValueAdd);
            // 
            // away0btn
            // 
            this.away0btn.Location = new System.Drawing.Point(406, 306);
            this.away0btn.Name = "away0btn";
            this.away0btn.Size = new System.Drawing.Size(50, 50);
            this.away0btn.TabIndex = 2;
            this.away0btn.Tag = "away";
            this.away0btn.Text = "0";
            this.away0btn.UseVisualStyleBackColor = true;
            this.away0btn.Click += new System.EventHandler(this.newValueAdd);
            // 
            // homeRadio
            // 
            this.homeRadio.AutoSize = true;
            this.homeRadio.BackColor = System.Drawing.Color.White;
            this.homeRadio.Checked = true;
            this.homeRadio.ForeColor = System.Drawing.Color.Blue;
            this.homeRadio.Location = new System.Drawing.Point(34, 3);
            this.homeRadio.Name = "homeRadio";
            this.homeRadio.Padding = new System.Windows.Forms.Padding(5);
            this.homeRadio.Size = new System.Drawing.Size(93, 27);
            this.homeRadio.TabIndex = 3;
            this.homeRadio.TabStop = true;
            this.homeRadio.Text = "Home Team";
            this.homeRadio.UseVisualStyleBackColor = false;
            // 
            // awayRadio
            // 
            this.awayRadio.AutoSize = true;
            this.awayRadio.BackColor = System.Drawing.Color.White;
            this.awayRadio.ForeColor = System.Drawing.Color.Red;
            this.awayRadio.Location = new System.Drawing.Point(144, 3);
            this.awayRadio.Name = "awayRadio";
            this.awayRadio.Padding = new System.Windows.Forms.Padding(5);
            this.awayRadio.Size = new System.Drawing.Size(91, 27);
            this.awayRadio.TabIndex = 3;
            this.awayRadio.Text = "Away Team";
            this.awayRadio.UseVisualStyleBackColor = false;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(118)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.awayRadio);
            this.Controls.Add(this.homeRadio);
            this.Controls.Add(this.away3btn);
            this.Controls.Add(this.away2btn);
            this.Controls.Add(this.home3btn);
            this.Controls.Add(this.awayM1btn);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.home2btn);
            this.Controls.Add(this.away1btn);
            this.Controls.Add(this.away0btn);
            this.Controls.Add(this.home0btn);
            this.Controls.Add(this.homeM1btn);
            this.Controls.Add(this.home1btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button home1btn;
        private System.Windows.Forms.Button home2btn;
        private System.Windows.Forms.Button home3btn;
        private System.Windows.Forms.Button homeM1btn;
        private System.Windows.Forms.Button away1btn;
        private System.Windows.Forms.Button awayM1btn;
        private System.Windows.Forms.Button away2btn;
        private System.Windows.Forms.Button away3btn;
        private System.Windows.Forms.Button q1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button home0btn;
        private System.Windows.Forms.Button away0btn;
        private System.Windows.Forms.RadioButton homeRadio;
        private System.Windows.Forms.RadioButton awayRadio;
    }
}

