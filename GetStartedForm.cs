using Smart_Notepad;
using Smart_Notepad.Classes;
using System.Windows.Forms;
using static Smart_Notepad.FindFeatureForm;

namespace Smart_Notepad
{
    public partial class GetStartedForm : Form
    {
        public GetStartedForm()
        {
            InitializeComponent();
            FileStatusValueLabel.Text = FileTab.CurrentFileStatus.ToString();
        }
        #region File Tab
        private void SaveFileOption_Click(object sender, EventArgs e)
        {
            FileTab.SaveFile(TextBox);
            FileStatusValueLabel.Text = FileTab.CurrentFileStatus.ToString();
        }
        private void OpenFileOption_Click(object sender, EventArgs e)
        {
            FileTab.OpenFile(TextBox);
            FileStatusValueLabel.Text = FileTab.CurrentFileStatus.ToString();
        }
        private void SaveAsFileOption_Click(object sender, EventArgs e)
        {
            FileTab.SaveAsTextFile(TextBox);
            FileStatusValueLabel.Text = FileTab.CurrentFileStatus.ToString();
        }
        #endregion     

        #region Edit Tab
        #region Clipboard
        private void CopyEditOption_Click(object sender, EventArgs e)
        {
            EditTab.PerformClipboardAction(ClipboardAction.Copy, TextBox);
        }
        private void PasteEditOption_Click(object sender, EventArgs e)
        {
            EditTab.PerformClipboardAction(ClipboardAction.Paste, TextBox);
        }
        private void CutEditOption_Click(object sender, EventArgs e)
        {
            EditTab.PerformClipboardAction(ClipboardAction.Cut, TextBox);
        }
        #endregion

        #region Style
        private void BoldStyleFontEditOption_Click(object sender, EventArgs e)
        {
            EditTab.ApplyStyle(TextBox, TextFontStyle.Bold);
        }
        private void ItalicStyleFontEditOption_Click(object sender, EventArgs e)
        {
            EditTab.ApplyStyle(TextBox, TextFontStyle.Italic);
        }
        private void UnderlineStyleFontEditOption_Click(object sender, EventArgs e)
        {
            EditTab.ApplyStyle(TextBox, TextFontStyle.Underline);
        }
        private void DefaultStyleFontEditOption_Click(object sender, EventArgs e)
        {
            EditTab.ApplyStyle(TextBox, TextFontStyle.Default);
        }
        #endregion

        #region Alignment
        private void LeftAlignmentFontEditOption_Click(object sender, EventArgs e)
        {
            EditTab.ApplyAlignment(TextBox, TextAlignment.Left);
        }
        private void CenterAlignmentFontEditOption_Click(object sender, EventArgs e)
        {
            EditTab.ApplyAlignment(TextBox, TextAlignment.Center);
        }
        private void RightAlignmentFontEditOption_Click(object sender, EventArgs e)
        {
            EditTab.ApplyAlignment(TextBox, TextAlignment.Right);
        }
        #endregion

        private void SizeFontEditOption_Click(object sender, EventArgs e)
        {
            EditTab.FontSize(TextBox);
        }
        private void ColorFontEditOption_Click(object sender, EventArgs e)
        {
            EditTab.FontColor(TextBox);
        }
        #endregion

        #region View Tab

        #region Zoom
        private void ZoomInZoomViewOption_Click(object sender, EventArgs e)
        {
            ViewTab.ZoomIn(TextBox);
        }
        private void ZoomOutZoomViewOption_Click(object sender, EventArgs e)
        {
            ViewTab.ZoomOut(TextBox);
        }
        private void DefaultZoomViewOption_Click(object sender, EventArgs e)
        {
            ViewTab.ResetZoom(TextBox);
        }
        #endregion

        #region Status bar
        private void ShowStatusBarOption_Click(object sender, EventArgs e)
        {
            ViewTab.ToggleStatusBarVisibility(StatusStrip, true);
        }
        private void HideStatusBarOption_Click(object sender, EventArgs e)
        {
            ViewTab.ToggleStatusBarVisibility(StatusStrip, false);
        }
        #endregion

        #endregion

        #region Feature Tab
        private void OcrFeatureOption_Click(object sender, EventArgs e)
        {
            FeatureTab.OCR(TextBox);
        }

        private void UndoFeatureOption_Click(object sender, EventArgs e)
        {
            FeatureTab.Undo(TextBox);
        }
        private void RedoFeatureOption_Click(object sender, EventArgs e)
        {
            FeatureTab.Redo(TextBox);
        }

        private void TimeDateFeatureOption_Click(object sender, EventArgs e)
        {
            FeatureTab.TimeDate(TextBox);
        }
        private void BackgroundColorFeatureOption_Click(object sender, EventArgs e)
        {
            FeatureTab.BackgroundColor(TextBox);
        }
        private void BiDirectionalFeatureOption_Click(object sender, EventArgs e)
        {
            FeatureTab.ConvertSelectedText(TextBox);
        }



        private void FindFeatureOption_Click(object sender, EventArgs e)
        {
            FindFeatureForm findFeatureForm = new FindFeatureForm(SearchOptions.Find);
            findFeatureForm.ShowDialog();

            // Access the data from the FormData class
            FeatureTab.Find(TextBox, FormData.SearchText);
        }
        private void FindAndReplaceFeatureOption_Click(object sender, EventArgs e)
        {
            FindFeatureForm findFeatureForm = new FindFeatureForm(SearchOptions.FindAndReplace);
            findFeatureForm.ShowDialog();

            // Access the data from the FormData class
            FeatureTab.FindAndReplace(TextBox, FormData.SearchText, FormData.ReplaceText);
        }

        #endregion


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            FeatureTab.TextChanged(TextBox.Text);
        }
        private void PrintDocumentOfTextBox_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (e.Graphics != null)
            {
                string textToPrint = TextBox.Text ?? string.Empty;
                e.Graphics.DrawString(textToPrint, TextBox.Font, Brushes.Black, new Point(100, 100));
            }
        }
        private void PrintFeatureOption_Click(object sender, EventArgs e)
        {
            if (PrintPreviewDialogOfTextBox.ShowDialog() == DialogResult.OK)
            {
                PrintDocumentOfTextBox.Print();
            }
        }
    }
}