namespace ZeroORM
{
	public static class RawSqlQuery
	{
		public static string RawSql( this ISqlBuilder builder, string sql )
			=> sql;
	}
}
