using System;
using System.Linq.Expressions;

namespace ZeroORM.Infrastructure
{
	internal static class ExpressionBasedSqlAssembler
	{
		private class UnderhoodVisitor : ExpressionVisitor
		{
			private bool IsReference( Type t )
				=> t.IsGenericType
				&& t.GetGenericTypeDefinition() == typeof( TableReference<> )
				;

			protected override Expression VisitUnary( UnaryExpression node )
			{
				if (node.NodeType == ExpressionType.Convert)
				{

				}
				return base.VisitUnary( node );
			}

			protected override Expression VisitMember( MemberExpression node )
			{
				Type sourceType = node.Expression.Type;
				if ( !IsReference( sourceType ) )
					if ( node.Expression is MemberExpression member && IsReference( member.Expression.Type ) )
						sourceType = member.Expression.Type;
					else
						return base.VisitMember( node );

			}
		}

		public static string ToSql( Expression<Func<FormattableString>> expression )
		{

		}
	}
}
