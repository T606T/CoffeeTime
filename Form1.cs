namespace CoffeeTime;

using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    // These MUST be fields, not inside the constructor
    private DateTime startTime;
    private double initialMg;
    private Timer timer1; 

    private List<Dose> doses = new();
    public Form1()
    {
        InitializeComponent();

        // Activate the timer (assuming timer1 exists in Designer)
        timer1 = new Timer();
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;
        timer1.Start();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        // Read caffeine amount
        if (double.TryParse(textBoxMg.Text, out double mg))
        {
            initialMg = mg;
            startTime = DateTime.Now;
            textBoxMg.Clear();
        }
        else
        {
            MessageBox.Show("Please enter a valid number.");
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        double hours = (DateTime.Now - startTime).TotalHours;

        double halfLife = 5.0;  // You can change later
        double k = Math.Log(2) / halfLife;

        double current = initialMg * Math.Exp(-k * hours);

        labelResult.Text = $"Caffeine now: {current:F1} mg";
    }
}
