using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace cs39_07_formsandclasses
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ValidatePasswords()
		{
			if (passwordBox.Text != confirmPasswordBox.Text
				&& passwordBox.Text != string.Empty
				&& confirmPasswordBox.Text != string.Empty)
			{
				passwordBox.BackColor = Color.Red;
				confirmPasswordBox.BackColor = Color.Red;
			} else {
				passwordBox.BackColor = Color.Empty;
				confirmPasswordBox.BackColor = Color.Empty;
			}
		}

		private void majorBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			specialties.Clear();
			string major = majorBox.Text.ToString();

			if (major != null)
				UpdateSpecialties(major);
		}

		private void UpdateSpecialties(string s)
		{
			switch (s) {
				case "Biology":
					specialties.Add("Anatomy");
					specialties.Add("Biophysics");
					specialties.Add("Genetics");
					specialties.Add("Molecular");
					break;
				case "Computer Science":
					specialties.Add("Artificial Intelligence");
					specialties.Add("Bioinformatics");
					specialties.Add("Databases");
					specialties.Add("Networking");
					break;
				case "Economics":
					specialties.Add("Labor");
					specialties.Add("Industrial");
					specialties.Add("International");
					break;
				case "Literature":
					specialties.Add("American");
					specialties.Add("Poetry");
					break;
				case "Political Science":
					specialties.Add("American Politics");
					specialties.Add("Comparative Politics");
					specialties.Add("Internation Relations");
					break;
			}
			bindingList = new BindingList<string>(specialties);
			specialtyBox.DataSource = bindingList;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			foreach (Control control in this.Controls) {
				if (control.GetType() == typeof(TextBox)) {
					TextBox box = (TextBox)control;
					box.Clear();
				}
			}
			ValidatePasswords();
			majorBox.SelectedIndex = -1;
			toolStripStatusLabel1.Text = String.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (isValid()) {
				lastUser = new User();
				lastUser.Username = usernameBox.Text;
				lastUser.FirstName = firstNameBox.Text;
				lastUser.LastName = lastNameBox.Text;
				lastUser.Password = passwordBox.Text;
				lastUser.Specialty = specialtyBox.Text;

				// removes the whitespace from the ComboBox to get the MajorType
				lastUser.Major = (MajorType)Enum.Parse(typeof(MajorType), Regex.Replace(majorBox.Text, " ", ""));

				toolStripStatusLabel1.Text = "Submitted";
			} else
				toolStripStatusLabel1.Text = "Please make sure all fields are filled correctly";
		}

		private bool isValid()
		{
			foreach(Control control in this.Controls)
				if (control.Text == string.Empty)
					return false;

			ValidatePasswords();
			if (passwordBox.BackColor == Color.Red)
				return false;

			return true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (lastUser != null) {
				firstNameBox.Text = lastUser.FirstName;
				lastNameBox.Text = lastUser.LastName;
				usernameBox.Text = lastUser.Username;
				passwordBox.Text = lastUser.Password;
				majorBox.SelectedIndex = (int)lastUser.Major;
				specialtyBox.SelectedText = lastUser.Specialty;
			} else {
				MessageBox.Show("No user to load");
			}
		}

		private List<string> specialties = new List<string>();
		private BindingList<string> bindingList;
		private User lastUser;

		private void passwordBox_Leave(object sender, EventArgs e)
		{
			ValidatePasswords();
		}

		private void confirmPasswordBox_Leave(object sender, EventArgs e)
		{
			ValidatePasswords();
		}
	}
}
