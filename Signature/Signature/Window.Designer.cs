﻿namespace Signature
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.msTop = new System.Windows.Forms.MenuStrip();
            this.tabSigFinish = new System.Windows.Forms.TabPage();
            this.btnCreateSignatures = new System.Windows.Forms.Button();
            this.btnFileNamesVarify = new System.Windows.Forms.Button();
            this.tbFileNames = new System.Windows.Forms.TextBox();
            this.tbSaveLocation = new System.Windows.Forms.TextBox();
            this.lblFileNames = new System.Windows.Forms.Label();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.lblSaveLocation = new System.Windows.Forms.Label();
            this.tabSigData = new System.Windows.Forms.TabPage();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tabSigTemplate = new System.Windows.Forms.TabPage();
            this.btnTemplateFileLoad = new System.Windows.Forms.Button();
            this.btnTemplateFileSave = new System.Windows.Forms.Button();
            this.tbTemplateFile = new System.Windows.Forms.TextBox();
            this.lblTemplateFileName = new System.Windows.Forms.Label();
            this.pnlWebBrowse = new System.Windows.Forms.Panel();
            this.wbTemplate = new System.Windows.Forms.WebBrowser();
            this.tabSigFormat = new System.Windows.Forms.TabPage();
            this.btnFieldsMoveDown = new System.Windows.Forms.Button();
            this.btnFieldsMoveUp = new System.Windows.Forms.Button();
            this.btnFieldsSaveToFile = new System.Windows.Forms.Button();
            this.btnFieldsLoadFromFile = new System.Windows.Forms.Button();
            this.btnFieldsLoadFromTemplate = new System.Windows.Forms.Button();
            this.btnFieldsReset = new System.Windows.Forms.Button();
            this.btnFieldsUpdate = new System.Windows.Forms.Button();
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSig = new System.Windows.Forms.TabControl();
            this.btnTemplateFileReload = new System.Windows.Forms.Button();
            this.tabSigFinish.SuspendLayout();
            this.tabSigData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabSigTemplate.SuspendLayout();
            this.pnlWebBrowse.SuspendLayout();
            this.tabSigFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            this.tabSig.SuspendLayout();
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
            // tabSigFinish
            // 
            this.tabSigFinish.Controls.Add(this.btnCreateSignatures);
            this.tabSigFinish.Controls.Add(this.btnFileNamesVarify);
            this.tabSigFinish.Controls.Add(this.tbFileNames);
            this.tabSigFinish.Controls.Add(this.tbSaveLocation);
            this.tabSigFinish.Controls.Add(this.lblFileNames);
            this.tabSigFinish.Controls.Add(this.btnSaveLocation);
            this.tabSigFinish.Controls.Add(this.lblSaveLocation);
            this.tabSigFinish.Location = new System.Drawing.Point(4, 23);
            this.tabSigFinish.Name = "tabSigFinish";
            this.tabSigFinish.Size = new System.Drawing.Size(906, 524);
            this.tabSigFinish.TabIndex = 4;
            this.tabSigFinish.Text = "Finish";
            this.tabSigFinish.UseVisualStyleBackColor = true;
            // 
            // btnCreateSignatures
            // 
            this.btnCreateSignatures.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSignatures.Location = new System.Drawing.Point(11, 72);
            this.btnCreateSignatures.Name = "btnCreateSignatures";
            this.btnCreateSignatures.Size = new System.Drawing.Size(105, 21);
            this.btnCreateSignatures.TabIndex = 28;
            this.btnCreateSignatures.Text = "Create Signatures";
            this.btnCreateSignatures.UseVisualStyleBackColor = true;
            this.btnCreateSignatures.Click += new System.EventHandler(this.btnCreateSignatures_Click);
            // 
            // btnFileNamesVarify
            // 
            this.btnFileNamesVarify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileNamesVarify.Location = new System.Drawing.Point(394, 43);
            this.btnFileNamesVarify.Name = "btnFileNamesVarify";
            this.btnFileNamesVarify.Size = new System.Drawing.Size(51, 24);
            this.btnFileNamesVarify.TabIndex = 27;
            this.btnFileNamesVarify.Text = "Verify";
            this.btnFileNamesVarify.UseVisualStyleBackColor = true;
            this.btnFileNamesVarify.Click += new System.EventHandler(this.btnFileNamesVarify_Click);
            // 
            // tbFileNames
            // 
            this.tbFileNames.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileNames.Location = new System.Drawing.Point(93, 46);
            this.tbFileNames.Name = "tbFileNames";
            this.tbFileNames.Size = new System.Drawing.Size(295, 20);
            this.tbFileNames.TabIndex = 26;
            // 
            // tbSaveLocation
            // 
            this.tbSaveLocation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaveLocation.Location = new System.Drawing.Point(93, 13);
            this.tbSaveLocation.Name = "tbSaveLocation";
            this.tbSaveLocation.ReadOnly = true;
            this.tbSaveLocation.Size = new System.Drawing.Size(295, 20);
            this.tbSaveLocation.TabIndex = 23;
            // 
            // lblFileNames
            // 
            this.lblFileNames.AutoSize = true;
            this.lblFileNames.Location = new System.Drawing.Point(8, 49);
            this.lblFileNames.Name = "lblFileNames";
            this.lblFileNames.Size = new System.Drawing.Size(71, 14);
            this.lblFileNames.TabIndex = 25;
            this.lblFileNames.Text = "Save Names:";
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLocation.Location = new System.Drawing.Point(394, 11);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(51, 24);
            this.btnSaveLocation.TabIndex = 24;
            this.btnSaveLocation.Text = "Find";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.Location = new System.Drawing.Point(8, 16);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(79, 14);
            this.lblSaveLocation.TabIndex = 22;
            this.lblSaveLocation.Text = "Save Location:";
            // 
            // tabSigData
            // 
            this.tabSigData.Controls.Add(this.dgvData);
            this.tabSigData.Location = new System.Drawing.Point(4, 23);
            this.tabSigData.Name = "tabSigData";
            this.tabSigData.Padding = new System.Windows.Forms.Padding(3);
            this.tabSigData.Size = new System.Drawing.Size(906, 524);
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
            this.dgvData.Size = new System.Drawing.Size(900, 518);
            this.dgvData.TabIndex = 0;
            // 
            // tabSigTemplate
            // 
            this.tabSigTemplate.Controls.Add(this.btnTemplateFileReload);
            this.tabSigTemplate.Controls.Add(this.btnTemplateFileLoad);
            this.tabSigTemplate.Controls.Add(this.btnTemplateFileSave);
            this.tabSigTemplate.Controls.Add(this.tbTemplateFile);
            this.tabSigTemplate.Controls.Add(this.lblTemplateFileName);
            this.tabSigTemplate.Controls.Add(this.pnlWebBrowse);
            this.tabSigTemplate.Location = new System.Drawing.Point(4, 23);
            this.tabSigTemplate.Name = "tabSigTemplate";
            this.tabSigTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tabSigTemplate.Size = new System.Drawing.Size(906, 524);
            this.tabSigTemplate.TabIndex = 2;
            this.tabSigTemplate.Text = "Template";
            this.tabSigTemplate.UseVisualStyleBackColor = true;
            // 
            // btnTemplateFileLoad
            // 
            this.btnTemplateFileLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateFileLoad.Location = new System.Drawing.Point(682, 2);
            this.btnTemplateFileLoad.Name = "btnTemplateFileLoad";
            this.btnTemplateFileLoad.Size = new System.Drawing.Size(68, 24);
            this.btnTemplateFileLoad.TabIndex = 3;
            this.btnTemplateFileLoad.Text = "Load Template";
            this.btnTemplateFileLoad.UseVisualStyleBackColor = true;
            this.btnTemplateFileLoad.Click += new System.EventHandler(this.btnTemplateFileLoad_Click);
            // 
            // btnTemplateFileSave
            // 
            this.btnTemplateFileSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateFileSave.Enabled = false;
            this.btnTemplateFileSave.Location = new System.Drawing.Point(830, 2);
            this.btnTemplateFileSave.Name = "btnTemplateFileSave";
            this.btnTemplateFileSave.Size = new System.Drawing.Size(68, 24);
            this.btnTemplateFileSave.TabIndex = 5;
            this.btnTemplateFileSave.Text = "Save";
            this.btnTemplateFileSave.UseVisualStyleBackColor = true;
            this.btnTemplateFileSave.Click += new System.EventHandler(this.btnTemplateFileSave_Click);
            // 
            // tbTemplateFile
            // 
            this.tbTemplateFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTemplateFile.Location = new System.Drawing.Point(60, 6);
            this.tbTemplateFile.Name = "tbTemplateFile";
            this.tbTemplateFile.ReadOnly = true;
            this.tbTemplateFile.Size = new System.Drawing.Size(616, 20);
            this.tbTemplateFile.TabIndex = 2;
            // 
            // lblTemplateFileName
            // 
            this.lblTemplateFileName.AutoSize = true;
            this.lblTemplateFileName.Location = new System.Drawing.Point(5, 9);
            this.lblTemplateFileName.Name = "lblTemplateFileName";
            this.lblTemplateFileName.Size = new System.Drawing.Size(49, 14);
            this.lblTemplateFileName.TabIndex = 1;
            this.lblTemplateFileName.Text = "Template";
            // 
            // pnlWebBrowse
            // 
            this.pnlWebBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWebBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWebBrowse.Controls.Add(this.wbTemplate);
            this.pnlWebBrowse.Location = new System.Drawing.Point(8, 58);
            this.pnlWebBrowse.Name = "pnlWebBrowse";
            this.pnlWebBrowse.Size = new System.Drawing.Size(890, 458);
            this.pnlWebBrowse.TabIndex = 0;
            // 
            // wbTemplate
            // 
            this.wbTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTemplate.Location = new System.Drawing.Point(0, 0);
            this.wbTemplate.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTemplate.Name = "wbTemplate";
            this.wbTemplate.Size = new System.Drawing.Size(888, 456);
            this.wbTemplate.TabIndex = 0;
            this.wbTemplate.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabSigFormat
            // 
            this.tabSigFormat.Controls.Add(this.btnFieldsMoveDown);
            this.tabSigFormat.Controls.Add(this.btnFieldsMoveUp);
            this.tabSigFormat.Controls.Add(this.btnFieldsSaveToFile);
            this.tabSigFormat.Controls.Add(this.btnFieldsLoadFromFile);
            this.tabSigFormat.Controls.Add(this.btnFieldsLoadFromTemplate);
            this.tabSigFormat.Controls.Add(this.btnFieldsReset);
            this.tabSigFormat.Controls.Add(this.btnFieldsUpdate);
            this.tabSigFormat.Controls.Add(this.dgvFields);
            this.tabSigFormat.Location = new System.Drawing.Point(4, 23);
            this.tabSigFormat.Name = "tabSigFormat";
            this.tabSigFormat.Size = new System.Drawing.Size(906, 524);
            this.tabSigFormat.TabIndex = 3;
            this.tabSigFormat.Text = "Format";
            this.tabSigFormat.UseVisualStyleBackColor = true;
            // 
            // btnFieldsMoveDown
            // 
            this.btnFieldsMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFieldsMoveDown.Location = new System.Drawing.Point(787, 123);
            this.btnFieldsMoveDown.Name = "btnFieldsMoveDown";
            this.btnFieldsMoveDown.Size = new System.Drawing.Size(111, 24);
            this.btnFieldsMoveDown.TabIndex = 8;
            this.btnFieldsMoveDown.Text = "Move Down";
            this.btnFieldsMoveDown.UseVisualStyleBackColor = true;
            this.btnFieldsMoveDown.Click += new System.EventHandler(this.btnFieldsMoveDown_Click);
            // 
            // btnFieldsMoveUp
            // 
            this.btnFieldsMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFieldsMoveUp.Location = new System.Drawing.Point(787, 93);
            this.btnFieldsMoveUp.Name = "btnFieldsMoveUp";
            this.btnFieldsMoveUp.Size = new System.Drawing.Size(111, 24);
            this.btnFieldsMoveUp.TabIndex = 7;
            this.btnFieldsMoveUp.Text = "Move Up";
            this.btnFieldsMoveUp.UseVisualStyleBackColor = true;
            this.btnFieldsMoveUp.Click += new System.EventHandler(this.btnFieldsMoveUp_Click);
            // 
            // btnFieldsSaveToFile
            // 
            this.btnFieldsSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFieldsSaveToFile.Location = new System.Drawing.Point(787, 63);
            this.btnFieldsSaveToFile.Name = "btnFieldsSaveToFile";
            this.btnFieldsSaveToFile.Size = new System.Drawing.Size(111, 24);
            this.btnFieldsSaveToFile.TabIndex = 6;
            this.btnFieldsSaveToFile.Text = "Save To File";
            this.btnFieldsSaveToFile.UseVisualStyleBackColor = true;
            this.btnFieldsSaveToFile.Click += new System.EventHandler(this.btnFieldsSaveToFile_Click);
            // 
            // btnFieldsLoadFromFile
            // 
            this.btnFieldsLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFieldsLoadFromFile.Location = new System.Drawing.Point(787, 33);
            this.btnFieldsLoadFromFile.Name = "btnFieldsLoadFromFile";
            this.btnFieldsLoadFromFile.Size = new System.Drawing.Size(111, 24);
            this.btnFieldsLoadFromFile.TabIndex = 5;
            this.btnFieldsLoadFromFile.Text = "Load From File";
            this.btnFieldsLoadFromFile.UseVisualStyleBackColor = true;
            this.btnFieldsLoadFromFile.Click += new System.EventHandler(this.btnFieldsLoadFromFile_Click);
            // 
            // btnFieldsLoadFromTemplate
            // 
            this.btnFieldsLoadFromTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFieldsLoadFromTemplate.Location = new System.Drawing.Point(787, 3);
            this.btnFieldsLoadFromTemplate.Name = "btnFieldsLoadFromTemplate";
            this.btnFieldsLoadFromTemplate.Size = new System.Drawing.Size(111, 24);
            this.btnFieldsLoadFromTemplate.TabIndex = 4;
            this.btnFieldsLoadFromTemplate.Text = "Load From Template";
            this.btnFieldsLoadFromTemplate.UseVisualStyleBackColor = true;
            this.btnFieldsLoadFromTemplate.Click += new System.EventHandler(this.btnFieldsLoadFromTemplate_Click);
            // 
            // btnFieldsReset
            // 
            this.btnFieldsReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFieldsReset.Location = new System.Drawing.Point(787, 213);
            this.btnFieldsReset.Name = "btnFieldsReset";
            this.btnFieldsReset.Size = new System.Drawing.Size(111, 24);
            this.btnFieldsReset.TabIndex = 3;
            this.btnFieldsReset.Text = "Reset Fields";
            this.btnFieldsReset.UseVisualStyleBackColor = true;
            this.btnFieldsReset.Click += new System.EventHandler(this.btnFieldsReset_Click);
            // 
            // btnFieldsUpdate
            // 
            this.btnFieldsUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFieldsUpdate.Location = new System.Drawing.Point(787, 183);
            this.btnFieldsUpdate.Name = "btnFieldsUpdate";
            this.btnFieldsUpdate.Size = new System.Drawing.Size(111, 24);
            this.btnFieldsUpdate.TabIndex = 2;
            this.btnFieldsUpdate.Text = "Update Fields";
            this.btnFieldsUpdate.UseVisualStyleBackColor = true;
            this.btnFieldsUpdate.Click += new System.EventHandler(this.btnFieldsUpdate_Click);
            // 
            // dgvFields
            // 
            this.dgvFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.field});
            this.dgvFields.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgvFields.Location = new System.Drawing.Point(8, 3);
            this.dgvFields.Name = "dgvFields";
            this.dgvFields.Size = new System.Drawing.Size(773, 518);
            this.dgvFields.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.DefaultCellStyle = dataGridViewCellStyle1;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // field
            // 
            this.field.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field.DefaultCellStyle = dataGridViewCellStyle2;
            this.field.HeaderText = "Field";
            this.field.Name = "field";
            // 
            // tabSig
            // 
            this.tabSig.Controls.Add(this.tabSigTemplate);
            this.tabSig.Controls.Add(this.tabSigFormat);
            this.tabSig.Controls.Add(this.tabSigData);
            this.tabSig.Controls.Add(this.tabSigFinish);
            this.tabSig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSig.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSig.Location = new System.Drawing.Point(0, 24);
            this.tabSig.Name = "tabSig";
            this.tabSig.SelectedIndex = 0;
            this.tabSig.Size = new System.Drawing.Size(914, 551);
            this.tabSig.TabIndex = 1;
            // 
            // btnTemplateFileReload
            // 
            this.btnTemplateFileReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemplateFileReload.Location = new System.Drawing.Point(756, 2);
            this.btnTemplateFileReload.Name = "btnTemplateFileReload";
            this.btnTemplateFileReload.Size = new System.Drawing.Size(68, 24);
            this.btnTemplateFileReload.TabIndex = 4;
            this.btnTemplateFileReload.Text = "Reload";
            this.btnTemplateFileReload.UseVisualStyleBackColor = true;
            this.btnTemplateFileReload.Click += new System.EventHandler(this.btnTemplateFileReload_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 575);
            this.Controls.Add(this.tabSig);
            this.Controls.Add(this.msTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msTop;
            this.Name = "window";
            this.Text = "Signature";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.window_FormClosing);
            this.Load += new System.EventHandler(this.window_Load);
            this.tabSigFinish.ResumeLayout(false);
            this.tabSigFinish.PerformLayout();
            this.tabSigData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabSigTemplate.ResumeLayout(false);
            this.tabSigTemplate.PerformLayout();
            this.pnlWebBrowse.ResumeLayout(false);
            this.tabSigFormat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).EndInit();
            this.tabSig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTop;
        private System.Windows.Forms.TabPage tabSigFinish;
        private System.Windows.Forms.Button btnCreateSignatures;
        private System.Windows.Forms.Button btnFileNamesVarify;
        private System.Windows.Forms.TextBox tbFileNames;
        private System.Windows.Forms.TextBox tbSaveLocation;
        private System.Windows.Forms.Label lblFileNames;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.Label lblSaveLocation;
        private System.Windows.Forms.TabPage tabSigData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TabPage tabSigTemplate;
        private System.Windows.Forms.Button btnTemplateFileLoad;
        private System.Windows.Forms.Button btnTemplateFileSave;
        private System.Windows.Forms.TextBox tbTemplateFile;
        private System.Windows.Forms.Label lblTemplateFileName;
        private System.Windows.Forms.Panel pnlWebBrowse;
        private System.Windows.Forms.WebBrowser wbTemplate;
        private System.Windows.Forms.TabPage tabSigFormat;
        private System.Windows.Forms.Button btnFieldsReset;
        private System.Windows.Forms.Button btnFieldsUpdate;
        private System.Windows.Forms.DataGridView dgvFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn field;
        private System.Windows.Forms.TabControl tabSig;
        private System.Windows.Forms.Button btnFieldsSaveToFile;
        private System.Windows.Forms.Button btnFieldsLoadFromFile;
        private System.Windows.Forms.Button btnFieldsLoadFromTemplate;
        private System.Windows.Forms.Button btnFieldsMoveDown;
        private System.Windows.Forms.Button btnFieldsMoveUp;
        private System.Windows.Forms.Button btnTemplateFileReload;
    }
}

