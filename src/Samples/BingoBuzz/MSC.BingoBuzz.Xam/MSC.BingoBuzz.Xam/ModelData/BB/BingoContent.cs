// <auto-generated> - Template:SqliteModelData, Version:1.0, Id:c5caad15-b3be-4443-87d8-7cabde59f7b0
using CodeGenHero.Xam.Sqlite;
using SQLite;

namespace CodeGenHero.BingoBuzz.Xam.ModelData.BB
{
	[Table("BingoContent")]
	public partial class BingoContent : BaseAuditEdit
	{

		[PrimaryKey]
		public System.Guid BingoContentId { get; set; }

		public string Content { get; set; }
		public bool FreeSquareIndicator { get; set; }
		public int NumberOfDownvotes { get; set; }
		public int NumberOfUpvotes { get; set; }
	}
}
