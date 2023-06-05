using System.Windows.Forms;
namespace GestionareMagazie
{
    partial class loginForm
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
            buttonOKLogIN = new Button();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            labelUserName = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // buttonOKLogIN
            // 
            buttonOKLogIN.Location = new Point(509, 304);
            buttonOKLogIN.Name = "buttonOKLogIN";
            buttonOKLogIN.Size = new Size(145, 41);
            buttonOKLogIN.TabIndex = 0;
            buttonOKLogIN.Text = "OK";
            buttonOKLogIN.UseVisualStyleBackColor = true;
            buttonOKLogIN.Click += ButtonOKLogIN_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(168, 96);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(298, 23);
            textBoxUserName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(168, 134);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(298, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.Location = new Point(81, 99);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(62, 15);
            labelUserName.TabIndex = 3;
            labelUserName.Text = "username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(81, 134);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(59, 15);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "password";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(742, 379);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(buttonOKLogIN);
            Name = "loginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonOKLogIN_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (VerifyCredentials(username, password))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Numele de utilizator sau parola sunt incorecte. Vă rugăm să încercați din nou.");
            }
        }

        #endregion

        private Button buttonOKLogIN;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Label labelUserName;
        private Label labelPassword;
    }
}