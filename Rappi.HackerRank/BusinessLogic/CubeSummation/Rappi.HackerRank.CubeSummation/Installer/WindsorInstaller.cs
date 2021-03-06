﻿namespace Rappi.HackerRank.CubeSummation.Installer
{
    using Castle.Core;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;
    using Cube3D;
    using Cube3D.Interfaces;

    /// <summary>
    /// Windsor Installer
    /// </summary>
    /// <seealso cref="Castle.MicroKernel.Registration.IWindsorInstaller" />
    public class WindsorInstaller : IWindsorInstaller
    {
        /// <summary>The base container.</summary>
        private readonly IWindsorContainer baseContainer;

        /// <summary>
        /// The default life style type.
        /// </summary>
        private readonly LifestyleType defaultLifeStyleType;

        /// <summary>
        /// The cube summation configuration settings
        /// </summary>
        private readonly CubeSummationConfigurationSettings cubeSummationConfigurationSettings;

        /// <summary>
        /// Initializes a new instance of the <see cref="WindsorInstaller" /> class.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="defaultLifeStyleType">The default life style type.</param>
        /// <param name="cubeSummationConfigurationSettings">The cube summation configuration settings.</param>
        public WindsorInstaller(IWindsorContainer container, LifestyleType defaultLifeStyleType, CubeSummationConfigurationSettings cubeSummationConfigurationSettings)
        {
            this.baseContainer = container;
            this.defaultLifeStyleType = defaultLifeStyleType;
            this.cubeSummationConfigurationSettings = cubeSummationConfigurationSettings;
        }

        /// <summary>
        /// Performs the installation in the <see cref="T:Castle.Windsor.IWindsorContainer" />.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="store">The configuration store.</param>
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            this.baseContainer.Register(
                                Component.For<IGenerateInputFormat>()
                    .ImplementedBy<GenerateInputFormatFromText>()
                    .DependsOn(Dependency.OnValue("pathFile", this.cubeSummationConfigurationSettings.PathFile))
                    .Named("GenerateInputFormatFromText").LifeStyle.Is(this.defaultLifeStyleType),
                    Component.For<ICubeSummationCube3D>()
                    .ImplementedBy<CubeSummationCube3D>()
                    .DependsOn(Dependency.OnValue("generateInputFormatValidation", this.cubeSummationConfigurationSettings.GenerateInputFormatValidation))
                    .Named("CubeSummationCube3D").LifeStyle.Is(this.defaultLifeStyleType)
                );
        }
    }
}