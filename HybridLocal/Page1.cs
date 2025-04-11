using Wisej.Services;
using Wisej.Web;

namespace HybridLocal
{
	public partial class Page1 : Page
	{
		
		[Inject()]
		DataRepository _dataRepository { get; set; }

		public Page1()
		{
			InitializeComponent();
		}

		private async void buttonSave_Click(object sender, System.EventArgs e)
		{
			// save the data to the remote database and wait for the reply.
			var success = await this._dataRepository.SaveValue(this.textBoxValue.Text);
			
			// show the reply.
			AlertBox.Show($"Success: {success}");
			
			// async operations may lose the application context, restore it.
			Application.Update(this);
		}

		private async void buttonGet_Click(object sender, System.EventArgs e)
		{
			// get the value from the remote database.
			var text = await this._dataRepository.GetValue();

			// update the label.
			this.labelValue.Text = text;

			// restore the session from the async operation.
			Application.Update(this);
		}
	}
}
 