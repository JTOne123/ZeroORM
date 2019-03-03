using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public static class SqlBuilderFactory
	{
		public static ISqlBuilder Script( this IMetadataProvider metadata )
			=> new SqlBuilder( metadata );
	}
}
