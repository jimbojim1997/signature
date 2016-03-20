namespace Signature
{
    partial class window
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
            this.msTop = new System.Windows.Forms.MenuStrip();
            this.tabSig = new System.Windows.Forms.TabControl();
            this.tabSigData = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tabSigOptions = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetFields = new System.Windows.Forms.Button();
            this.btnUpdateFields = new System.Windows.Forms.Button();
            this.btnCreateSignatures = new System.Windows.Forms.Button();
            this.btnFileNamesVarify = new System.Windows.Forms.Button();
            this.tbFileNames = new System.Windows.Forms.TextBox();
            this.lblFileNames = new System.Windows.Forms.Label();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.tbSaveLocation = new System.Windows.Forms.TextBox();
            this.lblSaveLocation = new System.Windows.Forms.Label();
            this.btnTemplateFileOpen = new System.Windows.Forms.Button();
            this.tbTemplateFile = new System.Windows.Forms.TextBox();
            this.lblTemplateFile = new System.Windows.Forms.Label();
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSig.SuspendLayout();
            this.tabSigData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabSigOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            this.SuspendLayout();
            // 
            // msTop
            // 
            this.msTop.Location = new System.Drawing.Point(0, 0);
            this.msTop.Name = "msTop";
            this.msTop.Size = new System.Drawing.Size(914, 24);
            this.msTop.TabIndex = 0;
            this.msTop.Text = "msTop";
            // 
            // tabSig
            // 
            this.tabSig.Controls.Add(this.tabSigData);
            this.tabSig.Controls.Add(this.tabSigOptions);
            this.tabSig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSig.Location = new System.Drawing.Point(0, 24);
            this.tabSig.Name = "tabSig";
            this.tabSig.SelectedIndex = 0;
            this.tabSig.Size = new System.Drawing.Size(914, 551);
            this.tabSig.TabIndex = 1;
            // 
            // tabSigData
            // 
            this.tabSigData.Controls.Add(this.dgvData);
            this.tabSigData.Location = new System.Drawing.Point(4, 22);
            this.tabSigData.Name = "tabSigData";
            this.tabSigData.Padding = new System.Windows.Forms.Padding(3);
            this.tabSigData.Size = new System.Drawing.Size(906, 525);
            this.tabSigData.TabIndex = 0;
            this.tabSigData.Text = "Data";
            this.tabSigData.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 3);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(900, 519);
            this.dgvData.TabIndex = 0;
            // 
            // tabSigOptions
            // 
            this.tabSigOptions.Controls.Add(this.panel1);
            this.tabSigOptions.Controls.Add(this.dgvFields);
            this.tabSigOptions.Location = new System.Drawing.Point(4, 22);
            this.tabSigOptions.Name = "tabSigOptions";
            this.tabSigOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabSigOptions.Size = new System.Drawing.Size(906, 525);
            this.tabSigOptions.TabIndex = 1;
            this.tabSigOptions.Text = "Options";
            this.tabSigOptions.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetFields);
            this.panel1.Controls.Add(this.btnUpdateFields);
            this.panel1.Controls.Add(this.btnCreateSignatures);
            this.panel1.Controls.Add(this.btnFileNamesVarify);
            this.panel1.Controls.Add(this.tbFileNames);
            this.panel1.Controls.Add(this.lblFileNames);
            this.panel1.Controls.Add(this.btnSaveLocation);
            this.panel1.Controls.Add(this.tbSaveLocation);
            this.panel1.Controls.Add(this.lblSaveLocation);
            this.panel1.Controls.Add(this.btnTemplateFileOpen);
            this.panel1.Controls.Add(this.tbTemplateFile);
            this.panel1.Controls.Add(this.lblTemplateFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(458, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 519);
            this.panel1.TabIndex = 1;
            // 
            // btnResetFields
            // 
            this.btnResetFields.Location = new System.Drawing.Point(219, 493);
            this.btnResetFields.Name = "btnResetFields";
            this.btnResetFields.Size = new System.Drawing.Size(96, 21);
            this.btnResetFields.TabIndex = 11;
            this.btnResetFields.Text = "Reset Fields";
            this.btnResetFields.UseVisualStyleBackColor = true;
            this.btnResetFields.Click += new System.EventHandler(this.btnResetFields_Click);
            // 
            // btnUpdateFields
            // 
            this.btnUpdateFields.Location = new System.Drawing.Point(117, 493);
            this.btnUpdateFields.Name = "btnUpdateFields";
            this.btnUpdateFields.Size = new System.Drawing.Size(96, 21);
            this.btnUpdateFields.TabIndex = 10;
            this.btnUpdateFields.Text = "Update Fields";
            this.btnUpdateFields.UseVisualStyleBackColor = true;
            this.btnUpdateFields.Click += new System.EventHandler(this.btnUpdateFields_Click);
            // 
            // btnCreateSignatures
            // 
            this.btnCreateSignatures.Location = new System.Drawing.Point(6, 493);
            this.btnCreateSignatures.Name = "btnCreateSignatures";
            this.btnCreateSignatures.Size = new System.Drawing.Size(105, 21);
            this.btnCreateSignatures.TabIndex = 9;
            this.btnCreateSignatures.Text = "Create Signatures";
            this.btnCreateSignatures.UseVisualStyleBackColor = true;
            this.btnCreateSignatures.Click += new System.EventHandler(this.btnCreateSignatures_Click);
            // 
            // btnFileNamesVarify
            // 
            this.btnFileNamesVarify.Location = new System.Drawing.Point(389, 72);
            this.btnFileNamesVarify.Name = "btnFileNamesVarify";
            this.btnFileNamesVarify.Size = new System.Drawing.Size(51, 24);
            this.btnFileNamesVarify.TabIndex = 8;
            this.btnFileNamesVarify.Text = "Verify";
            this.btnFileNamesVarify.UseVisualStyleBackColor = true;
            this.btnFileNamesVarify.Click += new System.EventHandler(this.btnFileNamesVarify_Click);
            // 
            // tbFileNames
            // 
            this.tbFileNames.Location = new System.Drawing.Point(88, 75);
            this.tbFileNames.Name = "tbFileNames";
            this.tbFileNames.Size = new System.Drawing.Size(295, 20);
            this.tbFileNames.TabIndex = 7;
            // 
            // lblFileNames
            // 
            this.lblFileNames.AutoSize = true;
            this.lblFileNames.Location = new System.Drawing.Point(3, 78);
            this.lblFileNames.Name = "lblFileNames";
            this.lblFileNames.Size = new System.Drawing.Size(71, 13);
            this.lblFileNames.TabIndex = 6;
            this.lblFileNames.Text = "Save Names:";
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(389, 40);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(51, 24);
            this.btnSaveLocation.TabIndex = 5;
            this.btnSaveLocation.Text = "Find";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // tbSaveLocation
            // 
            this.tbSaveLocation.Location = new System.Drawing.Point(88, 42);
            this.tbSaveLocation.Name = "tbSaveLocation";
            this.tbSaveLocation.ReadOnly = true;
            this.tbSaveLocation.Size = new System.Drawing.Size(295, 20);
            this.tbSaveLocation.TabIndex = 4;
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.Location = new System.Drawing.Point(3, 45);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(79, 13);
            this.lblSaveLocation.TabIndex = 3;
            this.lblSaveLocation.Text = "Save Location:";
            // 
            // btnTemplateFileOpen
            // 
            this.btnTemplateFileOpen.Location = new System.Drawing.Point(389, 7);
            this.btnTemplateFileOpen.Name = "btnTemplateFileOpen";
            this.btnTemplateFileOpen.Size = new System.Drawing.Size(51, 24);
            this.btnTemplateFileOpen.TabIndex = 2;
            this.btnTemplateFileOpen.Text = "Open";
            this.btnTemplateFileOpen.UseVisualStyleBackColor = true;
            this.btnTemplateFileOpen.Click += new System.EventHandler(this.btnTemplateFileOpen_Click);
            // 
            // tbTemplateFile
            // 
            this.tbTemplateFile.Location = new System.Drawing.Point(88, 9);
            this.tbTemplateFile.Name = "tbTemplateFile";
            this.tbTemplateFile.ReadOnly = true;
            this.tbTemplateFile.Size = new System.Drawing.Size(295, 20);
            this.tbTemplateFile.TabIndex = 1;
            // 
            // lblTemplateFile
            // 
            this.lblTemplateFile.AutoSize = true;
            this.lblTemplateFile.Location = new System.Drawing.Point(3, 12);
            this.lblTemplateFile.Name = "lblTemplateFile";
            this.lblTemplateFile.Size = new System.Drawing.Size(73, 13);
            this.lblTemplateFile.TabIndex = 0;
            this.lblTemplateFile.Text = "Template File:";
            // 
            // dgvFields
            // 
            this.dgvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.field});
            this.dgvFields.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvFields.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgvFields.Location = new System.Drawing.Point(3, 3);
            this.dgvFields.Name = "dgvFields";
            this.dgvFields.Size = new System.Drawing.Size(445, 519);
            this.dgvFields.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // field
            // 
            this.field.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.field.HeaderText = "Field";
            this.field.Name = "field";
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 575);
            this.Controls.Add(this.tabSig);
            this.Controls.Add(this.msTop);
            this.MainMenuStrip = this.msTop;
            this.Name = "window";
            this.ShowIcon = false;
            this.Text = "Signature";
            this.tabSig.ResumeLayout(false);
            this.tabSigData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabSigOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTop;
        private System.Windows.Forms.TabControl tabSig;
        private System.Windows.Forms.TabPage tabSigData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TabPage tabSigOptions;
        private System.Windows.Forms.DataGridView dgvFields;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTemplateFileOpen;
        private System.Windows.Forms.TextBox tbTemplateFile;
        private System.Windows.Forms.Label lblTemplateFile;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.TextBox tbSaveLocation;
        private System.Windows.Forms.Label lblSaveLocation;
        private System.Windows.Forms.TextBox tbFileNames;
        private System.Windows.Forms.Label lblFileNames;
        private System.Windows.Forms.Button btnFileNamesVarify;
        private System.Windows.Forms.Button btnResetFields;
        private System.Windows.Forms.Button btnUpdateFields;
        private System.Windows.Forms.Button btnCreateSignatures;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn field;
    }
}

