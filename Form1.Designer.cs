namespace CoffeeTime;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private TextBox textBoxMg;
    private Button buttonAdd;
    private Label labelResult;

    private Button buttonCoffee;
    private Button buttonTea;
    private Button buttonEnergy;
    private Button buttonDelete;
    
    private Label labelPrediction;
    private ListBox listBox1;

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
        this.textBoxMg = new TextBox();
        this.buttonAdd = new Button();
        this.labelResult = new Label();

        this.buttonCoffee = new Button();
        this.buttonTea = new Button();
        this.buttonEnergy = new Button();
        this.buttonDelete = new Button();

        this.listBox1 = new ListBox();

        this.labelPrediction = new Label();

        this.SuspendLayout();

        // labelPrediction
        this.labelPrediction.Location = new System.Drawing.Point(20, 90);
        this.labelPrediction.Size = new System.Drawing.Size(300, 23);
        this.labelPrediction.Name = "labelPrediction";
        this.labelPrediction.Text = "Prediction: --";
        this.Controls.Add(this.labelPrediction);

        // labelResult
        this.labelResult.Location = new System.Drawing.Point(20, 60);
        this.labelResult.Size = new System.Drawing.Size(260, 23);
        this.labelResult.Name = "labelResult";
        this.labelResult.Text = "Caffeine now: 0 mg";

        // Coffee button
        this.buttonCoffee.Location = new System.Drawing.Point(20, 100);
        this.buttonCoffee.Size = new System.Drawing.Size(100, 30);
        this.buttonCoffee.Name = "buttonCoffee";
        this.buttonCoffee.Text = "Coffee (90 mg)";
        this.buttonCoffee.UseVisualStyleBackColor = true;
        this.buttonCoffee.Click += buttonCoffee_Click;

        // Tea button
        this.buttonTea.Location = new System.Drawing.Point(130, 100);
        this.buttonTea.Size = new System.Drawing.Size(100, 30);
        this.buttonTea.Name = "buttonTea";
        this.buttonTea.Text = "Tea (50 mg)";
        this.buttonTea.UseVisualStyleBackColor = true;
        this.buttonTea.Click += buttonTea_Click;

        // Energy Drink button
        this.buttonEnergy.Location = new System.Drawing.Point(240, 100);
        this.buttonEnergy.Size = new System.Drawing.Size(120, 30);
        this.buttonEnergy.Name = "buttonEnergy";
        this.buttonEnergy.Text = "Energy Drink";
        this.buttonEnergy.UseVisualStyleBackColor = true;
        this.buttonEnergy.Click += buttonEnergyDrink_Click;

        // ListBox
        this.listBox1.Location = new System.Drawing.Point(20, 150);
        this.listBox1.Size = new System.Drawing.Size(240, 150);
        this.listBox1.Name = "listBox1";

        // Delete button
        this.buttonDelete.Location = new System.Drawing.Point(270, 150);
        this.buttonDelete.Size = new System.Drawing.Size(90, 30);
        this.buttonDelete.Name = "buttonDelete";
        this.buttonDelete.Text = "Delete Dose";
        this.buttonDelete.UseVisualStyleBackColor = true;
        this.buttonDelete.Click += buttonDelete_Click;

        // Form1
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(380, 330);
        //this.Controls.Add(this.textBoxMg);
        //this.Controls.Add(this.buttonAdd);
        this.Controls.Add(this.labelResult);

        this.Controls.Add(this.buttonCoffee);
        this.Controls.Add(this.buttonTea);
        this.Controls.Add(this.buttonEnergy);

        this.Controls.Add(this.listBox1);
        this.Controls.Add(this.buttonDelete);

        this.Name = "Form1";
        this.Text = "CoffeeTime";

        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
