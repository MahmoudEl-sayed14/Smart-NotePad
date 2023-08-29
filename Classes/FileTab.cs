using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Smart_Notepad.Classes
{
    public enum FileStatus
    {
        NoFile,
        Opened,
        Modified
    }

    internal static class FileTab
    {
        static FileStatus _status = FileStatus.NoFile;
        static string? _filePath = null;
        static string? _originalContent = null;

        public static FileStatus CurrentFileStatus
        {
            get
            {
                return string.IsNullOrEmpty(_filePath)
                    ? FileStatus.NoFile
                    : _status;
            }
        }

        public static void OpenFile(RichTextBox richTextBox)
        {
            if (_status == FileStatus.NoFile || HandleUnsavedChanges(richTextBox))
            {
                OpenNewFile(richTextBox);
            }
        }
        public static void SaveAsTextFile(RichTextBox richTextBox)
        {
            using var saveFileDialog = CreateSaveFileDialog("Text Files|*.txt", "Save File As");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string chosenFilePath = saveFileDialog.FileName;

                try
                {
                    File.WriteAllText(chosenFilePath, richTextBox.Text, Encoding.Default);
                    UpdateFileStatus(chosenFilePath, richTextBox.Text, FileStatus.Modified);
                    richTextBox.Clear();
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("An error occurred while saving the file: " + ex.Message);
                }
            }
        } 
        public static void SaveFile(RichTextBox richTextBox)
        {
            if (_filePath != null)
            {
                File.WriteAllText(_filePath, richTextBox.Text, Encoding.UTF8);
                UpdateFileStatus(_filePath, richTextBox.Text, FileStatus.Modified);
            }
        }

        private static bool HandleUnsavedChanges(RichTextBox richTextBox)
        {
            bool hasUnsavedChanges = !string.Equals(_originalContent, richTextBox.Text);

            if (hasUnsavedChanges)
            {
                var result = ShowConfirmationMessage(
                    "Save changes before opening a new file?",
                    "Unsaved Changes"
                );

                if (result == DialogResult.Yes)
                {
                    SaveFile(richTextBox);
                    return true;
                }
                else if (result == DialogResult.No)
                {
                    return true;
                }
            }
            else
            {
                OpenNewFile(richTextBox);
            }

            return false;
        }
        private static void OpenNewFile(RichTextBox richTextBox)
        {
            string? filePath = BrowseForFile("Text Files|*.txt");
            if (filePath != null)
            {
                _filePath = filePath;
                _originalContent = File.ReadAllText(_filePath);
                richTextBox.Text = _originalContent;
                _status = FileStatus.Opened;
            }
        }
        
        private static SaveFileDialog CreateSaveFileDialog(string filter, string title)
        {
            return new SaveFileDialog
            {
                Filter = filter,
                Title = title
            };
        }
        private static void UpdateFileStatus(string filePath, string content, FileStatus status)
        {
            _filePath = filePath;
            _originalContent = content;
            _status = status;
        }
        private static DialogResult ShowConfirmationMessage(string message, string caption)
        {
            return MessageBox.Show(
                message,
                caption,
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );
        }
        private static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private static string? BrowseForFile(string filter)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Filter = filter,
                Title = "Select a file"
            };

            return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : null;
        }
    }
}
