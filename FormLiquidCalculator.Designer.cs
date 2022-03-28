namespace Liquid_Rechner
{
    partial class FormLiquidCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMaxNicotine = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Lbl_Aroma = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Rb_AromaIn_ml = new System.Windows.Forms.RadioButton();
            this.Rb_AromaIn_percent = new System.Windows.Forms.RadioButton();
            this.TxtTargetNicotine = new System.Windows.Forms.TextBox();
            this.TxtAromaAmount = new System.Windows.Forms.TextBox();
            this.TxtNicotineContent_Shot = new System.Windows.Forms.TextBox();
            this.TxtBottleSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblMaxNicotine
            // 
            this.LblMaxNicotine.AutoSize = true;
            this.LblMaxNicotine.Location = new System.Drawing.Point(421, 179);
            this.LblMaxNicotine.Name = "LblMaxNicotine";
            this.LblMaxNicotine.Size = new System.Drawing.Size(90, 15);
            this.LblMaxNicotine.TabIndex = 31;
            this.LblMaxNicotine.Text = "(max. 0 mg/ml)";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(115, 277);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(448, 112);
            this.TxtResult.TabIndex = 30;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(151, 248);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 29;
            this.BtnCalculate.Text = "Berechnen";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(365, 179);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(50, 15);
            this.Label6.TabIndex = 28;
            this.Label6.Text = "mg / ml";
            // 
            // Lbl_Aroma
            // 
            this.Lbl_Aroma.AutoSize = true;
            this.Lbl_Aroma.Location = new System.Drawing.Point(365, 119);
            this.Lbl_Aroma.Name = "Lbl_Aroma";
            this.Lbl_Aroma.Size = new System.Drawing.Size(21, 15);
            this.Lbl_Aroma.TabIndex = 27;
            this.Lbl_Aroma.Text = "ml";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(365, 65);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(50, 15);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "mg / ml";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(365, 12);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(21, 15);
            this.Label4.TabIndex = 25;
            this.Label4.Text = "ml";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(99, 179);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(154, 15);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "Gewünschter Nikotingehalt:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(115, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(138, 15);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Nikotingehalt 10ml Shot:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(166, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 15);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Flaschengröße:";
            // 
            // Rb_AromaIn_ml
            // 
            this.Rb_AromaIn_ml.AutoSize = true;
            this.Rb_AromaIn_ml.Checked = true;
            this.Rb_AromaIn_ml.Location = new System.Drawing.Point(162, 132);
            this.Rb_AromaIn_ml.Name = "Rb_AromaIn_ml";
            this.Rb_AromaIn_ml.Size = new System.Drawing.Size(91, 19);
            this.Rb_AromaIn_ml.TabIndex = 21;
            this.Rb_AromaIn_ml.TabStop = true;
            this.Rb_AromaIn_ml.Text = "Aroma in ml";
            this.Rb_AromaIn_ml.UseVisualStyleBackColor = true;
            this.Rb_AromaIn_ml.CheckedChanged += new System.EventHandler(this.Rb_AromaIn_ml_CheckedChanged);
            // 
            // Rb_AromaIn_percent
            // 
            this.Rb_AromaIn_percent.AutoSize = true;
            this.Rb_AromaIn_percent.Location = new System.Drawing.Point(162, 107);
            this.Rb_AromaIn_percent.Name = "Rb_AromaIn_percent";
            this.Rb_AromaIn_percent.Size = new System.Drawing.Size(87, 19);
            this.Rb_AromaIn_percent.TabIndex = 20;
            this.Rb_AromaIn_percent.Text = "Aroma in %";
            this.Rb_AromaIn_percent.UseVisualStyleBackColor = true;
            this.Rb_AromaIn_percent.CheckedChanged += new System.EventHandler(this.Rb_AromaIn_percent_CheckedChanged);
            // 
            // TxtTargetNicotine
            // 
            this.TxtTargetNicotine.Enabled = false;
            this.TxtTargetNicotine.Location = new System.Drawing.Point(259, 176);
            this.TxtTargetNicotine.Name = "TxtTargetNicotine";
            this.TxtTargetNicotine.Size = new System.Drawing.Size(100, 23);
            this.TxtTargetNicotine.TabIndex = 19;
            this.TxtTargetNicotine.Text = "0";
            this.TxtTargetNicotine.TextChanged += new System.EventHandler(this.TxtTargetNicotine_TextChanged);
            // 
            // TxtAromaAmount
            // 
            this.TxtAromaAmount.Location = new System.Drawing.Point(259, 116);
            this.TxtAromaAmount.Name = "TxtAromaAmount";
            this.TxtAromaAmount.Size = new System.Drawing.Size(100, 23);
            this.TxtAromaAmount.TabIndex = 18;
            this.TxtAromaAmount.Text = "0";
            this.TxtAromaAmount.TextChanged += new System.EventHandler(this.TxtAromaAmount_TextChanged);
            // 
            // TxtNicotineContent_Shot
            // 
            this.TxtNicotineContent_Shot.Location = new System.Drawing.Point(259, 62);
            this.TxtNicotineContent_Shot.Name = "TxtNicotineContent_Shot";
            this.TxtNicotineContent_Shot.Size = new System.Drawing.Size(100, 23);
            this.TxtNicotineContent_Shot.TabIndex = 17;
            this.TxtNicotineContent_Shot.Text = "0";
            this.TxtNicotineContent_Shot.TextChanged += new System.EventHandler(this.TxtNicotineContent_Shot_TextChanged);
            // 
            // TxtBottleSize
            // 
            this.TxtBottleSize.Location = new System.Drawing.Point(259, 9);
            this.TxtBottleSize.Name = "TxtBottleSize";
            this.TxtBottleSize.Size = new System.Drawing.Size(100, 23);
            this.TxtBottleSize.TabIndex = 16;
            this.TxtBottleSize.Text = "0";
            this.TxtBottleSize.TextChanged += new System.EventHandler(this.TxtBottleSize_TextChanged);
            // 
            // FormLiquidCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMaxNicotine);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Lbl_Aroma);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Rb_AromaIn_ml);
            this.Controls.Add(this.Rb_AromaIn_percent);
            this.Controls.Add(this.TxtTargetNicotine);
            this.Controls.Add(this.TxtAromaAmount);
            this.Controls.Add(this.TxtNicotineContent_Shot);
            this.Controls.Add(this.TxtBottleSize);
            this.Name = "FormLiquidCalculator";
            this.Text = "Liquid Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label LblMaxNicotine;
        internal TextBox TxtResult;
        internal Button BtnCalculate;
        internal Label Label6;
        internal Label Lbl_Aroma;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal RadioButton Rb_AromaIn_percent;
        internal TextBox TxtTargetNicotine;
        internal TextBox TxtAromaAmount;
        internal TextBox TxtNicotineContent_Shot;
        public TextBox TxtBottleSize;
        public RadioButton Rb_AromaIn_ml;
    }
}