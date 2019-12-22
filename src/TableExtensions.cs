using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public static partial class TableExtensions
	{
		public static ISqlBuilder UseTable<TEntity>( this ISqlBuilder builder, out ITableMetadata<TEntity> table )
		{
			table = ( (IMetadataProviderContainer) builder ).Metadata.GetTable<TEntity>();
			return builder;
		}
	}
}
