// <auto-generated> - Template:ModelsBackedByDto, Version:1.0, Id:4d03f2c7-de26-4abe-a267-cad747c9606a
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

	public class LoadRequestNotificationMethodType : EventArgs
	{
		public LoadRequestNotificationMethodType(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class NotificationMethodType : BaseModel<IWebApiDataServiceBB>, INotificationMethodType
	{
		public event EventHandler<LoadRequestNotificationMethodType> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.NotificationMethodType _dto = null;

		public NotificationMethodType(ILoggingService log, IDataService<IWebApiDataServiceBB> dataService) : base(log, dataService)
		{
			_dto = new xDTO.NotificationMethodType();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public NotificationMethodType(ILoggingService log, IDataService<IWebApiDataServiceBB> dataService, xDTO.NotificationMethodType dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual string Name { get { return _dto.Name; } }
		public virtual int NotificationMethodTypeId { get { return _dto.NotificationMethodTypeId; } }

		private List<INotificationRule> _notificationRules = null; // Reverse Navigation


		public virtual List<INotificationRule> NotificationRules
		{
			get
			{
				if (_notificationRules == null && _dto != null && _dto.NotificationRules != null)
				{
					_notificationRules = new List<INotificationRule>();
					foreach (var dtoItem in _dto.NotificationRules)
					{
						_notificationRules.Add(new NotificationRule(Log, DataService, dtoItem));
					}
				}

				return _notificationRules;
			}
		}



	}
}
