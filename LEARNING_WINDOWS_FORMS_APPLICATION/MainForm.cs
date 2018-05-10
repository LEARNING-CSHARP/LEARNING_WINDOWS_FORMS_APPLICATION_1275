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
			//titleLabel.Left = (Width - titleLabel.Width) / 2;
			//titleLabel.Top = (Height - titleLabel.Height) / 2;

			MoveLabelCenter();
		}

		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			//titleLabel.Left = (Width - titleLabel.Width) / 2;
			//titleLabel.Top = (Height - titleLabel.Height) / 2;

			MoveLabelCenter();
		}

		/// <summary>
		/// دقت کنید که اگر ویژگی
		/// Anchor
		/// کتنرلی را
		/// none
		/// قرار دهیم، به طور اتوماتیک در اثر تغییر اندازه فرم، کنترل به نسبتی که از لبه‌ها فاصله دارد
		/// جابجا می‌شود
		/// </summary>
		private void MoveLabelCenter()
		{
			//titleLabel.Left = (Width - titleLabel.Width) / 2;
			//titleLabel.Top = (Height - titleLabel.Height) / 2;

			System.Drawing.Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);

			int titleHeight = screenRectangle.Top - Top;

			titleLabel.Left = (Width - titleLabel.Width) / 2;
			titleLabel.Top = (Height - titleHeight - titleLabel.Height) / 2;
		}
	}
}
