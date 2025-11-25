using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeTime
{
    public static class ModernUI
    {
        // === PALETA ===
        private static readonly Color Bg = ColorTranslator.FromHtml("#C2B280");
        private static readonly Color PanelBg = Color.White;
        private static readonly Color Fg = Color.White;
        private static readonly Color Accent = ColorTranslator.FromHtml("#6F4E37");
        private static readonly Color AccentHover = ColorTranslator.FromHtml("#AA7E6E");

        // === TIPOGRAFÍA ===
        private static readonly Font DefaultFont = new Font("Segoe UI", 10, FontStyle.Regular);
        private static readonly Font BoldFont = new Font("Segoe UI Semibold", 10, FontStyle.Bold);


        // MAIN ENTRY POINT
        public static void ApplyModernTheme(Form form)
        {
            form.BackColor = Bg;
            form.ForeColor = Fg;
            form.Font = DefaultFont;

            foreach (Control ctrl in form.Controls)
                StyleControl(ctrl);
        }


        // === CONTROL ROUTER ===
        private static void StyleControl(Control ctrl)
        {
            ctrl.ForeColor = Fg;
            ctrl.Font = DefaultFont;

            switch (ctrl)
            {
                case Panel p:
                    p.BackColor = PanelBg;
                    p.BorderStyle = BorderStyle.None;
                    break;

                case Button b:
                    StyleButton(b);
                    break;

                case TextBox tb:
                    StyleTextBox(tb);
                    break;

                case Label l:
                    l.ForeColor = Fg;
                    break;
                case ListBox lb:
                    StyleListBox(lb);
                    break;
            }

            // Recurse on children
            foreach (Control child in ctrl.Controls)
                StyleControl(child);
        }


        // === BUTTON STYLE ===
        private static void StyleButton(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = Accent;
            b.ForeColor = Color.White;
            b.Font = BoldFont;
            b.Cursor = Cursors.Hand;

            b.MouseEnter += (s, e) => b.BackColor = AccentHover;
            b.MouseLeave += (s, e) => b.BackColor = Accent;
        }
        // === BUTTON STYLE TextBox ===
        private static void StyleListBox(ListBox lb)
        {
            lb.BackColor = PanelBg;
            lb.ForeColor = Color.Black;
            lb.BorderStyle = BorderStyle.None;
        }
        // === TEXTBOX STYLE ===
        private static void StyleTextBox(TextBox tb)
        {
            tb.BorderStyle = BorderStyle.None;
            tb.BackColor = PanelBg;
            tb.ForeColor = Color.Black;
            tb.Margin = new Padding(4);
            tb.Padding = new Padding(4);
        }
    }
}
