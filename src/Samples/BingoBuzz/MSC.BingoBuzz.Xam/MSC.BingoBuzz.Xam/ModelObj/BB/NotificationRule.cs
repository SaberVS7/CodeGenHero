// <auto-generated> - Template:MvvmLightModelObject, Version:1.0, Id:4d03f2c7-de26-4aee-a267-cad747c9606a
using GalaSoft.MvvmLight;

namespace CodeGenHero.BingoBuzz.Xam.ModelObj.BB
{
	public partial class NotificationRule : ObservableObject
	{
		public NotificationRule()
		{
			MeetingAttendees = new System.Collections.Generic.List<MeetingAttendee>(); // Reverse Navigation

			InitializePartial();
		}

		private int _minutesBeforehand;
		private int _notificationMethodTypeId;
		private System.Guid _notificationRuleId;


		public int MinutesBeforehand
		{
			get { return _minutesBeforehand; }
			set
			{
				Set<int>(() => MinutesBeforehand, ref _minutesBeforehand, value);
				RunCustomLogicSetMinutesBeforehand(value);
			}
		}

		public int NotificationMethodTypeId
		{
			get { return _notificationMethodTypeId; }
			set
			{
				Set<int>(() => NotificationMethodTypeId, ref _notificationMethodTypeId, value);
				RunCustomLogicSetNotificationMethodTypeId(value);
			}
		}

		public System.Guid NotificationRuleId
		{
			get { return _notificationRuleId; }
			set
			{
				Set<System.Guid>(() => NotificationRuleId, ref _notificationRuleId, value);
				RunCustomLogicSetNotificationRuleId(value);
			}
		}

		public virtual System.Collections.Generic.IList<MeetingAttendee> MeetingAttendees { get; set; } // Many to many mapping
		public virtual NotificationMethodType NotificationMethodType { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetMinutesBeforehand(int value);
		partial void RunCustomLogicSetNotificationMethodTypeId(int value);
		partial void RunCustomLogicSetNotificationRuleId(System.Guid value);

		#endregion RunCustomLogicSet

	}
}
