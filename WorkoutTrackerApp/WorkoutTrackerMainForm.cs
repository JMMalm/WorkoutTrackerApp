﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutTrackerApp
{
	public partial class formWorkoutTrackerMain : Form
	{
		public formWorkoutTrackerMain()
		{
			InitializeComponent();
		}

		private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SettingsConfigurationForm settingsConfig = new SettingsConfigurationForm();
			settingsConfig.Show();
		}
	}
}
