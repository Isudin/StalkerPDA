namespace StalkerPDA.UserControls
{
    partial class factionPanel
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.factionStatusLabel = new System.Windows.Forms.Label();
            this.factionPanelLabel4 = new System.Windows.Forms.Label();
            this.factionMembersLabel = new System.Windows.Forms.Label();
            this.factionLeaderLabel = new System.Windows.Forms.Label();
            this.factionNameLabel = new System.Windows.Forms.Label();
            this.factionPanelLabel3 = new System.Windows.Forms.Label();
            this.factionPanelLabel2 = new System.Windows.Forms.Label();
            this.factionPanelLabel1 = new System.Windows.Forms.Label();
            this.factionListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // factionStatusLabel
            // 
            this.factionStatusLabel.AutoSize = true;
            this.factionStatusLabel.Location = new System.Drawing.Point(469, 113);
            this.factionStatusLabel.Name = "factionStatusLabel";
            this.factionStatusLabel.Size = new System.Drawing.Size(87, 17);
            this.factionStatusLabel.TabIndex = 27;
            this.factionStatusLabel.Text = "Brak danych";
            // 
            // factionPanelLabel4
            // 
            this.factionPanelLabel4.AutoSize = true;
            this.factionPanelLabel4.Location = new System.Drawing.Point(342, 113);
            this.factionPanelLabel4.Name = "factionPanelLabel4";
            this.factionPanelLabel4.Size = new System.Drawing.Size(52, 17);
            this.factionPanelLabel4.TabIndex = 26;
            this.factionPanelLabel4.Text = "Status:";
            // 
            // factionMembersLabel
            // 
            this.factionMembersLabel.AutoSize = true;
            this.factionMembersLabel.Location = new System.Drawing.Point(469, 86);
            this.factionMembersLabel.Name = "factionMembersLabel";
            this.factionMembersLabel.Size = new System.Drawing.Size(87, 17);
            this.factionMembersLabel.TabIndex = 25;
            this.factionMembersLabel.Text = "Brak danych";
            // 
            // factionLeaderLabel
            // 
            this.factionLeaderLabel.AutoSize = true;
            this.factionLeaderLabel.Location = new System.Drawing.Point(469, 58);
            this.factionLeaderLabel.Name = "factionLeaderLabel";
            this.factionLeaderLabel.Size = new System.Drawing.Size(87, 17);
            this.factionLeaderLabel.TabIndex = 24;
            this.factionLeaderLabel.Text = "Brak danych";
            // 
            // factionNameLabel
            // 
            this.factionNameLabel.AutoSize = true;
            this.factionNameLabel.Location = new System.Drawing.Point(469, 30);
            this.factionNameLabel.Name = "factionNameLabel";
            this.factionNameLabel.Size = new System.Drawing.Size(87, 17);
            this.factionNameLabel.TabIndex = 23;
            this.factionNameLabel.Text = "Brak danych";
            // 
            // factionPanelLabel3
            // 
            this.factionPanelLabel3.AutoSize = true;
            this.factionPanelLabel3.Location = new System.Drawing.Point(342, 86);
            this.factionPanelLabel3.Name = "factionPanelLabel3";
            this.factionPanelLabel3.Size = new System.Drawing.Size(70, 17);
            this.factionPanelLabel3.TabIndex = 22;
            this.factionPanelLabel3.Text = "Members:";
            // 
            // factionPanelLabel2
            // 
            this.factionPanelLabel2.AutoSize = true;
            this.factionPanelLabel2.Location = new System.Drawing.Point(342, 58);
            this.factionPanelLabel2.Name = "factionPanelLabel2";
            this.factionPanelLabel2.Size = new System.Drawing.Size(57, 17);
            this.factionPanelLabel2.TabIndex = 21;
            this.factionPanelLabel2.Text = "Leader:";
            // 
            // factionPanelLabel1
            // 
            this.factionPanelLabel1.AutoSize = true;
            this.factionPanelLabel1.Location = new System.Drawing.Point(342, 30);
            this.factionPanelLabel1.Name = "factionPanelLabel1";
            this.factionPanelLabel1.Size = new System.Drawing.Size(49, 17);
            this.factionPanelLabel1.TabIndex = 20;
            this.factionPanelLabel1.Text = "Name:";
            // 
            // factionListBox
            // 
            this.factionListBox.FormattingEnabled = true;
            this.factionListBox.ItemHeight = 16;
            this.factionListBox.Location = new System.Drawing.Point(23, 29);
            this.factionListBox.Name = "factionListBox";
            this.factionListBox.Size = new System.Drawing.Size(120, 292);
            this.factionListBox.TabIndex = 18;
            this.factionListBox.SelectedIndexChanged += new System.EventHandler(this.factionListBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(215, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // factionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.factionStatusLabel);
            this.Controls.Add(this.factionPanelLabel4);
            this.Controls.Add(this.factionMembersLabel);
            this.Controls.Add(this.factionLeaderLabel);
            this.Controls.Add(this.factionNameLabel);
            this.Controls.Add(this.factionPanelLabel3);
            this.Controls.Add(this.factionPanelLabel2);
            this.Controls.Add(this.factionPanelLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.factionListBox);
            this.Name = "factionPanel";
            this.Size = new System.Drawing.Size(776, 351);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label factionStatusLabel;
        private System.Windows.Forms.Label factionPanelLabel4;
        private System.Windows.Forms.Label factionMembersLabel;
        private System.Windows.Forms.Label factionLeaderLabel;
        private System.Windows.Forms.Label factionNameLabel;
        private System.Windows.Forms.Label factionPanelLabel3;
        private System.Windows.Forms.Label factionPanelLabel2;
        private System.Windows.Forms.Label factionPanelLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox factionListBox;
    }
}
