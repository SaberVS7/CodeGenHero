// <auto-generated>
using CodeGenHero.EAMVCXamPOCO;
using MSC.BingoBuzz.Repository.Entities.BB;
using System;

namespace MSC.BingoBuzz.Repository.Interface
{
	public partial interface IBBRepository : IBBRepositoryCrud
	{

		#region DeleteEntity

		RepositoryActionResult<BingoContent> DeleteBingoContent(System.Guid bingoContentId, string content, bool freeSquareIndicator, int numberOfUpvotes, int numberOfDownvotes, System.DateTime createdDate, System.Guid createdUserId, System.DateTime updatedDate, System.Guid updatedUserId, bool isDeleted);

		RepositoryActionResult<BingoInstance> DeleteBingoInstance(System.Guid bingoInstanceId);

		RepositoryActionResult<BingoInstanceContent> DeleteBingoInstanceContent(System.Guid bingoInstanceContentId);

		RepositoryActionResult<BingoInstanceEvent> DeleteBingoInstanceEvent(System.Guid bingoInstanceEventId);

		RepositoryActionResult<BingoInstanceEventType> DeleteBingoInstanceEventType(int bingoInstanceEventTypeId);

		RepositoryActionResult<Company> DeleteCompany(System.Guid companyId);

		RepositoryActionResult<FrequencyType> DeleteFrequencyType(int frequencyTypeId);

		RepositoryActionResult<Meeting> DeleteMeeting(System.Guid meetingId);

		RepositoryActionResult<MeetingAttendee> DeleteMeetingAttendee(System.Guid meetingAttendeeId);

		RepositoryActionResult<MeetingSchedule> DeleteMeetingSchedule(System.Guid meetingScheduleId);

		RepositoryActionResult<NotificationMethodType> DeleteNotificationMethodType(int notificationMethodTypeId);

		RepositoryActionResult<NotificationRule> DeleteNotificationRule(System.Guid notificationRuleId);

		RepositoryActionResult<RecurrenceRule> DeleteRecurrenceRule(System.Guid recurrenceRuleId);

		RepositoryActionResult<User> DeleteUser(System.Guid userId);


		#endregion DeleteEntity

		#region FirstOrDefault

		BingoContent GetBingoContent(System.Guid bingoContentId, string content, bool freeSquareIndicator, int numberOfUpvotes, int numberOfDownvotes, System.DateTime createdDate, System.Guid createdUserId, System.DateTime updatedDate, System.Guid updatedUserId, bool isDeleted);

		BingoInstance GetBingoInstance(System.Guid bingoInstanceId);

		BingoInstanceContent GetBingoInstanceContent(System.Guid bingoInstanceContentId);

		BingoInstanceEvent GetBingoInstanceEvent(System.Guid bingoInstanceEventId);

		BingoInstanceEventType GetBingoInstanceEventType(int bingoInstanceEventTypeId);

		Company GetCompany(System.Guid companyId);

		FrequencyType GetFrequencyType(int frequencyTypeId);

		Meeting GetMeeting(System.Guid meetingId);

		MeetingAttendee GetMeetingAttendee(System.Guid meetingAttendeeId);

		MeetingSchedule GetMeetingSchedule(System.Guid meetingScheduleId);

		NotificationMethodType GetNotificationMethodType(int notificationMethodTypeId);

		NotificationRule GetNotificationRule(System.Guid notificationRuleId);

		RecurrenceRule GetRecurrenceRule(System.Guid recurrenceRuleId);

		User GetUser(System.Guid userId);


		#endregion FirstOrDefault

	}
}
