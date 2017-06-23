namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			MakeCenter();
		}

		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			MakeCenter();
		}

		private void MakeCenter()
		{
			titleLabel.Left = (Width - titleLabel.Width) / 2;
			titleLabel.Top = (Height - titleLabel.Height) / 2;
		}
	}
}
