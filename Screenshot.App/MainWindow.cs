namespace Screenshot.App
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You've accidentally clicked on the label.");
        }

        private void btnWindow_Click(object sender, EventArgs e)
        {
            var windowSelection = new WindowSelection();
            windowSelection.Show();
        }
    }
}
