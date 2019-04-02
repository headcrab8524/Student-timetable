﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
	public partial class Groups : Form
	{
		public Groups()
		{
			InitializeComponent();
			DG_Group.AutoGenerateColumns = false;
			DG_Group.DataSource = Controllers.CGroup.Select();
		}

		private void DeleteRow(object sender, EventArgs e)
		{
			if (DG_Group.SelectedRows.Count > 0)
			{
				MGroup mGroup;
				foreach (DataGridViewRow row in DG_Group.SelectedRows)
				{
					DataRow Row = ((DataRowView)row.DataBoundItem).Row;
					mGroup = new MGroup((string)Row["Group"]);
					Controllers.CGroup.Delete(mGroup);
				}
			}
		}

		private void AddRow(object sender, EventArgs e)
		{
		}
	}
}
