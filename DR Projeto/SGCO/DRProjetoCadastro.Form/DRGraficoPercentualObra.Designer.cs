namespace DRProjetoCadastro.Form
{
    partial class DRGraficoPercentualObra
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dsGraficos1 = new DRProjetoCadastro.BLL.DSGraficos();
            this.bsCompletude = new System.Windows.Forms.BindingSource(this.components);
            this.bsOrcadoRealizado = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckNaoMostraNaAbertura = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PercentualCompletudeEtapa = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PercentualObra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OrcadoRealizado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGraficos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompletude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrcadoRealizado)).BeginInit();
            this.panel2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentualCompletudeEtapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentualObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrcadoRealizado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drBS
            // 
            this.drBS.DataMember = "DRProjetoPercentualCompletude";
            this.drBS.DataSource = this.dsGraficos1;
            // 
            // dsGraficos1
            // 
            this.dsGraficos1.DataSetName = "DSGraficos";
            this.dsGraficos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsCompletude
            // 
            this.bsCompletude.DataMember = "DRETAPAPERCENTUALCOMPLETUDE";
            this.bsCompletude.DataSource = this.dsGraficos1;
            // 
            // bsOrcadoRealizado
            // 
            this.bsOrcadoRealizado.DataMember = "DRETAPAORCADOREALIZADO";
            this.bsOrcadoRealizado.DataSource = this.dsGraficos1;
            // 
            // button2
            // 
            this.button2.Image = global::DRProjetoCadastro.Form.Properties.Resources.Grafico;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Atualizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::DRProjetoCadastro.Form.Properties.Resources.exit;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(244, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 46);
            this.panel2.TabIndex = 2;
            // 
            // ckNaoMostraNaAbertura
            // 
            this.ckNaoMostraNaAbertura.AutoSize = true;
            this.ckNaoMostraNaAbertura.Location = new System.Drawing.Point(20, 16);
            this.ckNaoMostraNaAbertura.Name = "ckNaoMostraNaAbertura";
            this.ckNaoMostraNaAbertura.Size = new System.Drawing.Size(218, 17);
            this.ckNaoMostraNaAbertura.TabIndex = 3;
            this.ckNaoMostraNaAbertura.Text = "Não mostrar esta tela ao iniciar o sistema";
            this.ckNaoMostraNaAbertura.UseVisualStyleBackColor = true;
            this.ckNaoMostraNaAbertura.CheckedChanged += new System.EventHandler(this.ckNaoMostraNaAbertura_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PercentualCompletudeEtapa);
            this.splitContainer1.Panel1.Controls.Add(this.PercentualObra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OrcadoRealizado);
            this.splitContainer1.Size = new System.Drawing.Size(936, 402);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 3;
            // 
            // PercentualCompletudeEtapa
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.Maximum = 100;
            chartArea1.AxisY2.Crossing = 1.7976931348623157E+308;
            chartArea1.AxisY2.Maximum = 100;
            chartArea1.Name = "ChartArea1";
            this.PercentualCompletudeEtapa.ChartAreas.Add(chartArea1);
            this.PercentualCompletudeEtapa.DataSource = this.bsCompletude;
            this.PercentualCompletudeEtapa.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.PercentualCompletudeEtapa.Legends.Add(legend1);
            this.PercentualCompletudeEtapa.Location = new System.Drawing.Point(380, 0);
            this.PercentualCompletudeEtapa.Name = "PercentualCompletudeEtapa";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.IsValueShownAsLabel = true;
            series1.Label = "#VAL %";
            series1.LabelToolTip = "#VAL %";
            series1.Legend = "Legend1";
            series1.LegendText = "Etapas";
            series1.LegendToolTip = "Etapas";
            series1.Name = "Series1";
            series1.XValueMember = "Descricao";
            series1.YValueMembers = "PERCENTUALCOMPLETUDE";
            this.PercentualCompletudeEtapa.Series.Add(series1);
            this.PercentualCompletudeEtapa.Size = new System.Drawing.Size(556, 245);
            this.PercentualCompletudeEtapa.TabIndex = 5;
            this.PercentualCompletudeEtapa.Text = "d";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Percentual de Completude da Etapa";
            title1.ToolTip = "Percentual de Completude da Etapa";
            this.PercentualCompletudeEtapa.Titles.Add(title1);
            // 
            // PercentualObra
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.PercentualObra.ChartAreas.Add(chartArea2);
            this.PercentualObra.DataSource = this.drBS;
            this.PercentualObra.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.PercentualObra.Legends.Add(legend2);
            this.PercentualObra.Location = new System.Drawing.Point(0, 0);
            this.PercentualObra.Name = "PercentualObra";
            series2.BorderColor = System.Drawing.Color.Black;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.EmptyPointStyle.AxisLabel = "%";
            series2.EmptyPointStyle.IsValueShownAsLabel = true;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Label = "#VAL %";
            series2.LabelFormat = "#,##0.00";
            series2.LabelToolTip = "#VAL %";
            series2.Legend = "Legend1";
            series2.LegendText = "#VALX - #VAL %";
            series2.LegendToolTip = "#VALX - #VAL %";
            series2.Name = "Series1";
            series2.XValueMember = "Nome";
            series2.YValueMembers = "PERCENTUALCOMPLETUDE";
            this.PercentualObra.Series.Add(series2);
            this.PercentualObra.Size = new System.Drawing.Size(380, 245);
            this.PercentualObra.TabIndex = 4;
            this.PercentualObra.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Percentual de Completude da Obra";
            this.PercentualObra.Titles.Add(title2);
            // 
            // OrcadoRealizado
            // 
            chartArea3.Name = "ChartArea1";
            this.OrcadoRealizado.ChartAreas.Add(chartArea3);
            this.OrcadoRealizado.DataSource = this.bsOrcadoRealizado;
            this.OrcadoRealizado.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.OrcadoRealizado.Legends.Add(legend3);
            this.OrcadoRealizado.Location = new System.Drawing.Point(0, 0);
            this.OrcadoRealizado.Name = "OrcadoRealizado";
            this.OrcadoRealizado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.BackImageTransparentColor = System.Drawing.Color.White;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.LabelFormat = "#,##0.00";
            series3.Legend = "Legend1";
            series3.Name = "Total Orçado";
            series3.XValueMember = "Descricao";
            series3.YValueMembers = "ORCADO";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.IsXValueIndexed = true;
            series4.LabelFormat = "#,##0.00";
            series4.Legend = "Legend1";
            series4.Name = "Total de Despesa";
            series4.XValueMember = "CodEtapa";
            series4.YValueMembers = "EXECUTADO";
            this.OrcadoRealizado.Series.Add(series3);
            this.OrcadoRealizado.Series.Add(series4);
            this.OrcadoRealizado.Size = new System.Drawing.Size(936, 153);
            this.OrcadoRealizado.TabIndex = 2;
            this.OrcadoRealizado.Text = "chart2";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title1";
            title3.Text = "Total Orçado X Total de Despesa";
            title3.ToolTip = "Total Orçado X Total de Despesa";
            this.OrcadoRealizado.Titles.Add(title3);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.ckNaoMostraNaAbertura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(591, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 46);
            this.panel1.TabIndex = 6;
            // 
            // DRGraficoPercentualObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 448);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Name = "DRGraficoPercentualObra";
            this.Text = "DRGRAFICO";
            this.Load += new System.EventHandler(this.DRGraficoPercentualObra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGraficos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompletude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrcadoRealizado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PercentualCompletudeEtapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentualObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrcadoRealizado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DRProjetoCadastro.BLL.DSGraficos dsGraficos1;
        private System.Windows.Forms.BindingSource bsOrcadoRealizado;
        private System.Windows.Forms.BindingSource bsCompletude;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart PercentualCompletudeEtapa;
        private System.Windows.Forms.DataVisualization.Charting.Chart PercentualObra;
        private System.Windows.Forms.DataVisualization.Charting.Chart OrcadoRealizado;
        private System.Windows.Forms.CheckBox ckNaoMostraNaAbertura;
        private System.Windows.Forms.Panel panel1;
    }
}