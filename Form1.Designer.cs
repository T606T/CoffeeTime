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
    private DateTimePicker datetimePickerCustom;

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
        this.textBoxMg =    new TextBox();

        this.buttonAdd =    new Button();
        this.buttonCoffee = new Button();
        this.buttonTea =    new Button();
        this.buttonEnergy = new Button();
        this.buttonDelete = new Button();
            
        this.listBox1 =     new ListBox();

        this.labelPrediction = new Label();
        this.labelResult = new Label();

        this.datetimePickerCustom = new DateTimePicker();

        this.SuspendLayout();
//-------------------------LAYOUT OF BUTTONS----------------------------------------//
        //Custom Button + custom amount
        this.buttonAdd.Location = new System.Drawing.Point(240,15);
        this.textBoxMg.Location = new System.Drawing.Point(130,15);
        this.buttonAdd.Size = new System.Drawing.Size(120,30);
        this.textBoxMg.Size = new System.Drawing.Size(100,30);
        //TimePicker
        this.datetimePickerCustom.Location = new System.Drawing.Point(20,15);
        this.datetimePickerCustom.Size = new System.Drawing.Size(100,30);

        //Coffee, Tea, Energy buttons
        this.buttonCoffee.Location = new System.Drawing.Point(20, 50);
        this.buttonTea.Location = new System.Drawing.Point(130, 50);
        this.buttonEnergy.Location = new System.Drawing.Point(240, 50);

        this.buttonCoffee.Size = new System.Drawing.Size(100, 30);
        this.buttonTea.Size = new System.Drawing.Size(100, 30);
        this.buttonEnergy.Size = new System.Drawing.Size(120, 30);
        
        //listbox + delete
        this.listBox1.Location = new System.Drawing.Point(20, 90);
        this.listBox1.Size = new System.Drawing.Size(240, 40);
        this.buttonDelete.Location = new System.Drawing.Point(270, 90);
        this.buttonDelete.Size = new System.Drawing.Size(90, 30);
        
        //Labels
        this.labelResult.Location = new System.Drawing.Point(40, 140);
        this.labelResult.Size = new System.Drawing.Size(300, 23);
        this.labelPrediction.Location = new System.Drawing.Point(190, 140);
        this.labelPrediction.Size = new System.Drawing.Size(300, 23);
        
        // labelPrediction
        this.labelPrediction.Name = "labelPrediction";
        this.labelPrediction.Text = "Prediction: --";
        this.Controls.Add(this.labelPrediction);

        // labelResult
        this.labelResult.Name = "labelResult";
        this.labelResult.Text = "Caffeine now: 0 mg";

        // Coffee button
        this.buttonCoffee.Name = "buttonCoffee";
        this.buttonCoffee.Text = "Coffee";
        this.buttonCoffee.Click += buttonCoffee_Click;

        // Tea button
        this.buttonTea.Name = "buttonTea";
        this.buttonTea.Text = "Tea";
        this.buttonTea.Click += buttonTea_Click;

        // Energy Drink button
        this.buttonEnergy.Name = "buttonEnergy";
        this.buttonEnergy.Text = "Energy Drink";
        this.buttonEnergy.Click += buttonEnergyDrink_Click;

        //Custom button
        this.buttonAdd.Name = "CustomAdd";
        this.buttonAdd.Text = "Custom Beverage";
        this.buttonAdd.Click += buttonAdd_Click;

        // ListBox
        this.listBox1.Name = "listBox1";

        // Delete button
        this.buttonDelete.Name = "buttonDelete";
        this.buttonDelete.Text = "Delete Dose";
        this.buttonDelete.Click += buttonDelete_Click;

        //TextBoxMg
        this.textBoxMg.BackColor = Color.FromArgb(35,35,35);
        this.textBoxMg.ForeColor = Color.White;

        
        //DateTimePicker
        this.datetimePickerCustom.Format = DateTimePickerFormat.Time;
        this.datetimePickerCustom.ShowUpDown = true;

        // Form1
        this.ClientSize = new System.Drawing.Size(380, 170);
        
        this.Controls.Add(this.textBoxMg);
        this.Controls.Add(this.labelResult);

        this.Controls.Add(this.buttonCoffee);
        this.Controls.Add(this.buttonTea);
        this.Controls.Add(this.buttonEnergy);
        this.Controls.Add(this.buttonAdd);
        this.Controls.Add(this.buttonDelete);

        this.Controls.Add(this.listBox1);

        this.Controls.Add(this.datetimePickerCustom);
        

        this.Name = "Form1";
        this.Text = "CoffeeTime";

        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
