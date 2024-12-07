using System;
using System.Windows.Forms;

namespace fix_black_lines_on_TV
{
    public partial class SettingsForm : Form
    {
        public int PatternHeight { get; private set; }
        public int LineSize { get; private set; }
        public int PatternOffset { get; private set; }
        public double OpacityValue { get; private set; }
        public int TargetScreenIndex { get; private set; }

        public event EventHandler SettingsApplied;

        public SettingsForm(int patternHeight, int lineSize, int patternOffset, double opacityValue, int targetScreenIndex)
        {
            InitializeComponent();
            
            // Initialize screen combo box
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                cboScreenIndex.Items.Add($"Screen {i + 1}");
            }
            
            numPatternHeight.Value = patternHeight;
            numLineSize.Value = lineSize;
            numPatternOffset.Value = patternOffset;
            numOpacity.Value = (decimal)opacityValue;
            cboScreenIndex.SelectedIndex = targetScreenIndex;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ApplySettings();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplySettings();
            SettingsApplied?.Invoke(this, EventArgs.Empty);
        }

        private void ApplySettings()
        {
            PatternHeight = (int)numPatternHeight.Value;
            LineSize = (int)numLineSize.Value;
            PatternOffset = (int)numPatternOffset.Value;
            OpacityValue = (double)numOpacity.Value;
            TargetScreenIndex = cboScreenIndex.SelectedIndex;
        }
    }
}
