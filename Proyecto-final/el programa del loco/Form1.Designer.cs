﻿namespace el_programa_del_loco
{
    partial class Form1
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPremio3 = new System.Windows.Forms.TextBox();
            this.txtPremio2 = new System.Windows.Forms.TextBox();
            this.txtPremio1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtrepetidos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtrepetido = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(199, 86);
            this.txtn1.Multiline = true;
            this.txtn1.Name = "txtn1";
            this.txtn1.ReadOnly = true;
            this.txtn1.Size = new System.Drawing.Size(63, 30);
            this.txtn1.TabIndex = 0;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(199, 138);
            this.txtn2.Multiline = true;
            this.txtn2.Name = "txtn2";
            this.txtn2.ReadOnly = true;
            this.txtn2.Size = new System.Drawing.Size(63, 32);
            this.txtn2.TabIndex = 1;
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(199, 188);
            this.txtn3.Multiline = true;
            this.txtn3.Name = "txtn3";
            this.txtn3.ReadOnly = true;
            this.txtn3.Size = new System.Drawing.Size(63, 30);
            this.txtn3.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(38, 293);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(58, 23);
            this.txtNumero.TabIndex = 3;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(240, 306);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(126, 76);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Primer lugar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Segundo lugar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tercer lugar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero Apostado";
            // 
            // txtPremio3
            // 
            this.txtPremio3.Location = new System.Drawing.Point(303, 188);
            this.txtPremio3.Multiline = true;
            this.txtPremio3.Name = "txtPremio3";
            this.txtPremio3.ReadOnly = true;
            this.txtPremio3.Size = new System.Drawing.Size(63, 30);
            this.txtPremio3.TabIndex = 11;
            // 
            // txtPremio2
            // 
            this.txtPremio2.Location = new System.Drawing.Point(303, 136);
            this.txtPremio2.Multiline = true;
            this.txtPremio2.Name = "txtPremio2";
            this.txtPremio2.ReadOnly = true;
            this.txtPremio2.Size = new System.Drawing.Size(63, 32);
            this.txtPremio2.TabIndex = 10;
            // 
            // txtPremio1
            // 
            this.txtPremio1.Location = new System.Drawing.Point(303, 86);
            this.txtPremio1.Multiline = true;
            this.txtPremio1.Name = "txtPremio1";
            this.txtPremio1.ReadOnly = true;
            this.txtPremio1.Size = new System.Drawing.Size(63, 30);
            this.txtPremio1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(268, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "$:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(268, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "$:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(268, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "$:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(38, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cantidad de Apuesta";
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(38, 365);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(58, 23);
            this.txtDinero.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(303, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "LOTERIA PICHARDO";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToOrderColumns = true;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgv.Location = new System.Drawing.Point(403, 86);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowTemplate.Height = 25;
            this.dtgv.Size = new System.Drawing.Size(495, 252);
            this.dtgv.TabIndex = 18;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Primer numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Segundo numero";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tercer numero";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "Fecha/Hora";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // txtrepetidos
            // 
            this.txtrepetidos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtrepetidos.ForeColor = System.Drawing.SystemColors.Info;
            this.txtrepetidos.Location = new System.Drawing.Point(683, 352);
            this.txtrepetidos.Multiline = true;
            this.txtrepetidos.Name = "txtrepetidos";
            this.txtrepetidos.ReadOnly = true;
            this.txtrepetidos.Size = new System.Drawing.Size(77, 30);
            this.txtrepetidos.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(403, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 30);
            this.label10.TabIndex = 20;
            this.label10.Text = "Numero que mas se repite";
            // 
            // txtrepetido
            // 
            this.txtrepetido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtrepetido.ForeColor = System.Drawing.SystemColors.Info;
            this.txtrepetido.Location = new System.Drawing.Point(12, 226);
            this.txtrepetido.Multiline = true;
            this.txtrepetido.Name = "txtrepetido";
            this.txtrepetido.ReadOnly = true;
            this.txtrepetido.Size = new System.Drawing.Size(406, 30);
            this.txtrepetido.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(950, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(263, 252);
            this.dataGridView1.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 120F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Numeros ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Canditad de veces que se repite";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtrepetido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtrepetidos);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPremio3);
            this.Controls.Add(this.txtPremio2);
            this.Controls.Add(this.txtPremio1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Name = "Form1";
            this.Text = "Loteria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtn1;
        private TextBox txtn2;
        private TextBox txtn3;
        private TextBox txtNumero;
        private Button btnEjecutar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPremio3;
        private TextBox txtPremio2;
        private TextBox txtPremio1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDinero;
        private Label label9;
        private TextBox txtPerdiste;
        private DataGridView dtgv;
        private TextBox txtrepetidos;
        private Label label10;
        private TextBox txtrepetido;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button button1;
    }
}