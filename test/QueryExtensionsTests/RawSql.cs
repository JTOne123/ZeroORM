using FluentAssertions;
using Xunit;

namespace ZeroORM.Test.QueryExtensionsTests
{
	public class RawSql
	{
		private const string _testString = "test";

		[Fact]
		public void RawSqlReturnsItsParameter()
			=> ( null as ISqlBuilder )
			.RawSql( _testString )
			.Should()
			.BeSameAs( _testString );
	}
}
