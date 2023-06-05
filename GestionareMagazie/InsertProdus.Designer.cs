namespace GestionareMagazie
{
    partial class InsertProdus
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
            buttonAdauga = new Button();
            buttonCancel = new Button();
            labelDenumire = new Label();
            textBoxDenumire = new TextBox();
            labelUnitateDeMasura = new Label();
            textBoxUnitateDeMasura = new TextBox();
            labelPret = new Label();
            label1 = new Label();
            textBoxPret = new TextBox();
            dateTimePickerExpirare = new DateTimePicker();
            labelDescriere = new Label();
            textBoxDescriere = new TextBox();
            SuspendLayout();
            // 
            // buttonAdauga
            // 
            buttonAdauga.Location = new Point(580, 401);
            buttonAdauga.Name = "buttonAdauga";
            buttonAdauga.Size = new Size(102, 36);
            buttonAdauga.TabIndex = 0;
            buttonAdauga.Text = "Adauga";
            buttonAdauga.UseVisualStyleBackColor = true;
            buttonAdauga.Click += buttonAdauga_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(430, 400);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(115, 38);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Anuleaza";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelDenumire
            // 
            labelDenumire.AutoSize = true;
            labelDenumire.Location = new Point(27, 58);
            labelDenumire.Name = "labelDenumire";
            labelDenumire.Size = new Size(59, 15);
            labelDenumire.TabIndex = 2;
            labelDenumire.Text = "Denumire";
            // 
            // textBoxDenumire
            // 
            textBoxDenumire.Location = new Point(152, 55);
            textBoxDenumire.Name = "textBoxDenumire";
            textBoxDenumire.Size = new Size(222, 23);
            textBoxDenumire.TabIndex = 3;
            // 
            // labelUnitateDeMasura
            // 
            labelUnitateDeMasura.AutoSize = true;
            labelUnitateDeMasura.Location = new Point(27, 139);
            labelUnitateDeMasura.Name = "labelUnitateDeMasura";
            labelUnitateDeMasura.Size = new Size(103, 15);
            labelUnitateDeMasura.TabIndex = 4;
            labelUnitateDeMasura.Text = "Unitate de masura";
            // 
            // textBoxUnitateDeMasura
            // 
            textBoxUnitateDeMasura.Location = new Point(153, 136);
            textBoxUnitateDeMasura.Name = "textBoxUnitateDeMasura";
            textBoxUnitateDeMasura.Size = new Size(220, 23);
            textBoxUnitateDeMasura.TabIndex = 5;
            // 
            // labelPret
            // 
            labelPret.AutoSize = true;
            labelPret.Location = new Point(27, 178);
            labelPret.Name = "labelPret";
            labelPret.Size = new Size(28, 15);
            labelPret.TabIndex = 6;
            labelPret.Text = "Pret";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 208);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 7;
            label1.Text = "Data expirarii";
            // 
            // textBoxPret
            // 
            textBoxPret.Location = new Point(152, 175);
            textBoxPret.Name = "textBoxPret";
            textBoxPret.Size = new Size(221, 23);
            textBoxPret.TabIndex = 8;
            // 
            // dateTimePickerExpirare
            // 
            dateTimePickerExpirare.Location = new Point(152, 209);
            dateTimePickerExpirare.Name = "dateTimePickerExpirare";
            dateTimePickerExpirare.Size = new Size(223, 23);
            dateTimePickerExpirare.TabIndex = 9;
            // 
            // labelDescriere
            // 
            labelDescriere.AutoSize = true;
            labelDescriere.Location = new Point(27, 97);
            labelDescriere.Name = "labelDescriere";
            labelDescriere.Size = new Size(55, 15);
            labelDescriere.TabIndex = 10;
            labelDescriere.Text = "Descriere";
            // 
            // textBoxDescriere
            // 
            textBoxDescriere.Location = new Point(153, 95);
            textBoxDescriere.Name = "textBoxDescriere";
            textBoxDescriere.Size = new Size(222, 23);
            textBoxDescriere.TabIndex = 11;
            // 
            // Insert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDescriere);
            Controls.Add(labelDescriere);
            Controls.Add(dateTimePickerExpirare);
            Controls.Add(textBoxPret);
            Controls.Add(label1);
            Controls.Add(labelPret);
            Controls.Add(textBoxUnitateDeMasura);
            Controls.Add(labelUnitateDeMasura);
            Controls.Add(textBoxDenumire);
            Controls.Add(labelDenumire);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdauga);
            Name = "Insert";
            Text = "Insert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdauga;
        private Button buttonCancel;
        private Label labelDenumire;
        private TextBox textBoxDenumire;
        private Label labelUnitateDeMasura;
        private TextBox textBoxUnitateDeMasura;
        private Label labelPret;
        private Label label1;
        private TextBox textBoxPret;
        private DateTimePicker dateTimePickerExpirare;
        private Label labelDescriere;
        private TextBox textBoxDescriere;
    }
}