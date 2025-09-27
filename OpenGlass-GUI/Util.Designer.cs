
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
            this.glassBox = new System.Windows.Forms.CheckBox();
            this.centerBox = new System.Windows.Forms.CheckBox();
            this.captionBox = new System.Windows.Forms.ComboBox();
            this.captionLabel = new System.Windows.Forms.Label();
            this.configLabel = new System.Windows.Forms.Label();
            this.shaderBox = new System.Windows.Forms.ComboBox();
            this.shaderLabel = new System.Windows.Forms.Label();
            this.advancedTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.captionTextBtn = new System.Windows.Forms.RadioButton();
            this.accentOverriderBtn = new System.Windows.Forms.RadioButton();
            this.glassFrameBtn = new System.Windows.Forms.RadioButton();
            this.glassReflectionBtn = new System.Windows.Forms.RadioButton();
            this.glassBatteryBox = new System.Windows.Forms.CheckBox();
            this.memDumpsBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.D3DBox = new System.Windows.Forms.CheckBox();
            this.colouringTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.advancedTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.generalTab);
            this.tabControl.Controls.Add(this.colouringTab);
            this.tabControl.Controls.Add(this.advancedTab);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(340, 400);
            this.tabControl.TabIndex = 0;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.shaderBox);
            this.generalTab.Controls.Add(this.shaderLabel);
            this.generalTab.Controls.Add(this.glassBox);
            this.generalTab.Controls.Add(this.centerBox);
            this.generalTab.Controls.Add(this.captionBox);
            this.generalTab.Controls.Add(this.captionLabel);
            this.generalTab.Controls.Add(this.configLabel);
            this.generalTab.Location = new System.Drawing.Point(4, 24);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(332, 372);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // glassBox
            // 
            this.glassBox.AutoSize = true;
            this.glassBox.Location = new System.Drawing.Point(19, 61);
            this.glassBox.Name = "glassBox";
            this.glassBox.Size = new System.Drawing.Size(164, 19);
            this.glassBox.TabIndex = 5;
            this.glassBox.Text = "Disable glass transparency";
            this.glassBox.UseVisualStyleBackColor = true;
            this.glassBox.CheckedChanged += new System.EventHandler(this.glassBox_CheckedChanged);
            // 
            // centerBox
            // 
            this.centerBox.AutoSize = true;
            this.centerBox.Location = new System.Drawing.Point(19, 116);
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
            this.captionBox.Location = new System.Drawing.Point(137, 86);
            this.captionBox.Name = "captionBox";
            this.captionBox.Size = new System.Drawing.Size(180, 23);
            this.captionBox.TabIndex = 2;
            this.captionBox.SelectedIndexChanged += new System.EventHandler(this.captionBox_SelectedIndexChanged);
            // 
            // captionLabel
            // 
            this.captionLabel.AutoSize = true;
            this.captionLabel.Location = new System.Drawing.Point(16, 89);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(115, 15);
            this.captionLabel.TabIndex = 1;
            this.captionLabel.Text = "Caption button style";
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.configLabel.Location = new System.Drawing.Point(16, 11);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(195, 15);
            this.configLabel.TabIndex = 0;
            this.configLabel.Text = "Configure OpenGlass to your liking.";
            // 
            // shaderBox
            // 
            this.shaderBox.FormattingEnabled = true;
            this.shaderBox.Items.AddRange(new object[] {
            "Aero style shader",
            "Vista style shader"});
            this.shaderBox.Location = new System.Drawing.Point(120, 32);
            this.shaderBox.Name = "shaderBox";
            this.shaderBox.Size = new System.Drawing.Size(197, 23);
            this.shaderBox.TabIndex = 7;
            this.shaderBox.SelectedIndexChanged += new System.EventHandler(this.shaderBox_SelectedIndexChanged);
            // 
            // shaderLabel
            // 
            this.shaderLabel.AutoSize = true;
            this.shaderLabel.Location = new System.Drawing.Point(16, 35);
            this.shaderLabel.Name = "shaderLabel";
            this.shaderLabel.Size = new System.Drawing.Size(98, 15);
            this.shaderLabel.TabIndex = 6;
            this.shaderLabel.Text = "Aero Shader style";
            // 
            // advancedTab
            // 
            this.advancedTab.Controls.Add(this.D3DBox);
            this.advancedTab.Controls.Add(this.label3);
            this.advancedTab.Controls.Add(this.memDumpsBox);
            this.advancedTab.Controls.Add(this.glassBatteryBox);
            this.advancedTab.Controls.Add(this.glassReflectionBtn);
            this.advancedTab.Controls.Add(this.glassFrameBtn);
            this.advancedTab.Controls.Add(this.accentOverriderBtn);
            this.advancedTab.Controls.Add(this.captionTextBtn);
            this.advancedTab.Controls.Add(this.label2);
            this.advancedTab.Controls.Add(this.label1);
            this.advancedTab.Location = new System.Drawing.Point(4, 24);
            this.advancedTab.Name = "advancedTab";
            this.advancedTab.Size = new System.Drawing.Size(332, 372);
            this.advancedTab.TabIndex = 1;
            this.advancedTab.Text = "Advanced";
            this.advancedTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Only enable these if you know what you\'re doing.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Disable module hooks for OpenGlass";
            // 
            // captionTextBtn
            // 
            this.captionTextBtn.AutoSize = true;
            this.captionTextBtn.Location = new System.Drawing.Point(19, 56);
            this.captionTextBtn.Name = "captionTextBtn";
            this.captionTextBtn.Size = new System.Drawing.Size(194, 19);
            this.captionTextBtn.TabIndex = 3;
            this.captionTextBtn.TabStop = true;
            this.captionTextBtn.Text = "Disable CaptionTextHandler.cpp";
            this.captionTextBtn.UseVisualStyleBackColor = true;
            // 
            // accentOverriderBtn
            // 
            this.accentOverriderBtn.AutoSize = true;
            this.accentOverriderBtn.Location = new System.Drawing.Point(19, 81);
            this.accentOverriderBtn.Name = "accentOverriderBtn";
            this.accentOverriderBtn.Size = new System.Drawing.Size(175, 19);
            this.accentOverriderBtn.TabIndex = 4;
            this.accentOverriderBtn.TabStop = true;
            this.accentOverriderBtn.Text = "Disable AccentOverrider.cpp";
            this.accentOverriderBtn.UseVisualStyleBackColor = true;
            // 
            // glassFrameBtn
            // 
            this.glassFrameBtn.AutoSize = true;
            this.glassFrameBtn.Location = new System.Drawing.Point(19, 106);
            this.glassFrameBtn.Name = "glassFrameBtn";
            this.glassFrameBtn.Size = new System.Drawing.Size(191, 19);
            this.glassFrameBtn.TabIndex = 5;
            this.glassFrameBtn.TabStop = true;
            this.glassFrameBtn.Text = "Disable GlassFrameHandler.cpp";
            this.glassFrameBtn.UseVisualStyleBackColor = true;
            // 
            // glassReflectionBtn
            // 
            this.glassReflectionBtn.AutoSize = true;
            this.glassReflectionBtn.Location = new System.Drawing.Point(19, 131);
            this.glassReflectionBtn.Name = "glassReflectionBtn";
            this.glassReflectionBtn.Size = new System.Drawing.Size(211, 19);
            this.glassReflectionBtn.TabIndex = 6;
            this.glassReflectionBtn.TabStop = true;
            this.glassReflectionBtn.Text = "Disable GlassReflectionHandler.cpp";
            this.glassReflectionBtn.UseVisualStyleBackColor = true;
            // 
            // glassBatteryBox
            // 
            this.glassBatteryBox.AutoSize = true;
            this.glassBatteryBox.Location = new System.Drawing.Point(19, 180);
            this.glassBatteryBox.Name = "glassBatteryBox";
            this.glassBatteryBox.Size = new System.Drawing.Size(184, 19);
            this.glassBatteryBox.TabIndex = 7;
            this.glassBatteryBox.Text = "Disable glass whilst on battery";
            this.glassBatteryBox.UseVisualStyleBackColor = true;
            // 
            // memDumpsBox
            // 
            this.memDumpsBox.AutoSize = true;
            this.memDumpsBox.Location = new System.Drawing.Point(19, 205);
            this.memDumpsBox.Name = "memDumpsBox";
            this.memDumpsBox.Size = new System.Drawing.Size(259, 19);
            this.memDumpsBox.TabIndex = 8;
            this.memDumpsBox.Text = "Disable memory dumps when DWM crashes";
            this.memDumpsBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Other advanced settings";
            // 
            // D3DBox
            // 
            this.D3DBox.AutoSize = true;
            this.D3DBox.Location = new System.Drawing.Point(19, 230);
            this.D3DBox.Name = "D3DBox";
            this.D3DBox.Size = new System.Drawing.Size(291, 19);
            this.D3DBox.TabIndex = 10;
            this.D3DBox.Text = "Enable Direct3D rendering (Only with Aero shader)";
            this.D3DBox.UseVisualStyleBackColor = true;
            // 
            // colouringTab
            // 
            this.colouringTab.Location = new System.Drawing.Point(4, 24);
            this.colouringTab.Name = "colouringTab";
            this.colouringTab.Size = new System.Drawing.Size(332, 372);
            this.colouringTab.TabIndex = 2;
            this.colouringTab.Text = "Colouring";
            this.colouringTab.UseVisualStyleBackColor = true;
            this.colouringTab.UseWaitCursor = true;
            // 
            // Util
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 424);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Util";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenGlass Configuration Utility";
            this.tabControl.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.advancedTab.ResumeLayout(false);
            this.advancedTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.ComboBox captionBox;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.CheckBox centerBox;
        private System.Windows.Forms.CheckBox glassBox;
        private System.Windows.Forms.ComboBox shaderBox;
        private System.Windows.Forms.Label shaderLabel;
        private System.Windows.Forms.TabPage advancedTab;
        private System.Windows.Forms.RadioButton glassReflectionBtn;
        private System.Windows.Forms.RadioButton glassFrameBtn;
        private System.Windows.Forms.RadioButton accentOverriderBtn;
        private System.Windows.Forms.RadioButton captionTextBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox memDumpsBox;
        private System.Windows.Forms.CheckBox glassBatteryBox;
        private System.Windows.Forms.CheckBox D3DBox;
        private System.Windows.Forms.TabPage colouringTab;
    }
}

