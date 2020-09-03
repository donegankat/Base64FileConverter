using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64FileConverter
{
	public partial class Base64FileConverterForm : Form
	{
		public Base64FileConverterForm()
		{
			InitializeComponent();
		}

		private void _btnBackToModeSelect_Click(object sender, EventArgs e)
		{
			_pnlBackToModeSelect.Hide();
			_pnlFileToBase64.Hide();
			_pnlBase64ToFile.Hide();

			_pnlSelectRunMode.Show();
		}

		private void _btnSelectModeConvertBase64ToFile_Click(object sender, EventArgs e)
		{
			_pnlSelectRunMode.Hide();
			_pnlFileToBase64.Hide();

			_pnlBackToModeSelect.Show();
			_pnlBase64ToFile.Show();
		}

		private void _btnSelectModeConvertFileToBase64_Click(object sender, EventArgs e)
		{
			_pnlSelectRunMode.Hide();
			_pnlBase64ToFile.Hide();

			_pnlBackToModeSelect.Show();
			_pnlFileToBase64.Show();
		}

		private void _btnSelectFileToConvertToBase64_Click(object sender, EventArgs e)
		{
			_dlgSelectFileToConvertToBase64.ShowDialog();
		}

		private void _dlgSelectFileToConvertToBase64_FileOk(object sender, CancelEventArgs e)
		{
			_txtFileToConvertToBase64.Text = _dlgSelectFileToConvertToBase64.FileName;
		}

		private void _btnExecuteConvertFileToBase64_Click(object sender, EventArgs e)
		{
			_txtDecompressedBase64.Text = null;
			_txtCompressedBase64.Text = null;
			_btnCopyDecompressedToClipboard.Enabled = false;
			_btnCopyCompressedToClipboard.Enabled = false;

			if (string.IsNullOrWhiteSpace(_txtFileToConvertToBase64.Text))
				MessageBox.Show("Enter a file path.", "Error", MessageBoxButtons.OK);
			else if (!File.Exists(_txtFileToConvertToBase64.Text))
				MessageBox.Show("The file you provided doesn't exist.", "Error", MessageBoxButtons.OK);
			else
			{
				_txtDecompressedBase64.Text = "Processing...";
				_txtCompressedBase64.Text = "Processing...";

				var bytes = File.ReadAllBytes(_dlgSelectFileToConvertToBase64.FileName);
				var base64String = Convert.ToBase64String(bytes);
				_txtDecompressedBase64.Text = base64String;
				_btnCopyDecompressedToClipboard.Enabled = true;

				var compressedBytes = Utilities.Compress(bytes);
				var compressedBase64String = Convert.ToBase64String(compressedBytes);
				_txtCompressedBase64.Text = compressedBase64String;
				_btnCopyCompressedToClipboard.Enabled = true;
			}
		}

		private void _btnCopyDecompressedToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(_txtDecompressedBase64.Text);
		}

		private void _btnCopyCompressedToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(_txtCompressedBase64.Text);
		}

		private void _btnSelectFileToSaveBase64_Click(object sender, EventArgs e)
		{
			_lblSaveFileResult.Hide();
			_dlgSaveBase64ToFile.ShowDialog();
		}

		private void _dlgSaveBase64ToFile_FileOk(object sender, CancelEventArgs e)
		{
			_lblSaveFileResult.Hide();
			_txtFileToSaveFromBase64.Text = _dlgSaveBase64ToFile.FileName;
		}

		private void _txtFileToSaveFromBase64_TextChanged(object sender, EventArgs e)
		{
			_lblSaveFileResult.Hide();
		}

		private void _btnSaveBase64ToFile_Click(object sender, EventArgs e)
		{
			_lblSaveFileResult.Hide();

			var fullFilePath = _txtFileToSaveFromBase64.Text;

			if (string.IsNullOrWhiteSpace(_txtBase64ToConvertToFile.Text))
				MessageBox.Show("Enter a Base64 string.", "Error", MessageBoxButtons.OK);
			else if (string.IsNullOrWhiteSpace(fullFilePath))
				MessageBox.Show("Enter a file path.", "Error", MessageBoxButtons.OK);
			else if (!Directory.Exists(Path.GetDirectoryName(fullFilePath)))
				MessageBox.Show("The directory you provided doesn't exist.", "Error", MessageBoxButtons.OK);
			else if (string.IsNullOrWhiteSpace(Path.GetFileName(fullFilePath)))
				MessageBox.Show("Enter a file name.", "Error", MessageBoxButtons.OK);
			else if (string.IsNullOrWhiteSpace(Path.GetExtension(fullFilePath)))
				MessageBox.Show("Enter a file extension.", "Error", MessageBoxButtons.OK);
			else
			{
				if (File.Exists(fullFilePath))
				{
					// If the file already exists, prompt first to make sure it's ok to overwrite it. If not, cancel.
					if (DialogResult.No == MessageBox.Show("This file already exists. Overwrite it?", "Warning: File Already Exists", MessageBoxButtons.YesNo))
						return;
				}

				try
				{
					var base64 = _txtBase64ToConvertToFile.Text;
					var bytes = Convert.FromBase64String(base64);

					// Decompress the bytes and save it to a file. If the bytes were already decompressed this doesn't do anything.
					File.WriteAllBytes(fullFilePath, Utilities.Decompress(bytes));

					_lblSaveFileResult.ForeColor = Color.Green;
					_lblSaveFileResult.Text = "Saved";
					_lblSaveFileResult.Show();
				}
				catch (FormatException)
				{
					MessageBox.Show("The provided string was not valid Base64.", "Error", MessageBoxButtons.OK);
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An error occurred while saving: {ex.Message}", "Error", MessageBoxButtons.OK);
					_lblSaveFileResult.ForeColor = Color.Red;
					_lblSaveFileResult.Text = "Error";
					_lblSaveFileResult.Show();
				}
			}
		}		
	}
}
