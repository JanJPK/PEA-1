namespace PEA_1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLoadData = new System.Windows.Forms.GroupBox();
            this.comboBoxLoadDataFilenames = new System.Windows.Forms.ComboBox();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonDisplayData = new System.Windows.Forms.Button();
            this.groupBoxSalesman = new System.Windows.Forms.GroupBox();
            this.buttonSalesmanAll = new System.Windows.Forms.Button();
            this.checkBoxSalesmanGenetic = new System.Windows.Forms.CheckBox();
            this.textBoxSalesmanGenetic = new System.Windows.Forms.TextBox();
            this.buttonSalesmanGenetic = new System.Windows.Forms.Button();
            this.textBoxSalesmanLocalSearch = new System.Windows.Forms.TextBox();
            this.checkBoxSalesmanLocalSearch = new System.Windows.Forms.CheckBox();
            this.checkBoxSalesmanBnB = new System.Windows.Forms.CheckBox();
            this.buttonSalesmanLocalSearch = new System.Windows.Forms.Button();
            this.textBoxSalesmanBnB = new System.Windows.Forms.TextBox();
            this.buttonSalesmanBnB = new System.Windows.Forms.Button();
            this.buttonSalesman = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageManual = new System.Windows.Forms.TabPage();
            this.tabPageAuto = new System.Windows.Forms.TabPage();
            this.buttonAutoStart = new System.Windows.Forms.Button();
            this.textBoxAutoProgress = new System.Windows.Forms.TextBox();
            this.textBoxAutoPlannedTests = new System.Windows.Forms.TextBox();
            this.buttonAutoAddTest = new System.Windows.Forms.Button();
            this.textBoxAutoTestData = new System.Windows.Forms.TextBox();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.groupBoxLoadData.SuspendLayout();
            this.groupBoxSalesman.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageManual.SuspendLayout();
            this.tabPageAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLoadData
            // 
            this.groupBoxLoadData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxLoadData.Controls.Add(this.comboBoxLoadDataFilenames);
            this.groupBoxLoadData.Controls.Add(this.buttonLoadData);
            this.groupBoxLoadData.Controls.Add(this.buttonDisplayData);
            this.groupBoxLoadData.Location = new System.Drawing.Point(6, 6);
            this.groupBoxLoadData.Name = "groupBoxLoadData";
            this.groupBoxLoadData.Size = new System.Drawing.Size(340, 82);
            this.groupBoxLoadData.TabIndex = 6;
            this.groupBoxLoadData.TabStop = false;
            this.groupBoxLoadData.Text = "Wczytywanie danych";
            // 
            // comboBoxLoadDataFilenames
            // 
            this.comboBoxLoadDataFilenames.FormattingEnabled = true;
            this.comboBoxLoadDataFilenames.Location = new System.Drawing.Point(6, 21);
            this.comboBoxLoadDataFilenames.Name = "comboBoxLoadDataFilenames";
            this.comboBoxLoadDataFilenames.Size = new System.Drawing.Size(106, 21);
            this.comboBoxLoadDataFilenames.TabIndex = 5;
            this.comboBoxLoadDataFilenames.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoadDataFilenames_SelectedIndexChanged);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(118, 19);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(70, 23);
            this.buttonLoadData.TabIndex = 4;
            this.buttonLoadData.Text = "Wczytaj";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonDisplayData
            // 
            this.buttonDisplayData.Location = new System.Drawing.Point(194, 19);
            this.buttonDisplayData.Name = "buttonDisplayData";
            this.buttonDisplayData.Size = new System.Drawing.Size(70, 23);
            this.buttonDisplayData.TabIndex = 0;
            this.buttonDisplayData.Text = "Wypisz";
            this.buttonDisplayData.UseVisualStyleBackColor = true;
            this.buttonDisplayData.Click += new System.EventHandler(this.buttonDisplayData_Click);
            // 
            // groupBoxSalesman
            // 
            this.groupBoxSalesman.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanAll);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanGenetic);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanGenetic);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanGenetic);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanLocalSearch);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanLocalSearch);
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanBnB);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanLocalSearch);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanBnB);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanBnB);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesman);
            this.groupBoxSalesman.Location = new System.Drawing.Point(6, 94);
            this.groupBoxSalesman.Name = "groupBoxSalesman";
            this.groupBoxSalesman.Size = new System.Drawing.Size(340, 211);
            this.groupBoxSalesman.TabIndex = 16;
            this.groupBoxSalesman.TabStop = false;
            this.groupBoxSalesman.Text = "Komiwojażer";
            // 
            // buttonSalesmanAll
            // 
            this.buttonSalesmanAll.Location = new System.Drawing.Point(225, 104);
            this.buttonSalesmanAll.Name = "buttonSalesmanAll";
            this.buttonSalesmanAll.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanAll.TabIndex = 21;
            this.buttonSalesmanAll.Text = "Wszystkie";
            this.buttonSalesmanAll.UseVisualStyleBackColor = true;
            this.buttonSalesmanAll.Click += new System.EventHandler(this.buttonSalesmanAll_Click);
            // 
            // checkBoxSalesmanGenetic
            // 
            this.checkBoxSalesmanGenetic.AutoSize = true;
            this.checkBoxSalesmanGenetic.Enabled = false;
            this.checkBoxSalesmanGenetic.Location = new System.Drawing.Point(12, 69);
            this.checkBoxSalesmanGenetic.Name = "checkBoxSalesmanGenetic";
            this.checkBoxSalesmanGenetic.Size = new System.Drawing.Size(63, 17);
            this.checkBoxSalesmanGenetic.TabIndex = 18;
            this.checkBoxSalesmanGenetic.Text = "Genetic";
            this.checkBoxSalesmanGenetic.UseVisualStyleBackColor = true;
            // 
            // textBoxSalesmanGenetic
            // 
            this.textBoxSalesmanGenetic.Enabled = false;
            this.textBoxSalesmanGenetic.Location = new System.Drawing.Point(132, 71);
            this.textBoxSalesmanGenetic.Name = "textBoxSalesmanGenetic";
            this.textBoxSalesmanGenetic.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanGenetic.TabIndex = 16;
            // 
            // buttonSalesmanGenetic
            // 
            this.buttonSalesmanGenetic.Enabled = false;
            this.buttonSalesmanGenetic.Location = new System.Drawing.Point(225, 69);
            this.buttonSalesmanGenetic.Name = "buttonSalesmanGenetic";
            this.buttonSalesmanGenetic.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanGenetic.TabIndex = 15;
            this.buttonSalesmanGenetic.Text = "Wypisz";
            this.buttonSalesmanGenetic.UseVisualStyleBackColor = true;
            this.buttonSalesmanGenetic.Click += new System.EventHandler(this.buttonSalesmanGenetic_Click);
            // 
            // textBoxSalesmanLocalSearch
            // 
            this.textBoxSalesmanLocalSearch.Enabled = false;
            this.textBoxSalesmanLocalSearch.Location = new System.Drawing.Point(132, 44);
            this.textBoxSalesmanLocalSearch.Name = "textBoxSalesmanLocalSearch";
            this.textBoxSalesmanLocalSearch.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanLocalSearch.TabIndex = 14;
            // 
            // checkBoxSalesmanLocalSearch
            // 
            this.checkBoxSalesmanLocalSearch.AutoSize = true;
            this.checkBoxSalesmanLocalSearch.Enabled = false;
            this.checkBoxSalesmanLocalSearch.Location = new System.Drawing.Point(12, 42);
            this.checkBoxSalesmanLocalSearch.Name = "checkBoxSalesmanLocalSearch";
            this.checkBoxSalesmanLocalSearch.Size = new System.Drawing.Size(89, 17);
            this.checkBoxSalesmanLocalSearch.TabIndex = 13;
            this.checkBoxSalesmanLocalSearch.Text = "Local Search";
            this.checkBoxSalesmanLocalSearch.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalesmanBnB
            // 
            this.checkBoxSalesmanBnB.AutoSize = true;
            this.checkBoxSalesmanBnB.Location = new System.Drawing.Point(12, 16);
            this.checkBoxSalesmanBnB.Name = "checkBoxSalesmanBnB";
            this.checkBoxSalesmanBnB.Size = new System.Drawing.Size(40, 17);
            this.checkBoxSalesmanBnB.TabIndex = 12;
            this.checkBoxSalesmanBnB.Text = "B&B";
            this.checkBoxSalesmanBnB.UseVisualStyleBackColor = true;
            // 
            // buttonSalesmanLocalSearch
            // 
            this.buttonSalesmanLocalSearch.Enabled = false;
            this.buttonSalesmanLocalSearch.Location = new System.Drawing.Point(225, 42);
            this.buttonSalesmanLocalSearch.Name = "buttonSalesmanLocalSearch";
            this.buttonSalesmanLocalSearch.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanLocalSearch.TabIndex = 11;
            this.buttonSalesmanLocalSearch.Text = "Wypisz";
            this.buttonSalesmanLocalSearch.UseVisualStyleBackColor = true;
            this.buttonSalesmanLocalSearch.Click += new System.EventHandler(this.buttonSalesmanLocalSearch_Click);
            // 
            // textBoxSalesmanBnB
            // 
            this.textBoxSalesmanBnB.Location = new System.Drawing.Point(132, 18);
            this.textBoxSalesmanBnB.Name = "textBoxSalesmanBnB";
            this.textBoxSalesmanBnB.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanBnB.TabIndex = 10;
            // 
            // buttonSalesmanBnB
            // 
            this.buttonSalesmanBnB.Location = new System.Drawing.Point(225, 16);
            this.buttonSalesmanBnB.Name = "buttonSalesmanBnB";
            this.buttonSalesmanBnB.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanBnB.TabIndex = 6;
            this.buttonSalesmanBnB.Text = "Wypisz";
            this.buttonSalesmanBnB.UseVisualStyleBackColor = true;
            this.buttonSalesmanBnB.Click += new System.EventHandler(this.buttonSalesmanBnB_Click);
            // 
            // buttonSalesman
            // 
            this.buttonSalesman.Location = new System.Drawing.Point(6, 104);
            this.buttonSalesman.Name = "buttonSalesman";
            this.buttonSalesman.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesman.TabIndex = 4;
            this.buttonSalesman.Text = "Start";
            this.buttonSalesman.UseVisualStyleBackColor = true;
            this.buttonSalesman.Click += new System.EventHandler(this.buttonSalesman_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageManual);
            this.tabControlMain.Controls.Add(this.tabPageAuto);
            this.tabControlMain.Controls.Add(this.tabPageDebug);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(360, 337);
            this.tabControlMain.TabIndex = 20;
            // 
            // tabPageManual
            // 
            this.tabPageManual.Controls.Add(this.groupBoxLoadData);
            this.tabPageManual.Controls.Add(this.groupBoxSalesman);
            this.tabPageManual.Location = new System.Drawing.Point(4, 22);
            this.tabPageManual.Name = "tabPageManual";
            this.tabPageManual.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManual.Size = new System.Drawing.Size(352, 311);
            this.tabPageManual.TabIndex = 0;
            this.tabPageManual.Text = "Manual";
            this.tabPageManual.UseVisualStyleBackColor = true;
            // 
            // tabPageAuto
            // 
            this.tabPageAuto.Controls.Add(this.buttonAutoStart);
            this.tabPageAuto.Controls.Add(this.textBoxAutoProgress);
            this.tabPageAuto.Controls.Add(this.textBoxAutoPlannedTests);
            this.tabPageAuto.Controls.Add(this.buttonAutoAddTest);
            this.tabPageAuto.Controls.Add(this.textBoxAutoTestData);
            this.tabPageAuto.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuto.Name = "tabPageAuto";
            this.tabPageAuto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuto.Size = new System.Drawing.Size(352, 311);
            this.tabPageAuto.TabIndex = 1;
            this.tabPageAuto.Text = "Auto";
            this.tabPageAuto.UseVisualStyleBackColor = true;
            // 
            // buttonAutoStart
            // 
            this.buttonAutoStart.Location = new System.Drawing.Point(290, 6);
            this.buttonAutoStart.Name = "buttonAutoStart";
            this.buttonAutoStart.Size = new System.Drawing.Size(56, 20);
            this.buttonAutoStart.TabIndex = 4;
            this.buttonAutoStart.Text = "START";
            this.buttonAutoStart.UseVisualStyleBackColor = true;
            this.buttonAutoStart.Click += new System.EventHandler(this.buttonAutoStart_Click);
            // 
            // textBoxAutoProgress
            // 
            this.textBoxAutoProgress.Location = new System.Drawing.Point(6, 285);
            this.textBoxAutoProgress.Name = "textBoxAutoProgress";
            this.textBoxAutoProgress.Size = new System.Drawing.Size(340, 20);
            this.textBoxAutoProgress.TabIndex = 3;
            // 
            // textBoxAutoPlannedTests
            // 
            this.textBoxAutoPlannedTests.Location = new System.Drawing.Point(6, 32);
            this.textBoxAutoPlannedTests.Multiline = true;
            this.textBoxAutoPlannedTests.Name = "textBoxAutoPlannedTests";
            this.textBoxAutoPlannedTests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAutoPlannedTests.Size = new System.Drawing.Size(340, 247);
            this.textBoxAutoPlannedTests.TabIndex = 2;
            // 
            // buttonAutoAddTest
            // 
            this.buttonAutoAddTest.Location = new System.Drawing.Point(242, 6);
            this.buttonAutoAddTest.Name = "buttonAutoAddTest";
            this.buttonAutoAddTest.Size = new System.Drawing.Size(42, 20);
            this.buttonAutoAddTest.TabIndex = 1;
            this.buttonAutoAddTest.Text = "OK";
            this.buttonAutoAddTest.UseVisualStyleBackColor = true;
            this.buttonAutoAddTest.Click += new System.EventHandler(this.buttonAutoAddTest_Click);
            // 
            // textBoxAutoTestData
            // 
            this.textBoxAutoTestData.Location = new System.Drawing.Point(6, 6);
            this.textBoxAutoTestData.Name = "textBoxAutoTestData";
            this.textBoxAutoTestData.Size = new System.Drawing.Size(230, 20);
            this.textBoxAutoTestData.TabIndex = 0;
            // 
            // tabPageDebug
            // 
            this.tabPageDebug.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebug.Size = new System.Drawing.Size(352, 311);
            this.tabPageDebug.TabIndex = 2;
            this.tabPageDebug.Text = "Debug";
            this.tabPageDebug.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Okno główne";
            this.groupBoxLoadData.ResumeLayout(false);
            this.groupBoxSalesman.ResumeLayout(false);
            this.groupBoxSalesman.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageManual.ResumeLayout(false);
            this.tabPageAuto.ResumeLayout(false);
            this.tabPageAuto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLoadData;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonDisplayData;
        private System.Windows.Forms.GroupBox groupBoxSalesman;
        private System.Windows.Forms.Button buttonSalesmanAll;
        private System.Windows.Forms.CheckBox checkBoxSalesmanGenetic;
        private System.Windows.Forms.TextBox textBoxSalesmanGenetic;
        private System.Windows.Forms.Button buttonSalesmanGenetic;
        private System.Windows.Forms.TextBox textBoxSalesmanLocalSearch;
        private System.Windows.Forms.CheckBox checkBoxSalesmanLocalSearch;
        private System.Windows.Forms.CheckBox checkBoxSalesmanBnB;
        private System.Windows.Forms.Button buttonSalesmanLocalSearch;
        private System.Windows.Forms.TextBox textBoxSalesmanBnB;
        private System.Windows.Forms.Button buttonSalesmanBnB;
        private System.Windows.Forms.Button buttonSalesman;
        private System.Windows.Forms.ComboBox comboBoxLoadDataFilenames;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageManual;
        private System.Windows.Forms.TabPage tabPageAuto;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.TextBox textBoxAutoProgress;
        private System.Windows.Forms.TextBox textBoxAutoPlannedTests;
        private System.Windows.Forms.Button buttonAutoAddTest;
        private System.Windows.Forms.TextBox textBoxAutoTestData;
        private System.Windows.Forms.Button buttonAutoStart;
    }
}

