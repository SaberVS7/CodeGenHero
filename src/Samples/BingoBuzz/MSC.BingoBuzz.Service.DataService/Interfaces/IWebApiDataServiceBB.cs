// <auto-generated>
using CodeGenHero.EAMVCXamPOCO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MSC.BingoBuzz.DTO.BB;
using CodeGenHero.EAMVCXamPOCO.DataService.Interface;

namespace MSC.BingoBuzz.API.Client.Interface
{
	public partial interface IWebApiDataServiceBB : IWebApiDataServiceBase
	{
		#region GetAllPages

		Task<List<BingoContent>> GetAllPagesBingoContentsAsync(DateTime? minUpdatedDate);

		Task<List<BingoInstance>> GetAllPagesBingoInstancesAsync(DateTime? minUpdatedDate);

		Task<List<BingoInstanceContent>> GetAllPagesBingoInstanceContentsAsync(DateTime? minUpdatedDate);

		Task<List<BingoInstanceEvent>> GetAllPagesBingoInstanceEventsAsync(DateTime? minUpdatedDate);

		Task<List<BingoInstanceEventType>> GetAllPagesBingoInstanceEventTypesAsync();

		Task<List<Company>> GetAllPagesCompaniesAsync(DateTime? minUpdatedDate);

		Task<List<FrequencyType>> GetAllPagesFrequencyTypesAsync();

		Task<List<Meeting>> GetAllPagesMeetingsAsync(DateTime? minUpdatedDate);

		Task<List<MeetingAttendee>> GetAllPagesMeetingAttendeesAsync(DateTime? minUpdatedDate);

		Task<List<MeetingSchedule>> GetAllPagesMeetingSchedulesAsync(DateTime? minUpdatedDate);

		Task<List<NotificationMethodType>> GetAllPagesNotificationMethodTypesAsync();

		Task<List<NotificationRule>> GetAllPagesNotificationRulesAsync();

		Task<List<RecurrenceRule>> GetAllPagesRecurrenceRulesAsync();

		Task<List<User>> GetAllPagesUsersAsync(DateTime? minUpdatedDate);


		#endregion GetAllPages

		#region GetPageData

		Task<PageData<List<BingoContent>>> GetBingoContentsAsync(DateTime? minUpdatedDate, int page, int pageSize);

		Task<PageData<List<BingoInstance>>> GetBingoInstancesAsync(DateTime? minUpdatedDate, int page, int pageSize);

		Task<PageData<List<BingoInstanceContent>>> GetBingoInstanceContentsAsync(DateTime? minUpdatedDate, int page, int pageSize);

		Task<PageData<List<BingoInstanceEvent>>> GetBingoInstanceEventsAsync(DateTime? minUpdatedDate, int page, int pageSize);

		Task<PageData<List<BingoInstanceEventType>>> GetBingoInstanceEventTypesAsync(int page, int pageSize);

		Task<PageData<List<Company>>> GetCompaniesAsync(DateTime? minUpdatedDate, int page, int pageSize);

		Task<PageData<List<FrequencyType>>> GetFrequencyTypesAsync(int page, int pageSize);

		Task<PageData<List<Meeting>>> GetMeetingsAsync(DateTime? minUpdatedDate, int page, int pageSize);

		Task<PageData<List<MeetingAttendee>>> GetMeetingAttendeesAsync(DateTime? minUpdatedDate, int page, int pageSize);

		Task<PageData<List<MeetingSchedule>>> GetMeetingSchedulesAsync(DateTime? minUpdatedDate, int page, int pageSize);

		Task<PageData<List<NotificationMethodType>>> GetNotificationMethodTypesAsync(int page, int pageSize);

		Task<PageData<List<NotificationRule>>> GetNotificationRulesAsync(int page, int pageSize);

		Task<PageData<List<RecurrenceRule>>> GetRecurrenceRulesAsync(int page, int pageSize);

		Task<PageData<List<User>>> GetUsersAsync(DateTime? minUpdatedDate, int page, int pageSize);


		#endregion GetPageData

		#region Get By PK

		Task<HttpCallResult<BingoContent>> GetBingoContentAsync(System.Guid bingoContentId);

		Task<HttpCallResult<BingoInstance>> GetBingoInstanceAsync(System.Guid bingoInstanceId);

		Task<HttpCallResult<BingoInstanceContent>> GetBingoInstanceContentAsync(System.Guid bingoInstanceContentId);

		Task<HttpCallResult<BingoInstanceEvent>> GetBingoInstanceEventAsync(System.Guid bingoInstanceEventId);

		Task<HttpCallResult<BingoInstanceEventType>> GetBingoInstanceEventTypeAsync(int bingoInstanceEventTypeId);

		Task<HttpCallResult<Company>> GetCompanyAsync(System.Guid companyId);

		Task<HttpCallResult<FrequencyType>> GetFrequencyTypeAsync(int frequencyTypeId);

		Task<HttpCallResult<Meeting>> GetMeetingAsync(System.Guid meetingId);

		Task<HttpCallResult<MeetingAttendee>> GetMeetingAttendeeAsync(System.Guid meetingAttendeeId);

		Task<HttpCallResult<MeetingSchedule>> GetMeetingScheduleAsync(System.Guid meetingScheduleId);

		Task<HttpCallResult<NotificationMethodType>> GetNotificationMethodTypeAsync(int notificationMethodTypeId);

