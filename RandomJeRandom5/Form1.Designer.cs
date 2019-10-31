namespace RandomJeRandom_2
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nováStatistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUlozit = new System.Windows.Forms.ToolStripMenuItem();
            this.UlozitDoCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.UlozitDoDOC = new System.Windows.Forms.ToolStripMenuItem();
            this.UlozitDoTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novinkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDecRight = new System.Windows.Forms.Panel();
            this.lblNum6 = new System.Windows.Forms.Label();
            this.lblNum5 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.graf6 = new System.Windows.Forms.ProgressBar();
            this.graf5 = new System.Windows.Forms.ProgressBar();
            this.graf4 = new System.Windows.Forms.ProgressBar();
            this.graf3 = new System.Windows.Forms.ProgressBar();
            this.graf2 = new System.Windows.Forms.ProgressBar();
            this.graf1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.svFl = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.pnlDecRight.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripMenuItem,
            this.oProgramuToolStripMenuItem,
            this.novinkyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novýToolStripMenuItem
            // 
            this.novýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nováStatistikaToolStripMenuItem,
            this.MenuUlozit});
            this.novýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.novýToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.novýToolStripMenuItem.Name = "novýToolStripMenuItem";
            this.novýToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.novýToolStripMenuItem.Text = "Menu";
            // 
            // nováStatistikaToolStripMenuItem
            // 
            this.nováStatistikaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nováStatistikaToolStripMenuItem.Name = "nováStatistikaToolStripMenuItem";
            this.nováStatistikaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nováStatistikaToolStripMenuItem.Text = "Nová statistika";
            this.nováStatistikaToolStripMenuItem.Click += new System.EventHandler(this.NováStatistikaToolStripMenuItem_Click);
            // 
            // MenuUlozit
            // 
            this.MenuUlozit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UlozitDoCSV,
            this.UlozitDoDOC,
            this.UlozitDoTXT});
            this.MenuUlozit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MenuUlozit.Name = "MenuUlozit";
            this.MenuUlozit.Size = new System.Drawing.Size(224, 26);
            this.MenuUlozit.Text = "Uložit";
            // 
            // UlozitDoCSV
            // 
            this.UlozitDoCSV.Name = "UlozitDoCSV";
            this.UlozitDoCSV.Size = new System.Drawing.Size(224, 26);
            this.UlozitDoCSV.Text = "Do .csv";
            this.UlozitDoCSV.Click += new System.EventHandler(this.DoexclsToolStripMenuItem_Click);
            // 
            // UlozitDoDOC
            // 
            this.UlozitDoDOC.Name = "UlozitDoDOC";
            this.UlozitDoDOC.Size = new System.Drawing.Size(224, 26);
            this.UlozitDoDOC.Text = "Do .doc";
            this.UlozitDoDOC.Click += new System.EventHandler(this.MenuConvertTOdoc_Click);
            // 
            // UlozitDoTXT
            // 
            this.UlozitDoTXT.Name = "UlozitDoTXT";
            this.UlozitDoTXT.Size = new System.Drawing.Size(224, 26);
            this.UlozitDoTXT.Text = "Do .txt";
            this.UlozitDoTXT.Click += new System.EventHandler(this.MenuConvertTOtxt_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem,
            this.informaceToolStripMenuItem});
            this.oProgramuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.PomocToolStripMenuItem_Click_1);
            // 
            // informaceToolStripMenuItem
            // 
            this.informaceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.informaceToolStripMenuItem.Name = "informaceToolStripMenuItem";
            this.informaceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.informaceToolStripMenuItem.Text = "Informace";
            this.informaceToolStripMenuItem.Click += new System.EventHandler(this.InformaceToolStripMenuItem_Click_1);
            // 
            // novinkyToolStripMenuItem
            // 
            this.novinkyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.novinkyToolStripMenuItem.Name = "novinkyToolStripMenuItem";
            this.novinkyToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.novinkyToolStripMenuItem.Text = "Novinky";
            this.novinkyToolStripMenuItem.Click += new System.EventHandler(this.NovinkyToolStripMenuItem_Click);
            // 
            // pnlDecRight
            // 
            this.pnlDecRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.pnlDecRight.Controls.Add(this.lblNum6);
            this.pnlDecRight.Controls.Add(this.lblNum5);
            this.pnlDecRight.Controls.Add(this.lblNum4);
            this.pnlDecRight.Controls.Add(this.lblNum3);
            this.pnlDecRight.Controls.Add(this.lblNum2);
            this.pnlDecRight.Controls.Add(this.lblNum1);
            this.pnlDecRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDecRight.Location = new System.Drawing.Point(0, 33);
            this.pnlDecRight.Name = "pnlDecRight";
            this.pnlDecRight.Size = new System.Drawing.Size(147, 406);
            this.pnlDecRight.TabIndex = 1;
            // 
            // lblNum6
            // 
            this.lblNum6.AutoSize = true;
            this.lblNum6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum6.Location = new System.Drawing.Point(12, 306);
            this.lblNum6.Name = "lblNum6";
            this.lblNum6.Size = new System.Drawing.Size(65, 32);
            this.lblNum6.TabIndex = 5;
            this.lblNum6.Text = "6 - 0";
            // 
            // lblNum5
            // 
            this.lblNum5.AutoSize = true;
            this.lblNum5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum5.Location = new System.Drawing.Point(12, 250);
            this.lblNum5.Name = "lblNum5";
            this.lblNum5.Size = new System.Drawing.Size(65, 32);
            this.lblNum5.TabIndex = 4;
            this.lblNum5.Text = "5 - 0";
            // 
            // lblNum4
            // 
            this.lblNum4.AutoSize = true;
            this.lblNum4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum4.Location = new System.Drawing.Point(12, 194);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(66, 32);
            this.lblNum4.TabIndex = 3;
            this.lblNum4.Text = "4 - 0";
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum3.Location = new System.Drawing.Point(12, 138);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(65, 32);
            this.lblNum3.TabIndex = 2;
            this.lblNum3.Text = "3 - 0";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum2.Location = new System.Drawing.Point(12, 82);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(65, 32);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "2 - 0";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum1.Location = new System.Drawing.Point(12, 26);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(62, 32);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "1 - 0";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMax.Location = new System.Drawing.Point(6, 5);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(0, 32);
            this.lblMax.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(147, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 406);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(148)))), ((int)(((byte)(178)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(150, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 406);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.graf6);
            this.panel4.Controls.Add(this.graf5);
            this.panel4.Controls.Add(this.graf4);
            this.panel4.Controls.Add(this.graf3);
            this.panel4.Controls.Add(this.graf2);
            this.panel4.Controls.Add(this.graf1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(632, 363);
            this.panel4.TabIndex = 10;
            // 
            // graf6
            // 
            this.graf6.Location = new System.Drawing.Point(12, 306);
            this.graf6.Name = "graf6";
            this.graf6.Size = new System.Drawing.Size(567, 32);
            this.graf6.TabIndex = 5;
            // 
            // graf5
            // 
            this.graf5.Location = new System.Drawing.Point(12, 250);
            this.graf5.Name = "graf5";
            this.graf5.Size = new System.Drawing.Size(567, 32);
            this.graf5.TabIndex = 4;
            // 
            // graf4
            // 
            this.graf4.Location = new System.Drawing.Point(12, 194);
            this.graf4.Name = "graf4";
            this.graf4.Size = new System.Drawing.Size(567, 32);
            this.graf4.TabIndex = 3;
            // 
            // graf3
            // 
            this.graf3.Location = new System.Drawing.Point(12, 138);
            this.graf3.Name = "graf3";
            this.graf3.Size = new System.Drawing.Size(567, 32);
            this.graf3.TabIndex = 2;
            // 
            // graf2
            // 
            this.graf2.Location = new System.Drawing.Point(12, 82);
            this.graf2.Name = "graf2";
            this.graf2.Size = new System.Drawing.Size(567, 32);
            this.graf2.TabIndex = 1;
            // 
            // graf1
            // 
            this.graf1.Location = new System.Drawing.Point(12, 26);
            this.graf1.Name = "graf1";
            this.graf1.Size = new System.Drawing.Size(567, 32);
            this.graf1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.lblMax);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 43);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(782, 439);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDecRight);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola náhody";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDecRight.ResumeLayout(false);
            this.pnlDecRight.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nováStatistikaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDecRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNum6;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar graf6;
        private System.Windows.Forms.ProgressBar graf5;
        private System.Windows.Forms.ProgressBar graf4;
        private System.Windows.Forms.ProgressBar graf3;
        private System.Windows.Forms.ProgressBar graf2;
        private System.Windows.Forms.ProgressBar graf1;
        private System.Windows.Forms.ToolStripMenuItem MenuUlozit;
        private System.Windows.Forms.ToolStripMenuItem UlozitDoCSV;
        private System.Windows.Forms.ToolStripMenuItem UlozitDoDOC;
        private System.Windows.Forms.ToolStripMenuItem UlozitDoTXT;
        private System.Windows.Forms.SaveFileDialog svFl;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novinkyToolStripMenuItem;
    }
}

