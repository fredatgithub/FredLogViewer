namespace FredLogViewer
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.buttonLoadLog = new System.Windows.Forms.Button();
      this.textBoxSearch = new System.Windows.Forms.TextBox();
      this.labelSearch = new System.Windows.Forms.Label();
      this.buttonSearch = new System.Windows.Forms.Button();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.labelFilePath = new System.Windows.Forms.Label();
      this.textBoxFilePath = new System.Windows.Forms.TextBox();
      this.buttonFilename = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.languagetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.progressBarMain = new System.Windows.Forms.ProgressBar();
      this.labelNumberOfLinesBefore = new System.Windows.Forms.Label();
      this.textBoxNumberOfLinesBefore = new System.Windows.Forms.TextBox();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonLoadLog
      // 
      this.buttonLoadLog.Location = new System.Drawing.Point(26, 96);
      this.buttonLoadLog.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.buttonLoadLog.Name = "buttonLoadLog";
      this.buttonLoadLog.Size = new System.Drawing.Size(138, 28);
      this.buttonLoadLog.TabIndex = 0;
      this.buttonLoadLog.Text = "Load log";
      this.buttonLoadLog.UseVisualStyleBackColor = true;
      this.buttonLoadLog.Click += new System.EventHandler(this.ButtonLoadLog_Click);
      // 
      // textBoxSearch
      // 
      this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxSearch.Location = new System.Drawing.Point(117, 148);
      this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.textBoxSearch.Name = "textBoxSearch";
      this.textBoxSearch.Size = new System.Drawing.Size(1277, 35);
      this.textBoxSearch.TabIndex = 1;
      this.textBoxSearch.Text = "VFTS00889";
      // 
      // labelSearch
      // 
      this.labelSearch.AutoSize = true;
      this.labelSearch.Location = new System.Drawing.Point(20, 154);
      this.labelSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.labelSearch.Name = "labelSearch";
      this.labelSearch.Size = new System.Drawing.Size(129, 29);
      this.labelSearch.TabIndex = 2;
      this.labelSearch.Text = "Search for:";
      // 
      // buttonSearch
      // 
      this.buttonSearch.Location = new System.Drawing.Point(26, 196);
      this.buttonSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new System.Drawing.Size(117, 33);
      this.buttonSearch.TabIndex = 3;
      this.buttonSearch.Text = "Search";
      this.buttonSearch.UseVisualStyleBackColor = true;
      this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
      // 
      // textBoxResult
      // 
      this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxResult.Location = new System.Drawing.Point(26, 305);
      this.textBoxResult.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.textBoxResult.Multiline = true;
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxResult.Size = new System.Drawing.Size(1368, 428);
      this.textBoxResult.TabIndex = 4;
      // 
      // labelFilePath
      // 
      this.labelFilePath.AutoSize = true;
      this.labelFilePath.Location = new System.Drawing.Point(181, 55);
      this.labelFilePath.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.labelFilePath.Name = "labelFilePath";
      this.labelFilePath.Size = new System.Drawing.Size(114, 29);
      this.labelFilePath.TabIndex = 6;
      this.labelFilePath.Text = "File Path:";
      // 
      // textBoxFilePath
      // 
      this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxFilePath.Location = new System.Drawing.Point(266, 52);
      this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.textBoxFilePath.Name = "textBoxFilePath";
      this.textBoxFilePath.Size = new System.Drawing.Size(1128, 35);
      this.textBoxFilePath.TabIndex = 5;
      this.textBoxFilePath.Text = "D:\\trace\\oid_ora_13324_mytraceid.trc";
      this.textBoxFilePath.TextChanged += new System.EventHandler(this.TextBoxFilePath_TextChanged);
      // 
      // buttonFilename
      // 
      this.buttonFilename.Location = new System.Drawing.Point(26, 47);
      this.buttonFilename.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.buttonFilename.Name = "buttonFilename";
      this.buttonFilename.Size = new System.Drawing.Size(138, 31);
      this.buttonFilename.TabIndex = 7;
      this.buttonFilename.Text = "Choose a log file";
      this.buttonFilename.UseVisualStyleBackColor = true;
      this.buttonFilename.Click += new System.EventHandler(this.ButtonFilename_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.languagetoolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1429, 33);
      this.menuStrip1.TabIndex = 8;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
      this.fileToolStripMenuItem.Text = "&Fichier";
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
      this.quitToolStripMenuItem.Text = "&Quitter";
      this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
      this.editToolStripMenuItem.Text = "&Edition";
      // 
      // cancelToolStripMenuItem
      // 
      this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
      this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.cancelToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.cancelToolStripMenuItem.Text = "&Annuler";
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.redoToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(245, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
      this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.cutToolStripMenuItem.Text = "&Couper";
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.copyToolStripMenuItem.Text = "Co&pier";
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
      this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.pasteToolStripMenuItem.Text = "Co&ller";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(245, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
      this.selectAllToolStripMenuItem.Text = "Sélectio&nner tout";
      // 
      // languagetoolStripMenuItem
      // 
      this.languagetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem});
      this.languagetoolStripMenuItem.Name = "languagetoolStripMenuItem";
      this.languagetoolStripMenuItem.Size = new System.Drawing.Size(105, 29);
      this.languagetoolStripMenuItem.Text = "Language";
      // 
      // frenchToolStripMenuItem
      // 
      this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
      this.frenchToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
      this.frenchToolStripMenuItem.Text = "Français";
      this.frenchToolStripMenuItem.Click += new System.EventHandler(this.FrenchToolStripMenuItem_Click);
      // 
      // englishToolStripMenuItem
      // 
      this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
      this.englishToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
      this.englishToolStripMenuItem.Text = "Anglais";
      this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
      this.helpToolStripMenuItem.Text = "&Aide";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
      this.aboutToolStripMenuItem.Text = "À &propos de...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // progressBarMain
      // 
      this.progressBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.progressBarMain.Location = new System.Drawing.Point(0, 750);
      this.progressBarMain.Name = "progressBarMain";
      this.progressBarMain.Size = new System.Drawing.Size(1429, 23);
      this.progressBarMain.TabIndex = 9;
      this.progressBarMain.Visible = false;
      // 
      // labelNumberOfLinesBefore
      // 
      this.labelNumberOfLinesBefore.AutoSize = true;
      this.labelNumberOfLinesBefore.Location = new System.Drawing.Point(26, 256);
      this.labelNumberOfLinesBefore.Name = "labelNumberOfLinesBefore";
      this.labelNumberOfLinesBefore.Size = new System.Drawing.Size(600, 29);
      this.labelNumberOfLinesBefore.TabIndex = 10;
      this.labelNumberOfLinesBefore.Text = "Number of line before and after  the searched keyword:";
      // 
      // textBoxNumberOfLinesBefore
      // 
      this.textBoxNumberOfLinesBefore.Location = new System.Drawing.Point(430, 256);
      this.textBoxNumberOfLinesBefore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.textBoxNumberOfLinesBefore.Name = "textBoxNumberOfLinesBefore";
      this.textBoxNumberOfLinesBefore.Size = new System.Drawing.Size(86, 35);
      this.textBoxNumberOfLinesBefore.TabIndex = 11;
      this.textBoxNumberOfLinesBefore.Text = "0";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1429, 773);
      this.Controls.Add(this.textBoxNumberOfLinesBefore);
      this.Controls.Add(this.labelNumberOfLinesBefore);
      this.Controls.Add(this.progressBarMain);
      this.Controls.Add(this.buttonFilename);
      this.Controls.Add(this.labelFilePath);
      this.Controls.Add(this.textBoxFilePath);
      this.Controls.Add(this.textBoxResult);
      this.Controls.Add(this.buttonSearch);
      this.Controls.Add(this.labelSearch);
      this.Controls.Add(this.textBoxSearch);
      this.Controls.Add(this.buttonLoadLog);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.Name = "FormMain";
      this.Text = "Fred Log Viewer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonLoadLog;
    private System.Windows.Forms.TextBox textBoxSearch;
    private System.Windows.Forms.Label labelSearch;
    private System.Windows.Forms.Button buttonSearch;
    private System.Windows.Forms.TextBox textBoxResult;
    private System.Windows.Forms.Label labelFilePath;
    private System.Windows.Forms.TextBox textBoxFilePath;
    private System.Windows.Forms.Button buttonFilename;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ProgressBar progressBarMain;
    private System.Windows.Forms.Label labelNumberOfLinesBefore;
    private System.Windows.Forms.TextBox textBoxNumberOfLinesBefore;
    private System.Windows.Forms.ToolStripMenuItem languagetoolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
  }
}

