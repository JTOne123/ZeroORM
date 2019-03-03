using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	internal sealed class SqlBuilder : ISqlBuilder, IInternalSqlBuilder
	{
		private readonly IMetadataProvider _metadata;

		public SqlBuilder( IMetadataProvider metadata )
			=> _metadata = metadata;

		IMetadataProvider IInternalSqlBuilder.Metadata => _metadata;
	}
}
