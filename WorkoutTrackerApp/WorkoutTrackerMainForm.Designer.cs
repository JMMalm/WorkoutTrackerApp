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
			this.dgv_Workouts = new System.Windows.Forms.DataGridView();
			this.btn_NewWorkout = new System.Windows.Forms.Button();
			this.menuStripSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Workouts)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStripSettings
			// 
			this.menuStripSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
			this.menuStripSettings.Location = new System.Drawing.Point(0, 0);
			this.menuStripSettings.Name = "menuStripSettings";
			this.menuStripSettings.Size = new System.Drawing.Size(900, 24);
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
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// dgv_Workouts
			// 
			this.dgv_Workouts.AllowUserToAddRows = false;
			this.dgv_Workouts.AllowUserToDeleteRows = false;
			this.dgv_Workouts.AllowUserToResizeRows = false;
			this.dgv_Workouts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_Workouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Workouts.Location = new System.Drawing.Point(0, 100);
			this.dgv_Workouts.MinimumSize = new System.Drawing.Size(900, 150);
			this.dgv_Workouts.Name = "dgv_Workouts";
			this.dgv_Workouts.ReadOnly = true;
			this.dgv_Workouts.Size = new System.Drawing.Size(900, 150);
			this.dgv_Workouts.TabIndex = 1;
			// 
			// btn_NewWorkout
			// 
			this.btn_NewWorkout.Location = new System.Drawing.Point(12, 71);
			this.btn_NewWorkout.Name = "btn_NewWorkout";
			this.btn_NewWorkout.Size = new System.Drawing.Size(100, 23);
			this.btn_NewWorkout.TabIndex = 2;
			this.btn_NewWorkout.Text = "New Workout";
			this.btn_NewWorkout.UseVisualStyleBackColor = true;
			this.btn_NewWorkout.Click += new System.EventHandler(this.btn_NewWorkout_Click);
			// 
			// FormWorkoutTrackerMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 562);
			this.Controls.Add(this.btn_NewWorkout);
			this.Controls.Add(this.dgv_Workouts);
			this.Controls.Add(this.menuStripSettings);
			this.MainMenuStrip = this.menuStripSettings;
			this.MinimumSize = new System.Drawing.Size(916, 300);
			this.Name = "FormWorkoutTrackerMain";
			this.Text = "Workout Tracker";
			this.Shown += new System.EventHandler(this.FormWorkoutTrackerMain_Shown);
			this.menuStripSettings.ResumeLayout(false);
			this.menuStripSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Workouts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripSettings;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.DataGridView dgv_Workouts;
		private System.Windows.Forms.Button btn_NewWorkout;
	}
}

