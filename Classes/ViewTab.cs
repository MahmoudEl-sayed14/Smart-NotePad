using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Notepad.Classes
{
    internal class ViewTab
    {
        const float ZoomIncrement = 0.5f;
        const float DefaultZoomFactor = 1.0f;
        
        public static void ZoomIn(RichTextBox richTextBox)
        {
            richTextBox.ZoomFactor += ZoomIncrement;
        }
        public static void ZoomOut(RichTextBox richTextBox)
        {
            richTextBox.ZoomFactor -= ZoomIncrement;
        }
        public static void ResetZoom(RichTextBox richTextBox)
        {
            richTextBox.ZoomFactor = DefaultZoomFactor;
        } 
        
        public static void ToggleStatusBarVisibility(StatusStrip statusStrip, bool isVisible)
        {
            statusStrip.Visible = isVisible;
        }
    }
}
