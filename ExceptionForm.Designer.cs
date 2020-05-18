namespace VOX_Generator
{
    partial class ExceptionForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.excPrint = new System.Windows.Forms.TextBox();
            this.closeButt = new System.Windows.Forms.Button();
            this.copyButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(9, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(458, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "There has been an exception and the program has stopped. The error message will b" +
    "e listed in the text box below.";
            // 
            // excPrint
            // 
            this.excPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.excPrint.ForeColor = System.Drawing.Color.White;
            this.excPrint.Location = new System.Drawing.Point(12, 57);
            this.excPrint.Multiline = true;
            this.excPrint.Name = "excPrint";
            this.excPrint.Size = new System.Drawing.Size(377, 503);
            this.excPrint.TabIndex = 1;
            // 
            // closeButt
            // 
            this.closeButt.ForeColor = System.Drawing.Color.White;
            this.closeButt.Location = new System.Drawing.Point(395, 57);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(75, 23);
            this.closeButt.TabIndex = 2;
            this.closeButt.Text = "Close";
            this.closeButt.UseVisualStyleBackColor = true;
            this.closeButt.Click += new System.EventHandler(this.closeClick);
            // 
            // copyButt
            // 
            this.copyButt.ForeColor = System.Drawing.Color.White;
            this.copyButt.Location = new System.Drawing.Point(395, 86);
            this.copyButt.Name = "copyButt";
            this.copyButt.Size = new System.Drawing.Size(75, 23);
            this.copyButt.TabIndex = 3;
            this.copyButt.Text = "Copy";
            this.copyButt.UseVisualStyleBackColor = true;
            this.copyButt.Click += new System.EventHandler(this.copyClick);
            // 
            // ExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(482, 572);
            this.Controls.Add(this.copyButt);
            this.Controls.Add(this.closeButt);
            this.Controls.Add(this.excPrint);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExceptionForm";
            this.ShowIcon = false;
            this.Text = "Exception Catched!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox excPrint;
        private System.Windows.Forms.Button closeButt;
        private System.Windows.Forms.Button copyButt;
    }
}