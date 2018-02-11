// <auto-generated>
using SQLite;

namespace MSC.BingoBuzz.Xam.ModelData.BB
{
	[Table("RecurrenceRule")]
	public partial class RecurrenceRule
	{
		public System.DateTime? EndDate { get; set; }
		public int FrequencyTypeId { get; set; }
		public int? Hour { get; set; }
		public int? Minutes { get; set; }
		public int? OrdWeek { get; set; }

		[PrimaryKey]
		public System.Guid RecurrenceRuleId { get; set; }

		public int? Seconds { get; set; }
		public string WeekDay { get; set; }
		public int? WeekDayNum { get; set; }
	}
}
