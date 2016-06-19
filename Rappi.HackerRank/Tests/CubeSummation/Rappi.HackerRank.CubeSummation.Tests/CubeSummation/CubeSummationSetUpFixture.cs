namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation
{
    using System;
    using Castle.Core;
    using Core.IoC;
    using Installer;
    using NUnit.Framework;

    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [SetUpFixture]
    public class CubeSummationSetUpFixture
    {
        /// <summary>
        /// Sets up.
        /// </summary>
        [SetUp] 
        protected virtual void SetUp()
        {
            try
            {
                var container = IocHelper.GetInstance();
                container.Install(new WindsorInstaller(container, LifestyleType.Thread,
                    new ProcessSettingsFactory().CreateProcessSettings()));
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }
        }
    }
}