namespace Rappi.HackerRank.CubeSummation.Tests.CubeSummation
{
    using Castle.Windsor;

    /// <summary>
    /// Windsor Installer Instance
    /// </summary>
    public static class WindsorInstallerInstance
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static IWindsorContainer instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns></returns>
        public static IWindsorContainer GetInstance()
        {
            if (instance == null)
            {
                instance = new WindsorContainer();
            }
            return instance;
        }
    }
}