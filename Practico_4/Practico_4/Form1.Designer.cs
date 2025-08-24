namespace Practico_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.TDesde = new System.Windows.Forms.TextBox();
            this.THasta = new System.Windows.Forms.TextBox();
            this.BGenerador = new System.Windows.Forms.Button();
            this.LBMostrar = new System.Windows.Forms.ListBox();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BPares = new System.Windows.Forms.Button();
            this.BImpares = new System.Windows.Forms.Button();
            this.BPrimos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(21, 61);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 0;
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(24, 107);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 1;
            this.LHasta.Text = "Hasta";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(130, 11);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(157, 24);
            this.LTitulo.TabIndex = 2;
            this.LTitulo.Text = "Lista de Números";
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(65, 61);
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(100, 20);
            this.TDesde.TabIndex = 3;
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(65, 104);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(100, 20);
            this.THasta.TabIndex = 4;
            // 
            // BGenerador
            // 
            this.BGenerador.Location = new System.Drawing.Point(64, 142);
            this.BGenerador.Name = "BGenerador";
            this.BGenerador.Size = new System.Drawing.Size(101, 25);
            this.BGenerador.TabIndex = 5;
            this.BGenerador.Text = "Generar función";
            this.BGenerador.UseVisualStyleBackColor = true;
            this.BGenerador.Click += new System.EventHandler(this.BGenerador_Click);
            // 
            // LBMostrar
            // 
            this.LBMostrar.FormattingEnabled = true;
            this.LBMostrar.Location = new System.Drawing.Point(182, 61);
            this.LBMostrar.Name = "LBMostrar";
            this.LBMostrar.Size = new System.Drawing.Size(245, 212);
            this.LBMostrar.TabIndex = 6;
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(134, 326);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(75, 23);
            this.BEliminar.TabIndex = 7;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(298, 326);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 23);
            this.BSalir.TabIndex = 8;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BPares
            // 
            this.BPares.Location = new System.Drawing.Point(64, 183);
            this.BPares.Name = "BPares";
            this.BPares.Size = new System.Drawing.Size(100, 23);
            this.BPares.TabIndex = 9;
            this.BPares.Text = "Números Pares";
            this.BPares.UseVisualStyleBackColor = true;
            this.BPares.Click += new System.EventHandler(this.BPares_Click);
            // 
            // BImpares
            // 
            this.BImpares.Location = new System.Drawing.Point(65, 225);
            this.BImpares.Name = "BImpares";
            this.BImpares.Size = new System.Drawing.Size(99, 23);
            this.BImpares.TabIndex = 10;
            this.BImpares.Text = "Números Impares";
            this.BImpares.UseVisualStyleBackColor = true;
            this.BImpares.Click += new System.EventHandler(this.BImpares_Click);
            // 
            // BPrimos
            // 
            this.BPrimos.Location = new System.Drawing.Point(65, 269);
            this.BPrimos.Name = "BPrimos";
            this.BPrimos.Size = new System.Drawing.Size(99, 23);
            this.BPrimos.TabIndex = 11;
            this.BPrimos.Text = "Números Primos";
            this.BPrimos.UseVisualStyleBackColor = true;
            this.BPrimos.Click += new System.EventHandler(this.BPrimos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.CGrafico);
            this.panel1.Controls.Add(this.LBMostrar);
            this.panel1.Controls.Add(this.LTitulo);
            this.panel1.Controls.Add(this.BEliminar);
            this.panel1.Controls.Add(this.BSalir);
            this.panel1.Controls.Add(this.BPrimos);
            this.panel1.Controls.Add(this.THasta);
            this.panel1.Controls.Add(this.BImpares);
            this.panel1.Controls.Add(this.LDesde);
            this.panel1.Controls.Add(this.BPares);
            this.panel1.Controls.Add(this.LHasta);
            this.panel1.Controls.Add(this.TDesde);
            this.panel1.Controls.Add(this.BGenerador);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 418);
            this.panel1.TabIndex = 12;
            // 
            // CGrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.CGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CGrafico.Legends.Add(legend1);
            this.CGrafico.Location = new System.Drawing.Point(440, 61);
            this.CGrafico.Name = "CGrafico";
            series1.BackSecondaryColor = System.Drawing.Color.Red;
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CGrafico.Series.Add(series1);
            this.CGrafico.Size = new System.Drawing.Size(297, 288);
            this.CGrafico.TabIndex = 12;
            this.CGrafico.Text = "gráfico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 468);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Formulario 4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.Button BGenerador;
        private System.Windows.Forms.ListBox LBMostrar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BPares;
        private System.Windows.Forms.Button BImpares;
        private System.Windows.Forms.Button BPrimos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CGrafico;
    }
}

