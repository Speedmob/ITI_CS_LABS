namespace ITI_CS_LAB8
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

            lblCompanyName.Text = "My Company";
            lblCompanyName.Font = new Font("Arial", 16);
            lblCompanyName.ForeColor = Color.Black;
        }

        private void companyNameTool_Click(object sender, EventArgs e)
        {
            string currentFont = lblCompanyName.Font.Name;
            float currentSize = lblCompanyName.Font.Size;
            Color currentColor = lblCompanyName.ForeColor;
            string currentText = lblCompanyName.Text;

            using (Form2 dlg = new Form2(currentFont, currentSize, currentColor, currentText))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lblCompanyName.Text = dlg.NewCompanyName;
                    lblCompanyName.ForeColor = dlg.SelectedColor;
                    lblCompanyName.Font = new Font(dlg.SelectedFontName, dlg.SelectedFontSize);
                }
        }
        }
    }
}
