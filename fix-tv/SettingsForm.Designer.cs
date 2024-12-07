namespace fix_black_lines_on_TV
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPatternHeight = new System.Windows.Forms.Label();
            this.numPatternHeight = new System.Windows.Forms.NumericUpDown();
            this.lblLineSize = new System.Windows.Forms.Label();
            this.numLineSize = new System.Windows.Forms.NumericUpDown();
            this.lblPatternOffset = new System.Windows.Forms.Label();
            this.numPatternOffset = new System.Windows.Forms.NumericUpDown();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.numOpacity = new System.Windows.Forms.NumericUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblScreenIndex = new System.Windows.Forms.Label();
            this.cboScreenIndex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPatternHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLineSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPatternOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatternHeight
            // 
            this.lblPatternHeight.AutoSize = true;
            this.lblPatternHeight.Location = new System.Drawing.Point(10, 20);
            this.lblPatternHeight.Name = "lblPatternHeight";
            this.lblPatternHeight.Size = new System.Drawing.Size(80, 13);
            this.lblPatternHeight.TabIndex = 0;
            this.lblPatternHeight.Text = "Pattern Height:";
            // 
            // numPatternHeight
            // 
            this.numPatternHeight.Location = new System.Drawing.Point(120, 20);
            this.numPatternHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPatternHeight.Name = "numPatternHeight";
            this.numPatternHeight.Size = new System.Drawing.Size(100, 20);
            this.numPatternHeight.TabIndex = 1;
            this.numPatternHeight.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // lblLineSize
            // 
            this.lblLineSize.AutoSize = true;
            this.lblLineSize.Location = new System.Drawing.Point(10, 60);
            this.lblLineSize.Name = "lblLineSize";
            this.lblLineSize.Size = new System.Drawing.Size(54, 13);
            this.lblLineSize.TabIndex = 2;
            this.lblLineSize.Text = "Line Size:";
            // 
            // numLineSize
            // 
            this.numLineSize.Location = new System.Drawing.Point(120, 60);
            this.numLineSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numLineSize.Name = "numLineSize";
            this.numLineSize.Size = new System.Drawing.Size(100, 20);
            this.numLineSize.TabIndex = 3;
            this.numLineSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPatternOffset
            // 
            this.lblPatternOffset.AutoSize = true;
            this.lblPatternOffset.Location = new System.Drawing.Point(10, 100);
            this.lblPatternOffset.Name = "lblPatternOffset";
            this.lblPatternOffset.Size = new System.Drawing.Size(77, 13);
            this.lblPatternOffset.TabIndex = 4;
            this.lblPatternOffset.Text = "Pattern Offset:";
            // 
            // numPatternOffset
            // 
            this.numPatternOffset.Location = new System.Drawing.Point(120, 100);
            this.numPatternOffset.Name = "numPatternOffset";
            this.numPatternOffset.Size = new System.Drawing.Size(100, 20);
            this.numPatternOffset.TabIndex = 5;
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(10, 140);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(46, 13);
            this.lblOpacity.TabIndex = 6;
            this.lblOpacity.Text = "Opacity:";
            // 
            // numOpacity
            // 
            this.numOpacity.DecimalPlaces = 2;
            this.numOpacity.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.numOpacity.Location = new System.Drawing.Point(120, 140);
            this.numOpacity.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numOpacity.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            this.numOpacity.Name = "numOpacity";
            this.numOpacity.Size = new System.Drawing.Size(100, 20);
            this.numOpacity.TabIndex = 7;
            this.numOpacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(10, 220);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(80, 23);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(100, 220);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 23);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(190, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblScreenIndex
            // 
            this.lblScreenIndex.AutoSize = true;
            this.lblScreenIndex.Location = new System.Drawing.Point(10, 180);
            this.lblScreenIndex.Name = "lblScreenIndex";
            this.lblScreenIndex.Size = new System.Drawing.Size(47, 13);
            this.lblScreenIndex.TabIndex = 11;
            this.lblScreenIndex.Text = "Screen:";
            // 
            // cboScreenIndex
            // 
            this.cboScreenIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScreenIndex.FormattingEnabled = true;
            this.cboScreenIndex.Location = new System.Drawing.Point(120, 180);
            this.cboScreenIndex.Name = "cboScreenIndex";
            this.cboScreenIndex.Size = new System.Drawing.Size(100, 21);
            this.cboScreenIndex.TabIndex = 12;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnAccept;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 251);
            this.Controls.Add(this.cboScreenIndex);
            this.Controls.Add(this.lblScreenIndex);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.numOpacity);
            this.Controls.Add(this.lblOpacity);
            this.Controls.Add(this.numPatternOffset);
            this.Controls.Add(this.lblPatternOffset);
            this.Controls.Add(this.numLineSize);
            this.Controls.Add(this.lblLineSize);
            this.Controls.Add(this.numPatternHeight);
            this.Controls.Add(this.lblPatternHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numPatternHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLineSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPatternOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblPatternHeight;
        private System.Windows.Forms.NumericUpDown numPatternHeight;
        private System.Windows.Forms.Label lblLineSize;
        private System.Windows.Forms.NumericUpDown numLineSize;
        private System.Windows.Forms.Label lblPatternOffset;
        private System.Windows.Forms.NumericUpDown numPatternOffset;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.NumericUpDown numOpacity;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblScreenIndex;
        private System.Windows.Forms.ComboBox cboScreenIndex;
    }
}
