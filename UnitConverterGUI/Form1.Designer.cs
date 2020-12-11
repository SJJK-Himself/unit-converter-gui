namespace UnitConverterGUI
{
    partial class UnitConverterGUI
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.measurement1_label = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.convertLabel = new System.Windows.Forms.Label();
            this.measurement2_label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kilometers",
            "Miles",
            "Meters",
            "Feet"});
            this.comboBox1.Location = new System.Drawing.Point(12, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Choose a unit";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.unitBox1_SelectedIndexChanged);
            // 
            // measurement1_label
            // 
            this.measurement1_label.AutoSize = true;
            this.measurement1_label.Location = new System.Drawing.Point(155, 15);
            this.measurement1_label.Name = "measurement1_label";
            this.measurement1_label.Size = new System.Drawing.Size(0, 13);
            this.measurement1_label.TabIndex = 2;
            this.measurement1_label.Click += new System.EventHandler(this.measurement1_label_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(200, 41);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(0, 13);
            this.toLabel.TabIndex = 3;
            this.toLabel.Click += new System.EventHandler(this.static1_label_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(265, 12);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(137, 20);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Kilometers",
            "Miles",
            "Meters",
            "Feet"});
            this.comboBox2.Location = new System.Drawing.Point(265, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "Choose a unit";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.unitBox2_SelectedIndexChanged);
            // 
            // convertLabel
            // 
            this.convertLabel.AllowDrop = true;
            this.convertLabel.AutoSize = true;
            this.convertLabel.Location = new System.Drawing.Point(192, 15);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(0, 13);
            this.convertLabel.TabIndex = 7;
            // 
            // measurement2_label
            // 
            this.measurement2_label.AutoSize = true;
            this.measurement2_label.Location = new System.Drawing.Point(434, 14);
            this.measurement2_label.Name = "measurement2_label";
            this.measurement2_label.Size = new System.Drawing.Size(0, 13);
            this.measurement2_label.TabIndex = 8;
            this.measurement2_label.Click += new System.EventHandler(this.measurement2_label_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.InterceptArrowKeys = false;
            this.numericUpDown1.Location = new System.Drawing.Point(12, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(137, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 42);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guide";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Choose the units\r\n2. Set the amount of unit to convert\r\n";
            // 
            // UnitConverterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 126);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.measurement2_label);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.measurement1_label);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UnitConverterGUI";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.UnitConverterGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label measurement1_label;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.Label measurement2_label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

