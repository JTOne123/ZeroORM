using ZeroORM.Exceptions;
using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public readonly struct TableReference<TEntity> : System.IEquatable<TableReference<TEntity>>
	{
		public TableReference( ITableMetadata<TEntity> metadata ) => Metadata = metadata;

		public TEntity Table => throw new PropertyIsNotCallableException($"ZeroORM.TableReference<{typeof(TEntity).FullName}>.Table");

		internal ITableMetadata<TEntity> Metadata { get; }

		public override int GetHashCode() => Metadata?.GetHashCode() ?? 0;
		public bool Equals( TableReference<TEntity> other ) => System.Collections.Generic.EqualityComparer<ITableMetadata<TEntity>>.Default.Equals( Metadata, other.Metadata );
		public override bool Equals( object obj ) => obj is TableReference<TEntity> other && Equals( other );

		public static bool operator ==( TableReference<TEntity>x, TableReference<TEntity>y ) => x.Equals( y );
		public static bool operator !=( TableReference<TEntity>x, TableReference<TEntity>y ) => !x.Equals( y );
	}
}
