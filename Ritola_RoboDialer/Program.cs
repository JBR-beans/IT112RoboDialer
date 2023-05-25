// Juliea Ritola
// IT112
// NOTES: method AppendCountryCode in class CellPhone shows how you can expand upon the country code dialing functionality (and program scalabilty) by allowing you to choose a region, hard-coded to just "USA" for the sake of the project.
// BEHAVIORS NOT IMPLIMENTED AND WHY: Didn't have to cut anything out.

using System;

namespace Ritola_RoboDialer
{

	class Program
	{
		static void Main(string[] args)
		{
			Phone[] dialingList = new Phone[10];
			dialingList[0] = new Phone("(303) 985-5060", "CompuTest", "1");
			dialingList[1] = new Phone("(603) 532-4123", "Curtis Manufacturing", "2");
			dialingList[2] = new Phone("(800) 876-2524", "Data Functions", "1");
			dialingList[3] = new Phone("(708) 397-3330", "Donnay Repair", "1");
			dialingList[4] = new Phone("(360) 434-3894", "ErgoNomic Inc", "1");
			dialingList[5] = new Phone("(800) 969-4374", "ErgoSource", "1");
			dialingList[6] = new Phone("(800) 874-8527", "Fox Bay Industries", "2");
			dialingList[7] = new Phone("(800) 545-6254", "Glare-Guard", "2");
			dialingList[8] = new Phone("(407) 783-6641", "Hazard Comm Specialists", "2");
			dialingList[9] = new Phone("(714) 472-4409", "Komfort Support", "2");

			foreach (Phone phone in dialingList)
			{
				Console.WriteLine(phone.Dial());
			}
		}
	}
}