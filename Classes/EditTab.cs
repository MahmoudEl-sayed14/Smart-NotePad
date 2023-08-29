using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Notepad.Classes
{
    public enum TextAlignment
    {
        Left,
        Right,
        Center
    }
    public enum TextFontStyle
    {
        Bold,
        Italic,
        Underline,
        Default
    }
    public enum ClipboardAction
    {
        Copy,
        Cut,
        Paste
    }
    internal class EditTab
    {
        #region Clipboard
        public static void PerformClipboardAction(ClipboardAction action, RichTextBox richTextBox)
        {
            switch (action)
            {
                case ClipboardAction.Copy:
                    CopyToClipboard(richTextBox);
                    break;
                case ClipboardAction.Cut:
                    CutToClipboard(richTextBox);
                    break;
                case ClipboardAction.Paste:
                    PasteFromClipboard(richTextBox);
                    break;
                default:
                    throw new ArgumentException($"Invalid clipboard action: {action}", nameof(action));
            }
        }

        private static void CopyToClipboard(RichTextBox richTextBox)
        {
            Clipboard.SetText(richTextBox.Text);
        }
        private static void CutToClipboard(RichTextBox richTextBox)
        {
            Clipboard.SetText(richTextBox.Text);
            richTextBox.Clear();
        }
        private static void PasteFromClipboard(RichTextBox richTextBox)
        {
            string clipboardText = Clipboard.GetText();
            if (!string.IsNullOrEmpty(clipboardText))
            {
                richTextBox.Text += clipboardText;
            }
        }
        #endregion

        #region Font
        public static void ApplyStyle(RichTextBox richTextBox, TextFontStyle style)
        {
            FontStyle fontStyle;

            switch (style)
            {
                case TextFontStyle.Bold:
                    fontStyle = FontStyle.Bold;
                    break;
                case TextFontStyle.Italic:
                    fontStyle = FontStyle.Italic;
                    break;
                case TextFontStyle.Underline:
                    fontStyle = FontStyle.Underline;
                    break;
                case TextFontStyle.Default:
                    fontStyle = FontStyle.Regular;
                    break;
                default:
                    // Invalid style, do nothing or handle the error as needed.
                    return;
            }

            richTextBox.Font = new Font(richTextBox.Font, fontStyle);
        }
        public static void ApplyAlignment(RichTextBox richTextBox, TextAlignment alignment)
        {
            switch (alignment)
            {
                case TextAlignment.Left:
                    richTextBox.SelectionAlignment = HorizontalAlignment.Left;
                    break;
                case TextAlignment.Right:
                    richTextBox.SelectionAlignment = HorizontalAlignment.Right;
                    break;
                case TextAlignment.Center:
                    richTextBox.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                default:
                    // Invalid alignment, do nothing or handle the error as needed.
                    return;
            }
        }

        public static void FontColor(RichTextBox richTextBox)
        {
            ColorDialog colorDialog = new();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.ForeColor = colorDialog.Color;
            }
        }
        public static void FontSize(RichTextBox richTextBox)
        {
            FontDialog fontDialog = new();
            fontDialog.Font = richTextBox.SelectionFont;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog.Font;
                ApplyFontAndSize(selectedFont, richTextBox);
            }
        }

        private static void ApplyFontAndSize(Font font, RichTextBox richTextBox)
        {
            richTextBox.SelectionFont = font;
        } 
        #endregion
    }
}
