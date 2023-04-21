using FredLogViewer.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FredLogViewer
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private readonly List<string> logLines = new List<string>();
    private int numberOfLines = 1;

    private void FormMain_Load(object sender, EventArgs e)
    {
      GetWindowValue();
    }

    private void ButtonSearch_Click(object sender, EventArgs e)
    {
      // Add a please-wait form
      textBoxResult.Text = string.Empty; 
      Application.DoEvents();
      progressBarMain.Visible = true;
      progressBarMain.Minimum = 0;
      progressBarMain.Maximum = logLines.Count + 1;
      var compteur = progressBarMain.Minimum;
      var listOfResult = new List<string>();
      var linesBefore = new List<string>();
      var linesAfter = new List<string>();
      if (!int.TryParse(textBoxNumberOfLinesBefore.Text, out numberOfLines))
      {
        numberOfLines = 1;
      }

      bool itemFound = false;
      foreach (string line in logLines)
      {
        if (linesBefore.Count > numberOfLines)
        {
          linesBefore.RemoveAt(0);
        }

        listOfResult.Add(line);
        if (line.Contains(textBoxSearch.Text))
        {
          foreach (string item in linesBefore)
          {
            textBoxResult.Text += $"{item}{Environment.NewLine}";
          }

          linesBefore.Clear();
          textBoxResult.Text += $"{line}{Environment.NewLine}";
          itemFound = true;
        }

        if (itemFound)
        {
          if (linesAfter.Count <= numberOfLines)
          {
            linesAfter.Add(line);
          }
          else
          {
            foreach (string item in linesAfter)
            {
              textBoxResult.Text += $"{item}{Environment.NewLine}";
            }
            
            linesAfter.Clear();
            itemFound = false;
            textBoxResult.Text += $"-------------------------------{Environment.NewLine}";
          }
        }

        compteur++;
        progressBarMain.Value = compteur;
        Application.DoEvents();
      }

      progressBarMain.Value = 0;
      progressBarMain.Visible = false;
      MessageBox.Show("the search is finished");
    }

    private void ButtonLoadLog_Click(object sender, EventArgs e)
    {
      string filename = textBoxFilePath.Text;
      try
      {
        using (StreamReader sr = new StreamReader(filename))
        {
          var line = string.Empty;
          while ((line = sr.ReadLine()) != null)
          {
            logLines.Add(line);
          }
        }
      }
      catch (Exception exception)
      {
        throw new Exception(exception.Message);
      }

      MessageBox.Show("Chargement fini");
    }

    private void ButtonFilename_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      if (ofd.ShowDialog() == DialogResult.OK)
      {
        textBoxFilePath.Text = ofd.FileName;
      }
    }

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }
  }
}
