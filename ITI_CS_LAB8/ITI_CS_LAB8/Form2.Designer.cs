namespace ITI_CS_LAB8
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFont = new System.Windows.Forms.TabPage();
            this.gbFont = new System.Windows.Forms.GroupBox();
            this.rbCourier = new System.Windows.Forms.RadioButton();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.rbTimes = new System.Windows.Forms.RadioButton();
            this.tabSize = new System.Windows.Forms.TabPage();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rb24 = new System.Windows.Forms.RadioButton();
            this.rb20 = new System.Windows.Forms.RadioButton();
            this.rb16 = new System.Windows.Forms.RadioButton();
            this.tabColor = new System.Windows.Forms.TabPage();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.tabText = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.txtOldValue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabFont.SuspendLayout();
            this.gbFont.SuspendLayout();
            this.tabSize.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.tabColor.SuspendLayout();
            this.tabText.SuspendLayout();
            this.SuspendLayout();

            this.tabControl1.Controls.Add(this.tabFont);
            this.tabControl1.Controls.Add(this.tabSize);
            this.tabControl1.Controls.Add(this.tabColor);
            this.tabControl1.Controls.Add(this.tabText);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 200);
            this.tabControl1.TabIndex = 0;

            this.tabFont.Controls.Add(this.gbFont);
            this.tabFont.Location = new System.Drawing.Point(4, 22);
            this.tabFont.Name = "tabFont";
            this.tabFont.Padding = new System.Windows.Forms.Padding(3);
            this.tabFont.Size = new System.Drawing.Size(342, 174);
            this.tabFont.Text = "Font";
            this.tabFont.UseVisualStyleBackColor = true;

            this.gbFont.Controls.Add(this.rbCourier);
            this.gbFont.Controls.Add(this.rbArial);
            this.gbFont.Controls.Add(this.rbTimes);
            this.gbFont.Location = new System.Drawing.Point(20, 20);
            this.gbFont.Name = "gbFont";
            this.gbFont.Size = new System.Drawing.Size(200, 130);
            this.gbFont.TabIndex = 0;
            this.gbFont.TabStop = false;
            this.gbFont.Text = "Select Font";

            this.rbTimes.AutoSize = true;
            this.rbTimes.Location = new System.Drawing.Point(20, 30);
            this.rbTimes.Name = "rbTimes";
            this.rbTimes.Size = new System.Drawing.Size(115, 17);
            this.rbTimes.TabIndex = 0;
            this.rbTimes.TabStop = true;
            this.rbTimes.Text = "Times New Roman";
            this.rbTimes.UseVisualStyleBackColor = true;

            this.rbArial.AutoSize = true;
            this.rbArial.Location = new System.Drawing.Point(20, 60);
            this.rbArial.Name = "rbArial";
            this.rbArial.Size = new System.Drawing.Size(45, 17);
            this.rbArial.TabIndex = 1;
            this.rbArial.TabStop = true;
            this.rbArial.Text = "Arial";
            this.rbArial.UseVisualStyleBackColor = true;

            this.rbCourier.AutoSize = true;
            this.rbCourier.Location = new System.Drawing.Point(20, 90);
            this.rbCourier.Name = "rbCourier";
            this.rbCourier.Size = new System.Drawing.Size(83, 17);
            this.rbCourier.TabIndex = 2;
            this.rbCourier.TabStop = true;
            this.rbCourier.Text = "Courier New";
            this.rbCourier.UseVisualStyleBackColor = true;

            this.tabSize.Controls.Add(this.gbSize);
            this.tabSize.Location = new System.Drawing.Point(4, 22);
            this.tabSize.Name = "tabSize";
            this.tabSize.Size = new System.Drawing.Size(342, 174);
            this.tabSize.Text = "Size";
            this.tabSize.UseVisualStyleBackColor = true;

            this.gbSize.Controls.Add(this.rb24);
            this.gbSize.Controls.Add(this.rb20);
            this.gbSize.Controls.Add(this.rb16);
            this.gbSize.Location = new System.Drawing.Point(20, 20);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 130);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Select Size";

            this.rb16.AutoSize = true;
            this.rb16.Location = new System.Drawing.Point(20, 30);
            this.rb16.Name = "rb16";
            this.rb16.Size = new System.Drawing.Size(37, 17);
            this.rb16.TabIndex = 0;
            this.rb16.TabStop = true;
            this.rb16.Text = "16";
            this.rb16.UseVisualStyleBackColor = true;

            this.rb20.AutoSize = true;
            this.rb20.Location = new System.Drawing.Point(20, 60);
            this.rb20.Name = "rb20";
            this.rb20.Size = new System.Drawing.Size(37, 17);
            this.rb20.TabIndex = 1;
            this.rb20.TabStop = true;
            this.rb20.Text = "20";
            this.rb20.UseVisualStyleBackColor = true;

            this.rb24.AutoSize = true;
            this.rb24.Location = new System.Drawing.Point(20, 90);
            this.rb24.Name = "rb24";
            this.rb24.Size = new System.Drawing.Size(37, 17);
            this.rb24.TabIndex = 2;
            this.rb24.TabStop = true;
            this.rb24.Text = "24";
            this.rb24.UseVisualStyleBackColor = true;

            this.tabColor.Controls.Add(this.btnSelectColor);
            this.tabColor.Location = new System.Drawing.Point(4, 22);
            this.tabColor.Name = "tabColor";
            this.tabColor.Size = new System.Drawing.Size(342, 174);
            this.tabColor.Text = "Color";
            this.tabColor.UseVisualStyleBackColor = true;

            this.btnSelectColor.Location = new System.Drawing.Point(50, 50);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(200, 40);
            this.btnSelectColor.TabIndex = 0;
            this.btnSelectColor.Text = "Select Color...";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);

            this.tabText.Controls.Add(this.label2);
            this.tabText.Controls.Add(this.label1);
            this.tabText.Controls.Add(this.txtNewValue);
            this.tabText.Controls.Add(this.txtOldValue);
            this.tabText.Location = new System.Drawing.Point(4, 22);
            this.tabText.Name = "tabText";
            this.tabText.Size = new System.Drawing.Size(342, 174);
            this.tabText.Text = "Text";
            this.tabText.UseVisualStyleBackColor = true;

            this.txtOldValue.Location = new System.Drawing.Point(100, 30);
            this.txtOldValue.Name = "txtOldValue";
            this.txtOldValue.ReadOnly = true;
            this.txtOldValue.Size = new System.Drawing.Size(180, 20);
            this.txtOldValue.TabIndex = 0;

            this.txtNewValue.Location = new System.Drawing.Point(100, 70);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(180, 20);
            this.txtNewValue.TabIndex = 1;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.Text = "Old Value:";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.Text = "New Value:";

            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(206, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);


            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(287, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;

            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabFont.ResumeLayout(false);
            this.gbFont.ResumeLayout(false);
            this.gbFont.PerformLayout();
            this.tabSize.ResumeLayout(false);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.tabColor.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabText.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFont;
        private System.Windows.Forms.TabPage tabSize;
        private System.Windows.Forms.TabPage tabColor;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.GroupBox gbFont;
        private System.Windows.Forms.RadioButton rbCourier;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.RadioButton rbTimes;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rb24;
        private System.Windows.Forms.RadioButton rb20;
        private System.Windows.Forms.RadioButton rb16;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.TextBox txtOldValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}