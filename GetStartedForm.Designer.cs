namespace Smart_Notepad
{
    partial class GetStartedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStartedForm));
            ToolBar = new ToolStrip();
            FileOption = new ToolStripDropDownButton();
            OpenFileOption = new ToolStripMenuItem();
            SaveFileOption = new ToolStripMenuItem();
            SaveAsFileOption = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            EditOption = new ToolStripDropDownButton();
            FontEditOption = new ToolStripMenuItem();
            StyleFontEditOption = new ToolStripMenuItem();
            BoldStyleFontEditOption = new ToolStripMenuItem();
            ItalicStyleFontEditOption = new ToolStripMenuItem();
            UnderlineStyleFontEditOption = new ToolStripMenuItem();
            DefaultStyleFontEditOption = new ToolStripMenuItem();
            AlignmentFontEditOption = new ToolStripMenuItem();
            LeftAlignmentFontEditOption = new ToolStripMenuItem();
            CenterAlignmentFontEditOption = new ToolStripMenuItem();
            RightAlignmentFontEditOption = new ToolStripMenuItem();
            SizeFontEditOption = new ToolStripMenuItem();
            ColorFontEditOption = new ToolStripMenuItem();
            CopyEditOption = new ToolStripMenuItem();
            PasteEditOption = new ToolStripMenuItem();
            CutEditOption = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ViewOption = new ToolStripDropDownButton();
            ZoomViewOption = new ToolStripMenuItem();
            ZoomInZoomViewOption = new ToolStripMenuItem();
            ZoomOutZoomViewOption = new ToolStripMenuItem();
            DefaultZoomViewOption = new ToolStripMenuItem();
            StatusBarOption = new ToolStripMenuItem();
            ShowStatusBarOption = new ToolStripMenuItem();
            HideStatusBarOption = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            FeatureOption = new ToolStripDropDownButton();
            OcrFeatureOption = new ToolStripMenuItem();
            UndoFeatureOption = new ToolStripMenuItem();
            RedoFeatureOption = new ToolStripMenuItem();
            FindFeatureOption = new ToolStripMenuItem();
            FindAndReplaceFeatureOption = new ToolStripMenuItem();
            TimeDateFeatureOption = new ToolStripMenuItem();
            BackgroundColorFeatureOption = new ToolStripMenuItem();
            BiDirectionalFeatureOption = new ToolStripMenuItem();
            PrintFeatureOption = new ToolStripMenuItem();
            StatusStrip = new StatusStrip();
            TextBox = new RichTextBox();
            PrintPreviewDialogOfTextBox = new PrintPreviewDialog();
            PrintDocumentOfTextBox = new System.Drawing.Printing.PrintDocument();
            FileNameLabel = new ToolStripStatusLabel();
            FileNameStatusLabel = new ToolStripStatusLabel();
            FileStatusLabel = new ToolStripStatusLabel();
            FileStatusValueLabel = new ToolStripStatusLabel();
            ToolBar.SuspendLayout();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ToolBar
            // 
            ToolBar.ImageScalingSize = new Size(20, 20);
            ToolBar.Items.AddRange(new ToolStripItem[] { FileOption, toolStripSeparator1, EditOption, toolStripSeparator2, ViewOption, toolStripSeparator3, FeatureOption });
            ToolBar.Location = new Point(0, 0);
            ToolBar.Name = "ToolBar";
            ToolBar.Size = new Size(800, 27);
            ToolBar.TabIndex = 0;
            ToolBar.Text = "ToolBar";
            // 
            // FileOption
            // 
            FileOption.DisplayStyle = ToolStripItemDisplayStyle.Text;
            FileOption.DropDownItems.AddRange(new ToolStripItem[] { OpenFileOption, SaveFileOption, SaveAsFileOption });
            FileOption.Image = (Image)resources.GetObject("FileOption.Image");
            FileOption.ImageTransparentColor = Color.Magenta;
            FileOption.Name = "FileOption";
            FileOption.Size = new Size(46, 24);
            FileOption.Text = "File";
            // 
            // OpenFileOption
            // 
            OpenFileOption.Name = "OpenFileOption";
            OpenFileOption.Size = new Size(143, 26);
            OpenFileOption.Text = "Open";
            OpenFileOption.Click += OpenFileOption_Click;
            // 
            // SaveFileOption
            // 
            SaveFileOption.Name = "SaveFileOption";
            SaveFileOption.Size = new Size(143, 26);
            SaveFileOption.Text = "Save";
            SaveFileOption.Click += SaveFileOption_Click;
            // 
            // SaveAsFileOption
            // 
            SaveAsFileOption.Name = "SaveAsFileOption";
            SaveAsFileOption.Size = new Size(143, 26);
            SaveAsFileOption.Text = "Save As";
            SaveAsFileOption.Click += SaveAsFileOption_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // EditOption
            // 
            EditOption.DisplayStyle = ToolStripItemDisplayStyle.Text;
            EditOption.DropDownItems.AddRange(new ToolStripItem[] { FontEditOption, CopyEditOption, PasteEditOption, CutEditOption });
            EditOption.Image = (Image)resources.GetObject("EditOption.Image");
            EditOption.ImageTransparentColor = Color.Magenta;
            EditOption.Name = "EditOption";
            EditOption.Size = new Size(49, 24);
            EditOption.Text = "Edit";
            // 
            // FontEditOption
            // 
            FontEditOption.DropDownItems.AddRange(new ToolStripItem[] { StyleFontEditOption, AlignmentFontEditOption, SizeFontEditOption, ColorFontEditOption });
            FontEditOption.Name = "FontEditOption";
            FontEditOption.Size = new Size(126, 26);
            FontEditOption.Text = "Font";
            // 
            // StyleFontEditOption
            // 
            StyleFontEditOption.DropDownItems.AddRange(new ToolStripItem[] { BoldStyleFontEditOption, ItalicStyleFontEditOption, UnderlineStyleFontEditOption, DefaultStyleFontEditOption });
            StyleFontEditOption.Name = "StyleFontEditOption";
            StyleFontEditOption.Size = new Size(161, 26);
            StyleFontEditOption.Text = "Style";
            // 
            // BoldStyleFontEditOption
            // 
            BoldStyleFontEditOption.Name = "BoldStyleFontEditOption";
            BoldStyleFontEditOption.Size = new Size(156, 26);
            BoldStyleFontEditOption.Text = "Bold";
            BoldStyleFontEditOption.Click += BoldStyleFontEditOption_Click;
            // 
            // ItalicStyleFontEditOption
            // 
            ItalicStyleFontEditOption.Name = "ItalicStyleFontEditOption";
            ItalicStyleFontEditOption.Size = new Size(156, 26);
            ItalicStyleFontEditOption.Text = "Italic";
            ItalicStyleFontEditOption.Click += ItalicStyleFontEditOption_Click;
            // 
            // UnderlineStyleFontEditOption
            // 
            UnderlineStyleFontEditOption.Name = "UnderlineStyleFontEditOption";
            UnderlineStyleFontEditOption.Size = new Size(156, 26);
            UnderlineStyleFontEditOption.Text = "Underline";
            UnderlineStyleFontEditOption.Click += UnderlineStyleFontEditOption_Click;
            // 
            // DefaultStyleFontEditOption
            // 
            DefaultStyleFontEditOption.Name = "DefaultStyleFontEditOption";
            DefaultStyleFontEditOption.Size = new Size(156, 26);
            DefaultStyleFontEditOption.Text = "Default";
            DefaultStyleFontEditOption.Click += DefaultStyleFontEditOption_Click;
            // 
            // AlignmentFontEditOption
            // 
            AlignmentFontEditOption.DropDownItems.AddRange(new ToolStripItem[] { LeftAlignmentFontEditOption, CenterAlignmentFontEditOption, RightAlignmentFontEditOption });
            AlignmentFontEditOption.Name = "AlignmentFontEditOption";
            AlignmentFontEditOption.Size = new Size(161, 26);
            AlignmentFontEditOption.Text = "Alignment";
            // 
            // LeftAlignmentFontEditOption
            // 
            LeftAlignmentFontEditOption.Name = "LeftAlignmentFontEditOption";
            LeftAlignmentFontEditOption.Size = new Size(178, 26);
            LeftAlignmentFontEditOption.Text = "Left (default)";
            LeftAlignmentFontEditOption.Click += LeftAlignmentFontEditOption_Click;
            // 
            // CenterAlignmentFontEditOption
            // 
            CenterAlignmentFontEditOption.Name = "CenterAlignmentFontEditOption";
            CenterAlignmentFontEditOption.Size = new Size(178, 26);
            CenterAlignmentFontEditOption.Text = "Center";
            CenterAlignmentFontEditOption.Click += CenterAlignmentFontEditOption_Click;
            // 
            // RightAlignmentFontEditOption
            // 
            RightAlignmentFontEditOption.Name = "RightAlignmentFontEditOption";
            RightAlignmentFontEditOption.Size = new Size(178, 26);
            RightAlignmentFontEditOption.Text = "Right";
            RightAlignmentFontEditOption.Click += RightAlignmentFontEditOption_Click;
            // 
            // SizeFontEditOption
            // 
            SizeFontEditOption.Name = "SizeFontEditOption";
            SizeFontEditOption.Size = new Size(161, 26);
            SizeFontEditOption.Text = "Size";
            SizeFontEditOption.Click += SizeFontEditOption_Click;
            // 
            // ColorFontEditOption
            // 
            ColorFontEditOption.Name = "ColorFontEditOption";
            ColorFontEditOption.Size = new Size(161, 26);
            ColorFontEditOption.Text = "Color";
            ColorFontEditOption.Click += ColorFontEditOption_Click;
            // 
            // CopyEditOption
            // 
            CopyEditOption.Name = "CopyEditOption";
            CopyEditOption.Size = new Size(126, 26);
            CopyEditOption.Text = "Copy";
            CopyEditOption.Click += CopyEditOption_Click;
            // 
            // PasteEditOption
            // 
            PasteEditOption.Name = "PasteEditOption";
            PasteEditOption.Size = new Size(126, 26);
            PasteEditOption.Text = "Paste";
            PasteEditOption.Click += PasteEditOption_Click;
            // 
            // CutEditOption
            // 
            CutEditOption.Name = "CutEditOption";
            CutEditOption.Size = new Size(126, 26);
            CutEditOption.Text = "Cut";
            CutEditOption.Click += CutEditOption_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // ViewOption
            // 
            ViewOption.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ViewOption.DropDownItems.AddRange(new ToolStripItem[] { ZoomViewOption, StatusBarOption });
            ViewOption.Image = (Image)resources.GetObject("ViewOption.Image");
            ViewOption.ImageTransparentColor = Color.Magenta;
            ViewOption.Name = "ViewOption";
            ViewOption.Size = new Size(55, 24);
            ViewOption.Text = "View";
            // 
            // ZoomViewOption
            // 
            ZoomViewOption.DropDownItems.AddRange(new ToolStripItem[] { ZoomInZoomViewOption, ZoomOutZoomViewOption, DefaultZoomViewOption });
            ZoomViewOption.Name = "ZoomViewOption";
            ZoomViewOption.Size = new Size(158, 26);
            ZoomViewOption.Text = "Zoom";
            // 
            // ZoomInZoomViewOption
            // 
            ZoomInZoomViewOption.Name = "ZoomInZoomViewOption";
            ZoomInZoomViewOption.Size = new Size(158, 26);
            ZoomInZoomViewOption.Text = "Zoom in";
            ZoomInZoomViewOption.Click += ZoomInZoomViewOption_Click;
            // 
            // ZoomOutZoomViewOption
            // 
            ZoomOutZoomViewOption.Name = "ZoomOutZoomViewOption";
            ZoomOutZoomViewOption.Size = new Size(158, 26);
            ZoomOutZoomViewOption.Text = "Zoom out";
            ZoomOutZoomViewOption.Click += ZoomOutZoomViewOption_Click;
            // 
            // DefaultZoomViewOption
            // 
            DefaultZoomViewOption.Name = "DefaultZoomViewOption";
            DefaultZoomViewOption.Size = new Size(158, 26);
            DefaultZoomViewOption.Text = "Default";
            DefaultZoomViewOption.Click += DefaultZoomViewOption_Click;
            // 
            // StatusBarOption
            // 
            StatusBarOption.DropDownItems.AddRange(new ToolStripItem[] { ShowStatusBarOption, HideStatusBarOption });
            StatusBarOption.Name = "StatusBarOption";
            StatusBarOption.Size = new Size(158, 26);
            StatusBarOption.Text = "Status bar";
            // 
            // ShowStatusBarOption
            // 
            ShowStatusBarOption.Name = "ShowStatusBarOption";
            ShowStatusBarOption.Size = new Size(128, 26);
            ShowStatusBarOption.Text = "Show";
            ShowStatusBarOption.Click += ShowStatusBarOption_Click;
            // 
            // HideStatusBarOption
            // 
            HideStatusBarOption.Name = "HideStatusBarOption";
            HideStatusBarOption.Size = new Size(128, 26);
            HideStatusBarOption.Text = "Hide";
            HideStatusBarOption.Click += HideStatusBarOption_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // FeatureOption
            // 
            FeatureOption.DisplayStyle = ToolStripItemDisplayStyle.Text;
            FeatureOption.DropDownItems.AddRange(new ToolStripItem[] { OcrFeatureOption, UndoFeatureOption, RedoFeatureOption, FindFeatureOption, FindAndReplaceFeatureOption, TimeDateFeatureOption, BackgroundColorFeatureOption, BiDirectionalFeatureOption, PrintFeatureOption });
            FeatureOption.Image = (Image)resources.GetObject("FeatureOption.Image");
            FeatureOption.ImageTransparentColor = Color.Magenta;
            FeatureOption.Name = "FeatureOption";
            FeatureOption.Size = new Size(78, 24);
            FeatureOption.Text = "Features";
            // 
            // OcrFeatureOption
            // 
            OcrFeatureOption.Name = "OcrFeatureOption";
            OcrFeatureOption.Size = new Size(209, 26);
            OcrFeatureOption.Text = "OCR";
            OcrFeatureOption.Click += OcrFeatureOption_Click;
            // 
            // UndoFeatureOption
            // 
            UndoFeatureOption.Name = "UndoFeatureOption";
            UndoFeatureOption.Size = new Size(209, 26);
            UndoFeatureOption.Text = "Undo";
            UndoFeatureOption.Click += UndoFeatureOption_Click;
            // 
            // RedoFeatureOption
            // 
            RedoFeatureOption.Name = "RedoFeatureOption";
            RedoFeatureOption.Size = new Size(209, 26);
            RedoFeatureOption.Text = "Redo";
            RedoFeatureOption.Click += RedoFeatureOption_Click;
            // 
            // FindFeatureOption
            // 
            FindFeatureOption.Name = "FindFeatureOption";
            FindFeatureOption.Size = new Size(209, 26);
            FindFeatureOption.Text = "Find";
            FindFeatureOption.Click += FindFeatureOption_Click;
            // 
            // FindAndReplaceFeatureOption
            // 
            FindAndReplaceFeatureOption.Name = "FindAndReplaceFeatureOption";
            FindAndReplaceFeatureOption.Size = new Size(209, 26);
            FindAndReplaceFeatureOption.Text = "Find and replace";
            FindAndReplaceFeatureOption.Click += FindAndReplaceFeatureOption_Click;
            // 
            // TimeDateFeatureOption
            // 
            TimeDateFeatureOption.Name = "TimeDateFeatureOption";
            TimeDateFeatureOption.Size = new Size(209, 26);
            TimeDateFeatureOption.Text = "Time/Date";
            TimeDateFeatureOption.Click += TimeDateFeatureOption_Click;
            // 
            // BackgroundColorFeatureOption
            // 
            BackgroundColorFeatureOption.Name = "BackgroundColorFeatureOption";
            BackgroundColorFeatureOption.Size = new Size(209, 26);
            BackgroundColorFeatureOption.Text = "Background color";
            BackgroundColorFeatureOption.Click += BackgroundColorFeatureOption_Click;
            // 
            // BiDirectionalFeatureOption
            // 
            BiDirectionalFeatureOption.Name = "BiDirectionalFeatureOption";
            BiDirectionalFeatureOption.Size = new Size(209, 26);
            BiDirectionalFeatureOption.Text = "Bi-Directional";
            BiDirectionalFeatureOption.Click += BiDirectionalFeatureOption_Click;
            // 
            // PrintFeatureOption
            // 
            PrintFeatureOption.Name = "PrintFeatureOption";
            PrintFeatureOption.Size = new Size(209, 26);
            PrintFeatureOption.Text = "Print";
            PrintFeatureOption.Click += PrintFeatureOption_Click;
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(20, 20);
            StatusStrip.Items.AddRange(new ToolStripItem[] { FileNameLabel, FileNameStatusLabel, FileStatusLabel, FileStatusValueLabel });
            StatusStrip.Location = new Point(0, 424);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(800, 26);
            StatusStrip.TabIndex = 1;
            StatusStrip.Text = "statusStrip1";
            // 
            // TextBox
            // 
            TextBox.Dock = DockStyle.Fill;
            TextBox.Location = new Point(0, 27);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(800, 397);
            TextBox.TabIndex = 2;
            TextBox.Text = "";
            TextBox.KeyDown += TextBox_KeyDown;
            // 
            // PrintPreviewDialogOfTextBox
            // 
            PrintPreviewDialogOfTextBox.AutoScrollMargin = new Size(0, 0);
            PrintPreviewDialogOfTextBox.AutoScrollMinSize = new Size(0, 0);
            PrintPreviewDialogOfTextBox.ClientSize = new Size(400, 300);
            PrintPreviewDialogOfTextBox.Document = PrintDocumentOfTextBox;
            PrintPreviewDialogOfTextBox.Enabled = true;
            PrintPreviewDialogOfTextBox.Icon = (Icon)resources.GetObject("PrintPreviewDialogOfTextBox.Icon");
            PrintPreviewDialogOfTextBox.Name = "PrintPreviewDialogOfTextBox";
            PrintPreviewDialogOfTextBox.Visible = false;
            // 
            // FileNameLabel
            // 
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(83, 20);
            FileNameLabel.Text = "File Name: ";
            // 
            // FileNameStatusLabel
            // 
            FileNameStatusLabel.Name = "FileNameStatusLabel";
            FileNameStatusLabel.Size = new Size(30, 20);
            FileNameStatusLabel.Text = "NA";
            // 
            // FileStatusLabel
            // 
            FileStatusLabel.Margin = new Padding(475, 4, 0, 2);
            FileStatusLabel.Name = "FileStatusLabel";
            FileStatusLabel.Size = new Size(83, 20);
            FileStatusLabel.Text = "File Status: ";
            // 
            // FileStatusValueLabel
            // 
            FileStatusValueLabel.Name = "FileStatusValueLabel";
            FileStatusValueLabel.Size = new Size(30, 20);
            FileStatusValueLabel.Text = "NA";
            // 
            // GetStartedForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBox);
            Controls.Add(StatusStrip);
            Controls.Add(ToolBar);
            Name = "GetStartedForm";
            Text = "Smart Notepad";
            ToolBar.ResumeLayout(false);
            ToolBar.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolBar;
        private ToolStripDropDownButton FileOption;
        private ToolStripMenuItem OpenFileOption;
        private ToolStripMenuItem SaveFileOption;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton EditOption;
        private ToolStripMenuItem FontEditOption;
        private ToolStripMenuItem StyleFontEditOption;
        private ToolStripMenuItem BoldStyleFontEditOption;
        private ToolStripMenuItem ItalicStyleFontEditOption;
        private ToolStripMenuItem UnderlineStyleFontEditOption;
        private ToolStripMenuItem AlignmentFontEditOption;
        private ToolStripMenuItem LeftAlignmentFontEditOption;
        private ToolStripMenuItem CenterAlignmentFontEditOption;
        private ToolStripMenuItem RightAlignmentFontEditOption;
        private ToolStripMenuItem SizeFontEditOption;
        private ToolStripMenuItem ColorFontEditOption;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton ViewOption;
        private ToolStripMenuItem ZoomViewOption;
        private ToolStripMenuItem ZoomInZoomViewOption;
        private ToolStripMenuItem ZoomOutZoomViewOption;
        private ToolStripMenuItem StatusBarOption;
        private ToolStripMenuItem ShowStatusBarOption;
        private ToolStripMenuItem HideStatusBarOption;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton FeatureOption;
        private ToolStripMenuItem OcrFeatureOption;
        private ToolStripMenuItem CopyEditOption;
        private ToolStripMenuItem PasteEditOption;
        private ToolStripMenuItem CutEditOption;
        private ToolStripMenuItem DefaultZoomViewOption;
        private ToolStripMenuItem UndoFeatureOption;
        private ToolStripMenuItem RedoFeatureOption;
        private ToolStripMenuItem FindAndReplaceFeatureOption;
        private ToolStripMenuItem TimeDateFeatureOption;
        private ToolStripMenuItem BackgroundColorFeatureOption;
        private ToolStripMenuItem PrintFeatureOption;
        private StatusStrip StatusStrip;
        private RichTextBox TextBox;
        private ToolStripMenuItem DefaultStyleFontEditOption;
        private ToolStripMenuItem BiDirectionalFeatureOption;
        private ToolStripMenuItem FindFeatureOption;
        private ToolStripMenuItem SaveAsFileOption;
        private PrintPreviewDialog PrintPreviewDialogOfTextBox;
        private System.Drawing.Printing.PrintDocument PrintDocumentOfTextBox;
        private ToolStripStatusLabel FileNameLabel;
        private ToolStripStatusLabel FileNameStatusLabel;
        private ToolStripStatusLabel FileStatusLabel;
        private ToolStripStatusLabel FileStatusValueLabel;
    }
}