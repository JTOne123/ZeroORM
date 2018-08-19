using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public sealed class SqlBuilder : ISqlBuilder
	{
		private readonly IMetadataProvider _metadata;

		public SqlBuilder( IMetadataProvider metadata )
			=> _metadata = metadata;

		IMetadataProvider ISqlBuilder.Metadata => _metadata;
	}
}
