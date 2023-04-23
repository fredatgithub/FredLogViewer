using FredLogViewer.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

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
    private readonly Dictionary<string, string> languageDicoEn = new Dictionary<string, string>();
    private readonly Dictionary<string, string> languageDicoFr = new Dictionary<string, string>();
    private bool FileIsLoaded = false;

    private void FormMain_Load(object sender, EventArgs e)
    {
      GetWindowValue();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
      SetVariablesAtStartup();
    }

    private void SetVariablesAtStartup()
    {
      FileIsLoaded = false;
      buttonSearch.Enabled = false;
    }

    private void ButtonSearch_Click(object sender, EventArgs e)
    {
      if (logLines.Count == 0)
      {
        MessageBox.Show("You have to load the file before searching", "File not loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

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

        FileIsLoaded = true;
        buttonSearch.Enabled = true;
        MessageBox.Show("Chargement fini");
      }
      catch (Exception exception)
      {
        throw new Exception(exception.Message);
      }
    }

    private void ButtonFilename_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      if (ofd.ShowDialog() == DialogResult.OK)
      {
        textBoxFilePath.Text = ofd.FileName;
        buttonSearch.Enabled = false;
        FileIsLoaded = false;
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
      Settings.Default.LastLanguageUsed = FrenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.textBoxSearch = textBoxSearch.Text;
      Settings.Default.textBoxNumberOfLinesBefore = textBoxNumberOfLinesBefore.Text;
      Settings.Default.textBoxFilePath = textBoxFilePath.Text;
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      FrenchToolStripMenuItem.Checked = Settings.Default.LastLanguageUsed == "French";
      EnglishToolStripMenuItem.Checked = Settings.Default.LastLanguageUsed == "English";
      textBoxSearch.Text = Settings.Default.textBoxSearch;
      textBoxNumberOfLinesBefore.Text = Settings.Default.textBoxNumberOfLinesBefore;
      textBoxFilePath.Text = Settings.Default.textBoxFilePath;
      Text += DisplayTitle();
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private string DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      return string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void SetLanguage(string myLanguage)
    {
      switch (myLanguage)
      {
        case "English":
          //frenchToolStripMenuItem.Checked = false;
          //englishToolStripMenuItem.Checked = true;
          //fileToolStripMenuItem.Text = languageDicoEn["MenuFile"];
          //newToolStripMenuItem.Text = languageDicoEn["MenuFileNew"];
          //openToolStripMenuItem.Text = languageDicoEn["MenuFileOpen"];
          //saveToolStripMenuItem.Text = languageDicoEn["MenuFileSave"];
          //saveasToolStripMenuItem.Text = languageDicoEn["MenuFileSaveAs"];
          //printPreviewToolStripMenuItem.Text = languageDicoEn["MenuFilePrint"];
          //printPreviewToolStripMenuItem.Text = languageDicoEn["MenufilePageSetup"];
          //quitToolStripMenuItem.Text = languageDicoEn["MenufileQuit"];
          //editToolStripMenuItem.Text = languageDicoEn["MenuEdit"];
          //cancelToolStripMenuItem.Text = languageDicoEn["MenuEditCancel"];
          //redoToolStripMenuItem.Text = languageDicoEn["MenuEditRedo"];
          //cutToolStripMenuItem.Text = languageDicoEn["MenuEditCut"];
          //copyToolStripMenuItem.Text = languageDicoEn["MenuEditCopy"];
          //pasteToolStripMenuItem.Text = languageDicoEn["MenuEditPaste"];
          //selectAllToolStripMenuItem.Text = languageDicoEn["MenuEditSelectAll"];
          //toolsToolStripMenuItem.Text = languageDicoEn["MenuTools"];
          //personalizeToolStripMenuItem.Text = languageDicoEn["MenuToolsCustomize"];
          //optionsToolStripMenuItem.Text = languageDicoEn["MenuToolsOptions"];
          //languagetoolStripMenuItem.Text = languageDicoEn["MenuLanguage"];
          //englishToolStripMenuItem.Text = languageDicoEn["MenuLanguageEnglish"];
          //frenchToolStripMenuItem.Text = languageDicoEn["MenuLanguageFrench"];
          //helpToolStripMenuItem.Text = languageDicoEn["MenuHelp"];
          //summaryToolStripMenuItem.Text = languageDicoEn["MenuHelpSummary"];
          //indexToolStripMenuItem.Text = languageDicoEn["MenuHelpIndex"];
          //searchToolStripMenuItem.Text = languageDicoEn["MenuHelpSearch"];
          //aboutToolStripMenuItem.Text = languageDicoEn["MenuHelpAbout"];

          break;
        case "French":
          //frenchToolStripMenuItem.Checked = true;
          //englishToolStripMenuItem.Checked = false;
          //fileToolStripMenuItem.Text = languageDicoFr["MenuFile"];
          //newToolStripMenuItem.Text = languageDicoFr["MenuFileNew"];
          //openToolStripMenuItem.Text = languageDicoFr["MenuFileOpen"];
          //saveToolStripMenuItem.Text = languageDicoFr["MenuFileSave"];
          //saveasToolStripMenuItem.Text = languageDicoFr["MenuFileSaveAs"];
          //printPreviewToolStripMenuItem.Text = languageDicoFr["MenuFilePrint"];
          //printPreviewToolStripMenuItem.Text = languageDicoFr["MenufilePageSetup"];
          //quitToolStripMenuItem.Text = languageDicoFr["MenufileQuit"];
          //editToolStripMenuItem.Text = languageDicoFr["MenuEdit"];
          //cancelToolStripMenuItem.Text = languageDicoFr["MenuEditCancel"];
          //redoToolStripMenuItem.Text = languageDicoFr["MenuEditRedo"];
          //cutToolStripMenuItem.Text = languageDicoFr["MenuEditCut"];
          //copyToolStripMenuItem.Text = languageDicoFr["MenuEditCopy"];
          //pasteToolStripMenuItem.Text = languageDicoFr["MenuEditPaste"];
          //selectAllToolStripMenuItem.Text = languageDicoFr["MenuEditSelectAll"];
          //toolsToolStripMenuItem.Text = languageDicoFr["MenuTools"];
          //personalizeToolStripMenuItem.Text = languageDicoFr["MenuToolsCustomize"];
          //optionsToolStripMenuItem.Text = languageDicoFr["MenuToolsOptions"];
          //languagetoolStripMenuItem.Text = languageDicoFr["MenuLanguage"];
          //englishToolStripMenuItem.Text = languageDicoFr["MenuLanguageEnglish"];
          //frenchToolStripMenuItem.Text = languageDicoFr["MenuLanguageFrench"];
          //helpToolStripMenuItem.Text = languageDicoFr["MenuHelp"];
          //summaryToolStripMenuItem.Text = languageDicoFr["MenuHelpSummary"];
          //indexToolStripMenuItem.Text = languageDicoFr["MenuHelpIndex"];
          //searchToolStripMenuItem.Text = languageDicoFr["MenuHelpSearch"];
          //aboutToolStripMenuItem.Text = languageDicoFr["MenuHelpAbout"];

          break;

      }
    }

    public enum Language
    {
      French,
      English
    }

    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

      // read the translation file and feed the language
      XDocument xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   let xElementName = node.Element("name")
                   where xElementName != null
                   let xElementEnglish = node.Element("englishValue")
                   where xElementEnglish != null
                   let xElementFrench = node.Element("frenchValue")
                   where xElementFrench != null
                   select new
                   {
                     name = xElementName.Value,
                     englishValue = xElementEnglish.Value,
                     frenchValue = xElementFrench.Value
                   };
      foreach (var i in result)
      {
        languageDicoEn.Add(i.name, i.englishValue);
        languageDicoFr.Add(i.name, i.frenchValue);
      }
    }

    private static void CreateLanguageFile()
    {
      List<string> minimumVersion = new List<string>
      {
        "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>",
        "<Document>",
        "<DocumentVersion>",
        "<version> 1.0 </version>",
        "</DocumentVersion>",
        "<terms>",
         "<term>",
        "<name>MenuFile</name>",
        "<englishValue>File</englishValue>",
        "<frenchValue>Fichier</frenchValue>",
        "</term>",
        "  </terms>",
        "</Document>"
      };

      StreamWriter sw = new StreamWriter(Settings.Default.LanguageFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }

    private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrenchToolStripMenuItem.Checked = true;
      EnglishToolStripMenuItem.Checked = false;
      SetLanguage(Language.French.ToString());
    }

    private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrenchToolStripMenuItem.Checked = false;
      EnglishToolStripMenuItem.Checked = true;
      SetLanguage(Language.English.ToString());
    }

    private void TextBoxFilePath_TextChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(textBoxFilePath.Text))
      {
        buttonSearch.Enabled = false;
      }

      if (File.Exists(textBoxFilePath.Text))
      {
        buttonSearch.Enabled = true;
      }
      else
      {
        buttonSearch.Enabled = false;
      }
    }
  }
}
