using System;
using System.Windows.Forms;
using Smart_Notepad.Classes;

namespace Smart_Notepad
{
    public partial class FindFeatureForm : Form
    {
        public enum SearchOptions
        {
            FindAndReplace,
            Find
        }

        public FindFeatureForm(SearchOptions searchOption)
        {
            InitializeComponent();
            UpdateReplaceControlsVisibility(searchOption);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            SaveSearchAndReplaceText();
            CloseForm();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void UpdateReplaceControlsVisibility(SearchOptions searchOption)
        {
            if (searchOption == SearchOptions.Find)
                HideReplaceControls();
            else
                ShowReplaceControls();
        }

        private void HideReplaceControls()
        {
            ReplaceLabel.Visible = false;
            ReplaceTextBox.Visible = false;
        }

        private void ShowReplaceControls()
        {
            ReplaceLabel.Visible = true;
            ReplaceTextBox.Visible = true;
        }

        private void SaveSearchAndReplaceText()
        {
            FormData.SearchText = FindTextBox.Text;
            FormData.ReplaceText = ReplaceTextBox.Text;
        }

        private void CloseForm()
        {
            Close();
        }
    }
}
