using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	internal interface IInternalSqlBuilder
	{
		IMetadataProvider Metadata { get; }
	}
}
