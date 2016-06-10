namespace Simulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGolesLocal = new System.Windows.Forms.Label();
            this.lblGolesVisitante = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.BTNJugar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.golesPanel2 = new System.Windows.Forms.Panel();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVisitante = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitante)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DimGray;
            this.comboBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.DimGray;
            this.comboBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(325, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tu Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equipo Rival";
            // 
            // lblGolesLocal
            // 
            this.lblGolesLocal.AutoSize = true;
            this.lblGolesLocal.Location = new System.Drawing.Point(25, 255);
            this.lblGolesLocal.Name = "lblGolesLocal";
            this.lblGolesLocal.Size = new System.Drawing.Size(37, 13);
            this.lblGolesLocal.TabIndex = 6;
            this.lblGolesLocal.Text = "Goles:";
            this.lblGolesLocal.Visible = false;
            // 
            // lblGolesVisitante
            // 
            this.lblGolesVisitante.AutoSize = true;
            this.lblGolesVisitante.Location = new System.Drawing.Point(334, 255);
            this.lblGolesVisitante.Name = "lblGolesVisitante";
            this.lblGolesVisitante.Size = new System.Drawing.Size(37, 13);
            this.lblGolesVisitante.TabIndex = 7;
            this.lblGolesVisitante.Text = "Goles:";
            this.lblGolesVisitante.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tarjetas:";
            this.label3.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(28, 652);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(217, 73);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver ";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // BTNJugar
            // 
            this.BTNJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNJugar.Location = new System.Drawing.Point(86, 169);
            this.BTNJugar.Name = "BTNJugar";
            this.BTNJugar.Size = new System.Drawing.Size(159, 59);
            this.BTNJugar.TabIndex = 10;
            this.BTNJugar.Text = "Jugar";
            this.BTNJugar.UseVisualStyleBackColor = false;
            this.BTNJugar.Click += new System.EventHandler(this.BTNJugar_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tarjetas:";
            this.label5.Visible = false;
            // 
            // golesPanel2
            // 
            this.golesPanel2.Location = new System.Drawing.Point(836, 128);
            this.golesPanel2.Name = "golesPanel2";
            this.golesPanel2.Size = new System.Drawing.Size(145, 100);
            this.golesPanel2.TabIndex = 15;
            // 
            // dgvLocal
            // 
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Goles,
            this.Tarjetas});
            this.dgvLocal.Location = new System.Drawing.Point(12, 271);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.Size = new System.Drawing.Size(245, 120);
            this.dgvLocal.TabIndex = 16;
            // 
            // Goles
            // 
            this.Goles.HeaderText = "Goles";
            this.Goles.Name = "Goles";
            // 
            // Tarjetas
            // 
            this.Tarjetas.HeaderText = "Tarjetas";
            this.Tarjetas.Name = "Tarjetas";
            // 
            // dgvVisitante
            // 
            this.dgvVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvVisitante.Location = new System.Drawing.Point(291, 270);
            this.dgvVisitante.Name = "dgvVisitante";
            this.dgvVisitante.Size = new System.Drawing.Size(245, 120);
            this.dgvVisitante.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Goles";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tarjetas";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 733);
            this.Controls.Add(this.dgvVisitante);
            this.Controls.Add(this.dgvLocal);
            this.Controls.Add(this.golesPanel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNJugar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGolesVisitante);
            this.Controls.Add(this.lblGolesLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGolesLocal;
        private System.Windows.Forms.Label lblGolesVisitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button BTNJugar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel golesPanel2;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjetas;
        private System.Windows.Forms.DataGridView dgvVisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

