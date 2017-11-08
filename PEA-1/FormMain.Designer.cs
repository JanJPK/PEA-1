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
            this.labelMatrix = new System.Windows.Forms.Label();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonDisplayData = new System.Windows.Forms.Button();
            this.textBoxLoadDataFilename = new System.Windows.Forms.TextBox();
            this.groupBoxSalesman = new System.Windows.Forms.GroupBox();
            this.buttonSalesmanAll = new System.Windows.Forms.Button();
            this.checkBoxSalesmanGenetic = new System.Windows.Forms.CheckBox();
            this.textBoxSalesmanGenetic = new System.Windows.Forms.TextBox();
            this.buttonSalesmanGenetic = new System.Windows.Forms.Button();
            this.textBoxSalesmanLocalSearch = new System.Windows.Forms.TextBox();
            this.checkBoxSalesmanLocalSearch = new System.Windows.Forms.CheckBox();
            this.checkBoxSalesmanDynamic = new System.Windows.Forms.CheckBox();
            this.buttonSalesmanLocalSearch = new System.Windows.Forms.Button();
            this.textBoxSalesmanDynamic = new System.Windows.Forms.TextBox();
            this.buttonSalesmanDynamic = new System.Windows.Forms.Button();
            this.buttonSalesman = new System.Windows.Forms.Button();
            this.groupBoxRepeat = new System.Windows.Forms.GroupBox();
            this.textBoxRepeatNew = new System.Windows.Forms.TextBox();
            this.textBoxRepeatCurrent = new System.Windows.Forms.TextBox();
            this.buttonRepeatChange = new System.Windows.Forms.Button();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.textBoxDataGeneratorSize = new System.Windows.Forms.TextBox();
            this.buttonDataGenerator = new System.Windows.Forms.Button();
            this.groupBoxLoadData.SuspendLayout();
            this.groupBoxSalesman.SuspendLayout();
            this.groupBoxRepeat.SuspendLayout();
            this.groupBoxCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLoadData
            // 
            this.groupBoxLoadData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxLoadData.Controls.Add(this.labelMatrix);
            this.groupBoxLoadData.Controls.Add(this.buttonLoadData);
            this.groupBoxLoadData.Controls.Add(this.buttonDisplayData);
            this.groupBoxLoadData.Controls.Add(this.textBoxLoadDataFilename);
            this.groupBoxLoadData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLoadData.Name = "groupBoxLoadData";
            this.groupBoxLoadData.Size = new System.Drawing.Size(304, 82);
            this.groupBoxLoadData.TabIndex = 6;
            this.groupBoxLoadData.TabStop = false;
            this.groupBoxLoadData.Text = "Wczytywanie danych";
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Location = new System.Drawing.Point(15, 52);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(84, 13);
            this.labelMatrix.TabIndex = 2;
            this.labelMatrix.Text = "Podgląd danych";
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
            this.buttonDisplayData.Location = new System.Drawing.Point(118, 47);
            this.buttonDisplayData.Name = "buttonDisplayData";
            this.buttonDisplayData.Size = new System.Drawing.Size(70, 23);
            this.buttonDisplayData.TabIndex = 0;
            this.buttonDisplayData.Text = "Wypisz";
            this.buttonDisplayData.UseVisualStyleBackColor = true;
            this.buttonDisplayData.Click += new System.EventHandler(this.buttonDisplayData_Click);
            // 
            // textBoxLoadDataFilename
            // 
            this.textBoxLoadDataFilename.Location = new System.Drawing.Point(6, 19);
            this.textBoxLoadDataFilename.Name = "textBoxLoadDataFilename";
            this.textBoxLoadDataFilename.Size = new System.Drawing.Size(106, 20);
            this.textBoxLoadDataFilename.TabIndex = 0;
            this.textBoxLoadDataFilename.TextChanged += new System.EventHandler(this.textBoxLoadDataFilename_TextChanged);
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
            this.groupBoxSalesman.Controls.Add(this.checkBoxSalesmanDynamic);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanLocalSearch);
            this.groupBoxSalesman.Controls.Add(this.textBoxSalesmanDynamic);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesmanDynamic);
            this.groupBoxSalesman.Controls.Add(this.buttonSalesman);
            this.groupBoxSalesman.Location = new System.Drawing.Point(12, 100);
            this.groupBoxSalesman.Name = "groupBoxSalesman";
            this.groupBoxSalesman.Size = new System.Drawing.Size(304, 133);
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
            // checkBoxSalesmanDynamic
            // 
            this.checkBoxSalesmanDynamic.AutoSize = true;
            this.checkBoxSalesmanDynamic.Location = new System.Drawing.Point(12, 16);
            this.checkBoxSalesmanDynamic.Name = "checkBoxSalesmanDynamic";
            this.checkBoxSalesmanDynamic.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSalesmanDynamic.TabIndex = 12;
            this.checkBoxSalesmanDynamic.Text = "Dynamic";
            this.checkBoxSalesmanDynamic.UseVisualStyleBackColor = true;
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
            // textBoxSalesmanDynamic
            // 
            this.textBoxSalesmanDynamic.Location = new System.Drawing.Point(132, 18);
            this.textBoxSalesmanDynamic.Name = "textBoxSalesmanDynamic";
            this.textBoxSalesmanDynamic.Size = new System.Drawing.Size(90, 20);
            this.textBoxSalesmanDynamic.TabIndex = 10;
            // 
            // buttonSalesmanDynamic
            // 
            this.buttonSalesmanDynamic.Location = new System.Drawing.Point(225, 16);
            this.buttonSalesmanDynamic.Name = "buttonSalesmanDynamic";
            this.buttonSalesmanDynamic.Size = new System.Drawing.Size(70, 23);
            this.buttonSalesmanDynamic.TabIndex = 6;
            this.buttonSalesmanDynamic.Text = "Wypisz";
            this.buttonSalesmanDynamic.UseVisualStyleBackColor = true;
            this.buttonSalesmanDynamic.Click += new System.EventHandler(this.buttonSalesmanDynamic_Click);
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
            // groupBoxRepeat
            // 
            this.groupBoxRepeat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxRepeat.Controls.Add(this.textBoxRepeatNew);
            this.groupBoxRepeat.Controls.Add(this.textBoxRepeatCurrent);
            this.groupBoxRepeat.Controls.Add(this.buttonRepeatChange);
            this.groupBoxRepeat.Location = new System.Drawing.Point(12, 327);
            this.groupBoxRepeat.Name = "groupBoxRepeat";
            this.groupBoxRepeat.Size = new System.Drawing.Size(304, 51);
            this.groupBoxRepeat.TabIndex = 19;
            this.groupBoxRepeat.TabStop = false;
            this.groupBoxRepeat.Text = "Mnożnik";
            // 
            // textBoxRepeatNew
            // 
            this.textBoxRepeatNew.Location = new System.Drawing.Point(82, 19);
            this.textBoxRepeatNew.Name = "textBoxRepeatNew";
            this.textBoxRepeatNew.Size = new System.Drawing.Size(70, 20);
            this.textBoxRepeatNew.TabIndex = 16;
            // 
            // textBoxRepeatCurrent
            // 
            this.textBoxRepeatCurrent.Location = new System.Drawing.Point(6, 19);
            this.textBoxRepeatCurrent.Name = "textBoxRepeatCurrent";
            this.textBoxRepeatCurrent.ReadOnly = true;
            this.textBoxRepeatCurrent.Size = new System.Drawing.Size(70, 20);
            this.textBoxRepeatCurrent.TabIndex = 15;
            // 
            // buttonRepeatChange
            // 
            this.buttonRepeatChange.Location = new System.Drawing.Point(157, 19);
            this.buttonRepeatChange.Name = "buttonRepeatChange";
            this.buttonRepeatChange.Size = new System.Drawing.Size(70, 23);
            this.buttonRepeatChange.TabIndex = 4;
            this.buttonRepeatChange.Text = "Zmień";
            this.buttonRepeatChange.UseVisualStyleBackColor = true;
            this.buttonRepeatChange.Click += new System.EventHandler(this.buttonRepeatChange_Click);
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxCreate.Controls.Add(this.textBoxDataGeneratorSize);
            this.groupBoxCreate.Controls.Add(this.buttonDataGenerator);
            this.groupBoxCreate.Location = new System.Drawing.Point(12, 239);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(304, 82);
            this.groupBoxCreate.TabIndex = 18;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Tworzenie danych";
            // 
            // textBoxDataGeneratorSize
            // 
            this.textBoxDataGeneratorSize.Location = new System.Drawing.Point(6, 19);
            this.textBoxDataGeneratorSize.Name = "textBoxDataGeneratorSize";
            this.textBoxDataGeneratorSize.Size = new System.Drawing.Size(70, 20);
            this.textBoxDataGeneratorSize.TabIndex = 15;
            // 
            // buttonDataGenerator
            // 
            this.buttonDataGenerator.Location = new System.Drawing.Point(6, 45);
            this.buttonDataGenerator.Name = "buttonDataGenerator";
            this.buttonDataGenerator.Size = new System.Drawing.Size(70, 23);
            this.buttonDataGenerator.TabIndex = 4;
            this.buttonDataGenerator.Text = "Twórz";
            this.buttonDataGenerator.UseVisualStyleBackColor = true;
            this.buttonDataGenerator.Click += new System.EventHandler(this.buttonDataGenerator_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 392);
            this.Controls.Add(this.groupBoxRepeat);
            this.Controls.Add(this.groupBoxCreate);
            this.Controls.Add(this.groupBoxSalesman);
            this.Controls.Add(this.groupBoxLoadData);
            this.Name = "FormMain";
            this.Text = "Okno główne";
            this.groupBoxLoadData.ResumeLayout(false);
            this.groupBoxLoadData.PerformLayout();
            this.groupBoxSalesman.ResumeLayout(false);
            this.groupBoxSalesman.PerformLayout();
            this.groupBoxRepeat.ResumeLayout(false);
            this.groupBoxRepeat.PerformLayout();
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLoadData;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonDisplayData;
        private System.Windows.Forms.TextBox textBoxLoadDataFilename;
        private System.Windows.Forms.GroupBox groupBoxSalesman;
        private System.Windows.Forms.Button buttonSalesmanAll;
        private System.Windows.Forms.CheckBox checkBoxSalesmanGenetic;
        private System.Windows.Forms.TextBox textBoxSalesmanGenetic;
        private System.Windows.Forms.Button buttonSalesmanGenetic;
        private System.Windows.Forms.TextBox textBoxSalesmanLocalSearch;
        private System.Windows.Forms.CheckBox checkBoxSalesmanLocalSearch;
        private System.Windows.Forms.CheckBox checkBoxSalesmanDynamic;
        private System.Windows.Forms.Button buttonSalesmanLocalSearch;
        private System.Windows.Forms.TextBox textBoxSalesmanDynamic;
        private System.Windows.Forms.Button buttonSalesmanDynamic;
        private System.Windows.Forms.Button buttonSalesman;
        private System.Windows.Forms.GroupBox groupBoxRepeat;
        private System.Windows.Forms.TextBox textBoxRepeatNew;
        private System.Windows.Forms.TextBox textBoxRepeatCurrent;
        private System.Windows.Forms.Button buttonRepeatChange;
        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.TextBox textBoxDataGeneratorSize;
        private System.Windows.Forms.Button buttonDataGenerator;
    }
}

