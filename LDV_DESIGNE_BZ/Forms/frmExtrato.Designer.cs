namespace LDV_DESIGNE_BZ.Forms
{
    partial class frmExtrato
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtrato));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fillByFiltroContaToolStrip = new System.Windows.Forms.ToolStrip();
            this.nUMBERACCBANKToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nUMBERACCBANKToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByFiltroContaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnFiltroC = new System.Windows.Forms.Button();
            this.cbData = new MetroFramework.Controls.MetroDateTime();
            this.fillByDateToolStrip = new System.Windows.Forms.ToolStrip();
            this.dATESTATEMENTToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dATESTATEMENTToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByDateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lDVBANKSTATEMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lDV_PEDREIRADataSet = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSet();
            this.lDVBANKSTATEMENTTableAdapter = new LDV_DESIGNE_BZ.LDV_PEDREIRADataSetTableAdapters.LDVBANKSTATEMENTTableAdapter();
            this.btnRetiraF = new System.Windows.Forms.Button();
            this.fillByNumcontaToolStrip = new System.Windows.Forms.ToolStrip();
            this.nUMBERACCBANKToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nUMBERACCBANKToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNumcontaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByFiltroContaToolStrip.SuspendLayout();
            this.fillByDateToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKSTATEMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).BeginInit();
            this.fillByNumcontaToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetReport";
            reportDataSource1.Value = this.lDVBANKSTATEMENTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LDV_DESIGNE_BZ.Reports.rpExtract.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(11, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(891, 390);
            this.reportViewer1.TabIndex = 0;
            // 
            // fillByFiltroContaToolStrip
            // 
            this.fillByFiltroContaToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByFiltroContaToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByFiltroContaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUMBERACCBANKToolStripLabel,
            this.nUMBERACCBANKToolStripTextBox,
            this.fillByFiltroContaToolStripButton});
            this.fillByFiltroContaToolStrip.Location = new System.Drawing.Point(330, 9);
            this.fillByFiltroContaToolStrip.Name = "fillByFiltroContaToolStrip";
            this.fillByFiltroContaToolStrip.Size = new System.Drawing.Size(374, 27);
            this.fillByFiltroContaToolStrip.TabIndex = 1;
            this.fillByFiltroContaToolStrip.Text = "fillByFiltroContaToolStrip";
            this.fillByFiltroContaToolStrip.Visible = false;
            // 
            // nUMBERACCBANKToolStripLabel
            // 
            this.nUMBERACCBANKToolStripLabel.Name = "nUMBERACCBANKToolStripLabel";
            this.nUMBERACCBANKToolStripLabel.Size = new System.Drawing.Size(139, 24);
            this.nUMBERACCBANKToolStripLabel.Text = "NUMBERACCBANK:";
            // 
            // nUMBERACCBANKToolStripTextBox
            // 
            this.nUMBERACCBANKToolStripTextBox.Name = "nUMBERACCBANKToolStripTextBox";
            this.nUMBERACCBANKToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByFiltroContaToolStripButton
            // 
            this.fillByFiltroContaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByFiltroContaToolStripButton.Name = "fillByFiltroContaToolStripButton";
            this.fillByFiltroContaToolStripButton.Size = new System.Drawing.Size(121, 24);
            this.fillByFiltroContaToolStripButton.Text = "FillByFiltroConta";
            // 
            // btnFiltroC
            // 
            this.btnFiltroC.FlatAppearance.BorderSize = 0;
            this.btnFiltroC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFiltroC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroC.Location = new System.Drawing.Point(164, 86);
            this.btnFiltroC.Name = "btnFiltroC";
            this.btnFiltroC.Size = new System.Drawing.Size(119, 35);
            this.btnFiltroC.TabIndex = 3;
            this.btnFiltroC.Text = "Filtrar";
            this.btnFiltroC.UseVisualStyleBackColor = true;
            this.btnFiltroC.Click += new System.EventHandler(this.btnFiltroC_Click);
            // 
            // cbData
            // 
            this.cbData.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.cbData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbData.Location = new System.Drawing.Point(11, 86);
            this.cbData.MinimumSize = new System.Drawing.Size(0, 35);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(147, 35);
            this.cbData.TabIndex = 4;
            this.cbData.Value = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            // 
            // fillByDateToolStrip
            // 
            this.fillByDateToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByDateToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByDateToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByDateToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dATESTATEMENTToolStripLabel,
            this.dATESTATEMENTToolStripTextBox,
            this.fillByDateToolStripButton});
            this.fillByDateToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByDateToolStrip.Name = "fillByDateToolStrip";
            this.fillByDateToolStrip.Size = new System.Drawing.Size(313, 27);
            this.fillByDateToolStrip.TabIndex = 5;
            this.fillByDateToolStrip.Text = "fillByDateToolStrip";
            this.fillByDateToolStrip.Visible = false;
            // 
            // dATESTATEMENTToolStripLabel
            // 
            this.dATESTATEMENTToolStripLabel.Name = "dATESTATEMENTToolStripLabel";
            this.dATESTATEMENTToolStripLabel.Size = new System.Drawing.Size(128, 24);
            this.dATESTATEMENTToolStripLabel.Text = "DATESTATEMENT:";
            // 
            // dATESTATEMENTToolStripTextBox
            // 
            this.dATESTATEMENTToolStripTextBox.Name = "dATESTATEMENTToolStripTextBox";
            this.dATESTATEMENTToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByDateToolStripButton
            // 
            this.fillByDateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByDateToolStripButton.Name = "fillByDateToolStripButton";
            this.fillByDateToolStripButton.Size = new System.Drawing.Size(80, 24);
            this.fillByDateToolStripButton.Text = "FillByDate";
            // 
            // lDVBANKSTATEMENTBindingSource
            // 
            this.lDVBANKSTATEMENTBindingSource.DataMember = "LDVBANKSTATEMENT";
            this.lDVBANKSTATEMENTBindingSource.DataSource = this.lDV_PEDREIRADataSet;
            // 
            // lDV_PEDREIRADataSet
            // 
            this.lDV_PEDREIRADataSet.DataSetName = "LDV_PEDREIRADataSet";
            this.lDV_PEDREIRADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lDVBANKSTATEMENTTableAdapter
            // 
            this.lDVBANKSTATEMENTTableAdapter.ClearBeforeFill = true;
            // 
            // btnRetiraF
            // 
            this.btnRetiraF.FlatAppearance.BorderSize = 0;
            this.btnRetiraF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRetiraF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRetiraF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetiraF.Location = new System.Drawing.Point(289, 86);
            this.btnRetiraF.Name = "btnRetiraF";
            this.btnRetiraF.Size = new System.Drawing.Size(166, 35);
            this.btnRetiraF.TabIndex = 6;
            this.btnRetiraF.Text = "Retirar filtro";
            this.btnRetiraF.UseVisualStyleBackColor = true;
            this.btnRetiraF.Click += new System.EventHandler(this.btnRetiraF_Click);
            // 
            // fillByNumcontaToolStrip
            // 
            this.fillByNumcontaToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByNumcontaToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByNumcontaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUMBERACCBANKToolStripLabel1,
            this.nUMBERACCBANKToolStripTextBox1,
            this.fillByNumcontaToolStripButton});
            this.fillByNumcontaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByNumcontaToolStrip.Name = "fillByNumcontaToolStrip";
            this.fillByNumcontaToolStrip.Size = new System.Drawing.Size(370, 27);
            this.fillByNumcontaToolStrip.TabIndex = 7;
            this.fillByNumcontaToolStrip.Text = "fillByNumcontaToolStrip";
            this.fillByNumcontaToolStrip.Visible = false;
            // 
            // nUMBERACCBANKToolStripLabel1
            // 
            this.nUMBERACCBANKToolStripLabel1.Name = "nUMBERACCBANKToolStripLabel1";
            this.nUMBERACCBANKToolStripLabel1.Size = new System.Drawing.Size(139, 24);
            this.nUMBERACCBANKToolStripLabel1.Text = "NUMBERACCBANK:";
            // 
            // nUMBERACCBANKToolStripTextBox1
            // 
            this.nUMBERACCBANKToolStripTextBox1.Name = "nUMBERACCBANKToolStripTextBox1";
            this.nUMBERACCBANKToolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByNumcontaToolStripButton
            // 
            this.fillByNumcontaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNumcontaToolStripButton.Name = "fillByNumcontaToolStripButton";
            this.fillByNumcontaToolStripButton.Size = new System.Drawing.Size(117, 24);
            this.fillByNumcontaToolStripButton.Text = "FillByNumconta";
            // 
            // frmExtrato
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(922, 535);
            this.Controls.Add(this.fillByNumcontaToolStrip);
            this.Controls.Add(this.btnRetiraF);
            this.Controls.Add(this.fillByDateToolStrip);
            this.Controls.Add(this.cbData);
            this.Controls.Add(this.btnFiltroC);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.fillByFiltroContaToolStrip);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExtrato";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Extrato";
            this.Load += new System.EventHandler(this.frmExtrato_Load);
            this.fillByFiltroContaToolStrip.ResumeLayout(false);
            this.fillByFiltroContaToolStrip.PerformLayout();
            this.fillByDateToolStrip.ResumeLayout(false);
            this.fillByDateToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lDVBANKSTATEMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDV_PEDREIRADataSet)).EndInit();
            this.fillByNumcontaToolStrip.ResumeLayout(false);
            this.fillByNumcontaToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LDV_PEDREIRADataSet lDV_PEDREIRADataSet;
        private System.Windows.Forms.BindingSource lDVBANKSTATEMENTBindingSource;
        private LDV_PEDREIRADataSetTableAdapters.LDVBANKSTATEMENTTableAdapter lDVBANKSTATEMENTTableAdapter;
        private System.Windows.Forms.ToolStrip fillByFiltroContaToolStrip;
        private System.Windows.Forms.ToolStripLabel nUMBERACCBANKToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nUMBERACCBANKToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByFiltroContaToolStripButton;
        private System.Windows.Forms.Button btnFiltroC;
        private MetroFramework.Controls.MetroDateTime cbData;
        private System.Windows.Forms.ToolStrip fillByDateToolStrip;
        private System.Windows.Forms.ToolStripLabel dATESTATEMENTToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dATESTATEMENTToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByDateToolStripButton;
        private System.Windows.Forms.Button btnRetiraF;
        private System.Windows.Forms.ToolStrip fillByNumcontaToolStrip;
        private System.Windows.Forms.ToolStripLabel nUMBERACCBANKToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nUMBERACCBANKToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByNumcontaToolStripButton;
    }
}