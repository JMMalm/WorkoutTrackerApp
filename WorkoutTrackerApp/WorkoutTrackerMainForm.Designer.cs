namespace WorkoutTrackerApp
{
	partial class FormWorkoutTrackerMain
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
			this.menuStripSettings = new System.Windows.Forms.MenuStrip();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DataGridViewWorkouts = new System.Windows.Forms.DataGridView();
			this.ButtonNewWorkout = new System.Windows.Forms.Button();
			this.menuStripSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewWorkouts)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStripSettings
			// 
			this.menuStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
			this.menuStripSettings.Location = new System.Drawing.Point(0, 0);
			this.menuStripSettings.Name = "menuStripSettings";
			this.menuStripSettings.Size = new System.Drawing.Size(1064, 24);
			this.menuStripSettings.TabIndex = 0;
			this.menuStripSettings.Text = "Settings";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// configurationToolStripMenuItem
			// 
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.configurationToolStripMenuItem.Text = "Configuration";
			this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// DataGridViewWorkouts
			// 
			this.DataGridViewWorkouts.AllowUserToAddRows = false;
			this.DataGridViewWorkouts.AllowUserToDeleteRows = false;
			this.DataGridViewWorkouts.AllowUserToResizeRows = false;
			this.DataGridViewWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridViewWorkouts.Location = new System.Drawing.Point(13, 100);
			this.DataGridViewWorkouts.Name = "DataGridViewWorkouts";
			this.DataGridViewWorkouts.ReadOnly = true;
			this.DataGridViewWorkouts.Size = new System.Drawing.Size(900, 150);
			this.DataGridViewWorkouts.TabIndex = 1;
			// 
			// ButtonNewWorkout
			// 
			this.ButtonNewWorkout.Location = new System.Drawing.Point(952, 28);
			this.ButtonNewWorkout.Name = "ButtonNewWorkout";
			this.ButtonNewWorkout.Size = new System.Drawing.Size(100, 23);
			this.ButtonNewWorkout.TabIndex = 2;
			this.ButtonNewWorkout.Text = "New Workout";
			this.ButtonNewWorkout.UseVisualStyleBackColor = true;
			// 
			// FormWorkoutTrackerMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 262);
			this.Controls.Add(this.ButtonNewWorkout);
			this.Controls.Add(this.DataGridViewWorkouts);
			this.Controls.Add(this.menuStripSettings);
			this.MainMenuStrip = this.menuStripSettings;
			this.Name = "FormWorkoutTrackerMain";
			this.Text = "Workout Tracker";
			this.Shown += new System.EventHandler(this.FormWorkoutTrackerMain_Shown);
			this.menuStripSettings.ResumeLayout(false);
			this.menuStripSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewWorkouts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripSettings;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.DataGridView DataGridViewWorkouts;
		private System.Windows.Forms.Button ButtonNewWorkout;
	}
}

