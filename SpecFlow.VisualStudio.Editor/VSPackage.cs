using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace SpecFlow.VisualStudio.Editor
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(VSPackage.PackageGuidString)]
    public sealed class VSPackage : AsyncPackage
    {
        public const string PackageGuidString = "B78AA0FC-ADA7-4049-8CCE-754DC68FE984";

        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            // Switch to main thread to register commands
            await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
        }
        
    }
}
