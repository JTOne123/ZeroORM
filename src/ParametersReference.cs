using ZeroORM.Exceptions;

namespace ZeroORM
{
	public readonly struct ParametersReference<TEntity> : System.IEquatable<ParametersReference<TEntity>>
	{
		public TEntity Values => throw new PropertyIsNotCallableException($"ZeroORM.ParametersReference<{typeof(TEntity).FullName}>.Values");

		public override int GetHashCode() => 0;
		public bool Equals( ParametersReference<TEntity> other ) => true;
		public override bool Equals( object obj ) => obj is ParametersReference<TEntity> other && Equals( other );

		public static bool operator ==( ParametersReference<TEntity>x, ParametersReference<TEntity>y ) => x.Equals( y );
		public static bool operator !=( ParametersReference<TEntity>x, ParametersReference<TEntity>y ) => !x.Equals( y );
	}
}
