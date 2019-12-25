using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public static class SqlBuilderFactory
	{
		public static IScriptBuilder Script( this IMetadataProvider metadata )
			=> new SqlBuilder( metadata );
	}
}
