using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public static class SqlBuilderFactory
	{
		public static SqlBuilder Script( this IMetadataProvider metadata )
			=> new SqlBuilder( metadata );
	}
}
