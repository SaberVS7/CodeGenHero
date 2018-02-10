// <auto-generated>
using AutoMapper;
using xDTO = MSC.BingoBuzz.DTO.BB;
using xENT = MSC.BingoBuzz.Repository.Entities.BB;

namespace MSC.BingoBuzz.Repository.Infrastructure
{
	public partial class BBAutoMapperProfile : Profile
	{
		public BBAutoMapperProfile()
		{
			InitializeProfile();
			InitializePartial();
		}

		partial void InitializePartial();

		private void InitializeProfile()
		{
			CreateMap<xDTO.BingoContent, xENT.BingoContent>()
				.ForMember(d => d.CreatedUser, opt => opt.Ignore())
				.ForMember(d => d.UpdatedUser, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.BingoInstance, xENT.BingoInstance>()
				.ForMember(d => d.BingoInstanceContents, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.BingoInstanceEvents, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.CreatedUser, opt => opt.Ignore())
				.ForMember(d => d.Meeting, opt => opt.Ignore())
				.ForMember(d => d.UpdatedUser, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.BingoInstanceContent, xENT.BingoInstanceContent>()
				.ForMember(d => d.BingoInstanceEvents, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.BingoInstance, opt => opt.Ignore())
				.ForMember(d => d.CreatedUser, opt => opt.Ignore())
				.ForMember(d => d.UpdatedUser, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.BingoInstanceEvent, xENT.BingoInstanceEvent>()
				.ForMember(d => d.BingoInstance, opt => opt.Ignore())
				.ForMember(d => d.BingoInstanceContent, opt => opt.Ignore())
				.ForMember(d => d.BingoInstanceEventType, opt => opt.Ignore())
				.ForMember(d => d.CreatedUser, opt => opt.Ignore())
				.ForMember(d => d.UpdatedUser, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.BingoInstanceEventType, xENT.BingoInstanceEventType>()
				.ForMember(d => d.BingoInstanceEvents, opt => opt.Ignore()) // Reverse nav
			.ReverseMap();

			CreateMap<xDTO.Company, xENT.Company>()
				.ForMember(d => d.Meetings, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.CreatedUser, opt => opt.Ignore())
				.ForMember(d => d.UpdatedUser, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.FrequencyType, xENT.FrequencyType>()
				.ForMember(d => d.RecurrenceRules, opt => opt.Ignore()) // Reverse nav
			.ReverseMap();

			CreateMap<xDTO.Meeting, xENT.Meeting>()
				.ForMember(d => d.BingoInstances, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.MeetingAttendees, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.MeetingSchedules, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.Company, opt => opt.Ignore())
				.ForMember(d => d.CreatedUser, opt => opt.Ignore())
				.ForMember(d => d.UpdatedUser, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.MeetingAttendee, xENT.MeetingAttendee>()
				.ForMember(d => d.CreatedUser, opt => opt.Ignore())
				.ForMember(d => d.Meeting, opt => opt.Ignore())
				.ForMember(d => d.NotificationRule, opt => opt.Ignore())
				.ForMember(d => d.UpdatedUser, opt => opt.Ignore())
				.ForMember(d => d.User_UserId, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.MeetingSchedule, xENT.MeetingSchedule>()
				.ForMember(d => d.CreatedUser, opt => opt.Ignore())
				.ForMember(d => d.Meeting, opt => opt.Ignore())
				.ForMember(d => d.RecurrenceRule, opt => opt.Ignore())
				.ForMember(d => d.UpdatedUser, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.NotificationMethodType, xENT.NotificationMethodType>()
				.ForMember(d => d.NotificationRules, opt => opt.Ignore()) // Reverse nav
			.ReverseMap();

			CreateMap<xDTO.NotificationRule, xENT.NotificationRule>()
				.ForMember(d => d.MeetingAttendees, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.NotificationMethodType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.RecurrenceRule, xENT.RecurrenceRule>()
				.ForMember(d => d.MeetingSchedules, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.FrequencyType, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.User, xENT.User>()
				.ForMember(d => d.BingoContents_UpdatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.BingoInstanceContents_CreatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.BingoInstanceContents_UpdatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.BingoInstanceEvents_CreatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.BingoInstanceEvents_UpdatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.BingoInstances_CreatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.BingoInstances_UpdatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.Companies_CreatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.Companies_UpdatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.CreatedUser, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.MeetingAttendees_CreatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.MeetingAttendees_UpdatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.MeetingAttendees_UserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.Meetings_CreatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.Meetings_UpdatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.MeetingSchedules_CreatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.MeetingSchedules_UpdatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.Users_CreatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.Users_UpdatedUserId, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.User_CreatedUserId, opt => opt.Ignore())
				.ForMember(d => d.User_UpdatedUserId, opt => opt.Ignore())
			.ReverseMap();

		}
	}
}
