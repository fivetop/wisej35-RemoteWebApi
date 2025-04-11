namespace HybridLocal
{
	partial class Page1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonSave = new Wisej.Web.Button();
			this.textBoxValue = new Wisej.Web.TextBox();
			this.labelValue = new Wisej.Web.Label();
			this.buttonGet = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(43, 86);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(215, 37);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Save Data";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// textBoxValue
			// 
			this.textBoxValue.Location = new System.Drawing.Point(43, 37);
			this.textBoxValue.Name = "textBoxValue";
			this.textBoxValue.Size = new System.Drawing.Size(215, 30);
			this.textBoxValue.TabIndex = 1;
			// 
			// label1
			// 
			this.labelValue.Location = new System.Drawing.Point(43, 242);
			this.labelValue.Name = "label1";
			this.labelValue.Size = new System.Drawing.Size(215, 185);
			this.labelValue.TabIndex = 2;
			this.labelValue.Text = "...";
			// 
			// buttonGet
			// 
			this.buttonGet.Location = new System.Drawing.Point(43, 199);
			this.buttonGet.Name = "buttonGet";
			this.buttonGet.Size = new System.Drawing.Size(215, 37);
			this.buttonGet.TabIndex = 3;
			this.buttonGet.Text = "Fetch Data";
			this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.buttonGet);
			this.Controls.Add(this.labelValue);
			this.Controls.Add(this.textBoxValue);
			this.Controls.Add(this.buttonSave);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1787, 834);
			this.Text = "Page1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Button buttonSave;
		private Wisej.Web.TextBox textBoxValue;
		private Wisej.Web.Label labelValue;
		private Wisej.Web.Button buttonGet;
	}
}

