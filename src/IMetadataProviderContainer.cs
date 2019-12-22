using ZeroORM.Extensibility.Metadata;

namespace ZeroORM
{
	public interface IMetadataProviderContainer
	{
		IMetadataProvider Metadata { get; }
	}
}
