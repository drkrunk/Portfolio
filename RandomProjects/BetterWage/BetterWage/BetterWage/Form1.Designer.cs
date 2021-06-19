namespace BetterWage
{
    partial class JobForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultBox1 = new System.Windows.Forms.RichTextBox();
            this.hoursBox1 = new System.Windows.Forms.NumericUpDown();
            this.wageBox1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new BetterWage.NewProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultBox2 = new System.Windows.Forms.RichTextBox();
            this.hoursBox2 = new System.Windows.Forms.NumericUpDown();
            this.wageBox2 = new System.Windows.Forms.NumericUpDown();
            this.progressBar2 = new BetterWage.NewProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.hoursBox1);
            this.groupBox1.Controls.Add(this.wageBox1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job1";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // resultBox1
            // 
            this.resultBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.resultBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.resultBox1.Location = new System.Drawing.Point(6, 8);
            this.resultBox1.Name = "resultBox1";
            this.resultBox1.ReadOnly = true;
            this.resultBox1.Size = new System.Drawing.Size(356, 193);
            this.resultBox1.TabIndex = 7;
            this.resultBox1.TabStop = false;
            this.resultBox1.Text = "No Data Entered";
            // 
            // hoursBox1
            // 
            this.hoursBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hoursBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.hoursBox1.Location = new System.Drawing.Point(196, 128);
            this.hoursBox1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hoursBox1.Name = "hoursBox1";
            this.hoursBox1.Size = new System.Drawing.Size(180, 32);
            this.hoursBox1.TabIndex = 6;
            this.hoursBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursBox1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hoursBox1.ValueChanged += new System.EventHandler(this.hoursBox1_ValueChanged);
            // 
            // wageBox1
            // 
            this.wageBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.wageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wageBox1.DecimalPlaces = 2;
            this.wageBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wageBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.wageBox1.Location = new System.Drawing.Point(196, 68);
            this.wageBox1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wageBox1.Name = "wageBox1";
            this.wageBox1.Size = new System.Drawing.Size(180, 32);
            this.wageBox1.TabIndex = 5;
            this.wageBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wageBox1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wageBox1.ValueChanged += new System.EventHandler(this.wageBox1_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(6, 407);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(370, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hours Per Week";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount Per Hour";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.hoursBox2);
            this.groupBox2.Controls.Add(this.wageBox2);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(391, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job2";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // resultBox2
            // 
            this.resultBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.resultBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.resultBox2.Location = new System.Drawing.Point(9, 9);
            this.resultBox2.Name = "resultBox2";
            this.resultBox2.ReadOnly = true;
            this.resultBox2.Size = new System.Drawing.Size(353, 193);
            this.resultBox2.TabIndex = 13;
            this.resultBox2.TabStop = false;
            this.resultBox2.Text = "No Data Entered";
            // 
            // hoursBox2
            // 
            this.hoursBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hoursBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.hoursBox2.Location = new System.Drawing.Point(196, 128);
            this.hoursBox2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hoursBox2.Name = "hoursBox2";
            this.hoursBox2.Size = new System.Drawing.Size(180, 32);
            this.hoursBox2.TabIndex = 12;
            this.hoursBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hoursBox2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hoursBox2.ValueChanged += new System.EventHandler(this.hoursBox2_ValueChanged);
            // 
            // wageBox2
            // 
            this.wageBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.wageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wageBox2.DecimalPlaces = 2;
            this.wageBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wageBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.wageBox2.Location = new System.Drawing.Point(196, 68);
            this.wageBox2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wageBox2.Name = "wageBox2";
            this.wageBox2.Size = new System.Drawing.Size(180, 32);
            this.wageBox2.TabIndex = 11;
            this.wageBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wageBox2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wageBox2.ValueChanged += new System.EventHandler(this.wageBox2_ValueChanged);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar2.Location = new System.Drawing.Point(6, 407);
            this.progressBar2.MarqueeAnimationSpeed = 0;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(370, 10);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 10;
            this.progressBar2.Value = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hours Per Week";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount Per Hour";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.resultBox1);
            this.panel1.Location = new System.Drawing.Point(6, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 210);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.resultBox2);
            this.panel2.Location = new System.Drawing.Point(6, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 210);
            this.panel2.TabIndex = 14;
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "JobForm";
            this.Text = "Better Wage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown wageBox1;
        private System.Windows.Forms.RichTextBox resultBox1;
        private System.Windows.Forms.NumericUpDown hoursBox1;
        private System.Windows.Forms.RichTextBox resultBox2;
        private System.Windows.Forms.NumericUpDown hoursBox2;
        private System.Windows.Forms.NumericUpDown wageBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private NewProgressBar progressBar1;
        private NewProgressBar progressBar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

