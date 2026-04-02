namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 백제 B", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(244, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(315, 129);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("문체부 돋음체", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(173, 193);
            txtID.Name = "txtID";
            txtID.Size = new Size(452, 44);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.TextChanged += txtId_TextChanged;
            txtID.Enter += txtId_Enter;
            txtID.Leave += txtId_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("문체부 돋음체", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(173, 292);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(452, 44);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.TextChanged += txtPw_TextChanged;
            txtPW.Enter += txtPw_Enter;
            txtPW.Leave += txtPw_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 192);
            btnLogin.Font = new Font("한컴 백제 M", 16.1249981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(289, 532);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(218, 73);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 697);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
    }
}
