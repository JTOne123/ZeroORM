using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public sealed class SqlBuilder
	{
		private readonly IMetadataProvider _metadata;

		public SqlBuilder( IMetadataProvider metadata )
			=> _metadata = metadata;
	}
}
