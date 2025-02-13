using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalCodexGroup : gameJournalContainerEntry
	{
		[Ordinal(3)] 
		[RED("groupName")] 
		public LocalizationString GroupName
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public gameJournalCodexGroup()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();
			GroupName = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
