using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public static partial class TableExtensions
	{
		public static IScriptBuilder UseTable<TEntity>( this IScriptBuilder builder, out ITableMetadata<TEntity> table )
		{
			table = ( (IMetadataProviderContainer) builder ).Metadata.GetTable<TEntity>();
			return builder;
		}
	}
}
