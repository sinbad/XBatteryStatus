
namespace XBatteryStatus {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.updateFrequency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notificationsEnabled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.audioFileDropDown = new System.Windows.Forms.ComboBox();
            this.testAudio = new System.Windows.Forms.Button();
            this.audioEnabled = new System.Windows.Forms.CheckBox();
            this.audioLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Warning0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Warning1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Warning2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // updateFrequency
            // 
            this.updateFrequency.Location = new System.Drawing.Point(5, 5);
            this.updateFrequency.Margin = new System.Windows.Forms.Padding(5, 5, 2, 3);
            this.updateFrequency.MaxLength = 5;
            this.updateFrequency.Name = "updateFrequency";
            this.updateFrequency.Size = new System.Drawing.Size(45, 31);
            this.updateFrequency.TabIndex = 0;
            this.updateFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.updateFrequency_Validating);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Frequency:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.notificationsEnabled, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.audioEnabled, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.audioLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 203);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.updateFrequency);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(237, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(300, 40);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "seconds";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Low Battery Notifications?";
            // 
            // notificationsEnabled
            // 
            this.notificationsEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.notificationsEnabled.AutoSize = true;
            this.notificationsEnabled.Location = new System.Drawing.Point(242, 49);
            this.notificationsEnabled.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.notificationsEnabled.Name = "notificationsEnabled";
            this.notificationsEnabled.Size = new System.Drawing.Size(22, 21);
            this.notificationsEnabled.TabIndex = 6;
            this.notificationsEnabled.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Audio File:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.audioFileDropDown);
            this.flowLayoutPanel2.Controls.Add(this.testAudio);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(240, 163);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(308, 37);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // audioFileDropDown
            // 
            this.audioFileDropDown.FormattingEnabled = true;
            this.audioFileDropDown.ItemHeight = 25;
            this.audioFileDropDown.Location = new System.Drawing.Point(3, 3);
            this.audioFileDropDown.Name = "audioFileDropDown";
            this.audioFileDropDown.Size = new System.Drawing.Size(134, 33);
            this.audioFileDropDown.TabIndex = 8;
            // 
            // testAudio
            // 
            this.testAudio.Location = new System.Drawing.Point(143, 3);
            this.testAudio.Name = "testAudio";
            this.testAudio.Size = new System.Drawing.Size(112, 34);
            this.testAudio.TabIndex = 9;
            this.testAudio.Text = "Test";
            this.testAudio.UseVisualStyleBackColor = true;
            this.testAudio.Click += new System.EventHandler(this.testAudio_Click);
            // 
            // audioEnabled
            // 
            this.audioEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.audioEnabled.AutoSize = true;
            this.audioEnabled.Location = new System.Drawing.Point(242, 129);
            this.audioEnabled.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.audioEnabled.Name = "audioEnabled";
            this.audioEnabled.Size = new System.Drawing.Size(22, 21);
            this.audioEnabled.TabIndex = 7;
            this.audioEnabled.UseVisualStyleBackColor = true;
            // 
            // audioLabel
            // 
            this.audioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.audioLabel.AutoSize = true;
            this.audioLabel.Location = new System.Drawing.Point(122, 125);
            this.audioLabel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.audioLabel.Name = "audioLabel";
            this.audioLabel.Size = new System.Drawing.Size(105, 25);
            this.audioLabel.TabIndex = 3;
            this.audioLabel.Text = "Play Audio?";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Warning Levels:";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.Warning0);
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.Warning1);
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.Warning2);
            this.flowLayoutPanel4.Controls.Add(this.label8);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(237, 80);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(300, 40);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // Warning0
            // 
            this.Warning0.Location = new System.Drawing.Point(5, 5);
            this.Warning0.Margin = new System.Windows.Forms.Padding(5, 5, 0, 3);
            this.Warning0.MaxLength = 5;
            this.Warning0.Name = "Warning0";
            this.Warning0.Size = new System.Drawing.Size(45, 31);
            this.Warning0.TabIndex = 0;
            this.Warning0.Validating += new System.ComponentModel.CancelEventHandler(this.Warning0_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 7, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "%";
            // 
            // Warning1
            // 
            this.Warning1.Location = new System.Drawing.Point(87, 5);
            this.Warning1.Margin = new System.Windows.Forms.Padding(5, 5, 0, 3);
            this.Warning1.MaxLength = 5;
            this.Warning1.Name = "Warning1";
            this.Warning1.Size = new System.Drawing.Size(45, 31);
            this.Warning1.TabIndex = 0;
            this.Warning1.Validating += new System.ComponentModel.CancelEventHandler(this.Warning0_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 7, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "%";
            // 
            // Warning2
            // 
            this.Warning2.Location = new System.Drawing.Point(169, 5);
            this.Warning2.Margin = new System.Windows.Forms.Padding(5, 5, 0, 3);
            this.Warning2.MaxLength = 5;
            this.Warning2.Name = "Warning2";
            this.Warning2.Size = new System.Drawing.Size(45, 31);
            this.Warning2.TabIndex = 0;
            this.Warning2.Validating += new System.ComponentModel.CancelEventHandler(this.Warning0_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 7, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "%";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(190, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 34);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(77, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(107, 34);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.okButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(265, 222);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 41);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(573, 264);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XBatteryStatus Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox updateFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label audioLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox audioEnabled;
        private System.Windows.Forms.CheckBox notificationsEnabled;
        private System.Windows.Forms.ComboBox audioFileDropDown;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button testAudio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox Warning0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Warning1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Warning2;
        private System.Windows.Forms.Label label8;
    }
}