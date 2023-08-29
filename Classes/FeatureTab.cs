using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Smart_Notepad.Classes
{
    internal static class FeatureTab 
    {
        #region BackgroundColor
        /// <summary>
        /// Opens a color dialog and sets the background color of the RichTextBox.
        /// </summary>
        public static void BackgroundColor(RichTextBox richTextBox)
        {
            using (var colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.BackColor = colorDialog.Color;
                }
            }
        }
        #endregion

        #region TimeDate
        /// <summary>
        /// Appends the current date and time to the text in the RichTextBox.
        /// </summary>
        public static void TimeDate(RichTextBox richTextBox)
        {
            richTextBox.Text += DateTime.Now.ToString();
        }
        #endregion

        #region ConvertSelectedText
        static readonly Dictionary<char, string> EnglishToArabic = new()
        {
            ['q'] = "ض",
            ['w'] = "ص",
            ['e'] = "ث",
            ['r'] = "ق",
            ['t'] = "ف",
            ['y'] = "غ",
            ['u'] = "ع",
            ['i'] = "ه",
            ['o'] = "خ",
            ['p'] = "ح",
            ['a'] = "ش",
            ['s'] = "س",
            ['d'] = "ي",
            ['f'] = "ب",
            ['g'] = "ل",
            ['h'] = "ا",
            ['j'] = "ت",
            ['k'] = "ن",
            ['l'] = "م",
            [';'] = "ك",
            ['z'] = "ئ",
            ['x'] = "ء",
            ['c'] = "ؤ",
            ['v'] = "ر",
            ['b'] = "لا",
            ['n'] = "ى",
            ['m'] = "ة",
            [','] = "و",
            ['.'] = "ز",
            ['/'] = "ظ",
            ['\''] = "ظ",
            ['`'] = "ذ"
        };
        static readonly Dictionary<string, char> ArabicToEnglish = new()
        {
            ["ض"] = 'q',
            ["ص"] = 'w',
            ["ث"] = 'e',
            ["ق"] = 'r',
            ["ف"] = 't',
            ["غ"] = 'y',
            ["ع"] = 'u',
            ["ه"] = 'i',
            ["خ"] = 'o',
            ["ح"] = 'p',
            ["ش"] = 'a',
            ["س"] = 's',
            ["ي"] = 'd',
            ["ب"] = 'f',
            ["ل"] = 'g',
            ["ا"] = 'h',
            ["ت"] = 'j',
            ["ن"] = 'k',
            ["م"] = 'l',
            ["ك"] = ';',
            ["ئ"] = 'z',
            ["ء"] = 'x',
            ["ؤ"] = 'c',
            ["ر"] = 'v',
            ["لا"] = 'b',
            ["ى"] = 'n',
            ["ة"] = 'm',
            ["و"] = ',',
            ["ز"] = '.',
            ["ظ"] = '/',
            ["ذ"] = '`'
        };

        /// <summary>
        /// Converts the selected text in the RichTextBox using character mapping.
        /// </summary>
        public static void ConvertSelectedText(RichTextBox richTextBox)
        {
            string selectedText = richTextBox.SelectedText;

            if (!string.IsNullOrEmpty(selectedText))
            {
                string convertedText = ConvertText(selectedText);
                richTextBox.SelectedText = convertedText;
            }
            else
            {
                MessageBox.Show("No text selected to convert.", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private static char ConvertLetter(char c)
        {
            string charAsString = c.ToString();

            if (EnglishToArabic.ContainsKey(c))
            {
                return EnglishToArabic[c][0];
            }
            else if (ArabicToEnglish.ContainsKey(charAsString))
            {
                return ArabicToEnglish[charAsString];
            }

            return c; // No conversion found, keep the character unchanged
        }
        private static string ConvertText(string input)
        {
            char[] convertedChars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                convertedChars[i] = ConvertLetter(input[i]);
            }

            return new string(convertedChars);
        }
        #endregion

        #region Find, Find and replace
        /// <summary>
        /// Finds and replaces occurrences of a text in the RichTextBox.
        /// </summary>
        public static void FindAndReplace(this RichTextBox richTextBox, string searchText, string replaceText)
        {
            int index = richTextBox.Text.IndexOf(searchText, 0);
            while (index != -1)
            {
                richTextBox.SelectionStart = index;
                richTextBox.SelectionLength = searchText.Length;
                richTextBox.SelectedText = replaceText;

                index = richTextBox.Text.IndexOf(searchText, index + replaceText.Length);
            }
        }

        /// <summary>
        /// Finds occurrences of a text in the RichTextBox and highlights them.
        /// </summary>
        public static void Find(this RichTextBox richTextBox, string searchText)
        {
            UnmarkAllText(richTextBox);
            if (string.IsNullOrEmpty(searchText))
                return;

            int index = 0;
            while (index < richTextBox.TextLength)
            {
                int start = richTextBox.Find(searchText, index, RichTextBoxFinds.None);
                if (start == -1)
                    break;

                richTextBox.SelectionStart = start;
                richTextBox.SelectionLength = searchText.Length;
                richTextBox.SelectionBackColor = Color.Yellow;

                index = start + 1;
            }
        }

        /// <summary>
        /// Removes highlight from all text in the RichTextBox.
        /// </summary>
        private static void UnmarkAllText(RichTextBox richTextBox)
        {
            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = richTextBox.TextLength;
            richTextBox.SelectionBackColor = richTextBox.BackColor;
        }
        #endregion

        #region OCR
        /// <summary>
        /// Performs optical character recognition on an image and appends the extracted text to the RichTextBox.
        /// </summary>
        public static void OCR(RichTextBox richTextBox)
        {
            string? imageFilePath = GetFilePathFromUser("Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif");
            if (imageFilePath != null)
            {
                using (var engine = new TesseractEngine(@"tessdata\", "eng+ara", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(imageFilePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            string extractedText = page.GetText();
                            richTextBox.Text += extractedText;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Opens a file dialog to get a file path from the user.
        /// </summary>
        private static string? GetFilePathFromUser(string filter)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = filter;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return null;
        }
        #endregion

        #region Undo And Redo
        static Stack<string> undoActions = new();
        static Stack<string> redoActions = new();

        /// <summary>
        /// Undoes the last text change in the RichTextBox.
        /// </summary>
        public static void Undo(RichTextBox richTextBox)
        {
            UndoRedoCommonLogic(richTextBox, undoActions, redoActions);
        }

        /// <summary>
        /// Redoes the last undone text change in the RichTextBox.
        /// </summary>
        public static void Redo(RichTextBox richTextBox)
        {
            UndoRedoCommonLogic(richTextBox, redoActions, undoActions);
        }
        private static void UndoRedoCommonLogic(RichTextBox richTextBox, Stack<string> sourceStack, Stack<string> destinationStack)
        {
            if (sourceStack.Count < 1)
                return;

            if (destinationStack.Count == 0 || !string.IsNullOrEmpty(richTextBox.Text))
                destinationStack.Push(richTextBox.Text);

            richTextBox.Text = sourceStack.Pop();
        }

        /// <summary>
        /// Handles the text changed event and maintains the undo and redo events.
        /// </summary>
        public static void TextChanged(string text)
        {
            undoActions.Push(text);
        }
        #endregion
    }
}



