namespace KomisSamochodowy
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxKolor = new System.Windows.Forms.ComboBox();
            this.comboBoxSilnik = new System.Windows.Forms.ComboBox();
            this.checkBoxMetalic = new System.Windows.Forms.CheckBox();
            this.checkBoxKlima = new System.Windows.Forms.CheckBox();
            this.checkBoxAlarm = new System.Windows.Forms.CheckBox();
            this.pictureBoxSamochod = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSamochod)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.usunToolStripMenuItem,
            this.koniecToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // usunToolStripMenuItem
            // 
            this.usunToolStripMenuItem.Name = "usunToolStripMenuItem";
            this.usunToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.usunToolStripMenuItem.Text = "Usun";
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kolor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Silnik:";
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Location = new System.Drawing.Point(74, 68);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(165, 21);
            this.comboBoxMarka.TabIndex = 5;
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(74, 97);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(165, 21);
            this.comboBoxModel.TabIndex = 6;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // comboBoxKolor
            // 
            this.comboBoxKolor.FormattingEnabled = true;
            this.comboBoxKolor.Location = new System.Drawing.Point(74, 154);
            this.comboBoxKolor.Name = "comboBoxKolor";
            this.comboBoxKolor.Size = new System.Drawing.Size(165, 21);
            this.comboBoxKolor.TabIndex = 7;
            this.comboBoxKolor.SelectedIndexChanged += new System.EventHandler(this.comboBoxKolor_SelectedIndexChanged);
            // 
            // comboBoxSilnik
            // 
            this.comboBoxSilnik.FormattingEnabled = true;
            this.comboBoxSilnik.Location = new System.Drawing.Point(74, 127);
            this.comboBoxSilnik.Name = "comboBoxSilnik";
            this.comboBoxSilnik.Size = new System.Drawing.Size(165, 21);
            this.comboBoxSilnik.TabIndex = 8;
            this.comboBoxSilnik.SelectedIndexChanged += new System.EventHandler(this.comboBoxSilnik_SelectedIndexChanged);
            // 
            // checkBoxMetalic
            // 
            this.checkBoxMetalic.AutoSize = true;
            this.checkBoxMetalic.Location = new System.Drawing.Point(74, 182);
            this.checkBoxMetalic.Name = "checkBoxMetalic";
            this.checkBoxMetalic.Size = new System.Drawing.Size(60, 17);
            this.checkBoxMetalic.TabIndex = 9;
            this.checkBoxMetalic.Text = "Metalic";
            this.checkBoxMetalic.UseVisualStyleBackColor = true;
            this.checkBoxMetalic.CheckStateChanged += new System.EventHandler(this.checkBoxMetalic_CheckStateChanged);
            // 
            // checkBoxKlima
            // 
            this.checkBoxKlima.AutoSize = true;
            this.checkBoxKlima.Location = new System.Drawing.Point(74, 205);
            this.checkBoxKlima.Name = "checkBoxKlima";
            this.checkBoxKlima.Size = new System.Drawing.Size(84, 17);
            this.checkBoxKlima.TabIndex = 10;
            this.checkBoxKlima.Text = "Klimatyzacja";
            this.checkBoxKlima.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlarm
            // 
            this.checkBoxAlarm.AutoSize = true;
            this.checkBoxAlarm.Location = new System.Drawing.Point(74, 228);
            this.checkBoxAlarm.Name = "checkBoxAlarm";
            this.checkBoxAlarm.Size = new System.Drawing.Size(52, 17);
            this.checkBoxAlarm.TabIndex = 11;
            this.checkBoxAlarm.Text = "Alarm";
            this.checkBoxAlarm.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSamochod
            // 
            this.pictureBoxSamochod.Location = new System.Drawing.Point(260, 68);
            this.pictureBoxSamochod.Name = "pictureBoxSamochod";
            this.pictureBoxSamochod.Size = new System.Drawing.Size(387, 259);
            this.pictureBoxSamochod.TabIndex = 12;
            this.pictureBoxSamochod.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 397);
            this.Controls.Add(this.pictureBoxSamochod);
            this.Controls.Add(this.checkBoxAlarm);
            this.Controls.Add(this.checkBoxKlima);
            this.Controls.Add(this.checkBoxMetalic);
            this.Controls.Add(this.comboBoxSilnik);
            this.Controls.Add(this.comboBoxKolor);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Komis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSamochod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxKolor;
        private System.Windows.Forms.ComboBox comboBoxSilnik;
        private System.Windows.Forms.CheckBox checkBoxMetalic;
        private System.Windows.Forms.CheckBox checkBoxKlima;
        private System.Windows.Forms.CheckBox checkBoxAlarm;
        private System.Windows.Forms.PictureBox pictureBoxSamochod;
    }
}

