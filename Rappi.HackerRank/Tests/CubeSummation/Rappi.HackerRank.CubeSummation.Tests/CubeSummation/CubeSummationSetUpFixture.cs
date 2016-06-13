using System.Threading;
using Castle.Core;
using Castle.Windsor;

namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation
{
    using NUnit.Framework;
    using System;
    using Installer;

    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [SetUpFixture]
    public class CubeSummationSetUpFixture
    {
        [SetUp]
        protected virtual void SetUp()
        {
            try
            {
                IWindsorContainer container = WindsorInstallerInstance.GetInstance();
                container.Install(new WindsorInstaller(container, LifestyleType.Thread, new ProcessSettingsFactory().CreateProcessSettings()));
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }
    }
}