namespace WorkoutTrackerApp
{
	partial class WorkoutSetsForm
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
			this.dgv_WorkoutSets = new System.Windows.Forms.DataGridView();
			this.btn_Save = new System.Windows.Forms.Button();
			this.dtp_StartDateTime = new System.Windows.Forms.DateTimePicker();
			this.dtp_EndDateTime = new System.Windows.Forms.DateTimePicker();
			this.tbx_Location = new System.Windows.Forms.TextBox();
			this.lbl_Location = new System.Windows.Forms.Label();
			this.lbl_StartDateTime = new System.Windows.Forms.Label();
			this.lbl_EndDateTime = new System.Windows.Forms.Label();
			this.dtp_StartTime = new System.Windows.Forms.DateTimePicker();
			this.dtp_EndTime = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgv_WorkoutSets)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_WorkoutSets
			// 
			this.dgv_WorkoutSets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_WorkoutSets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_WorkoutSets.Location = new System.Drawing.Point(12, 98);
			this.dgv_WorkoutSets.Name = "dgv_WorkoutSets";
			this.dgv_WorkoutSets.Size = new System.Drawing.Size(876, 150);
			this.dgv_WorkoutSets.TabIndex = 0;
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(12, 527);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 1;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			// 
			// dtp_StartDateTime
			// 
			this.dtp_StartDateTime.Location = new System.Drawing.Point(12, 29);
			this.dtp_StartDateTime.Name = "dtp_StartDateTime";
			this.dtp_StartDateTime.Size = new System.Drawing.Size(200, 20);
			this.dtp_StartDateTime.TabIndex = 2;
			// 
			// dtp_EndDateTime
			// 
			this.dtp_EndDateTime.Location = new System.Drawing.Point(12, 72);
			this.dtp_EndDateTime.Name = "dtp_EndDateTime";
			this.dtp_EndDateTime.Size = new System.Drawing.Size(200, 20);
			this.dtp_EndDateTime.TabIndex = 3;
			// 
			// tbx_Location
			// 
			this.tbx_Location.Location = new System.Drawing.Point(324, 29);
			this.tbx_Location.MinimumSize = new System.Drawing.Size(100, 20);
			this.tbx_Location.Name = "tbx_Location";
			this.tbx_Location.Size = new System.Drawing.Size(150, 20);
			this.tbx_Location.TabIndex = 4;
			// 
			// lbl_Location
			// 
			this.lbl_Location.AutoSize = true;
			this.lbl_Location.Location = new System.Drawing.Point(321, 13);
			this.lbl_Location.Name = "lbl_Location";
			this.lbl_Location.Size = new System.Drawing.Size(48, 13);
			this.lbl_Location.TabIndex = 5;
			this.lbl_Location.Text = "Location";
			// 
			// lbl_StartDateTime
			// 
			this.lbl_StartDateTime.AutoSize = true;
			this.lbl_StartDateTime.Location = new System.Drawing.Point(12, 13);
			this.lbl_StartDateTime.Name = "lbl_StartDateTime";
			this.lbl_StartDateTime.Size = new System.Drawing.Size(102, 13);
			this.lbl_StartDateTime.TabIndex = 6;
			this.lbl_StartDateTime.Text = "Start Date and Time";
			// 
			// lbl_EndDateTime
			// 
			this.lbl_EndDateTime.AutoSize = true;
			this.lbl_EndDateTime.Location = new System.Drawing.Point(12, 56);
			this.lbl_EndDateTime.Name = "lbl_EndDateTime";
			this.lbl_EndDateTime.Size = new System.Drawing.Size(99, 13);
			this.lbl_EndDateTime.TabIndex = 7;
			this.lbl_EndDateTime.Text = "End Date and Time";
			// 
			// dtp_StartTime
			// 
			this.dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtp_StartTime.Location = new System.Drawing.Point(218, 29);
			this.dtp_StartTime.Name = "dtp_StartTime";
			this.dtp_StartTime.ShowUpDown = true;
			this.dtp_StartTime.Size = new System.Drawing.Size(100, 20);
			this.dtp_StartTime.TabIndex = 8;
			// 
			// dtp_EndTime
			// 
			this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtp_EndTime.Location = new System.Drawing.Point(218, 72);
			this.dtp_EndTime.Name = "dtp_EndTime";
			this.dtp_EndTime.ShowUpDown = true;
			this.dtp_EndTime.Size = new System.Drawing.Size(100, 20);
			this.dtp_EndTime.TabIndex = 9;
			// 
			// WorkoutSetsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 562);
			this.Controls.Add(this.dtp_EndTime);
			this.Controls.Add(this.dtp_StartTime);
			this.Controls.Add(this.lbl_EndDateTime);
			this.Controls.Add(this.lbl_StartDateTime);
			this.Controls.Add(this.lbl_Location);
			this.Controls.Add(this.tbx_Location);
			this.Controls.Add(this.dtp_EndDateTime);
			this.Controls.Add(this.dtp_StartDateTime);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.dgv_WorkoutSets);
			this.MinimumSize = new System.Drawing.Size(916, 300);
			this.Name = "WorkoutSetsForm";
			this.Text = "Workout Sets";
			((System.ComponentModel.ISupportInitialize)(this.dgv_WorkoutSets)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_WorkoutSets;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.DateTimePicker dtp_StartDateTime;
		private System.Windows.Forms.DateTimePicker dtp_EndDateTime;
		private System.Windows.Forms.TextBox tbx_Location;
		private System.Windows.Forms.Label lbl_Location;
		private System.Windows.Forms.Label lbl_StartDateTime;
		private System.Windows.Forms.Label lbl_EndDateTime;
		private System.Windows.Forms.DateTimePicker dtp_StartTime;
		private System.Windows.Forms.DateTimePicker dtp_EndTime;
	}
}