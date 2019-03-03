using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public static partial class TableExtensions
	{
		public static ISqlBuilder UseTable<TEntity>( this ISqlBuilder builder, out ITableMetadata<TEntity> table )
		{
			table = ( (IInternalSqlBuilder) builder ).Metadata.GetTable<TEntity>();
			return builder;
		}
	}
}
