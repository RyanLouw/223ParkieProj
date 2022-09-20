
namespace Natuurpark1._2
{
    partial class Report
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
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.amountOfbeds = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.reportBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfbeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(22, 51);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(200, 20);
            this.startdate.TabIndex = 0;
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(22, 115);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(200, 20);
            this.enddate.TabIndex = 1;
            // 
            // amountOfbeds
            // 
            this.amountOfbeds.Location = new System.Drawing.Point(22, 169);
            this.amountOfbeds.Name = "amountOfbeds";
            this.amountOfbeds.Size = new System.Drawing.Size(120, 20);
            this.amountOfbeds.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(228, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(593, 150);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // reportBTN
            // 
            this.reportBTN.Location = new System.Drawing.Point(22, 238);
            this.reportBTN.Name = "reportBTN";
            this.reportBTN.Size = new System.Drawing.Size(75, 23);
            this.reportBTN.TabIndex = 4;
            this.reportBTN.Text = "Report";
            this.reportBTN.UseVisualStyleBackColor = true;
            this.reportBTN.Click += new System.EventHandler(this.reportBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 124);
            this.dataGridView1.TabIndex = 5;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reportBTN);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.amountOfbeds);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.startdate);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountOfbeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.NumericUpDown amountOfbeds;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button reportBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}