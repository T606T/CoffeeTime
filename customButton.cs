using System.Drawing;
using System.Windows.Forms;

public class ModernButton : Button
{
    private Color _normal = ColorTranslator.FromHtml("#C2B280");
    private Color _hover = ColorTranslator.FromHtml("#6F4E37");

    public ModernButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.BackColor = _normal;
        this.ForeColor = Color.White;
        this.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        this.Cursor = Cursors.Hand;

        this.MouseEnter += (s, e) => this.BackColor = _hover;
        this.MouseLeave += (s, e) => this.BackColor = _normal;
    }
}
