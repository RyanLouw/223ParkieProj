
namespace Natuurpark1._2
{
    partial class Login
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
            this.wagwoordLB = new System.Windows.Forms.Label();
            this.wagwoordTB = new System.Windows.Forms.TextBox();
            this.usernameLB = new System.Windows.Forms.Label();
            this.loginBT = new System.Windows.Forms.Button();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wagwoordLB
            // 
            this.wagwoordLB.AutoSize = true;
            this.wagwoordLB.Location = new System.Drawing.Point(382, 215);
            this.wagwoordLB.Name = "wagwoordLB";
            this.wagwoordLB.Size = new System.Drawing.Size(54, 13);
            this.wagwoordLB.TabIndex = 9;
            this.wagwoordLB.Text = "Paswoord";
            // 
            // wagwoordTB
            // 
            this.wagwoordTB.Location = new System.Drawing.Point(235, 231);
            this.wagwoordTB.Name = "wagwoordTB";
            this.wagwoordTB.Size = new System.Drawing.Size(330, 20);
            this.wagwoordTB.TabIndex = 8;
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Location = new System.Drawing.Point(382, 139);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(55, 13);
            this.usernameLB.TabIndex = 7;
            this.usernameLB.Text = "Username";
            // 
            // loginBT
            // 
            this.loginBT.Location = new System.Drawing.Point(369, 289);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(75, 23);
            this.loginBT.TabIndex = 6;
            this.loginBT.Text = "Login";
            this.loginBT.UseVisualStyleBackColor = true;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(235, 168);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(330, 20);
            this.UsernameTB.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wagwoordLB);
            this.Controls.Add(this.wagwoordTB);
            this.Controls.Add(this.usernameLB);
            this.Controls.Add(this.loginBT);
            this.Controls.Add(this.UsernameTB);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wagwoordLB;
        private System.Windows.Forms.TextBox wagwoordTB;
        private System.Windows.Forms.Label usernameLB;
        private System.Windows.Forms.Button loginBT;
        private System.Windows.Forms.TextBox UsernameTB;
    }
}