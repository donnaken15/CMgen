namespace CMgen
{
    partial class program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program));
            this.stagelist = new System.Windows.Forms.ListBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.timelbl = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.NumericUpDown();
            this.final = new System.Windows.Forms.CheckBox();
            this.timeBool = new System.Windows.Forms.CheckBox();
            this.goal_r = new System.Windows.Forms.CheckBox();
            this.warplbl = new System.Windows.Forms.Label();
            this.goal_g = new System.Windows.Forms.CheckBox();
            this.goal_b = new System.Windows.Forms.CheckBox();
            this.addstage = new System.Windows.Forms.Button();
            this.remstage = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            this.SuspendLayout();
            // 
            // stagelist
            // 
            this.stagelist.Dock = System.Windows.Forms.DockStyle.Left;
            this.stagelist.FormattingEnabled = true;
            this.stagelist.IntegralHeight = false;
            this.stagelist.Location = new System.Drawing.Point(0, 0);
            this.stagelist.Name = "stagelist";
            this.stagelist.Size = new System.Drawing.Size(70, 210);
            this.stagelist.TabIndex = 0;
            this.stagelist.SelectedIndexChanged += new System.EventHandler(this.selectstg);
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.idlbl.Location = new System.Drawing.Point(73, 2);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(52, 13);
            this.idlbl.TabIndex = 1;
            this.idlbl.Text = "Stage ID:";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(73, 17);
            this.id.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.id.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(52, 20);
            this.id.TabIndex = 0;
            this.id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.id.ValueChanged += new System.EventHandler(this.updatestgid);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.timelbl.Location = new System.Drawing.Point(73, 38);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(33, 13);
            this.timelbl.TabIndex = 2;
            this.timelbl.Text = "Time:";
            // 
            // time
            // 
            this.time.DecimalPlaces = 2;
            this.time.Enabled = false;
            this.time.Location = new System.Drawing.Point(73, 55);
            this.time.Maximum = new decimal(new int[] {
            1166199371,
            1,
            0,
            458752});
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(52, 20);
            this.time.TabIndex = 3;
            this.time.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.time.ValueChanged += new System.EventHandler(this.updatestgtime);
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.Enabled = false;
            this.final.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.final.Location = new System.Drawing.Point(73, 79);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(54, 18);
            this.final.TabIndex = 4;
            this.final.Text = "Final";
            this.final.UseVisualStyleBackColor = true;
            // 
            // timeBool
            // 
            this.timeBool.AutoSize = true;
            this.timeBool.Enabled = false;
            this.timeBool.Location = new System.Drawing.Point(111, 39);
            this.timeBool.Name = "timeBool";
            this.timeBool.Size = new System.Drawing.Size(15, 14);
            this.timeBool.TabIndex = 5;
            this.timeBool.UseVisualStyleBackColor = true;
            this.timeBool.CheckedChanged += new System.EventHandler(this.updatestgtimer);
            this.timeBool.Click += new System.EventHandler(this.timeToggle);
            // 
            // goal_r
            // 
            this.goal_r.AutoSize = true;
            this.goal_r.Enabled = false;
            this.goal_r.Location = new System.Drawing.Point(73, 148);
            this.goal_r.Name = "goal_r";
            this.goal_r.Size = new System.Drawing.Size(46, 17);
            this.goal_r.TabIndex = 6;
            this.goal_r.Text = "Red";
            this.goal_r.UseVisualStyleBackColor = true;
            // 
            // warplbl
            // 
            this.warplbl.AutoSize = true;
            this.warplbl.Location = new System.Drawing.Point(73, 98);
            this.warplbl.Name = "warplbl";
            this.warplbl.Size = new System.Drawing.Size(38, 13);
            this.warplbl.TabIndex = 7;
            this.warplbl.Text = "Warps";
            // 
            // goal_g
            // 
            this.goal_g.AutoSize = true;
            this.goal_g.Enabled = false;
            this.goal_g.Location = new System.Drawing.Point(73, 131);
            this.goal_g.Name = "goal_g";
            this.goal_g.Size = new System.Drawing.Size(55, 17);
            this.goal_g.TabIndex = 8;
            this.goal_g.Text = "Green";
            this.goal_g.UseVisualStyleBackColor = true;
            // 
            // goal_b
            // 
            this.goal_b.AutoSize = true;
            this.goal_b.Enabled = false;
            this.goal_b.Location = new System.Drawing.Point(73, 115);
            this.goal_b.Name = "goal_b";
            this.goal_b.Size = new System.Drawing.Size(47, 17);
            this.goal_b.TabIndex = 9;
            this.goal_b.Text = "Blue";
            this.goal_b.UseVisualStyleBackColor = true;
            // 
            // addstage
            // 
            this.addstage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addstage.Location = new System.Drawing.Point(73, 164);
            this.addstage.Name = "addstage";
            this.addstage.Size = new System.Drawing.Size(14, 14);
            this.addstage.TabIndex = 10;
            this.addstage.Text = "+";
            this.addstage.UseVisualStyleBackColor = true;
            this.addstage.Click += new System.EventHandler(this.addstg);
            // 
            // remstage
            // 
            this.remstage.Enabled = false;
            this.remstage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.remstage.Location = new System.Drawing.Point(89, 164);
            this.remstage.Name = "remstage";
            this.remstage.Size = new System.Drawing.Size(14, 14);
            this.remstage.TabIndex = 11;
            this.remstage.Text = "-";
            this.remstage.UseVisualStyleBackColor = true;
            this.remstage.Click += new System.EventHandler(this.delstage);
            // 
            // clear
            // 
            this.clear.Enabled = false;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(106, 164);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(20, 14);
            this.clear.TabIndex = 12;
            this.clear.Text = "clr";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clearstg);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(73, 181);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(53, 27);
            this.save.TabIndex = 13;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(127, 210);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.remstage);
            this.Controls.Add(this.addstage);
            this.Controls.Add(this.goal_b);
            this.Controls.Add(this.goal_g);
            this.Controls.Add(this.warplbl);
            this.Controls.Add(this.goal_r);
            this.Controls.Add(this.timeBool);
            this.Controls.Add(this.final);
            this.Controls.Add(this.time);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.id);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.stagelist);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(6, 34);
            this.Name = "program";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMB1CMGEN";
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stagelist;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.NumericUpDown time;
        private System.Windows.Forms.CheckBox final;
        private System.Windows.Forms.CheckBox timeBool;
        private System.Windows.Forms.CheckBox goal_r;
        private System.Windows.Forms.Label warplbl;
        private System.Windows.Forms.CheckBox goal_g;
        private System.Windows.Forms.CheckBox goal_b;
        private System.Windows.Forms.Button addstage;
        private System.Windows.Forms.Button remstage;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
    }
}

