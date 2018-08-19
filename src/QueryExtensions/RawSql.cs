namespace ZeroORM
{
	public static class RawSqlQuery
	{
		public static string RawSql( this SqlBuilder builder, string sql )
			=> sql;
	}
}
