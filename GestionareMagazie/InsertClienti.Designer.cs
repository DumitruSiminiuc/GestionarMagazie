namespace GestionareMagazie
{
    partial class InsertClienti
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
            buttonAnuleaza = new Button();
            labelNume = new Label();
            labelPrenume = new Label();
            labelEmail = new Label();
            textBoxNume = new TextBox();
            textBoxPrenume = new TextBox();
            textBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // buttonAdauga
            // 
            buttonAdauga.Location = new Point(629, 408);
            buttonAdauga.Name = "buttonAdauga";
            buttonAdauga.Size = new Size(135, 33);
            buttonAdauga.TabIndex = 0;
            buttonAdauga.Text = "Adauga";
            buttonAdauga.UseVisualStyleBackColor = true;
            buttonAdauga.Click += buttonAdauga_Click;
            // 
            // buttonAnuleaza
            // 
            buttonAnuleaza.Location = new Point(464, 407);
            buttonAnuleaza.Name = "buttonAnuleaza";
            buttonAnuleaza.Size = new Size(133, 35);
            buttonAnuleaza.TabIndex = 1;
            buttonAnuleaza.Text = "Anuleaza";
            buttonAnuleaza.UseVisualStyleBackColor = true;
            buttonAnuleaza.Click += buttonAnuleaza_Click;
            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.Location = new Point(44, 55);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(40, 15);
            labelNume.TabIndex = 2;
            labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            labelPrenume.AutoSize = true;
            labelPrenume.Location = new Point(44, 92);
            labelPrenume.Name = "labelPrenume";
            labelPrenume.Size = new Size(55, 15);
            labelPrenume.TabIndex = 3;
            labelPrenume.Text = "Prenume";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(44, 127);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // textBoxNume
            // 
            textBoxNume.Location = new Point(116, 52);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(195, 23);
            textBoxNume.TabIndex = 5;
            // 
            // textBoxPrenume
            // 
            textBoxPrenume.Location = new Point(116, 84);
            textBoxPrenume.Name = "textBoxPrenume";
            textBoxPrenume.Size = new Size(195, 23);
            textBoxPrenume.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(117, 123);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(193, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // InsertClienti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPrenume);
            Controls.Add(textBoxNume);
            Controls.Add(labelEmail);
            Controls.Add(labelPrenume);
            Controls.Add(labelNume);
            Controls.Add(buttonAnuleaza);
            Controls.Add(buttonAdauga);
            Name = "InsertClienti";
            Text = "InsertClienti";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdauga;
        private Button buttonAnuleaza;
        private Label labelNume;
        private Label labelPrenume;
        private Label labelEmail;
        private TextBox textBoxNume;
        private TextBox textBoxPrenume;
        private TextBox textBoxEmail;
    }
}