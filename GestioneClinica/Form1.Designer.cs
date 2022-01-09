namespace GestioneClinica
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridViewPazienti = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridViewMedici = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridViewPatologie = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gridViewSpecializzazioni = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.cbxMedicoFilter = new System.Windows.Forms.CheckBox();
            this.cbxPazienteFilter = new System.Windows.Forms.CheckBox();
            this.cbxDataFilter = new System.Windows.Forms.CheckBox();
            this.cmbMedici = new System.Windows.Forms.ComboBox();
            this.cmbPazienti = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gridViewAppuntamenti = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPazienti)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedici)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPatologie)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSpecializzazioni)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppuntamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 675);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridViewPazienti);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PAZIENTI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridViewPazienti
            // 
            this.gridViewPazienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPazienti.Location = new System.Drawing.Point(2, 0);
            this.gridViewPazienti.Name = "gridViewPazienti";
            this.gridViewPazienti.Size = new System.Drawing.Size(569, 649);
            this.gridViewPazienti.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridViewMedici);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(569, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MEDICI";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridViewMedici
            // 
            this.gridViewMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMedici.Location = new System.Drawing.Point(0, 0);
            this.gridViewMedici.Name = "gridViewMedici";
            this.gridViewMedici.Size = new System.Drawing.Size(569, 653);
            this.gridViewMedici.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridViewPatologie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(569, 649);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PATOLOGIE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridViewPatologie
            // 
            this.gridViewPatologie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPatologie.Location = new System.Drawing.Point(-4, 0);
            this.gridViewPatologie.Name = "gridViewPatologie";
            this.gridViewPatologie.Size = new System.Drawing.Size(577, 649);
            this.gridViewPatologie.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gridViewSpecializzazioni);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(569, 649);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SPECIALIZZAZIONI";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gridViewSpecializzazioni
            // 
            this.gridViewSpecializzazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSpecializzazioni.Location = new System.Drawing.Point(0, 0);
            this.gridViewSpecializzazioni.Name = "gridViewSpecializzazioni";
            this.gridViewSpecializzazioni.Size = new System.Drawing.Size(569, 649);
            this.gridViewSpecializzazioni.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.btnReset);
            this.tabPage5.Controls.Add(this.btnFiltra);
            this.tabPage5.Controls.Add(this.cbxMedicoFilter);
            this.tabPage5.Controls.Add(this.cbxPazienteFilter);
            this.tabPage5.Controls.Add(this.cbxDataFilter);
            this.tabPage5.Controls.Add(this.cmbMedici);
            this.tabPage5.Controls.Add(this.cmbPazienti);
            this.tabPage5.Controls.Add(this.dateTimePicker1);
            this.tabPage5.Controls.Add(this.gridViewAppuntamenti);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(569, 649);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "APPUNTAMENTI";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Medico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Paziente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(451, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(62, 62);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnFiltra
            // 
            this.btnFiltra.Location = new System.Drawing.Point(359, 40);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(62, 62);
            this.btnFiltra.TabIndex = 8;
            this.btnFiltra.Text = "Applica filtri";
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // cbxMedicoFilter
            // 
            this.cbxMedicoFilter.AutoSize = true;
            this.cbxMedicoFilter.Location = new System.Drawing.Point(285, 100);
            this.cbxMedicoFilter.Name = "cbxMedicoFilter";
            this.cbxMedicoFilter.Size = new System.Drawing.Size(15, 14);
            this.cbxMedicoFilter.TabIndex = 7;
            this.cbxMedicoFilter.UseVisualStyleBackColor = true;
            this.cbxMedicoFilter.CheckedChanged += new System.EventHandler(this.cbxMedicoFilter_CheckedChanged);
            // 
            // cbxPazienteFilter
            // 
            this.cbxPazienteFilter.AutoSize = true;
            this.cbxPazienteFilter.Location = new System.Drawing.Point(285, 64);
            this.cbxPazienteFilter.Name = "cbxPazienteFilter";
            this.cbxPazienteFilter.Size = new System.Drawing.Size(15, 14);
            this.cbxPazienteFilter.TabIndex = 6;
            this.cbxPazienteFilter.UseVisualStyleBackColor = true;
            this.cbxPazienteFilter.CheckedChanged += new System.EventHandler(this.cbxPazienteFilter_CheckedChanged);
            // 
            // cbxDataFilter
            // 
            this.cbxDataFilter.AutoSize = true;
            this.cbxDataFilter.Location = new System.Drawing.Point(285, 25);
            this.cbxDataFilter.Name = "cbxDataFilter";
            this.cbxDataFilter.Size = new System.Drawing.Size(15, 14);
            this.cbxDataFilter.TabIndex = 5;
            this.cbxDataFilter.UseVisualStyleBackColor = true;
            this.cbxDataFilter.CheckedChanged += new System.EventHandler(this.cbxDataFilter_CheckedChanged);
            // 
            // cmbMedici
            // 
            this.cmbMedici.FormattingEnabled = true;
            this.cmbMedici.Location = new System.Drawing.Point(61, 98);
            this.cmbMedici.Name = "cmbMedici";
            this.cmbMedici.Size = new System.Drawing.Size(200, 21);
            this.cmbMedici.TabIndex = 4;
            // 
            // cmbPazienti
            // 
            this.cmbPazienti.FormattingEnabled = true;
            this.cmbPazienti.Location = new System.Drawing.Point(61, 62);
            this.cmbPazienti.Name = "cmbPazienti";
            this.cmbPazienti.Size = new System.Drawing.Size(200, 21);
            this.cmbPazienti.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // gridViewAppuntamenti
            // 
            this.gridViewAppuntamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAppuntamenti.Location = new System.Drawing.Point(0, 136);
            this.gridViewAppuntamenti.Name = "gridViewAppuntamenti";
            this.gridViewAppuntamenti.Size = new System.Drawing.Size(569, 513);
            this.gridViewAppuntamenti.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 670);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPazienti)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedici)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPatologie)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSpecializzazioni)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAppuntamenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView gridViewPazienti;
        private System.Windows.Forms.DataGridView gridViewMedici;
        private System.Windows.Forms.DataGridView gridViewPatologie;
        private System.Windows.Forms.DataGridView gridViewSpecializzazioni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.CheckBox cbxMedicoFilter;
        private System.Windows.Forms.CheckBox cbxPazienteFilter;
        private System.Windows.Forms.CheckBox cbxDataFilter;
        private System.Windows.Forms.ComboBox cmbMedici;
        private System.Windows.Forms.ComboBox cmbPazienti;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView gridViewAppuntamenti;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

