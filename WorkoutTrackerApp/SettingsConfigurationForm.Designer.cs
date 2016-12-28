namespace WorkoutTrackerApp
{
	partial class SettingsConfigurationForm
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
			this.labelDatabaseServer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelDatabaseServer
			// 
			this.labelDatabaseServer.AutoSize = true;
			this.labelDatabaseServer.Location = new System.Drawing.Point(13, 13);
			this.labelDatabaseServer.Name = "labelDatabaseServer";
			this.labelDatabaseServer.Size = new System.Drawing.Size(87, 13);
			this.labelDatabaseServer.TabIndex = 0;
			this.labelDatabaseServer.Text = "Database Server";
			// 
			// SettingsConfigurationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.labelDatabaseServer);
			this.Name = "SettingsConfigurationForm";
			this.Text = "SettingsConfigurationForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDatabaseServer;
	}
}