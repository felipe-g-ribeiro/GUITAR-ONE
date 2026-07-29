using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class BootstrapBtn : Button {
    public enum BootstrapStyle {
        Primary,
        Secondary,
        Success,
        Danger,
        Warning,
        Info,
        Light,
        Dark
    }

    public BootstrapStyle Style { get; set; } = BootstrapStyle.Primary;
    public int BorderRadius { get; set; } = 8;

    private bool isHovering = false;

    public BootstrapBtn() {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Cursor = Cursors.Hand;
        Font = new Font("Segoe UI Semibold", 11);
        ForeColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e) {
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, Width, Height);

        Color fill = isHovering ? GetHoverColor() : GetBootstrapColor();

        using (GraphicsPath path = RoundedPath(rect, BorderRadius))
        using (SolidBrush brush = new SolidBrush(fill)) {
            Region = new Region(path);
            g.FillPath(brush, path);
        }

        TextRenderer.DrawText(g, Text, Font, rect, ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private GraphicsPath RoundedPath(Rectangle rect, int radius) {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
        path.CloseFigure();
        return path;
    }

    private Color GetBootstrapColor() {
        switch (Style) {
            case BootstrapStyle.Primary: return Color.FromArgb(13, 110, 253);
            case BootstrapStyle.Secondary: return Color.FromArgb(108, 117, 125);
            case BootstrapStyle.Success: return Color.FromArgb(25, 135, 84);
            case BootstrapStyle.Danger: return Color.FromArgb(220, 53, 69);
            case BootstrapStyle.Warning: return Color.FromArgb(255, 193, 7);
            case BootstrapStyle.Info: return Color.FromArgb(23, 162, 184);
            case BootstrapStyle.Light: ForeColor = Color.Black; return Color.FromArgb(248, 249, 250);
            case BootstrapStyle.Dark: return Color.FromArgb(33, 37, 41);
            default: return Color.FromArgb(13, 110, 253);
        }
    }

    private Color GetHoverColor() {
        switch (Style) {
            case BootstrapStyle.Primary: return Color.FromArgb(11, 94, 215);
            case BootstrapStyle.Secondary: return Color.FromArgb(90, 98, 104);
            case BootstrapStyle.Success: return Color.FromArgb(21, 115, 72);
            case BootstrapStyle.Danger: return Color.FromArgb(187, 45, 59);
            case BootstrapStyle.Warning: return Color.FromArgb(230, 170, 0);
            case BootstrapStyle.Info: return Color.FromArgb(19, 140, 160);
            case BootstrapStyle.Light: return Color.FromArgb(230, 230, 230);
            case BootstrapStyle.Dark: return Color.FromArgb(28, 32, 36);
            default: return Color.FromArgb(11, 94, 215);
        }
    }

    protected override void OnMouseEnter(EventArgs e) {
        base.OnMouseEnter(e);
        isHovering = true;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e) {
        base.OnMouseLeave(e);
        isHovering = false;
        Invalidate();
    }
}
