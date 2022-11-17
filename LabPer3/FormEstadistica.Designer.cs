namespace LabPer3
{
    partial class FormEstadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadistica));
            this.generarBtn = new System.Windows.Forms.Button();
            this.MostrarListaBTN = new System.Windows.Forms.Button();
            this.tBox1 = new System.Windows.Forms.RichTextBox();
            this.SortedDataBTN = new System.Windows.Forms.Button();
            this.tBoxSortedData = new System.Windows.Forms.RichTextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxMedia = new System.Windows.Forms.TextBox();
            this.tBoxModa = new System.Windows.Forms.TextBox();
            this.tBoxMediana = new System.Windows.Forms.TextBox();
            this.tBoxDS = new System.Windows.Forms.TextBox();
            this.salirBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generarBtn
            // 
            this.generarBtn.BackColor = System.Drawing.Color.Coral;
            this.generarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generarBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.generarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.generarBtn.Location = new System.Drawing.Point(36, 76);
            this.generarBtn.Name = "generarBtn";
            this.generarBtn.Size = new System.Drawing.Size(153, 23);
            this.generarBtn.TabIndex = 0;
            this.generarBtn.Text = "GENERAR NÚMEROS";
            this.generarBtn.UseVisualStyleBackColor = false;
            this.generarBtn.Click += new System.EventHandler(this.generarBtn_Click);
            // 
            // MostrarListaBTN
            // 
            this.MostrarListaBTN.BackColor = System.Drawing.Color.Coral;
            this.MostrarListaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostrarListaBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MostrarListaBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.MostrarListaBTN.Location = new System.Drawing.Point(222, 76);
            this.MostrarListaBTN.Name = "MostrarListaBTN";
            this.MostrarListaBTN.Size = new System.Drawing.Size(138, 23);
            this.MostrarListaBTN.TabIndex = 1;
            this.MostrarListaBTN.Text = "MOSTRAR LISTA";
            this.MostrarListaBTN.UseVisualStyleBackColor = false;
            this.MostrarListaBTN.Click += new System.EventHandler(this.MostrarListaBTN_Click);
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(36, 114);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(526, 62);
            this.tBox1.TabIndex = 2;
            this.tBox1.Text = "";
            // 
            // SortedDataBTN
            // 
            this.SortedDataBTN.BackColor = System.Drawing.Color.Coral;
            this.SortedDataBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortedDataBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SortedDataBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.SortedDataBTN.Location = new System.Drawing.Point(36, 197);
            this.SortedDataBTN.Name = "SortedDataBTN";
            this.SortedDataBTN.Size = new System.Drawing.Size(187, 23);
            this.SortedDataBTN.TabIndex = 3;
            this.SortedDataBTN.Text = "ORDENAR LISTA DE NÚMEROS";
            this.SortedDataBTN.UseVisualStyleBackColor = false;
            this.SortedDataBTN.Click += new System.EventHandler(this.SortedDataBTN_Click);
            // 
            // tBoxSortedData
            // 
            this.tBoxSortedData.Location = new System.Drawing.Point(36, 244);
            this.tBoxSortedData.Name = "tBoxSortedData";
            this.tBoxSortedData.Size = new System.Drawing.Size(526, 56);
            this.tBoxSortedData.TabIndex = 4;
            this.tBoxSortedData.Text = "";
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.Coral;
            this.calcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.calcBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.calcBtn.Location = new System.Drawing.Point(36, 326);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(85, 23);
            this.calcBtn.TabIndex = 5;
            this.calcBtn.Text = "CALCULAR";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "MEDIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(142, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "MODA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(142, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "DESVIACIÓN ESTÁNDAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(142, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "MEDIANA";
            // 
            // tboxMedia
            // 
            this.tboxMedia.Location = new System.Drawing.Point(201, 328);
            this.tboxMedia.Name = "tboxMedia";
            this.tboxMedia.Size = new System.Drawing.Size(350, 20);
            this.tboxMedia.TabIndex = 12;
            // 
            // tBoxModa
            // 
            this.tBoxModa.Location = new System.Drawing.Point(201, 365);
            this.tBoxModa.Name = "tBoxModa";
            this.tBoxModa.Size = new System.Drawing.Size(350, 20);
            this.tBoxModa.TabIndex = 13;
            // 
            // tBoxMediana
            // 
            this.tBoxMediana.Location = new System.Drawing.Point(222, 402);
            this.tBoxMediana.Name = "tBoxMediana";
            this.tBoxMediana.Size = new System.Drawing.Size(329, 20);
            this.tBoxMediana.TabIndex = 14;
            // 
            // tBoxDS
            // 
            this.tBoxDS.Location = new System.Drawing.Point(300, 440);
            this.tBoxDS.Name = "tBoxDS";
            this.tBoxDS.Size = new System.Drawing.Size(251, 20);
            this.tBoxDS.TabIndex = 15;
            // 
            // salirBtn
            // 
            this.salirBtn.BackColor = System.Drawing.Color.Coral;
            this.salirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.salirBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.salirBtn.Location = new System.Drawing.Point(477, 479);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(74, 23);
            this.salirBtn.TabIndex = 16;
            this.salirBtn.Text = "SALIR";
            this.salirBtn.UseVisualStyleBackColor = false;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.BackColor = System.Drawing.Color.Coral;
            this.limpiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.limpiarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.limpiarBtn.Location = new System.Drawing.Point(387, 479);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(74, 23);
            this.limpiarBtn.TabIndex = 17;
            this.limpiarBtn.Text = "LIMPIAR";
            this.limpiarBtn.UseVisualStyleBackColor = false;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(160, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "CALCULADORA CON LISTA ALTERNA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(182, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "LAB. 1 - ANA DANIELA GIRÓN SAAVEDRA";
            // 
            // FormEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(601, 524);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.tBoxDS);
            this.Controls.Add(this.tBoxMediana);
            this.Controls.Add(this.tBoxModa);
            this.Controls.Add(this.tboxMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.tBoxSortedData);
            this.Controls.Add(this.SortedDataBTN);
            this.Controls.Add(this.tBox1);
            this.Controls.Add(this.MostrarListaBTN);
            this.Controls.Add(this.generarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEstadistica";
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.FormEstadistica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generarBtn;
        private System.Windows.Forms.Button MostrarListaBTN;
        private System.Windows.Forms.RichTextBox tBox1;
        private System.Windows.Forms.Button SortedDataBTN;
        private System.Windows.Forms.RichTextBox tBoxSortedData;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxMedia;
        private System.Windows.Forms.TextBox tBoxModa;
        private System.Windows.Forms.TextBox tBoxMediana;
        private System.Windows.Forms.TextBox tBoxDS;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}