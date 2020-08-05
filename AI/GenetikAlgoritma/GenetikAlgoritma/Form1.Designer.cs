namespace GenetikAlgoritma
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.populationSizeBox = new System.Windows.Forms.NumericUpDown();
            this.mutationRateBox = new System.Windows.Forms.NumericUpDown();
            this.seckinlikBox = new System.Windows.Forms.NumericUpDown();
            this.crossOverBox = new System.Windows.Forms.NumericUpDown();
            this.jenerasyonBox = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.populationSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seckinlikBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossOverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenerasyonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(83, 361);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Başla";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Populasyon Boyutu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seçkinlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Çaprazlama Oranı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mutasyon Oranı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Jenerasyon Sayısı";
            // 
            // populationSizeBox
            // 
            this.populationSizeBox.Location = new System.Drawing.Point(136, 37);
            this.populationSizeBox.Name = "populationSizeBox";
            this.populationSizeBox.Size = new System.Drawing.Size(120, 20);
            this.populationSizeBox.TabIndex = 14;
            this.populationSizeBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // mutationRateBox
            // 
            this.mutationRateBox.DecimalPlaces = 3;
            this.mutationRateBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.mutationRateBox.Location = new System.Drawing.Point(136, 92);
            this.mutationRateBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mutationRateBox.Name = "mutationRateBox";
            this.mutationRateBox.Size = new System.Drawing.Size(120, 20);
            this.mutationRateBox.TabIndex = 15;
            this.mutationRateBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            196608});
            // 
            // seckinlikBox
            // 
            this.seckinlikBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.seckinlikBox.Location = new System.Drawing.Point(136, 116);
            this.seckinlikBox.Name = "seckinlikBox";
            this.seckinlikBox.Size = new System.Drawing.Size(120, 20);
            this.seckinlikBox.TabIndex = 16;
            this.seckinlikBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // crossOverBox
            // 
            this.crossOverBox.DecimalPlaces = 1;
            this.crossOverBox.Location = new System.Drawing.Point(136, 63);
            this.crossOverBox.Name = "crossOverBox";
            this.crossOverBox.Size = new System.Drawing.Size(120, 20);
            this.crossOverBox.TabIndex = 17;
            this.crossOverBox.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // jenerasyonBox
            // 
            this.jenerasyonBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.jenerasyonBox.Location = new System.Drawing.Point(136, 274);
            this.jenerasyonBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.jenerasyonBox.Name = "jenerasyonBox";
            this.jenerasyonBox.Size = new System.Drawing.Size(120, 20);
            this.jenerasyonBox.TabIndex = 19;
            this.jenerasyonBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(290, 12);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.SystemColors.Highlight;
            series3.Legend = "Legend1";
            series3.Name = "fitness";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1057, 473);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 513);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.jenerasyonBox);
            this.Controls.Add(this.crossOverBox);
            this.Controls.Add(this.seckinlikBox);
            this.Controls.Add(this.mutationRateBox);
            this.Controls.Add(this.populationSizeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.populationSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seckinlikBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossOverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenerasyonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown populationSizeBox;
        private System.Windows.Forms.NumericUpDown mutationRateBox;
        private System.Windows.Forms.NumericUpDown seckinlikBox;
        private System.Windows.Forms.NumericUpDown crossOverBox;
        private System.Windows.Forms.NumericUpDown jenerasyonBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

