using System;

namespace Ritola_RoboDialer
{
	class Phone
	{
		protected string phoneNumber;
		protected string companyName;
		protected string phoneType;

		public Phone(string phoneNumber, string companyName, string phoneType)
		{
			this.phoneNumber = phoneNumber;
			this.companyName = companyName;
			this.phoneType = phoneType;
		}

		public virtual string Dial()
		{
			if (phoneType == "1")
			{
				HomePhone home = new HomePhone(phoneNumber, companyName, phoneType);
				return home.Dial();
			}
			if (phoneType == "2")
			{
				CellPhone cell = new CellPhone(phoneNumber, companyName, phoneType); 
				return cell.Dial();
			}

			return "Phone type must be indicated";
		}
	}

	class HomePhone : Phone
	{
		public HomePhone(string phoneNumber, string companyName, string phoneType)
			: base(phoneNumber, companyName, phoneType)
		{
		}

		public override string Dial()
		{
			string homeNumber;
			homeNumber = phoneNumber;

			return "Dialing " + companyName + " using " + homeNumber + "...";
		}
	}

	class CellPhone : Phone
	{
		public CellPhone(string phoneNumber, string companyName, string phoneType)
			: base(phoneNumber, companyName, phoneType)
		{
		}

		public override string Dial()
		{
			string cellNumber = phoneNumber;

			cellNumber = AppendCountryCode("USA",cellNumber);
			
			return "Dialing " + companyName + " using " + cellNumber + "...";
		}
		public string AppendCountryCode(string region, string number)
		{
			if (region == "USA")
			{
				number = "1+" + number;
			}
			return number;
		}
	}
}
