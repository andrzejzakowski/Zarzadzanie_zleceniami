namespace FixUpGuy
{
    partial class Form2
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
            this.text_form2_login = new System.Windows.Forms.TextBox();
            this.text_form2_password = new System.Windows.Forms.TextBox();
            this.but_form2_zaloguj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_form2_login
            // 
            this.text_form2_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_form2_login.Location = new System.Drawing.Point(74, 19);
            this.text_form2_login.Name = "text_form2_login";
            this.text_form2_login.Size = new System.Drawing.Size(125, 20);
            this.text_form2_login.TabIndex = 0;
            this.text_form2_login.TextChanged += new System.EventHandler(this.text_form2_login_TextChanged);
            // 
            // text_form2_password
            // 
            this.text_form2_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_form2_password.Location = new System.Drawing.Point(76, 78);
            this.text_form2_password.Name = "text_form2_password";
            this.text_form2_password.Size = new System.Drawing.Size(121, 20);
            this.text_form2_password.TabIndex = 1;
            this.text_form2_password.TextChanged += new System.EventHandler(this.text_form2_password_TextChanged);
            // 
            // but_form2_zaloguj
            // 
            this.but_form2_zaloguj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_form2_zaloguj.Location = new System.Drawing.Point(99, 130);
            this.but_form2_zaloguj.Name = "but_form2_zaloguj";
            this.but_form2_zaloguj.Size = new System.Drawing.Size(75, 23);
            this.but_form2_zaloguj.TabIndex = 2;
            this.but_form2_zaloguj.Text = "Zaloguj";
            this.but_form2_zaloguj.UseVisualStyleBackColor = true;
            this.but_form2_zaloguj.Click += new System.EventHandler(this.but_form2_zaloguj_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.02643F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.97357F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Controls.Add(this.but_form2_zaloguj, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.text_form2_login, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_form2_password, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 165);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 191);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox text_form2_password;
        private System.Windows.Forms.Button but_form2_zaloguj;
        private System.Windows.Forms.TextBox text_form2_login;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}