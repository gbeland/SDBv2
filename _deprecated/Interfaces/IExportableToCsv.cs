namespace SDB.Interfaces
{
	/// <summary>
	/// Returns properties of object as a CSV string for exporting.
	/// </summary>
	public interface IExportableToCsv
	{
		string ExportHeadersAsCsvString();
		string ExportPropertiesAsCsvString();
	}
}