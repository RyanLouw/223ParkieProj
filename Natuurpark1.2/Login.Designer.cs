
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
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wagwoordLB
            // 
            this.wagwoordLB.AutoSize = true;
            this.wagwoordLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wagwoordLB.ForeColor = System.Drawing.Color.White;
            this.wagwoordLB.Location = new System.Drawing.Point(134, 234);
            this.wagwoordLB.Name = "wagwoordLB";
            this.wagwoordLB.Size = new System.Drawing.Size(65, 13);
            this.wagwoordLB.TabIndex = 9;
            this.wagwoordLB.Text = "Password:";
            // 
            // wagwoordTB
            // 
            this.wagwoordTB.Location = new System.Drawing.Point(246, 231);
            this.wagwoordTB.Name = "wagwoordTB";
            this.wagwoordTB.PasswordChar = '*';
            this.wagwoordTB.Size = new System.Drawing.Size(330, 20);
            this.wagwoordTB.TabIndex = 8;
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLB.ForeColor = System.Drawing.Color.White;
            this.usernameLB.Location = new System.Drawing.Point(134, 171);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(55, 13);
            this.usernameLB.TabIndex = 7;
            this.usernameLB.Text = "Staff Nr:";
            this.usernameLB.Click += new System.EventHandler(this.usernameLB_Click);
            // 
            // loginBT
            // 
            this.loginBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBT.Location = new System.Drawing.Point(369, 289);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(94, 24);
            this.loginBT.TabIndex = 6;
            this.loginBT.Text = "Log In";
            this.loginBT.UseVisualStyleBackColor = true;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(246, 164);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(330, 20);
            this.UsernameTB.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(209, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(412, 67);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Parkie Gras Lodge";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(63)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
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
        private System.Windows.Forms.Label lblName;
    }
}