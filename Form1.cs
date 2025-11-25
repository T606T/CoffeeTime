namespace CoffeeTime;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private Timer timer1; 
    private List<Dose> doses = new();

    public Form1()
    {
        InitializeComponent();
        //STYLE
        ModernUI.ApplyModernTheme(this);
        //TIMERS
        timer1 = new Timer();
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;
        timer1.Start();
    }
    private void RefreshDoseList()
    {
        if (listBox1 == null) return;

        listBox1.Items.Clear();
        foreach (var d in doses)
            listBox1.Items.Add(d);
    }

    private void buttonCoffee_Click(object sender, EventArgs e)
    {
        doses.Add(new Dose("Coffee", 90, DateTime.Now));
        RefreshDoseList();
        UpdatePrediction();
    }
    private void buttonTea_Click(object sender, EventArgs e)
    {
        doses.Add(new Dose("Tea", 55, DateTime.Now));
        RefreshDoseList();
        UpdatePrediction();
    }
    private void buttonEnergyDrink_Click(object sender, EventArgs e)
    {
        doses.Add(new Dose("Energy Drink", 200, DateTime.Now));
        RefreshDoseList();
        UpdatePrediction();
    }
    private void buttonDelete_Click(object sender, EventArgs e)
    {
        var selected = (Dose)listBox1.SelectedItem;
        if (selected != null)
        {
        doses.Remove(selected);
        RefreshDoseList();
        UpdatePrediction();
        }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        if (double.TryParse(textBoxMg.Text, out double mg))
        {
            DateTime ingestedTime = datetimePickerCustom?.Value ?? DateTime.Now;
            doses.Add(new Dose("Custom", mg, ingestedTime));
            textBoxMg.Clear();
            RefreshDoseList();
            UpdatePrediction();
        }
        else
        {
            MessageBox.Show("Please enter a valid number.");
        }
    }
    private void UpdatePrediction()
    {
        double halfLife = 5.0;
        double k = Math.Log(2) / halfLife;

        double threshold = 40.0; // mg to go to sleep
        double C = ComputeTotalCaffeine();

        // Si el total ya está por debajo, actualizamos la UI y salimos
        if (C <= threshold)
        {
            if (labelPrediction != null)
                labelPrediction.Text = "Below 40 mg: now";
            else
                labelResult.Text = $"Caffeine now: {C:F1} mg  (Safe now)";
            return;
        }

        // Prevent division by zero or negative k
        if (k <= 0)
        {
            if (labelPrediction != null)
                labelPrediction.Text = "Cannot compute prediction";
            return;
        }

        // hoursToSafe = ln(C/threshold) / k
        double hoursToSafe = Math.Log(C / threshold) / k;
        if (double.IsNaN(hoursToSafe) || double.IsInfinity(hoursToSafe) || hoursToSafe < 0)
        {
            if (labelPrediction != null)
                labelPrediction.Text = "Prediction unavailable";
            return;
        }

        DateTime safeTime = DateTime.Now.AddHours(hoursToSafe);

        if (labelPrediction != null)
            labelPrediction.Text = $"Below 40 mg at: {safeTime:HH:mm}";
        else
            labelResult.Text = $"Caffeine now: {C:F1} mg  (Below 40 mg at {safeTime:HH:mm})";
    }

    
    // Total caffeine at current time from all doses
    private double ComputeTotalCaffeine()
    {
        if (doses.Count == 0) return 0;

        double halfLife = 5.0;       // adjustable later
        double k = Math.Log(2) / halfLife;  
        DateTime now = DateTime.Now;

        double total = 0;

        foreach (var dose in doses)
        {
            double hours = (now - dose.Timestamp).TotalHours;
            total += dose.Mg * Math.Exp(-k * hours);
        }

        return total;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        double C = ComputeTotalCaffeine();
        labelResult.Text = $"Caffeine now: {C:F1} mg";
    }
}

