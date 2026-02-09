using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITI_CS_LAB8
{
    public partial class Form2 : Form
    {
        public string SelectedFontName { get; private set; }
        public float SelectedFontSize { get; private set; }
        public Color SelectedColor { get; private set; }
        public string NewCompanyName { get; private set; }
        public Form2(string currentFont, float currentSize, Color currentColor, string currentName)
        {
            InitializeComponent();

            SelectedFontName = currentFont;
            SelectedFontSize = currentSize;
            SelectedColor = currentColor;

            if (currentFont == "Times New Roman") rbTimes.Checked = true;
            else if (currentFont == "Arial") rbArial.Checked = true;
            else if (currentFont == "Courier New") rbCourier.Checked = true;

            if (currentSize == 16) rb16.Checked = true;
            else if (currentSize == 20) rb20.Checked = true;
            else if (currentSize == 24) rb24.Checked = true;

            btnSelectColor.BackColor = currentColor;

            txtOldValue.Text = currentName;
            txtOldValue.ReadOnly = true;
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = SelectedColor; 

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = colorDialog.Color;
                btnSelectColor.BackColor = SelectedColor;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbTimes.Checked) SelectedFontName = "Times New Roman";
            else if (rbArial.Checked) SelectedFontName = "Arial";
            else if (rbCourier.Checked) SelectedFontName = "Courier New";

            if (rb16.Checked) SelectedFontSize = 16;
            else if (rb20.Checked) SelectedFontSize = 20;
            else if (rb24.Checked) SelectedFontSize = 24;

            if (!string.IsNullOrWhiteSpace(txtNewValue.Text))
                NewCompanyName = txtNewValue.Text;
            else
                NewCompanyName = txtOldValue.Text;

        }
    }
}
