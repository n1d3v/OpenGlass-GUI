
namespace OpenGlass_GUI
{
    partial class Util
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.centerBox = new System.Windows.Forms.CheckBox();
            this.captionBox = new System.Windows.Forms.ComboBox();
            this.captionLabel = new System.Windows.Forms.Label();
            this.configLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.generalTab);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(314, 400);
            this.tabControl.TabIndex = 0;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.centerBox);
            this.generalTab.Controls.Add(this.captionBox);
            this.generalTab.Controls.Add(this.captionLabel);
            this.generalTab.Controls.Add(this.configLabel);
            this.generalTab.Location = new System.Drawing.Point(4, 24);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(306, 372);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // centerBox
            // 
            this.centerBox.AutoSize = true;
            this.centerBox.Location = new System.Drawing.Point(18, 65);
            this.centerBox.Name = "centerBox";
            this.centerBox.Size = new System.Drawing.Size(187, 19);
            this.centerBox.TabIndex = 4;
            this.centerBox.Text = "Center the titlebar caption text";
            this.centerBox.UseVisualStyleBackColor = true;
            this.centerBox.CheckedChanged += new System.EventHandler(this.centerBox_CheckedChanged);
            // 
            // captionBox
            // 
            this.captionBox.FormattingEnabled = true;
            this.captionBox.Items.AddRange(new object[] {
            "Windows 10 style (Default)",
            "Windows 8.x style",
            "Windows 7 style",
            "Windows Vista style"});
            this.captionBox.Location = new System.Drawing.Point(136, 35);
            this.captionBox.Name = "captionBox";
            this.captionBox.Size = new System.Drawing.Size(155, 23);
            this.captionBox.TabIndex = 2;
            this.captionBox.SelectedIndexChanged += new System.EventHandler(this.captionBox_SelectedIndexChanged);
            // 
            // captionLabel
            // 
            this.captionLabel.AutoSize = true;
            this.captionLabel.Location = new System.Drawing.Point(15, 38);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(115, 15);
            this.captionLabel.TabIndex = 1;
            this.captionLabel.Text = "Caption button style";
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.configLabel.Location = new System.Drawing.Point(15, 11);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(195, 15);
            this.configLabel.TabIndex = 0;
            this.configLabel.Text = "Configure OpenGlass to your liking.";
            // 
            // Util
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 424);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Util";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenGlass Configuration Utility";
            this.tabControl.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.ComboBox captionBox;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.CheckBox centerBox;
    }
}

