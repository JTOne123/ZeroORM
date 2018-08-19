using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public static class TableExtensions
	{
		public static SqlBuilder UseTable<TEntity>( this SqlBuilder builder, out ITableMetadata<TEntity> table )
		{
			table = ( (ISqlBuilder) builder ).Metadata.GetTable<TEntity>();
			return builder;
		}
	}
}
