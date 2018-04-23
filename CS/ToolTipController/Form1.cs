using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToolTipController {
    public partial class Form1 : Form {
        List<Control> toolTipControls;
        Button activeButton;

        public Form1() {
            InitializeComponent();
            this.toolTipControls = new List<Control>();
            ToolTipControls.Add(button1);
            ToolTipControls.Add(button2);
            ToolTipControls.Add(button3);
            ToolTipControls.Add(button4);
            ToolTipControls.Add(button5);
        }
        protected List<Control> ToolTipControls { get { return toolTipControls; } }

        protected Button ActiveButton {
            get { return activeButton; }
            set {
                if(value == ActiveButton) return;
                if(ActiveButton != null) {
                    HideHint();
                }
                activeButton = value;
                if(ActiveButton != null) {
                    ShowHint();
                }
            }
        }
        protected Control FindToolTipControl(Point pt) {
            foreach(Control control in ToolTipControls) {
                if(control.Bounds.Contains(pt)) return control;
            }
            return null;
        }
        protected DevExpress.Utils.ToolTipController ToolTipController { get { return DevExpress.Utils.ToolTipController.DefaultController; } }
        protected void HideHint() {
            ToolTipController.HideHint();
        }
        protected void ShowHint() {
            if(ActiveButton == null) return;
            DevExpress.Utils.ToolTipControllerShowEventArgs showArgs = ToolTipController.CreateShowArgs();
            showArgs.SelectedControl = ActiveButton;
            showArgs.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            showArgs.ToolTip = string.Format("Here is the super tool tip for button: {0}", ActiveButton.Text);
            ToolTipController.ShowHint(showArgs);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            ActiveButton = FindToolTipControl(e.Location) as Button;
        }
        void Form1_MouseLeave(object sender, EventArgs e) {
            ActiveButton = null;
        }
    }
}