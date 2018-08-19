using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	internal interface ISqlBuilder
	{
		IMetadataProvider Metadata { get; }
	}
}
