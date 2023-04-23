﻿namespace FredLogViewer
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
      this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.sélectionnertoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.FrenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.EnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.progressBarMain = new System.Windows.Forms.ProgressBar();
      this.labelNumberOfLinesBefore = new System.Windows.Forms.Label();
      this.textBoxNumberOfLinesBefore = new System.Windows.Forms.TextBox();
      this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
      this.textBoxSearch.Size = new System.Drawing.Size(1277, 26);
      this.textBoxSearch.TabIndex = 1;
      this.textBoxSearch.Text = "VFTS00889";
      // 
      // labelSearch
      // 
      this.labelSearch.AutoSize = true;
      this.labelSearch.Location = new System.Drawing.Point(20, 154);
      this.labelSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.labelSearch.Name = "labelSearch";
      this.labelSearch.Size = new System.Drawing.Size(87, 20);
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
      this.labelFilePath.Size = new System.Drawing.Size(75, 20);
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
      this.textBoxFilePath.Size = new System.Drawing.Size(1128, 26);
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
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aideToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1429, 24);
      this.menuStrip1.TabIndex = 8;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // editionToolStripMenuItem
      // 
      this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.toolStripSeparator3,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.toolStripSeparator4,
            this.sélectionnertoutToolStripMenuItem});
      this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.couperToolStripMenuItem.Text = "&Couper";
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.copierToolStripMenuItem.Text = "Co&pier";
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.collerToolStripMenuItem.Text = "Co&ller";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrenchToolStripMenuItem,
            this.EnglishToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
      this.toolStripMenuItem1.Text = "Language";
      // 
      // FrenchToolStripMenuItem
      // 
      this.FrenchToolStripMenuItem.Name = "FrenchToolStripMenuItem";
      this.FrenchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.FrenchToolStripMenuItem.Text = "Français";
      this.FrenchToolStripMenuItem.Click += new System.EventHandler(this.FrenchToolStripMenuItem_Click);
      // 
      // EnglishToolStripMenuItem
      // 
      this.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem";
      this.EnglishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.EnglishToolStripMenuItem.Text = "Anglais";
      this.EnglishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
      // 
      // aideToolStripMenuItem
      // 
      this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àproposdeToolStripMenuItem});
      this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // àproposdeToolStripMenuItem
      // 
      this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
      this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.àproposdeToolStripMenuItem.Text = "À &propos de...";
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
      this.labelNumberOfLinesBefore.Size = new System.Drawing.Size(396, 20);
      this.labelNumberOfLinesBefore.TabIndex = 10;
      this.labelNumberOfLinesBefore.Text = "Number of line before and after  the searched keyword:";
      // 
      // textBoxNumberOfLinesBefore
      // 
      this.textBoxNumberOfLinesBefore.Location = new System.Drawing.Point(430, 256);
      this.textBoxNumberOfLinesBefore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.textBoxNumberOfLinesBefore.Name = "textBoxNumberOfLinesBefore";
      this.textBoxNumberOfLinesBefore.Size = new System.Drawing.Size(86, 26);
      this.textBoxNumberOfLinesBefore.TabIndex = 11;
      this.textBoxNumberOfLinesBefore.Text = "1";
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
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
    private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
    private System.Windows.Forms.ProgressBar progressBarMain;
    private System.Windows.Forms.Label labelNumberOfLinesBefore;
    private System.Windows.Forms.TextBox textBoxNumberOfLinesBefore;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem FrenchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem EnglishToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
  }
}

