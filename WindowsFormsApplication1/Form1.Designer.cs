namespace WindowsFormsApplication1
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
            this.txtSort = new System.Windows.Forms.TextBox();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSort
            // 
            this.txtSort.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSort.Location = new System.Drawing.Point(32, 34);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(204, 31);
            this.txtSort.TabIndex = 0;
            // 
            // cboSort
            // 
            this.cboSort.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Items.AddRange(new object[] {
            "Bubble Sort",
            "Quick Sort"});
            this.cboSort.Location = new System.Drawing.Point(32, 82);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(204, 30);
            this.cboSort.TabIndex = 1;
            this.cboSort.Text = "-Select Sort-";
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(136, 129);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 33);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "SORT";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(28, 193);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(19, 22);
            this.lblSort.TabIndex = 3;
            this.lblSort.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 237);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cboSort);
            this.Controls.Add(this.txtSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblSort;
    }
}

