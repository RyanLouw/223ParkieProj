
namespace Natuurpark1._2
{
    partial class Nave
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
            this.BtnHouses = new System.Windows.Forms.Button();
            this.BtnAn = new System.Windows.Forms.Button();
            this.BtnWorkers = new System.Windows.Forms.Button();
            this.BtnGueste = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHouses
            // 
            this.BtnHouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHouses.Location = new System.Drawing.Point(202, 229);
            this.BtnHouses.Name = "BtnHouses";
            this.BtnHouses.Size = new System.Drawing.Size(183, 77);
            this.BtnHouses.TabIndex = 9;
            this.BtnHouses.Text = "Houses";
            this.BtnHouses.UseVisualStyleBackColor = true;
            this.BtnHouses.Click += new System.EventHandler(this.BtnHouses_Click);
            // 
            // BtnAn
            // 
            this.BtnAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAn.Location = new System.Drawing.Point(419, 229);
            this.BtnAn.Name = "BtnAn";
            this.BtnAn.Size = new System.Drawing.Size(178, 77);
            this.BtnAn.TabIndex = 8;
            this.BtnAn.Text = "Animals";
            this.BtnAn.UseVisualStyleBackColor = true;
            this.BtnAn.Click += new System.EventHandler(this.BtnAn_Click);
            // 
            // BtnWorkers
            // 
            this.BtnWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWorkers.Location = new System.Drawing.Point(314, 329);
            this.BtnWorkers.Name = "BtnWorkers";
            this.BtnWorkers.Size = new System.Drawing.Size(178, 77);
            this.BtnWorkers.TabIndex = 7;
            this.BtnWorkers.Text = "Workers";
            this.BtnWorkers.UseVisualStyleBackColor = true;
            this.BtnWorkers.Click += new System.EventHandler(this.BtnWorkers_Click);
            // 
            // BtnGueste
            // 
            this.BtnGueste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGueste.Location = new System.Drawing.Point(419, 113);
            this.BtnGueste.Name = "BtnGueste";
            this.BtnGueste.Size = new System.Drawing.Size(178, 77);
            this.BtnGueste.TabIndex = 6;
            this.BtnGueste.Text = "Guest";
            this.BtnGueste.UseVisualStyleBackColor = true;
            this.BtnGueste.Click += new System.EventHandler(this.BtnGueste_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(202, 113);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(183, 77);
            this.btnBooking.TabIndex = 5;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(142, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(534, 53);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Welcome to Parkie Gras Lodge";
            // 
            // Nave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(63)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.BtnHouses);
            this.Controls.Add(this.BtnAn);
            this.Controls.Add(this.BtnWorkers);
            this.Controls.Add(this.BtnGueste);
            this.Controls.Add(this.btnBooking);
            this.Name = "Nave";
            this.Text = "Nave";
            this.Load += new System.EventHandler(this.Nave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHouses;
        private System.Windows.Forms.Button BtnAn;
        private System.Windows.Forms.Button BtnWorkers;
        private System.Windows.Forms.Button BtnGueste;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Label lblName;
    }
}