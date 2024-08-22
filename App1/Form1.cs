using System;
using System.IO;

namespace App1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        Button myButton = new Button();
        myButton.Text = "Click Me!";
        myButton.Location = new System.Drawing.Point(50, 50);
        myButton.Size = new System.Drawing.Size(100, 40);

        myButton.Click += new EventHandler(MyButton_Click);

        this.Controls.Add(myButton);
    }

    private async void MyButton_Click(object sender, EventArgs e)
    {
        // you don't have to wait for the task, Task<T> can be stored in a variable
        var responseTask = LongWriteToTextFileAsync();
        // you can then do other things
        MessageBox.Show("The file writing is still being done.");
        // then you can await the Task<T> from Task<T> variable
        var response = await responseTask;
        // after you receive the response, you may begin processing anything else you may need
        MessageBox.Show("The response is: " + response);
    }

    private async Task<string> LongWriteToTextFileAsync()
    {
        for (int i = 1; i < 400_000; i++)
        {
            string textToLog = DateTime.Now.ToString() + ": logged " + i.ToString() + Environment.NewLine;
            await File.AppendAllTextAsync(@"c:\users\waynem\desktop\log.txt", textToLog);
        }

        MessageBox.Show("Finally done writing to the log file.");
        return "completed asynchronously";
    }

    private string LongWriteToTextFile()
    {
        for (int i = 1; i < 1_000_000; i++)
        {
            string textToLog = DateTime.Now.ToString() + ": logged " + i.ToString() + Environment.NewLine;
            File.AppendAllText(@"c:\users\waynem\desktop\log.txt", textToLog);
        }
        return "completed";
    }
}
