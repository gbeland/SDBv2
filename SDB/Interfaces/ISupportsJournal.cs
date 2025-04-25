using SDB.Classes.General;

namespace SDB.Interfaces
{
	public interface ISupportsJournal
	{
		int ID { get; }
		ClassJournal.JournalTableInfo JournalTableInfo { get; }
	}
}