namespace JokeAndPunchline
{
    partial class JokeForm
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
            this.SetupButton = new System.Windows.Forms.Button();
            this.PunchlineButton = new System.Windows.Forms.Button();
            this.SetupLabel = new System.Windows.Forms.Label();
            this.PunchlineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetupButton
            // 
            this.SetupButton.Location = new System.Drawing.Point(77, 333);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.Size = new System.Drawing.Size(249, 54);
            this.SetupButton.TabIndex = 0;
            this.SetupButton.Text = "Setup";
            this.SetupButton.UseVisualStyleBackColor = true;
            this.SetupButton.Click += new System.EventHandler(this.SetupButton_Click);
            // 
            // PunchlineButton
            // 
            this.PunchlineButton.Location = new System.Drawing.Point(466, 333);
            this.PunchlineButton.Name = "PunchlineButton";
            this.PunchlineButton.Size = new System.Drawing.Size(249, 54);
            this.PunchlineButton.TabIndex = 1;
            this.PunchlineButton.Text = "Punchline";
            this.PunchlineButton.UseVisualStyleBackColor = true;
            this.PunchlineButton.Click += new System.EventHandler(this.PunchlineButton_Click);
            // 
            // SetupLabel
            // 
            this.SetupLabel.AutoSize = true;
            this.SetupLabel.Location = new System.Drawing.Point(304, 122);
            this.SetupLabel.Name = "SetupLabel";
            this.SetupLabel.Size = new System.Drawing.Size(183, 13);
            this.SetupLabel.TabIndex = 2;
            this.SetupLabel.Text = "What is the Best thing about Boolean";
            this.SetupLabel.Visible = false;
            // 
            // PunchlineLabel
            // 
            this.PunchlineLabel.AutoSize = true;
            this.PunchlineLabel.Location = new System.Drawing.Point(304, 150);
            this.PunchlineLabel.Name = "PunchlineLabel";
            this.PunchlineLabel.Size = new System.Drawing.Size(269, 13);
            this.PunchlineLabel.TabIndex = 3;
            this.PunchlineLabel.Text = "EVEN IF YOU ARE WRONG, YOU ARE OFF BY A BIT";
            this.PunchlineLabel.Visible = false;
            // 
            // JokeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PunchlineLabel);
            this.Controls.Add(this.SetupLabel);
            this.Controls.Add(this.PunchlineButton);
            this.Controls.Add(this.SetupButton);
            this.Name = "JokeForm";
            this.Text = "r/ProgrammingHumor Energy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetupButton;
        private System.Windows.Forms.Button PunchlineButton;
        private System.Windows.Forms.Label SetupLabel;
        private System.Windows.Forms.Label PunchlineLabel;
    }
}

