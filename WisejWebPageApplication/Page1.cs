using Wisej.Web;

namespace WisejWebPageApplication
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			AlertBox.Show(DataRepository.GetValue());
		}
	}
}
