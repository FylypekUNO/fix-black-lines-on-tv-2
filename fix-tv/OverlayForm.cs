﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace fix_black_lines_on_TV
{
    public partial class OverlayForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_EXSTYLE = -20; // Extended window styles
        private const int WS_EX_LAYERED = 0x80000; // Allows transparency
        private const int WS_EX_TOOLWINDOW = 0x80; // Hides from Alt+Tab
        private const int WS_EX_NOACTIVATE = 0x8000000; // Prevents activation on click
        private const int WS_EX_TRANSPARENT = 0x20; // Makes the window transparent to mouse events
        private const int HTTRANSPARENT = -1; // Transparent hit test value

        private NotifyIcon _trayIcon;
        private ContextMenuStrip _trayMenu;
        private int _targetScreenIndex = 0;
        private int _patternHeight = 4;
        private int _lineSize = 1;
        private int _patternOffset = 0;

        public OverlayForm()
        {
            SetVisuals();
            InitializeTrayIcon();
            UpdateTrayMenu();
            OnDisplaySizeChange();
        }

        private void InitializeTrayIcon()
        {
            _trayIcon = new NotifyIcon
            {
                Text = "FixBlackLines",
                Icon = SystemIcons.Application, // Template
                ContextMenuStrip = _trayMenu,
                Visible = true
            };

            _trayIcon.MouseDoubleClick += (sender, e) =>
            {
                if (e.Button != MouseButtons.Left) return;
                OnToggleOverlay();
            };
        }

        private void UpdateTrayMenu()
        {
            _trayMenu = new ContextMenuStrip();

            _trayMenu.Items.Add(Visible ? "Turn Off" : "Turn On", null, (sender, e) => OnToggleOverlay());
            _trayMenu.Items.Add("Settings", null, (sender, e) => OpenSettings());
            _trayMenu.Items.Add(new ToolStripSeparator());
            _trayMenu.Items.Add("Exit", null, (sender, e) => OnExit());

            _trayIcon.ContextMenuStrip = _trayMenu;
        }

        private void OnToggleOverlay()
        {
            Visible = !Visible;
            UpdateTrayMenu();
        }

        private void OnExit()
        {
            _trayIcon.Visible = false;
            Application.Exit();
        }

        private void SetVisuals()
        {
            this.SuspendLayout();
            this.Name = "OverlayForm";
            this.ResumeLayout(false);

            this.ShowInTaskbar = false; // Hide from taskbar
            this.FormBorderStyle = FormBorderStyle.None; // Remove window borders
            this.TopMost = true; // Keep the form on top
            this.WindowState = FormWindowState.Normal; // Set normal state
            this.BackColor = Color.White; // Set a background color (used for transparency)
            this.TransparencyKey = Color.White; // Make this color transparent
            this.AllowTransparency = true; // Enable transparency

            // Set the window styles to hide it and allow interaction
            var exStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle | WS_EX_LAYERED | WS_EX_TOOLWINDOW | WS_EX_NOACTIVATE | WS_EX_TRANSPARENT);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_DISPLAYCHANGE = 0x007E;
            const int WM_NCHITTEST = 0x0084;

            if (m.Msg == WM_DISPLAYCHANGE) OnDisplaySizeChange();
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTTRANSPARENT;
                return;
            }
            base.WndProc(ref m);
        }

        private void OnDisplaySizeChange()
        {
            var targetScreen = Screen.AllScreens[_targetScreenIndex];
            var screenBounds = targetScreen.Bounds;

            // Fullscreen
            this.Location = new Point(screenBounds.Left, screenBounds.Top);
            this.Size = new Size(screenBounds.Width, screenBounds.Height);

            this.Invalidate();
        }

        private TextureBrush CreatePatternBrush()
        {
            var pattern = new Bitmap(_patternHeight, _patternHeight);
            Graphics g = Graphics.FromImage(pattern);
            try
            {
                g.Clear(Color.Transparent);
                Pen p = new Pen(Color.Black, _lineSize);
                try
                {
                    g.DrawLine(p, _patternOffset, _patternHeight / 2, _patternHeight - _patternOffset, _patternHeight / 2);
                }
                finally
                {
                    p.Dispose();
                }
            }
            finally
            {
                g.Dispose();
            }
            return new TextureBrush(pattern);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            TextureBrush brush = CreatePatternBrush();
            try
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            finally
            {
                brush.Dispose();
            }
        }

        private void OpenSettings()
        {
            using (var settingsForm = new SettingsForm(_patternHeight, _lineSize, _patternOffset, this.Opacity))
            {
                settingsForm.SettingsApplied += (sender, e) =>
                {
                    // Apply settings
                    this.Opacity = settingsForm.OpacityValue;
                    _patternHeight = settingsForm.PatternHeight;
                    _lineSize = settingsForm.LineSize;
                    _patternOffset = settingsForm.PatternOffset;
                    this.Invalidate();
                };

                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    // Apply settings
                    this.Opacity = settingsForm.OpacityValue;
                    _patternHeight = settingsForm.PatternHeight;
                    _lineSize = settingsForm.LineSize;
                    _patternOffset = settingsForm.PatternOffset;
                    this.Invalidate();
                }
            }
        }
    }
}