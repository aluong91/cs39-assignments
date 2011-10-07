using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_07_formsandclasses
{
	enum MajorType
	{
		Biology,
		ComputerScience,
		Economics,
		Literature,
		PoliticalScience
	}

	class User
	{
		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value;}
		}

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value;}
		}

		public string Username
		{
			get { return _username; }
			set { _username = value;}
		}

		public string Password
		{
			get { return _password; }
			set { _password = value;}
		}

		public MajorType Major
		{
			get { return _major; }
			set { _major = value;}
		}

		public string Specialty
		{
			get { return _specialty; }
			set { _specialty = value;}
		}

		private string _firstName;
		private string _lastName;
		private string _username;
		private string _password;
		private MajorType _major;
		private string _specialty;
	}
}
