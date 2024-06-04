namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelEntInterpolation = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.inrerpolationTx = new System.Windows.Forms.TextBox();
            this.xValuesTx = new System.Windows.Forms.TextBox();
            this.yValuesTx = new System.Windows.Forms.TextBox();
            this.labelXValues = new System.Windows.Forms.Label();
            this.labelYValues = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtPolynomial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfIterations = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(208, 300);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 52);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // labelEntInterpolation
            // 
            this.labelEntInterpolation.AutoSize = true;
            this.labelEntInterpolation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEntInterpolation.Location = new System.Drawing.Point(43, 192);
            this.labelEntInterpolation.Name = "labelEntInterpolation";
            this.labelEntInterpolation.Size = new System.Drawing.Size(213, 29);
            this.labelEntInterpolation.TabIndex = 2;
            this.labelEntInterpolation.Text = "Interpolation Value";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(50, 309);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 29);
            this.listBox.TabIndex = 3;
            // 
            // inrerpolationTx
            // 
            this.inrerpolationTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inrerpolationTx.Location = new System.Drawing.Point(48, 224);
            this.inrerpolationTx.Name = "inrerpolationTx";
            this.inrerpolationTx.Size = new System.Drawing.Size(122, 34);
            this.inrerpolationTx.TabIndex = 5;
            // 
            // xValuesTx
            // 
            this.xValuesTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xValuesTx.Location = new System.Drawing.Point(48, 122);
            this.xValuesTx.Name = "xValuesTx";
            this.xValuesTx.Size = new System.Drawing.Size(122, 34);
            this.xValuesTx.TabIndex = 9;
            // 
            // yValuesTx
            // 
            this.yValuesTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yValuesTx.Location = new System.Drawing.Point(226, 122);
            this.yValuesTx.Name = "yValuesTx";
            this.yValuesTx.Size = new System.Drawing.Size(123, 34);
            this.yValuesTx.TabIndex = 8;
            // 
            // labelXValues
            // 
            this.labelXValues.AutoSize = true;
            this.labelXValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXValues.Location = new System.Drawing.Point(55, 79);
            this.labelXValues.Name = "labelXValues";
            this.labelXValues.Size = new System.Drawing.Size(93, 29);
            this.labelXValues.TabIndex = 7;
            this.labelXValues.Text = "Enter X";
            // 
            // labelYValues
            // 
            this.labelYValues.AutoSize = true;
            this.labelYValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYValues.Location = new System.Drawing.Point(234, 79);
            this.labelYValues.Name = "labelYValues";
            this.labelYValues.Size = new System.Drawing.Size(92, 29);
            this.labelYValues.TabIndex = 6;
            this.labelYValues.Text = "Enter Y";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chartArea4.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(531, 0);
            this.chart1.Name = "chart1";
            this.chart1.Padding = new System.Windows.Forms.Padding(1);
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(562, 449);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new System.Drawing.Point(12, 419);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(462, 30);
            this.txtResult.TabIndex = 11;
            // 
            // txtPolynomial
            // 
            this.txtPolynomial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPolynomial.Location = new System.Drawing.Point(531, 475);
            this.txtPolynomial.Multiline = true;
            this.txtPolynomial.Name = "txtPolynomial";
            this.txtPolynomial.ReadOnly = true;
            this.txtPolynomial.Size = new System.Drawing.Size(562, 252);
            this.txtPolynomial.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(185, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Solution ";
            // 
            // txtNumberOfIterations
            // 
            this.txtNumberOfIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumberOfIterations.Location = new System.Drawing.Point(12, 567);
            this.txtNumberOfIterations.Name = "txtNumberOfIterations";
            this.txtNumberOfIterations.Size = new System.Drawing.Size(350, 34);
            this.txtNumberOfIterations.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Points\' coordinates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Number of iterations";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(371, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 52);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save results";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 756);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfIterations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtPolynomial);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.xValuesTx);
            this.Controls.Add(this.yValuesTx);
            this.Controls.Add(this.labelXValues);
            this.Controls.Add(this.labelYValues);
            this.Controls.Add(this.inrerpolationTx);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.labelEntInterpolation);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelEntInterpolation;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox inrerpolationTx;
        private System.Windows.Forms.TextBox xValuesTx;
        private System.Windows.Forms.TextBox yValuesTx;
        private System.Windows.Forms.Label labelXValues;
        private System.Windows.Forms.Label labelYValues;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtPolynomial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfIterations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
    }
}

