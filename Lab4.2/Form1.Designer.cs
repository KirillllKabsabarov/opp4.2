namespace Lab4._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelA = new System.Windows.Forms.Label();
            this.trackBaraA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.trackBaraA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.labelA.Location = new System.Drawing.Point(57, 27);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(559, 91);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "А  <=  B  <=  C";
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // trackBaraA
            // 
            this.trackBaraA.Location = new System.Drawing.Point(12, 204);
            this.trackBaraA.Maximum = 100;
            this.trackBaraA.Name = "trackBaraA";
            this.trackBaraA.Size = new System.Drawing.Size(185, 45);
            this.trackBaraA.TabIndex = 3;
            this.trackBaraA.Value = 10;
            this.trackBaraA.Scroll += new System.EventHandler(this.trackBaraA_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(244, 204);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(181, 45);
            this.trackBarB.TabIndex = 4;
            this.trackBarB.Value = 12;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(478, 204);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(187, 45);
            this.trackBarC.TabIndex = 5;
            this.trackBarC.Value = 14;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBarC_Scroll);
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(12, 139);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(185, 20);
            this.textBox_A.TabIndex = 10;
            this.textBox_A.Text = "10";
            this.textBox_A.TextChanged += new System.EventHandler(this.textBox_A_TextChanged);
            this.textBox_A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_A_KeyDown);
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(244, 139);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(181, 20);
            this.textBox_B.TabIndex = 11;
            this.textBox_B.Text = "12";
            this.textBox_B.TextChanged += new System.EventHandler(this.textBox_B_TextChanged);
            this.textBox_B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_B_KeyDown);
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(478, 139);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(187, 20);
            this.textBox_C.TabIndex = 12;
            this.textBox_C.Text = "14";
            this.textBox_C.TextChanged += new System.EventHandler(this.textBox_C_TextChanged);
            this.textBox_C.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_C_KeyDown);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(12, 168);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(185, 20);
            this.numericUpDownA.TabIndex = 13;
            this.numericUpDownA.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(244, 167);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(181, 20);
            this.numericUpDownB.TabIndex = 14;
            this.numericUpDownB.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChanged);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(478, 166);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(187, 20);
            this.numericUpDownC.TabIndex = 15;
            this.numericUpDownC.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownC_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 278);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBaraA);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBaraA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TrackBar trackBaraA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

