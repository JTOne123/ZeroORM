using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	internal sealed class SqlBuilder : ISqlBuilder, IMetadataProviderContainer
	{
		private readonly IMetadataProvider _metadata;

		public SqlBuilder( IMetadataProvider metadata )
			=> _metadata = metadata;

		IMetadataProvider IMetadataProviderContainer.Metadata => _metadata;
	}
}
