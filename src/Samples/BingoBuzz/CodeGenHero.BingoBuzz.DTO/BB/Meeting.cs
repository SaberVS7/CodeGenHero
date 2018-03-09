// <auto-generated> - Template:DTO, Version:1.0, Id:58fa7ee2-89f7-41e6-85ed-8d4482653990
namespace CodeGenHero.BingoBuzz.DTO.BB
{
	public partial class Meeting
	{
		public Meeting()
		{
			BingoInstances = new System.Collections.Generic.List<BingoInstance>();
			MeetingAttendees = new System.Collections.Generic.List<MeetingAttendee>();
			MeetingSchedules = new System.Collections.Generic.List<MeetingSchedule>();

			InitializePartial();
		}

		public System.Guid MeetingId { get; set; } // Primary key
		public System.Guid? CompanyId { get; set; }
		public string Name { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public System.Guid CreatedUserId { get; set; }
		public System.DateTime UpdatedDate { get; set; }
		public System.Guid UpdatedUserId { get; set; }
		public bool IsDeleted { get; set; }
		public virtual System.Collections.Generic.ICollection<BingoInstance> BingoInstances { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.ICollection<MeetingAttendee> MeetingAttendees { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.ICollection<MeetingSchedule> MeetingSchedules { get; set; } // Many to many mapping
		public virtual Company Company { get; set; } 
		public virtual User CreatedUser { get; set; } 
		public virtual User UpdatedUser { get; set; } 


		partial void InitializePartial();

	}
}
