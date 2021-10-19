namespace Base64FileConverter
{
	partial class Base64FileConverterForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base64FileConverterForm));
			this._btnSelectModeConvertFileToBase64 = new System.Windows.Forms.Button();
			this._pnlSelectRunMode = new System.Windows.Forms.Panel();
			this._lblHeaderSelectRunMode = new System.Windows.Forms.Label();
			this._btnSelectModeConvertBase64ToFile = new System.Windows.Forms.Button();
			this._pnlBackToModeSelect = new System.Windows.Forms.Panel();
			this._btnBackToModeSelect = new System.Windows.Forms.Button();
			this._pnlFileToBase64 = new System.Windows.Forms.Panel();
			this._lblHeaderConvertFileToBase64 = new System.Windows.Forms.Label();
			this._lblFileToConvertToBase64 = new System.Windows.Forms.Label();
			this._lblDecompressedBase64 = new System.Windows.Forms.Label();
			this._lblDeflatedBase64 = new System.Windows.Forms.Label();
			this._btnCopyCompressedToClipboard = new System.Windows.Forms.Button();
			this._btnCopyDecompressedToClipboard = new System.Windows.Forms.Button();
			this._btnExecuteConvertFileToBase64 = new System.Windows.Forms.Button();
			this._txtCompressedBase64 = new System.Windows.Forms.RichTextBox();
			this._txtDecompressedBase64 = new System.Windows.Forms.RichTextBox();
			this._txtFileToConvertToBase64 = new System.Windows.Forms.TextBox();
			this._btnSelectFileToConvertToBase64 = new System.Windows.Forms.Button();
			this._lblHeaderConvertBase64ToFile = new System.Windows.Forms.Label();
			this._lblFileToSaveFromBase64 = new System.Windows.Forms.Label();
			this._txtFileToSaveFromBase64 = new System.Windows.Forms.TextBox();
			this._pnlBase64ToFile = new System.Windows.Forms.Panel();
			this._lblSaveFileResult = new System.Windows.Forms.Label();
			this._btnSaveBase64ToFile = new System.Windows.Forms.Button();
			this._btnSelectFileToSaveBase64 = new System.Windows.Forms.Button();
			this._lblBase64ToFileDestinationHelpText = new System.Windows.Forms.Label();
			this._lblBase64ToConvertDecompressionHelpText = new System.Windows.Forms.Label();
			this._lblBase64ToConvertToFile = new System.Windows.Forms.Label();
			this._txtBase64ToConvertToFile = new System.Windows.Forms.RichTextBox();
			this._dlgSelectFileToConvertToBase64 = new System.Windows.Forms.OpenFileDialog();
			this._dlgSaveBase64ToFile = new System.Windows.Forms.SaveFileDialog();
			this._pnlSelectRunMode.SuspendLayout();
			this._pnlBackToModeSelect.SuspendLayout();
			this._pnlFileToBase64.SuspendLayout();
			this._pnlBase64ToFile.SuspendLayout();
			this.SuspendLayout();
			// 
			// _btnSelectModeConvertFileToBase64
			// 
			this._btnSelectModeConvertFileToBase64.Location = new System.Drawing.Point(36, 114);
			this._btnSelectModeConvertFileToBase64.Name = "_btnSelectModeConvertFileToBase64";
			this._btnSelectModeConvertFileToBase64.Size = new System.Drawing.Size(338, 46);
			this._btnSelectModeConvertFileToBase64.TabIndex = 1;
			this._btnSelectModeConvertFileToBase64.Text = "Convert a File to Base64";
			this._btnSelectModeConvertFileToBase64.UseVisualStyleBackColor = true;
			this._btnSelectModeConvertFileToBase64.Click += new System.EventHandler(this._btnSelectModeConvertFileToBase64_Click);
			// 
			// _pnlSelectRunMode
			// 
			this._pnlSelectRunMode.Controls.Add(this._lblHeaderSelectRunMode);
			this._pnlSelectRunMode.Controls.Add(this._btnSelectModeConvertBase64ToFile);
			this._pnlSelectRunMode.Controls.Add(this._btnSelectModeConvertFileToBase64);
			this._pnlSelectRunMode.Location = new System.Drawing.Point(0, 0);
			this._pnlSelectRunMode.Name = "_pnlSelectRunMode";
			this._pnlSelectRunMode.Size = new System.Drawing.Size(1433, 477);
			this._pnlSelectRunMode.TabIndex = 1;
			// 
			// _lblHeaderSelectRunMode
			// 
			this._lblHeaderSelectRunMode.AutoSize = true;
			this._lblHeaderSelectRunMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this._lblHeaderSelectRunMode.Location = new System.Drawing.Point(27, 34);
			this._lblHeaderSelectRunMode.Name = "_lblHeaderSelectRunMode";
			this._lblHeaderSelectRunMode.Size = new System.Drawing.Size(267, 50);
			this._lblHeaderSelectRunMode.TabIndex = 2;
			this._lblHeaderSelectRunMode.Text = "Select a Mode";
			// 
			// _btnSelectModeConvertBase64ToFile
			// 
			this._btnSelectModeConvertBase64ToFile.Location = new System.Drawing.Point(36, 211);
			this._btnSelectModeConvertBase64ToFile.Name = "_btnSelectModeConvertBase64ToFile";
			this._btnSelectModeConvertBase64ToFile.Size = new System.Drawing.Size(338, 46);
			this._btnSelectModeConvertBase64ToFile.TabIndex = 2;
			this._btnSelectModeConvertBase64ToFile.Text = "Convert Base64 to a File";
			this._btnSelectModeConvertBase64ToFile.UseVisualStyleBackColor = true;
			this._btnSelectModeConvertBase64ToFile.Click += new System.EventHandler(this._btnSelectModeConvertBase64ToFile_Click);
			// 
			// _pnlBackToModeSelect
			// 
			this._pnlBackToModeSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._pnlBackToModeSelect.Controls.Add(this._btnBackToModeSelect);
			this._pnlBackToModeSelect.Location = new System.Drawing.Point(0, 966);
			this._pnlBackToModeSelect.Name = "_pnlBackToModeSelect";
			this._pnlBackToModeSelect.Size = new System.Drawing.Size(1433, 82);
			this._pnlBackToModeSelect.TabIndex = 12;
			this._pnlBackToModeSelect.Visible = false;
			// 
			// _btnBackToModeSelect
			// 
			this._btnBackToModeSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this._btnBackToModeSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this._btnBackToModeSelect.Location = new System.Drawing.Point(37, 13);
			this._btnBackToModeSelect.Name = "_btnBackToModeSelect";
			this._btnBackToModeSelect.Size = new System.Drawing.Size(316, 46);
			this._btnBackToModeSelect.TabIndex = 12;
			this._btnBackToModeSelect.Text = "<< Back to Mode Select";
			this._btnBackToModeSelect.UseVisualStyleBackColor = false;
			this._btnBackToModeSelect.Click += new System.EventHandler(this._btnBackToModeSelect_Click);
			// 
			// _pnlFileToBase64
			// 
			this._pnlFileToBase64.Controls.Add(this._lblHeaderConvertFileToBase64);
			this._pnlFileToBase64.Controls.Add(this._lblFileToConvertToBase64);
			this._pnlFileToBase64.Controls.Add(this._lblDecompressedBase64);
			this._pnlFileToBase64.Controls.Add(this._lblDeflatedBase64);
			this._pnlFileToBase64.Controls.Add(this._btnCopyCompressedToClipboard);
			this._pnlFileToBase64.Controls.Add(this._btnCopyDecompressedToClipboard);
			this._pnlFileToBase64.Controls.Add(this._btnExecuteConvertFileToBase64);
			this._pnlFileToBase64.Controls.Add(this._txtCompressedBase64);
			this._pnlFileToBase64.Controls.Add(this._txtDecompressedBase64);
			this._pnlFileToBase64.Controls.Add(this._txtFileToConvertToBase64);
			this._pnlFileToBase64.Controls.Add(this._btnSelectFileToConvertToBase64);
			this._pnlFileToBase64.Location = new System.Drawing.Point(0, 0);
			this._pnlFileToBase64.Name = "_pnlFileToBase64";
			this._pnlFileToBase64.Size = new System.Drawing.Size(1433, 960);
			this._pnlFileToBase64.TabIndex = 2;
			this._pnlFileToBase64.Visible = false;
			// 
			// _lblHeaderConvertFileToBase64
			// 
			this._lblHeaderConvertFileToBase64.AutoSize = true;
			this._lblHeaderConvertFileToBase64.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this._lblHeaderConvertFileToBase64.Location = new System.Drawing.Point(30, 9);
			this._lblHeaderConvertFileToBase64.Name = "_lblHeaderConvertFileToBase64";
			this._lblHeaderConvertFileToBase64.Size = new System.Drawing.Size(440, 50);
			this._lblHeaderConvertFileToBase64.TabIndex = 13;
			this._lblHeaderConvertFileToBase64.Text = "Convert a File to Base64";
			// 
			// _lblFileToConvertToBase64
			// 
			this._lblFileToConvertToBase64.AutoSize = true;
			this._lblFileToConvertToBase64.Location = new System.Drawing.Point(27, 79);
			this._lblFileToConvertToBase64.Name = "_lblFileToConvertToBase64";
			this._lblFileToConvertToBase64.Size = new System.Drawing.Size(176, 32);
			this._lblFileToConvertToBase64.TabIndex = 12;
			this._lblFileToConvertToBase64.Text = "File to Convert:";
			// 
			// _lblDecompressedBase64
			// 
			this._lblDecompressedBase64.AutoSize = true;
			this._lblDecompressedBase64.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this._lblDecompressedBase64.Location = new System.Drawing.Point(27, 134);
			this._lblDecompressedBase64.Name = "_lblDecompressedBase64";
			this._lblDecompressedBase64.Size = new System.Drawing.Size(340, 45);
			this._lblDecompressedBase64.TabIndex = 11;
			this._lblDecompressedBase64.Text = "Decompressed Base64";
			// 
			// _lblDeflatedBase64
			// 
			this._lblDeflatedBase64.AutoSize = true;
			this._lblDeflatedBase64.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this._lblDeflatedBase64.Location = new System.Drawing.Point(27, 544);
			this._lblDeflatedBase64.Name = "_lblDeflatedBase64";
			this._lblDeflatedBase64.Size = new System.Drawing.Size(455, 45);
			this._lblDeflatedBase64.TabIndex = 10;
			this._lblDeflatedBase64.Text = "Deflated (Compressed) Base64";
			// 
			// _btnCopyCompressedToClipboard
			// 
			this._btnCopyCompressedToClipboard.Enabled = false;
			this._btnCopyCompressedToClipboard.Location = new System.Drawing.Point(962, 883);
			this._btnCopyCompressedToClipboard.Name = "_btnCopyCompressedToClipboard";
			this._btnCopyCompressedToClipboard.Size = new System.Drawing.Size(445, 46);
			this._btnCopyCompressedToClipboard.TabIndex = 9;
			this._btnCopyCompressedToClipboard.Text = "Copy Deflated to Clipboard";
			this._btnCopyCompressedToClipboard.UseVisualStyleBackColor = true;
			this._btnCopyCompressedToClipboard.Click += new System.EventHandler(this._btnCopyCompressedToClipboard_Click);
			// 
			// _btnCopyDecompressedToClipboard
			// 
			this._btnCopyDecompressedToClipboard.Enabled = false;
			this._btnCopyDecompressedToClipboard.Location = new System.Drawing.Point(961, 471);
			this._btnCopyDecompressedToClipboard.Name = "_btnCopyDecompressedToClipboard";
			this._btnCopyDecompressedToClipboard.Size = new System.Drawing.Size(445, 46);
			this._btnCopyDecompressedToClipboard.TabIndex = 8;
			this._btnCopyDecompressedToClipboard.Text = "Copy Decompressed to Clipboard";
			this._btnCopyDecompressedToClipboard.UseVisualStyleBackColor = true;
			this._btnCopyDecompressedToClipboard.Click += new System.EventHandler(this._btnCopyDecompressedToClipboard_Click);
			// 
			// _btnExecuteConvertFileToBase64
			// 
			this._btnExecuteConvertFileToBase64.BackColor = System.Drawing.SystemColors.ControlDark;
			this._btnExecuteConvertFileToBase64.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this._btnExecuteConvertFileToBase64.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnExecuteConvertFileToBase64.Location = new System.Drawing.Point(1209, 72);
			this._btnExecuteConvertFileToBase64.Name = "_btnExecuteConvertFileToBase64";
			this._btnExecuteConvertFileToBase64.Size = new System.Drawing.Size(150, 46);
			this._btnExecuteConvertFileToBase64.TabIndex = 7;
			this._btnExecuteConvertFileToBase64.Text = "Convert";
			this._btnExecuteConvertFileToBase64.UseVisualStyleBackColor = false;
			this._btnExecuteConvertFileToBase64.Click += new System.EventHandler(this._btnExecuteConvertFileToBase64_Click);
			// 
			// _txtCompressedBase64
			// 
			this._txtCompressedBase64.Location = new System.Drawing.Point(37, 592);
			this._txtCompressedBase64.Name = "_txtCompressedBase64";
			this._txtCompressedBase64.ReadOnly = true;
			this._txtCompressedBase64.Size = new System.Drawing.Size(1370, 275);
			this._txtCompressedBase64.TabIndex = 6;
			this._txtCompressedBase64.Text = "";
			// 
			// _txtDecompressedBase64
			// 
			this._txtDecompressedBase64.Location = new System.Drawing.Point(36, 184);
			this._txtDecompressedBase64.Name = "_txtDecompressedBase64";
			this._txtDecompressedBase64.ReadOnly = true;
			this._txtDecompressedBase64.Size = new System.Drawing.Size(1370, 275);
			this._txtDecompressedBase64.TabIndex = 5;
			this._txtDecompressedBase64.Text = "";
			// 
			// _txtFileToConvertToBase64
			// 
			this._txtFileToConvertToBase64.Location = new System.Drawing.Point(199, 76);
			this._txtFileToConvertToBase64.Name = "_txtFileToConvertToBase64";
			this._txtFileToConvertToBase64.Size = new System.Drawing.Size(839, 39);
			this._txtFileToConvertToBase64.TabIndex = 4;
			// 
			// _btnSelectFileToConvertToBase64
			// 
			this._btnSelectFileToConvertToBase64.Location = new System.Drawing.Point(1044, 72);
			this._btnSelectFileToConvertToBase64.Name = "_btnSelectFileToConvertToBase64";
			this._btnSelectFileToConvertToBase64.Size = new System.Drawing.Size(150, 46);
			this._btnSelectFileToConvertToBase64.TabIndex = 3;
			this._btnSelectFileToConvertToBase64.Text = "Browse";
			this._btnSelectFileToConvertToBase64.UseVisualStyleBackColor = true;
			this._btnSelectFileToConvertToBase64.Click += new System.EventHandler(this._btnSelectFileToConvertToBase64_Click);
			// 
			// _lblHeaderConvertBase64ToFile
			// 
			this._lblHeaderConvertBase64ToFile.AutoSize = true;
			this._lblHeaderConvertBase64ToFile.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this._lblHeaderConvertBase64ToFile.Location = new System.Drawing.Point(30, 9);
			this._lblHeaderConvertBase64ToFile.Name = "_lblHeaderConvertBase64ToFile";
			this._lblHeaderConvertBase64ToFile.Size = new System.Drawing.Size(440, 50);
			this._lblHeaderConvertBase64ToFile.TabIndex = 13;
			this._lblHeaderConvertBase64ToFile.Text = "Convert Base64 to a File";
			// 
			// _lblFileToSaveFromBase64
			// 
			this._lblFileToSaveFromBase64.AutoSize = true;
			this._lblFileToSaveFromBase64.Location = new System.Drawing.Point(38, 714);
			this._lblFileToSaveFromBase64.Name = "_lblFileToSaveFromBase64";
			this._lblFileToSaveFromBase64.Size = new System.Drawing.Size(185, 32);
			this._lblFileToSaveFromBase64.TabIndex = 12;
			this._lblFileToSaveFromBase64.Text = "File Destination:";
			// 
			// _txtFileToSaveFromBase64
			// 
			this._txtFileToSaveFromBase64.Location = new System.Drawing.Point(221, 711);
			this._txtFileToSaveFromBase64.Name = "_txtFileToSaveFromBase64";
			this._txtFileToSaveFromBase64.Size = new System.Drawing.Size(839, 39);
			this._txtFileToSaveFromBase64.TabIndex = 4;
			this._txtFileToSaveFromBase64.TextChanged += new System.EventHandler(this._txtFileToSaveFromBase64_TextChanged);
			// 
			// _pnlBase64ToFile
			// 
			this._pnlBase64ToFile.Controls.Add(this._lblSaveFileResult);
			this._pnlBase64ToFile.Controls.Add(this._btnSaveBase64ToFile);
			this._pnlBase64ToFile.Controls.Add(this._btnSelectFileToSaveBase64);
			this._pnlBase64ToFile.Controls.Add(this._lblBase64ToFileDestinationHelpText);
			this._pnlBase64ToFile.Controls.Add(this._lblBase64ToConvertDecompressionHelpText);
			this._pnlBase64ToFile.Controls.Add(this._lblBase64ToConvertToFile);
			this._pnlBase64ToFile.Controls.Add(this._txtBase64ToConvertToFile);
			this._pnlBase64ToFile.Controls.Add(this._lblHeaderConvertBase64ToFile);
			this._pnlBase64ToFile.Controls.Add(this._lblFileToSaveFromBase64);
			this._pnlBase64ToFile.Controls.Add(this._txtFileToSaveFromBase64);
			this._pnlBase64ToFile.Location = new System.Drawing.Point(0, 0);
			this._pnlBase64ToFile.Name = "_pnlBase64ToFile";
			this._pnlBase64ToFile.Size = new System.Drawing.Size(1433, 960);
			this._pnlBase64ToFile.TabIndex = 2;
			this._pnlBase64ToFile.Visible = false;
			// 
			// _lblSaveFileResult
			// 
			this._lblSaveFileResult.AutoSize = true;
			this._lblSaveFileResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
			this._lblSaveFileResult.Location = new System.Drawing.Point(210, 840);
			this._lblSaveFileResult.Name = "_lblSaveFileResult";
			this._lblSaveFileResult.Size = new System.Drawing.Size(206, 32);
			this._lblSaveFileResult.TabIndex = 13;
			this._lblSaveFileResult.Text = "<Save file result>";
			this._lblSaveFileResult.Visible = false;
			// 
			// _btnSaveBase64ToFile
			// 
			this._btnSaveBase64ToFile.BackColor = System.Drawing.SystemColors.ControlDark;
			this._btnSaveBase64ToFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this._btnSaveBase64ToFile.Location = new System.Drawing.Point(37, 833);
			this._btnSaveBase64ToFile.Name = "_btnSaveBase64ToFile";
			this._btnSaveBase64ToFile.Size = new System.Drawing.Size(167, 46);
			this._btnSaveBase64ToFile.TabIndex = 18;
			this._btnSaveBase64ToFile.Text = "Save to File";
			this._btnSaveBase64ToFile.UseVisualStyleBackColor = false;
			this._btnSaveBase64ToFile.Click += new System.EventHandler(this._btnSaveBase64ToFile_Click);
			// 
			// _btnSelectFileToSaveBase64
			// 
			this._btnSelectFileToSaveBase64.Location = new System.Drawing.Point(1066, 707);
			this._btnSelectFileToSaveBase64.Name = "_btnSelectFileToSaveBase64";
			this._btnSelectFileToSaveBase64.Size = new System.Drawing.Size(150, 46);
			this._btnSelectFileToSaveBase64.TabIndex = 13;
			this._btnSelectFileToSaveBase64.Text = "Browse";
			this._btnSelectFileToSaveBase64.UseVisualStyleBackColor = true;
			this._btnSelectFileToSaveBase64.Click += new System.EventHandler(this._btnSelectFileToSaveBase64_Click);
			// 
			// _lblBase64ToFileDestinationHelpText
			// 
			this._lblBase64ToFileDestinationHelpText.AutoSize = true;
			this._lblBase64ToFileDestinationHelpText.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this._lblBase64ToFileDestinationHelpText.ForeColor = System.Drawing.SystemColors.GrayText;
			this._lblBase64ToFileDestinationHelpText.Location = new System.Drawing.Point(221, 753);
			this._lblBase64ToFileDestinationHelpText.Name = "_lblBase64ToFileDestinationHelpText";
			this._lblBase64ToFileDestinationHelpText.Size = new System.Drawing.Size(623, 30);
			this._lblBase64ToFileDestinationHelpText.TabIndex = 17;
			this._lblBase64ToFileDestinationHelpText.Text = "Specify the complete file path including the file name and extension.";
			// 
			// _lblBase64ToConvertDecompressionHelpText
			// 
			this._lblBase64ToConvertDecompressionHelpText.AutoSize = true;
			this._lblBase64ToConvertDecompressionHelpText.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this._lblBase64ToConvertDecompressionHelpText.ForeColor = System.Drawing.SystemColors.GrayText;
			this._lblBase64ToConvertDecompressionHelpText.Location = new System.Drawing.Point(38, 104);
			this._lblBase64ToConvertDecompressionHelpText.Name = "_lblBase64ToConvertDecompressionHelpText";
			this._lblBase64ToConvertDecompressionHelpText.Size = new System.Drawing.Size(1042, 30);
			this._lblBase64ToConvertDecompressionHelpText.TabIndex = 16;
			this._lblBase64ToConvertDecompressionHelpText.Text = "Decompresseion will be attempted before file conversion, so either decompressed o" +
	"r deflated (compressed) will work.";
			// 
			// _lblBase64ToConvertToFile
			// 
			this._lblBase64ToConvertToFile.AutoSize = true;
			this._lblBase64ToConvertToFile.Location = new System.Drawing.Point(38, 72);
			this._lblBase64ToConvertToFile.Name = "_lblBase64ToConvertToFile";
			this._lblBase64ToConvertToFile.Size = new System.Drawing.Size(221, 32);
			this._lblBase64ToConvertToFile.TabIndex = 15;
			this._lblBase64ToConvertToFile.Text = "Base 64 to Convert:";
			// 
			// _txtBase64ToConvertToFile
			// 
			this._txtBase64ToConvertToFile.Location = new System.Drawing.Point(46, 136);
			this._txtBase64ToConvertToFile.Name = "_txtBase64ToConvertToFile";
			this._txtBase64ToConvertToFile.Size = new System.Drawing.Size(1347, 523);
			this._txtBase64ToConvertToFile.TabIndex = 14;
			this._txtBase64ToConvertToFile.Text = "";
			// 
			// _dlgSelectFileToConvertToBase64
			// 
			this._dlgSelectFileToConvertToBase64.FileOk += new System.ComponentModel.CancelEventHandler(this._dlgSelectFileToConvertToBase64_FileOk);
			// 
			// _dlgSaveBase64ToFile
			// 
			this._dlgSaveBase64ToFile.OverwritePrompt = false;
			this._dlgSaveBase64ToFile.FileOk += new System.ComponentModel.CancelEventHandler(this._dlgSaveBase64ToFile_FileOk);
			// 
			// Base64FileConverterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1434, 1049);
			this.Controls.Add(this._pnlBackToModeSelect);
			this.Controls.Add(this._pnlBase64ToFile);
			this.Controls.Add(this._pnlFileToBase64);
			this.Controls.Add(this._pnlSelectRunMode);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Base64FileConverterForm";
			this.Text = "Base 64 File Converter";
			this._pnlSelectRunMode.ResumeLayout(false);
			this._pnlSelectRunMode.PerformLayout();
			this._pnlBackToModeSelect.ResumeLayout(false);
			this._pnlFileToBase64.ResumeLayout(false);
			this._pnlFileToBase64.PerformLayout();
			this._pnlBase64ToFile.ResumeLayout(false);
			this._pnlBase64ToFile.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _btnSelectModeConvertFileToBase64;
		private System.Windows.Forms.Panel _pnlSelectRunMode;
		private System.Windows.Forms.Button _btnSelectModeConvertBase64ToFile;
		private System.Windows.Forms.Panel _pnlFileToBase64;
		private System.Windows.Forms.Panel _pnlBase64ToFile;
		private System.Windows.Forms.Button _btnSelectFileToConvertToBase64;
		private System.Windows.Forms.OpenFileDialog _dlgSelectFileToConvertToBase64;
		private System.Windows.Forms.RichTextBox _txtCompressedBase64;
		private System.Windows.Forms.RichTextBox _txtDecompressedBase64;
		private System.Windows.Forms.TextBox _txtFileToConvertToBase64;
		private System.Windows.Forms.TextBox _txtFileToSaveFromBase64;
		private System.Windows.Forms.Button _btnExecuteConvertFileToBase64;
		private System.Windows.Forms.Button _btnCopyDecompressedToClipboard;
		private System.Windows.Forms.Label _lblDecompressedBase64;
		private System.Windows.Forms.Label _lblDeflatedBase64;
		private System.Windows.Forms.Button _btnCopyCompressedToClipboard;
		private System.Windows.Forms.Button _btnBackToModeSelect;
		private System.Windows.Forms.Panel _pnlBackToModeSelect;
		private System.Windows.Forms.Label _lblHeaderConvertFileToBase64;
		private System.Windows.Forms.Label _lblHeaderConvertBase64ToFile;
		private System.Windows.Forms.Label _lblFileToConvertToBase64;
		private System.Windows.Forms.Label _lblFileToSaveFromBase64;
		private System.Windows.Forms.Label _lblBase64ToConvertDecompressionHelpText;
		private System.Windows.Forms.Label _lblBase64ToConvertToFile;
		private System.Windows.Forms.RichTextBox _txtBase64ToConvertToFile;
		private System.Windows.Forms.Button _btnSaveBase64ToFile;
		private System.Windows.Forms.Button _btnSelectFileToSaveBase64;
		private System.Windows.Forms.Label _lblBase64ToFileDestinationHelpText;
		private System.Windows.Forms.SaveFileDialog _dlgSaveBase64ToFile;
		private System.Windows.Forms.Label _lblSaveFileResult;
		private System.Windows.Forms.Label _lblHeaderSelectRunMode;
	}
}

