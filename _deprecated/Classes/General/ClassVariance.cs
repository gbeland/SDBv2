namespace SDB.Classes.General
{
	/// <summary>
	/// A variance in value between two object properties.
	/// </summary>
	public class ClassVariance
	{
		public string Prop { get; set; }
		public string valA { get; set; }
		public string valB { get; set; }

		public override string ToString()
		{
			return string.Format("{0}: {1} > {2}", Prop, valA, valB);
		}
	}
}