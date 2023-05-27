using System.Drawing;
using System.Windows.Forms;
using System.Linq.Expressions;
using System;

namespace RegistrtionForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800,800);
            this.Size = new Size(1000, 1000);
            this.Text = "Registrtion";



            textLogin = new TextBox();
            textLogin.Width = 100;
            textLogin.Height = 100;
            textLogin.Location = new Point(350, 50);
            this.Controls.Add(textLogin);

            textPass = new TextBox();
            textPass.Location = new Point(textLogin.Location.X, textLogin.Location.Y + 20);
            textPass.Width = 100;
            textPass.Height = 100;

            this.Controls.Add(textPass);

            textPass2 = new TextBox();
            textPass2.Location = new Point(textLogin.Location.X, textLogin.Location.Y + 40);
            textPass2.Width = 100;
            textPass2.Height = 100;

            this.Controls.Add(textPass2);

            Sex_Panel = new Panel();
            //Sex_Panel.BackColor = Color.LightGray;

            Sex_Panel.Size = new Size(200, 100);
            Sex_Panel.Location = new Point(textLogin.Location.X, textPass2.Location.Y + 40);
            this.Controls.Add(Sex_Panel);

            infoPanel = new Label();
            infoPanel.Text = "Choose Sex";

            infoPanel.Location = new Point(Sex_Panel.Location.X, Sex_Panel.Location.Y + 70);
            Sex_Panel.Controls.Add(infoPanel);

            Man_RB = new RadioButton();
            Man_RB.Text = "Man";

            Sex_Panel.Controls.Add(Man_RB);

            Woman_RB = new RadioButton();
            Woman_RB.Text = "Woman";
            Woman_RB.Location = new Point(0, Man_RB.Height + 5);
            Sex_Panel.Controls.Add(Woman_RB);

            Other_RB = new RadioButton();
            Other_RB.Text = "Other";
            Other_RB.Location = new Point(0, Man_RB.Height + 32);
            Sex_Panel.Controls.Add(Other_RB);

            btnC = new Button();
            btnC.Text = "Confirm";
            btnC.ForeColor = Color.Green;
            btnC.Size = new Size(50, 50);
            btnC.Location = new Point(350, infoPanel.Location.Y +25);
            btnC.BackColor = Color.Aquamarine;
            btnC.Font = new Font("Times New Roman", 7, FontStyle.Bold | FontStyle.Italic);
            btnC.Click += BtnC_Click;

            this.Controls.Add(btnC);

            btnDel = new Button();
            btnDel.Text = "Clear";
            btnDel.ForeColor = Color.Green;
            btnDel.Size = new Size(50, 50);
            btnDel.Location = new Point(btnC.Location.X + 55, infoPanel.Location.Y +25);
            btnDel.BackColor = Color.Aquamarine;
            btnDel.Font = new Font("Times New Roman", 8, FontStyle.Bold | FontStyle.Italic);
            btnDel.Click += BtnDel_Click;
            this.Controls.Add(btnDel);


            btn_Undo = new Button();
            btn_Undo.Text = "Cancel";
            btn_Undo.ForeColor = Color.Green;
            btn_Undo.Size = new Size(50, 50);
            btn_Undo.Location = new Point(btnDel.Location.X + 55, infoPanel.Location.Y + 25);
            btn_Undo.BackColor = Color.Aquamarine;
            btn_Undo.Font = new Font("Times New Roman", 8, FontStyle.Bold | FontStyle.Italic);
            this.Controls.Add(btn_Undo);

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            textPass.Text = string.Empty;
            textPass2.Text = string.Empty;
            textLogin.Text = string.Empty;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            if (textPass.Text == textPass2.Text && textLogin.TextLength > 0 && textPass.TextLength > 0)
            {
                MessageBox.Show("Acount Created");
            }
            if (textLogin.TextLength == 0 || textPass.TextLength == 0)
            {
                MessageBox.Show("Login or password can`t be empty");
            }
            else
            {
                MessageBox.Show("Passwords are not the same");

            }
        }

        TextBox textLogin;
        TextBox textPass;
        TextBox textPass2;
        Panel Sex_Panel;
        Label infoPanel;
        RadioButton Man_RB;
        RadioButton Woman_RB;
        RadioButton Other_RB;
        Button btnC;
        Button btnDel;
        Button btn_Undo;



        #endregion
    }
}

