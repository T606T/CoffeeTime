namespace CoffeeTime;

partial class Form1
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
    private TextBox textBoxMg;
    private Button buttonAdd;
    private Label labelResult;
    private void InitializeComponent()
    {
         this.textBoxMg = new TextBox();
        this.buttonAdd = new Button();
        this.labelResult = new Label();

        this.SuspendLayout();

        // textBoxMg
        this.textBoxMg.Location = new System.Drawing.Point(20, 20);
        this.textBoxMg.Size = new System.Drawing.Size(150, 23);
        this.textBoxMg.Name = "textBoxMg";
        this.textBoxMg.PlaceholderText = "mg of caffeine";

        // buttonAdd
        this.buttonAdd.Location = new System.Drawing.Point(180, 20);
        this.buttonAdd.Size = new System.Drawing.Size(100, 23);
        this.buttonAdd.Name = "buttonAdd";
        this.buttonAdd.Text = "Add Dose";
        this.buttonAdd.Click += buttonAdd_Click;

        // labelResult
        this.labelResult.Location = new System.Drawing.Point(20, 60);
        this.labelResult.Size = new System.Drawing.Size(260, 23);
        this.labelResult.Name = "labelResult";
        this.labelResult.Text = "Caffeine now: 0 mg";

        // Form1
        this.ClientSize = new System.Drawing.Size(320, 120);
        this.Controls.Add(this.textBoxMg);
        this.Controls.Add(this.buttonAdd);
        this.Controls.Add(this.labelResult);
        this.Name = "Form1";
        this.Text = "CoffeeTime";

        this.ResumeLayout(false);
        this.PerformLayout();
        
        components = new System.ComponentModel.Container();
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Text = "CoffeeTimer";
    }

    #endregion
}
