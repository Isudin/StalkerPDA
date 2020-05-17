namespace StalkerPDA
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuBox = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.relationTabButton = new System.Windows.Forms.Button();
            this.factionTabButton = new System.Windows.Forms.Button();
            this.guideTabButton = new System.Windows.Forms.Button();
            this.timeLabelTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.relationPanel1 = new StalkerPDA.UserControls.relationPanel();
            this.guidePanel1 = new StalkerPDA.UserControls.guidePanel();
            this.factionPanel1 = new StalkerPDA.UserControls.factionPanel();
            this.mainMenuBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBox
            // 
            this.mainMenuBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainMenuBox.Controls.Add(this.pictureBox1);
            this.mainMenuBox.Controls.Add(this.timeLabel);
            this.mainMenuBox.Controls.Add(this.relationTabButton);
            this.mainMenuBox.Controls.Add(this.factionTabButton);
            this.mainMenuBox.Controls.Add(this.guideTabButton);
            this.mainMenuBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenuBox.Location = new System.Drawing.Point(0, 0);
            this.mainMenuBox.MinimumSize = new System.Drawing.Size(600, 68);
            this.mainMenuBox.Name = "mainMenuBox";
            this.mainMenuBox.Size = new System.Drawing.Size(800, 68);
            this.mainMenuBox.TabIndex = 7;
            this.mainMenuBox.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(739, 28);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 17);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Time";
            // 
            // relationTabButton
            // 
            this.relationTabButton.Location = new System.Drawing.Point(118, 21);
            this.relationTabButton.Name = "relationTabButton";
            this.relationTabButton.Size = new System.Drawing.Size(100, 30);
            this.relationTabButton.TabIndex = 2;
            this.relationTabButton.Text = "Relations";
            this.relationTabButton.UseVisualStyleBackColor = true;
            this.relationTabButton.Click += new System.EventHandler(this.relationTabButton_Click);
            // 
            // factionTabButton
            // 
            this.factionTabButton.Location = new System.Drawing.Point(12, 21);
            this.factionTabButton.Name = "factionTabButton";
            this.factionTabButton.Size = new System.Drawing.Size(100, 30);
            this.factionTabButton.TabIndex = 1;
            this.factionTabButton.Text = "Factions";
            this.factionTabButton.UseVisualStyleBackColor = true;
            this.factionTabButton.Click += new System.EventHandler(this.factionTabButton_Click);
            // 
            // guideTabButton
            // 
            this.guideTabButton.Location = new System.Drawing.Point(224, 21);
            this.guideTabButton.Name = "guideTabButton";
            this.guideTabButton.Size = new System.Drawing.Size(100, 30);
            this.guideTabButton.TabIndex = 3;
            this.guideTabButton.Text = "Guide";
            this.guideTabButton.UseVisualStyleBackColor = true;
            this.guideTabButton.Click += new System.EventHandler(this.guideTabButton_Click);
            // 
            // timeLabelTimer
            // 
            this.timeLabelTimer.Tick += new System.EventHandler(this.timeLabelTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StalkerPDA.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(461, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // relationPanel1
            // 
            this.relationPanel1.Location = new System.Drawing.Point(12, 87);
            this.relationPanel1.Name = "relationPanel1";
            this.relationPanel1.Size = new System.Drawing.Size(776, 351);
            this.relationPanel1.TabIndex = 10;
            this.relationPanel1.Visible = false;
            // 
            // guidePanel1
            // 
            this.guidePanel1.Location = new System.Drawing.Point(12, 87);
            this.guidePanel1.Name = "guidePanel1";
            this.guidePanel1.Size = new System.Drawing.Size(776, 351);
            this.guidePanel1.TabIndex = 9;
            this.guidePanel1.Visible = false;
            // 
            // factionPanel1
            // 
            this.factionPanel1.Location = new System.Drawing.Point(12, 87);
            this.factionPanel1.Name = "factionPanel1";
            this.factionPanel1.Size = new System.Drawing.Size(776, 351);
            this.factionPanel1.TabIndex = 8;
            this.factionPanel1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.relationPanel1);
            this.Controls.Add(this.guidePanel1);
            this.Controls.Add(this.factionPanel1);
            this.Controls.Add(this.mainMenuBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.T.A.L.K.E.R. PDA";
            this.mainMenuBox.ResumeLayout(false);
            this.mainMenuBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainMenuBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button relationTabButton;
        private System.Windows.Forms.Button factionTabButton;
        private System.Windows.Forms.Button guideTabButton;
        private System.Windows.Forms.Timer timeLabelTimer;
        private UserControls.factionPanel factionPanel1;
        private UserControls.guidePanel guidePanel1;
        private UserControls.relationPanel relationPanel1;
    }
}

