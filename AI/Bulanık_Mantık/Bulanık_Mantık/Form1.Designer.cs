namespace Bulanık_Mantık
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
            this.numericHassaslik = new System.Windows.Forms.NumericUpDown();
            this.numericMiktar = new System.Windows.Forms.NumericUpDown();
            this.numericKirlilik = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHassaslikDurum = new System.Windows.Forms.Label();
            this.labelMiktarDurum = new System.Windows.Forms.Label();
            this.labelKirlilikDurum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridTetiklenen = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericHassaslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKirlilik)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTetiklenen)).BeginInit();
            this.SuspendLayout();
            // 
            // numericHassaslik
            // 
            this.numericHassaslik.DecimalPlaces = 2;
            this.numericHassaslik.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numericHassaslik.Location = new System.Drawing.Point(106, 42);
            this.numericHassaslik.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericHassaslik.Name = "numericHassaslik";
            this.numericHassaslik.Size = new System.Drawing.Size(120, 20);
            this.numericHassaslik.TabIndex = 0;
            this.numericHassaslik.ValueChanged += new System.EventHandler(this.numericHassaslik_ValueChanged);
            // 
            // numericMiktar
            // 
            this.numericMiktar.DecimalPlaces = 2;
            this.numericMiktar.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numericMiktar.Location = new System.Drawing.Point(106, 78);
            this.numericMiktar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericMiktar.Name = "numericMiktar";
            this.numericMiktar.Size = new System.Drawing.Size(120, 20);
            this.numericMiktar.TabIndex = 1;
            this.numericMiktar.ValueChanged += new System.EventHandler(this.numericMiktar_ValueChanged);
            // 
            // numericKirlilik
            // 
            this.numericKirlilik.DecimalPlaces = 2;
            this.numericKirlilik.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numericKirlilik.Location = new System.Drawing.Point(106, 113);
            this.numericKirlilik.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericKirlilik.Name = "numericKirlilik";
            this.numericKirlilik.Size = new System.Drawing.Size(120, 20);
            this.numericKirlilik.TabIndex = 2;
            this.numericKirlilik.ValueChanged += new System.EventHandler(this.numericKirlilik_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hassaslık =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miktar =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kirlilik =";
            // 
            // labelHassaslikDurum
            // 
            this.labelHassaslikDurum.AutoSize = true;
            this.labelHassaslikDurum.Location = new System.Drawing.Point(269, 42);
            this.labelHassaslikDurum.Name = "labelHassaslikDurum";
            this.labelHassaslikDurum.Size = new System.Drawing.Size(40, 13);
            this.labelHassaslikDurum.TabIndex = 4;
            this.labelHassaslikDurum.Text = "sağlam";
            // 
            // labelMiktarDurum
            // 
            this.labelMiktarDurum.AutoSize = true;
            this.labelMiktarDurum.Location = new System.Drawing.Point(269, 78);
            this.labelMiktarDurum.Name = "labelMiktarDurum";
            this.labelMiktarDurum.Size = new System.Drawing.Size(37, 13);
            this.labelMiktarDurum.TabIndex = 4;
            this.labelMiktarDurum.Text = "küçük";
            // 
            // labelKirlilikDurum
            // 
            this.labelKirlilikDurum.AutoSize = true;
            this.labelKirlilikDurum.Location = new System.Drawing.Point(269, 113);
            this.labelKirlilikDurum.Name = "labelKirlilikDurum";
            this.labelKirlilikDurum.Size = new System.Drawing.Size(37, 13);
            this.labelKirlilikDurum.TabIndex = 4;
            this.labelKirlilikDurum.Text = "küçük";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.numericMiktar);
            this.groupBox1.Controls.Add(this.labelKirlilikDurum);
            this.groupBox1.Controls.Add(this.numericHassaslik);
            this.groupBox1.Controls.Add(this.labelMiktarDurum);
            this.groupBox1.Controls.Add(this.labelHassaslikDurum);
            this.groupBox1.Controls.Add(this.numericKirlilik);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Değerleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mamdani";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(359, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(197, 99);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(610, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(608, 634);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridTetiklenen
            // 
            this.dataGridTetiklenen.AllowUserToAddRows = false;
            this.dataGridTetiklenen.AllowUserToDeleteRows = false;
            this.dataGridTetiklenen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTetiklenen.Enabled = false;
            this.dataGridTetiklenen.Location = new System.Drawing.Point(12, 460);
            this.dataGridTetiklenen.Name = "dataGridTetiklenen";
            this.dataGridTetiklenen.ReadOnly = true;
            this.dataGridTetiklenen.Size = new System.Drawing.Size(592, 186);
            this.dataGridTetiklenen.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(202, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tetiklenen Kurallar";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(12, 226);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(477, 104);
            this.textBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ağırlıklı Ortalama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1224, 651);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridTetiklenen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericHassaslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKirlilik)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTetiklenen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericHassaslik;
        private System.Windows.Forms.NumericUpDown numericMiktar;
        private System.Windows.Forms.NumericUpDown numericKirlilik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHassaslikDurum;
        private System.Windows.Forms.Label labelMiktarDurum;
        private System.Windows.Forms.Label labelKirlilikDurum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridTetiklenen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}

