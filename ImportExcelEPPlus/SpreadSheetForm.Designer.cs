namespace ImportExcelEPPlus
{
    partial class SpreadSheetForm
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
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lbQtdLines = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImporter = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.gridImporter = new System.Windows.Forms.DataGridView();
            this.lbQtdColumns = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridImporter)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSheet
            // 
            this.cbSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Location = new System.Drawing.Point(740, 12);
            this.cbSheet.Margin = new System.Windows.Forms.Padding(4);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(208, 21);
            this.cbSheet.TabIndex = 17;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(16, 16);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(412, 20);
            this.txtFileName.TabIndex = 16;
            // 
            // lbQtdLines
            // 
            this.lbQtdLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQtdLines.AutoSize = true;
            this.lbQtdLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdLines.Location = new System.Drawing.Point(104, 410);
            this.lbQtdLines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQtdLines.Name = "lbQtdLines";
            this.lbQtdLines.Size = new System.Drawing.Size(18, 20);
            this.lbQtdLines.TabIndex = 15;
            this.lbQtdLines.Text = "#";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Linhas:";
            // 
            // btnImporter
            // 
            this.btnImporter.Location = new System.Drawing.Point(437, 13);
            this.btnImporter.Margin = new System.Windows.Forms.Padding(4);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(112, 28);
            this.btnImporter.TabIndex = 13;
            this.btnImporter.Text = "Importar";
            this.btnImporter.UseVisualStyleBackColor = true;
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdOk.Location = new System.Drawing.Point(16, 458);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(4);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(100, 28);
            this.cmdOk.TabIndex = 12;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // gridImporter
            // 
            this.gridImporter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridImporter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImporter.Location = new System.Drawing.Point(16, 48);
            this.gridImporter.Margin = new System.Windows.Forms.Padding(4);
            this.gridImporter.Name = "gridImporter";
            this.gridImporter.Size = new System.Drawing.Size(933, 358);
            this.gridImporter.TabIndex = 11;
            // 
            // lbQtdColumns
            // 
            this.lbQtdColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQtdColumns.AutoSize = true;
            this.lbQtdColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdColumns.Location = new System.Drawing.Point(104, 434);
            this.lbQtdColumns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQtdColumns.Name = "lbQtdColumns";
            this.lbQtdColumns.Size = new System.Drawing.Size(18, 20);
            this.lbQtdColumns.TabIndex = 19;
            this.lbQtdColumns.Text = "#";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 434);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Colunas:";
            // 
            // SpreadSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 498);
            this.Controls.Add(this.lbQtdColumns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSheet);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lbQtdLines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImporter);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.gridImporter);
            this.Name = "SpreadSheetForm";
            this.Text = "Planilha";
            ((System.ComponentModel.ISupportInitialize)(this.gridImporter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSheet;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lbQtdLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImporter;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.DataGridView gridImporter;
        private System.Windows.Forms.Label lbQtdColumns;
        private System.Windows.Forms.Label label3;
    }
}

