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

	public class LoadRequestFrequencyType : EventArgs
	{
		public LoadRequestFrequencyType(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class FrequencyType : BaseModel<IWebApiDataServiceBB>, IFrequencyType
	{
		public event EventHandler<LoadRequestFrequencyType> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.FrequencyType _dto = null;

		public FrequencyType(ILoggingService log, IDataService<IWebApiDataServiceBB> dataService) : base(log, dataService)
		{
			_dto = new xDTO.FrequencyType();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public FrequencyType(ILoggingService log, IDataService<IWebApiDataServiceBB> dataService, xDTO.FrequencyType dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual int FrequencyTypeId { get { return _dto.FrequencyTypeId; } }
		public virtual string Name { get { return _dto.Name; } }

		private List<IRecurrenceRule> _recurrenceRules = null; // Reverse Navigation


		public virtual List<IRecurrenceRule> RecurrenceRules
		{
			get
			{
				if (_recurrenceRules == null && _dto != null && _dto.RecurrenceRules != null)
				{
					_recurrenceRules = new List<IRecurrenceRule>();
					foreach (var dtoItem in _dto.RecurrenceRules)
					{
						_recurrenceRules.Add(new RecurrenceRule(Log, DataService, dtoItem));
					}
				}

				return _recurrenceRules;
			}
		}



	}
}