		Task<HttpCallResult<NotificationRule>> GetNotificationRuleAsync(System.Guid notificationRuleId);

		Task<HttpCallResult<RecurrenceRule>> GetRecurrenceRuleAsync(System.Guid recurrenceRuleId);

		Task<HttpCallResult<User>> GetUserAsync(System.Guid userId);


		#endregion Get By PK

		#region Create

		Task<HttpCallResult<BingoContent>> CreateBingoContentAsync(BingoContent item);

		Task<HttpCallResult<BingoInstance>> CreateBingoInstanceAsync(BingoInstance item);

		Task<HttpCallResult<BingoInstanceContent>> CreateBingoInstanceContentAsync(BingoInstanceContent item);

		Task<HttpCallResult<BingoInstanceEvent>> CreateBingoInstanceEventAsync(BingoInstanceEvent item);

		Task<HttpCallResult<BingoInstanceEventType>> CreateBingoInstanceEventTypeAsync(BingoInstanceEventType item);

		Task<HttpCallResult<Company>> CreateCompanyAsync(Company item);

		Task<HttpCallResult<FrequencyType>> CreateFrequencyTypeAsync(FrequencyType item);

		Task<HttpCallResult<Meeting>> CreateMeetingAsync(Meeting item);

		Task<HttpCallResult<MeetingAttendee>> CreateMeetingAttendeeAsync(MeetingAttendee item);

		Task<HttpCallResult<MeetingSchedule>> CreateMeetingScheduleAsync(MeetingSchedule item);

		Task<HttpCallResult<NotificationMethodType>> CreateNotificationMethodTypeAsync(NotificationMethodType item);

		Task<HttpCallResult<NotificationRule>> CreateNotificationRuleAsync(NotificationRule item);

		Task<HttpCallResult<RecurrenceRule>> CreateRecurrenceRuleAsync(RecurrenceRule item);

		Task<HttpCallResult<User>> CreateUserAsync(User item);

		#endregion Create

		#region Update

		Task<HttpCallResult<BingoContent>> UpdateBingoContentAsync(BingoContent item);

		Task<HttpCallResult<BingoInstance>> UpdateBingoInstanceAsync(BingoInstance item);

		Task<HttpCallResult<BingoInstanceContent>> UpdateBingoInstanceContentAsync(BingoInstanceContent item);

		Task<HttpCallResult<BingoInstanceEvent>> UpdateBingoInstanceEventAsync(BingoInstanceEvent item);

		Task<HttpCallResult<BingoInstanceEventType>> UpdateBingoInstanceEventTypeAsync(BingoInstanceEventType item);

		Task<HttpCallResult<Company>> UpdateCompanyAsync(Company item);

		Task<HttpCallResult<FrequencyType>> UpdateFrequencyTypeAsync(FrequencyType item);

		Task<HttpCallResult<Meeting>> UpdateMeetingAsync(Meeting item);

		Task<HttpCallResult<MeetingAttendee>> UpdateMeetingAttendeeAsync(MeetingAttendee item);

		Task<HttpCallResult<MeetingSchedule>> UpdateMeetingScheduleAsync(MeetingSchedule item);

		Task<HttpCallResult<NotificationMethodType>> UpdateNotificationMethodTypeAsync(NotificationMethodType item);

		Task<HttpCallResult<NotificationRule>> UpdateNotificationRuleAsync(NotificationRule item);

		Task<HttpCallResult<RecurrenceRule>> UpdateRecurrenceRuleAsync(RecurrenceRule item);

		Task<HttpCallResult<User>> UpdateUserAsync(User item);

		#endregion Update

		#region Delete

		Task<HttpCallResult<BingoContent>> DeleteBingoContentAsync(System.Guid bingoContentId);

		Task<HttpCallResult<BingoInstance>> DeleteBingoInstanceAsync(System.Guid bingoInstanceId);

		Task<HttpCallResult<BingoInstanceContent>> DeleteBingoInstanceContentAsync(System.Guid bingoInstanceContentId);

		Task<HttpCallResult<BingoInstanceEvent>> DeleteBingoInstanceEventAsync(System.Guid bingoInstanceEventId);

		Task<HttpCallResult<BingoInstanceEventType>> DeleteBingoInstanceEventTypeAsync(int bingoInstanceEventTypeId);

		Task<HttpCallResult<Company>> DeleteCompanyAsync(System.Guid companyId);

		Task<HttpCallResult<FrequencyType>> DeleteFrequencyTypeAsync(int frequencyTypeId);

		Task<HttpCallResult<Meeting>> DeleteMeetingAsync(System.Guid meetingId);

		Task<HttpCallResult<MeetingAttendee>> DeleteMeetingAttendeeAsync(System.Guid meetingAttendeeId);

		Task<HttpCallResult<MeetingSchedule>> DeleteMeetingScheduleAsync(System.Guid meetingScheduleId);

		Task<HttpCallResult<NotificationMethodType>> DeleteNotificationMethodTypeAsync(int notificationMethodTypeId);

		Task<HttpCallResult<NotificationRule>> DeleteNotificationRuleAsync(System.Guid notificationRuleId);

		Task<HttpCallResult<RecurrenceRule>> DeleteRecurrenceRuleAsync(System.Guid recurrenceRuleId);

		Task<HttpCallResult<User>> DeleteUserAsync(System.Guid userId);

		#endregion Delete
	}
}
