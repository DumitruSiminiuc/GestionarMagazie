namespace GestionareMagazie
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            buttonProduse = new Button();
            buttonCutii = new Button();
            buttonClienti = new Button();
            buttonLivrari = new Button();
            buttonLocatii = new Button();
            buttonStoc = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItemData = new ToolStripMenuItem();
            toolStripMenuItemExportExcel = new ToolStripMenuItem();
            toolStripMenuItemExportCsv = new ToolStripMenuItem();
            toolStripMenuItemEnviroment = new ToolStripMenuItem();
            toolStripMenuItemTheme = new ToolStripMenuItem();
            toolStripMenuItemDarkTheme = new ToolStripMenuItem();
            toolStripMenuItemLightTheme = new ToolStripMenuItem();
            toolStripMenuItemBlueTheme = new ToolStripMenuItem();
            toolStripMenuItemInsert = new ToolStripMenuItem();
            produsToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            locatieToolStripMenuItem = new ToolStripMenuItem();
            livrareToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(286, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(824, 509);
            dataGridView1.TabIndex = 0;
            // 
            // buttonProduse
            // 
            buttonProduse.Location = new Point(21, 67);
            buttonProduse.Name = "buttonProduse";
            buttonProduse.Size = new Size(156, 36);
            buttonProduse.TabIndex = 1;
            buttonProduse.Text = "Produse";
            buttonProduse.UseVisualStyleBackColor = true;
            buttonProduse.Click += button1_Click;
            // 
            // buttonCutii
            // 
            buttonCutii.Location = new Point(22, 121);
            buttonCutii.Name = "buttonCutii";
            buttonCutii.Size = new Size(153, 35);
            buttonCutii.TabIndex = 2;
            buttonCutii.Text = "Cutii";
            buttonCutii.UseVisualStyleBackColor = true;
            buttonCutii.Click += buttonCutii_Click;
            // 
            // buttonClienti
            // 
            buttonClienti.Location = new Point(21, 176);
            buttonClienti.Name = "buttonClienti";
            buttonClienti.Size = new Size(154, 34);
            buttonClienti.TabIndex = 3;
            buttonClienti.Text = "Clienti";
            buttonClienti.UseVisualStyleBackColor = true;
            buttonClienti.Click += buttonClienti_Click;
            // 
            // buttonLivrari
            // 
            buttonLivrari.Location = new Point(21, 230);
            buttonLivrari.Name = "buttonLivrari";
            buttonLivrari.Size = new Size(153, 33);
            buttonLivrari.TabIndex = 4;
            buttonLivrari.Text = "Livrari";
            buttonLivrari.UseVisualStyleBackColor = true;
            buttonLivrari.Click += buttonLivrari_Click;
            // 
            // buttonLocatii
            // 
            buttonLocatii.Location = new Point(21, 284);
            buttonLocatii.Name = "buttonLocatii";
            buttonLocatii.Size = new Size(156, 36);
            buttonLocatii.TabIndex = 5;
            buttonLocatii.Text = "Locatii";
            buttonLocatii.UseVisualStyleBackColor = true;
            buttonLocatii.Click += buttonLocatii_Click;
            // 
            // buttonStoc
            // 
            buttonStoc.Location = new Point(21, 336);
            buttonStoc.Name = "buttonStoc";
            buttonStoc.Size = new Size(154, 38);
            buttonStoc.TabIndex = 6;
            buttonStoc.Text = "Stoc";
            buttonStoc.UseVisualStyleBackColor = true;
            buttonStoc.Click += buttonStoc_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemData, toolStripMenuItemEnviroment, toolStripMenuItemInsert });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemData
            // 
            toolStripMenuItemData.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemExportExcel, toolStripMenuItemExportCsv });
            toolStripMenuItemData.Name = "toolStripMenuItemData";
            toolStripMenuItemData.Size = new Size(43, 20);
            toolStripMenuItemData.Text = "Data";
            // 
            // toolStripMenuItemExportExcel
            // 
            toolStripMenuItemExportExcel.Name = "toolStripMenuItemExportExcel";
            toolStripMenuItemExportExcel.Size = new Size(135, 22);
            toolStripMenuItemExportExcel.Text = "Export XML";
            toolStripMenuItemExportExcel.Click += toolStripMenuItemExportExcel_Click;
            // 
            // toolStripMenuItemExportCsv
            // 
            toolStripMenuItemExportCsv.Name = "toolStripMenuItemExportCsv";
            toolStripMenuItemExportCsv.Size = new Size(135, 22);
            toolStripMenuItemExportCsv.Text = "Export csv";
            toolStripMenuItemExportCsv.Click += toolStripMenuItemExportCsv_Click;
            // 
            // toolStripMenuItemEnviroment
            // 
            toolStripMenuItemEnviroment.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemTheme });
            toolStripMenuItemEnviroment.Name = "toolStripMenuItemEnviroment";
            toolStripMenuItemEnviroment.Size = new Size(80, 20);
            toolStripMenuItemEnviroment.Text = "Enviroment";
            // 
            // toolStripMenuItemTheme
            // 
            toolStripMenuItemTheme.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemDarkTheme, toolStripMenuItemLightTheme, toolStripMenuItemBlueTheme });
            toolStripMenuItemTheme.Name = "toolStripMenuItemTheme";
            toolStripMenuItemTheme.Size = new Size(180, 22);
            toolStripMenuItemTheme.Text = "Theme";
            // 
            // toolStripMenuItemDarkTheme
            // 
            toolStripMenuItemDarkTheme.Name = "toolStripMenuItemDarkTheme";
            toolStripMenuItemDarkTheme.Size = new Size(180, 22);
            toolStripMenuItemDarkTheme.Text = "Dark";
            // 
            // toolStripMenuItemLightTheme
            // 
            toolStripMenuItemLightTheme.Name = "toolStripMenuItemLightTheme";
            toolStripMenuItemLightTheme.Size = new Size(180, 22);
            toolStripMenuItemLightTheme.Text = "Light";
            toolStripMenuItemLightTheme.Click += toolStripMenuItemLightTheme_Click;
            // 
            // toolStripMenuItemBlueTheme
            // 
            toolStripMenuItemBlueTheme.Name = "toolStripMenuItemBlueTheme";
            toolStripMenuItemBlueTheme.Size = new Size(180, 22);
            toolStripMenuItemBlueTheme.Text = "Blue";
            toolStripMenuItemBlueTheme.Click += toolStripMenuItemBlueTheme_Click;
            // 
            // toolStripMenuItemInsert
            // 
            toolStripMenuItemInsert.DropDownItems.AddRange(new ToolStripItem[] { produsToolStripMenuItem, clientToolStripMenuItem, locatieToolStripMenuItem, livrareToolStripMenuItem });
            toolStripMenuItemInsert.Name = "toolStripMenuItemInsert";
            toolStripMenuItemInsert.Size = new Size(48, 20);
            toolStripMenuItemInsert.Text = "Insert";
            // 
            // produsToolStripMenuItem
            // 
            produsToolStripMenuItem.Name = "produsToolStripMenuItem";
            produsToolStripMenuItem.Size = new Size(112, 22);
            produsToolStripMenuItem.Text = "Produs";
            produsToolStripMenuItem.Click += produsToolStripMenuItem_Click;
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(112, 22);
            clientToolStripMenuItem.Text = "Client";
            clientToolStripMenuItem.Click += clientToolStripMenuItem_Click;
            // 
            // locatieToolStripMenuItem
            // 
            locatieToolStripMenuItem.Name = "locatieToolStripMenuItem";
            locatieToolStripMenuItem.Size = new Size(112, 22);
            locatieToolStripMenuItem.Text = "Locatie";
            // 
            // livrareToolStripMenuItem
            // 
            livrareToolStripMenuItem.Name = "livrareToolStripMenuItem";
            livrareToolStripMenuItem.Size = new Size(112, 22);
            livrareToolStripMenuItem.Text = "Livrare";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1184, 603);
            Controls.Add(buttonStoc);
            Controls.Add(buttonLocatii);
            Controls.Add(buttonLivrari);
            Controls.Add(buttonClienti);
            Controls.Add(buttonCutii);
            Controls.Add(buttonProduse);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Gestionare Magazie";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonProduse;
        private Button buttonCutii;
        private Button buttonClienti;
        private Button buttonLivrari;
        private Button buttonLocatii;
        private Button buttonStoc;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemData;
        private ToolStripMenuItem toolStripMenuItemExportExcel;
        private ToolStripMenuItem toolStripMenuItemExportCsv;
        private ToolStripMenuItem toolStripMenuItemEnviroment;
        private ToolStripMenuItem toolStripMenuItemTheme;
        private ToolStripMenuItem toolStripMenuItemDarkTheme;
        private ToolStripMenuItem toolStripMenuItemLightTheme;
        private ToolStripMenuItem toolStripMenuItemBlueTheme;
        private ToolStripMenuItem toolStripMenuItemInsert;
        private ToolStripMenuItem produsToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem locatieToolStripMenuItem;
        private ToolStripMenuItem livrareToolStripMenuItem;
    }
}