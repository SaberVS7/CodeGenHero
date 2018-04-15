// <auto-generated> - Template:DTO, Version:1.0, Id:58fa7ee2-89f7-41e6-85ed-8d4482653990
namespace CodeGenHero.BingoBuzz.DTO.BB
{
	public partial class User
	{
		public User()
		{
			InitializePartial();
		}

		public System.Guid UserId { get; set; } // Primary key
		public System.Guid CompanyId { get; set; }
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public System.Guid CreatedUserId { get; set; }
		public System.DateTime UpdatedDate { get; set; }
		public System.Guid UpdatedUserId { get; set; }
		public bool IsDeleted { get; set; }
		// public virtual System.Collections.Generic.ICollection<BingoContent> BingoContents_UpdatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<BingoContent> CreatedUser { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<BingoInstance> BingoInstances_CreatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<BingoInstance> BingoInstances_UpdatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<BingoInstanceContent> BingoInstanceContents_CreatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<BingoInstanceContent> BingoInstanceContents_UpdatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<BingoInstanceContent> BingoInstanceContents_UserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<BingoInstanceEvent> BingoInstanceEvents_CreatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<BingoInstanceEvent> BingoInstanceEvents_UpdatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<Company> Companies_CreatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<Company> Companies_UpdatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<Meeting> Meetings_CreatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<Meeting> Meetings_UpdatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<MeetingAttendee> MeetingAttendees_CreatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<MeetingAttendee> MeetingAttendees_UpdatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<MeetingAttendee> MeetingAttendees_UserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<MeetingSchedule> MeetingSchedules_CreatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<MeetingSchedule> MeetingSchedules_UpdatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<User> Users_CreatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual System.Collections.Generic.ICollection<User> Users_UpdatedUserId { get; set; } // Many to many mapping -- Excluded navigation property per configuration.
		// public virtual User User_CreatedUserId { get; set; }  -- Excluded navigation property per configuration.
		// public virtual User User_UpdatedUserId { get; set; }  -- Excluded navigation property per configuration.


		partial void InitializePartial();

	}
}
