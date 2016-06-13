namespace Rappi.HackerRank.Core.IoC
{
    using Castle.Windsor;

    /// <summary>
    /// Ioc Helper
    /// </summary>
    public static class IocHelper
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