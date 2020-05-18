namespace VOX_Generator
{
    partial class DictionaryWind
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
            this.dictionaryField = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dictionaryField
            // 
            this.dictionaryField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.dictionaryField.ForeColor = System.Drawing.Color.White;
            this.dictionaryField.Location = new System.Drawing.Point(12, 51);
            this.dictionaryField.Multiline = true;
            this.dictionaryField.Name = "dictionaryField";
            this.dictionaryField.Size = new System.Drawing.Size(592, 277);
            this.dictionaryField.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(334, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "All words available for VOX";
            // 
            // closeButt
            // 
            this.closeButt.ForeColor = System.Drawing.Color.White;
            this.closeButt.Location = new System.Drawing.Point(579, 13);
            this.closeButt.Name = "closeButt";
            this.closeButt.Size = new System.Drawing.Size(25, 25);
            this.closeButt.TabIndex = 2;
            this.closeButt.Text = "X";
            this.closeButt.UseVisualStyleBackColor = true;
            this.closeButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // DictionaryWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(616, 340);
            this.Controls.Add(this.closeButt);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dictionaryField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DictionaryWind";
            this.ShowIcon = false;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dictionaryField;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButt;
    }
}