using System.Collections.Generic;
using MyMartaApp.Common.ValueObjects;

namespace MyMartaApp.Common.Apis
{
	public interface IRailScheduleApi
	{
		IEnumerable<RailSchedule> GetRailSchedules();
	}

	public class RailScheduleApi : IRailScheduleApi
	{
		public IEnumerable<RailSchedule> GetRailSchedules()
		{
			return null;
		}
	}
}

