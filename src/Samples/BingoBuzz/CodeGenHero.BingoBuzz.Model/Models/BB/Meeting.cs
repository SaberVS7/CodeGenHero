// <auto-generated> - Template:ModelsBackedByDto, Version:1.0, Id:f1539c0d-024f-4b1f-b346-132cdd9dd31f
using CodeGenHero.Logging;
using CodeGenHero.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using CodeGenHero.BingoBuzz.API.Client.Interface;
using CodeGenHero.BingoBuzz.Model.BB.Interface;
using xDTO = CodeGenHero.BingoBuzz.DTO.BB;

namespace CodeGenHero.BingoBuzz.Model.BB
{

	public class LoadRequestMeeting : EventArgs
	{
		public LoadRequestMeeting(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class Meeting : BaseModel<IWebApiDataServiceBB>, IMeeting
	{
		public event EventHandler<LoadRequestMeeting> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.Meeting _dto = null;

		public Meeting(ILoggingService log, IDataService<IWebApiDataServiceBB> dataService) : base(log, dataService)
		{
			_dto = new xDTO.Meeting();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public Meeting(ILoggingService log, IDataService<IWebApiDataServiceBB> dataService, xDTO.Meeting dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual System.Guid? CompanyId { get { return _dto.CompanyId; } }
		public virtual System.DateTime CreatedDate { get { return _dto.CreatedDate; } }
		public virtual System.Guid CreatedUserId { get { return _dto.CreatedUserId; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual System.Guid MeetingId { get { return _dto.MeetingId; } }
		public virtual string Name { get { return _dto.Name; } }
		public virtual System.DateTime UpdatedDate { get { return _dto.UpdatedDate; } }
		public virtual System.Guid UpdatedUserId { get { return _dto.UpdatedUserId; } }

		private ICompany _company = null; // Foreign Key
		private IUser _createdUser = null; // Foreign Key
		private IUser _updatedUser = null; // Foreign Key
		private List<IBingoInstance> _bingoInstances = null; // Reverse Navigation
		private List<IMeetingAttendee> _meetingAttendees = null; // Reverse Navigation
		private List<IMeetingSchedule> _meetingSchedules = null; // Reverse Navigation


		public virtual ICompany Company
		{
			get
			{
				if (_company == null && _dto != null && _dto.Company != null)
				{
					_company = new Company(Log, DataService, _dto.Company);
				}

				return _company;
			}
		}

		public virtual IUser CreatedUser
		{
			get
			{
				if (_createdUser == null && _dto != null && _dto.CreatedUser != null)
				{
					_createdUser = new User(Log, DataService, _dto.CreatedUser);
				}

				return _createdUser;
			}
		}

		public virtual IUser UpdatedUser
		{
			get
			{
				if (_updatedUser == null && _dto != null && _dto.UpdatedUser != null)
				{
					_updatedUser = new User(Log, DataService, _dto.UpdatedUser);
				}

				return _updatedUser;
			}
		}

		public virtual List<IBingoInstance> BingoInstances
		{
			get
			{
				if (_bingoInstances == null)
				{
					OnLazyLoadRequest(this, new LoadRequestMeeting(nameof(BingoInstances)));
				}

				return _bingoInstances;
			}
		}

		public virtual List<IMeetingAttendee> MeetingAttendees
		{
			get
			{
				if (_meetingAttendees == null && _dto != null && _dto.MeetingAttendees != null)
				{
					_meetingAttendees = new List<IMeetingAttendee>();
					foreach (var dtoItem in _dto.MeetingAttendees)
					{
						_meetingAttendees.Add(new MeetingAttendee(Log, DataService, dtoItem));
					}
				}

				return _meetingAttendees;
			}
		}

		public virtual List<IMeetingSchedule> MeetingSchedules
		{
			get
			{
				if (_meetingSchedules == null && _dto != null && _dto.MeetingSchedules != null)
				{
					_meetingSchedules = new List<IMeetingSchedule>();
					foreach (var dtoItem in _dto.MeetingSchedules)
					{
						_meetingSchedules.Add(new MeetingSchedule(Log, DataService, dtoItem));
					}
				}

				return _meetingSchedules;
			}
		}



	}
}
