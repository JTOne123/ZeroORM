using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	internal interface IMetadataProviderContainer
	{
		IMetadataProvider Metadata { get; }
	}
}
