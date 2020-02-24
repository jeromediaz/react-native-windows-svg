using Microsoft.ReactNative;
using Microsoft.ReactNative.Managed;

namespace ReactNativeSVG
{
    public sealed class ReactPackageProvider : IReactPackageProvider
    {
        public void CreatePackage(IReactPackageBuilder packageBuilder)
        {
            packageBuilder.AddViewManagers();
        }
    }
}