namespace ZeroORM.Exceptions
{
	public class PropertyIsNotCallableException : ZeroORMException
	{
		public PropertyIsNotCallableException(string subMessage)
			: base($"Property is not intended to be accessed directly (not from AST). {subMessage}")
		{

		}
	}
}
