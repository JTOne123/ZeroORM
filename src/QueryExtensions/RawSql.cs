namespace ZeroORM
{
	public static class RawSqlQuery
	{
		public static string RawSql( this IScriptBuilder builder, string sql )
			=> sql;
	}
}
