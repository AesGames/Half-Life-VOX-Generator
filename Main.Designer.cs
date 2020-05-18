namespace VOX_Generator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputSent = new System.Windows.Forms.TextBox();
            this.generateButt = new System.Windows.Forms.Button();
            this.quitButt = new System.Windows.Forms.Button();
            this.infoButt = new System.Windows.Forms.Button();
            this.vType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dictButt = new System.Windows.Forms.Button();
            this.logText = new System.Windows.Forms.TextBox();
            this.annihilateButt = new System.Windows.Forms.Button();
            this.closePush = new System.Windows.Forms.Button();
            this.minimizeButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Snow;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(463, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Half-Life VOX Sentence Generator\r\n";
            // 
            // inputSent
            // 
            this.inputSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.inputSent.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSent.ForeColor = System.Drawing.SystemColors.Window;
            this.inputSent.Location = new System.Drawing.Point(13, 73);
            this.inputSent.Name = "inputSent";
            this.inputSent.Size = new System.Drawing.Size(444, 20);
            this.inputSent.TabIndex = 1;
            // 
            // generateButt
            // 
            this.generateButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.generateButt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButt.ForeColor = System.Drawing.SystemColors.Window;
            this.generateButt.Location = new System.Drawing.Point(463, 73);
            this.generateButt.Name = "generateButt";
            this.generateButt.Size = new System.Drawing.Size(75, 23);
            this.generateButt.TabIndex = 2;
            this.generateButt.Text = "Generate!";
            this.generateButt.UseVisualStyleBackColor = true;
            this.generateButt.Click += new System.EventHandler(this.generateClick);
            // 
            // quitButt
            // 
            this.quitButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitButt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButt.ForeColor = System.Drawing.SystemColors.Window;
            this.quitButt.Location = new System.Drawing.Point(462, 100);
            this.quitButt.Name = "quitButt";
            this.quitButt.Size = new System.Drawing.Size(75, 23);
            this.quitButt.TabIndex = 3;
            this.quitButt.Text = "Exit";
            this.quitButt.UseVisualStyleBackColor = true;
            this.quitButt.Click += new System.EventHandler(this.quitClick);
            // 
            // infoButt
            // 
            this.infoButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.infoButt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButt.ForeColor = System.Drawing.SystemColors.Window;
            this.infoButt.Location = new System.Drawing.Point(13, 100);
            this.infoButt.Name = "infoButt";
            this.infoButt.Size = new System.Drawing.Size(75, 23);
            this.infoButt.TabIndex = 4;
            this.infoButt.Text = "Info";
            this.infoButt.UseVisualStyleBackColor = true;
            this.infoButt.Click += new System.EventHandler(this.infoClick);
            // 
            // vType
            // 
            this.vType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.vType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vType.ForeColor = System.Drawing.SystemColors.Window;
            this.vType.FormattingEnabled = true;
            this.vType.Items.AddRange(new object[] {
            "VOX",
            "Human Grunt",
            "HEV Suit"});
            this.vType.Location = new System.Drawing.Point(12, 45);
            this.vType.Name = "vType";
            this.vType.Size = new System.Drawing.Size(121, 22);
            this.vType.TabIndex = 6;
            this.vType.SelectedIndexChanged += new System.EventHandler(this.vtypeSelectionChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(139, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Voice type\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dictButt
            // 
            this.dictButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dictButt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dictButt.ForeColor = System.Drawing.SystemColors.Window;
            this.dictButt.Location = new System.Drawing.Point(94, 100);
            this.dictButt.Name = "dictButt";
            this.dictButt.Size = new System.Drawing.Size(75, 23);
            this.dictButt.TabIndex = 8;
            this.dictButt.Text = "Dictionary";
            this.dictButt.UseVisualStyleBackColor = true;
            this.dictButt.Click += new System.EventHandler(this.dictionaryClick);
            // 
            // logText
            // 
            this.logText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.logText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logText.ForeColor = System.Drawing.Color.White;
            this.logText.Location = new System.Drawing.Point(13, 129);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.ReadOnly = true;
            this.logText.Size = new System.Drawing.Size(525, 332);
            this.logText.TabIndex = 9;
            // 
            // annihilateButt
            // 
            this.annihilateButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.annihilateButt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annihilateButt.ForeColor = System.Drawing.SystemColors.Window;
            this.annihilateButt.Location = new System.Drawing.Point(175, 100);
            this.annihilateButt.Name = "annihilateButt";
            this.annihilateButt.Size = new System.Drawing.Size(75, 23);
            this.annihilateButt.TabIndex = 10;
            this.annihilateButt.Text = "Delete All";
            this.annihilateButt.UseVisualStyleBackColor = true;
            this.annihilateButt.Click += new System.EventHandler(this.annihilateClick);
            // 
            // closePush
            // 
            this.closePush.Location = new System.Drawing.Point(512, 11);
            this.closePush.Name = "closePush";
            this.closePush.Size = new System.Drawing.Size(25, 25);
            this.closePush.TabIndex = 11;
            this.closePush.Text = "X";
            this.closePush.UseVisualStyleBackColor = true;
            this.closePush.Click += new System.EventHandler(this.closePush_Click);
            // 
            // minimizeButt
            // 
            this.minimizeButt.Location = new System.Drawing.Point(481, 11);
            this.minimizeButt.Name = "minimizeButt";
            this.minimizeButt.Size = new System.Drawing.Size(25, 25);
            this.minimizeButt.TabIndex = 12;
            this.minimizeButt.Text = "_";
            this.minimizeButt.UseVisualStyleBackColor = true;
            this.minimizeButt.Click += new System.EventHandler(this.minimizeButt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(549, 473);
            this.Controls.Add(this.minimizeButt);
            this.Controls.Add(this.closePush);
            this.Controls.Add(this.annihilateButt);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.dictButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vType);
            this.Controls.Add(this.infoButt);
            this.Controls.Add(this.quitButt);
            this.Controls.Add(this.generateButt);
            this.Controls.Add(this.inputSent);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Load += new System.EventHandler(this.mainLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox inputSent;
        private System.Windows.Forms.Button generateButt;
        private System.Windows.Forms.Button quitButt;
        private System.Windows.Forms.Button infoButt;
        private System.Windows.Forms.ComboBox vType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dictButt;
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.Button annihilateButt;
        private System.Windows.Forms.Button closePush;
        private System.Windows.Forms.Button minimizeButt;
    }
}

