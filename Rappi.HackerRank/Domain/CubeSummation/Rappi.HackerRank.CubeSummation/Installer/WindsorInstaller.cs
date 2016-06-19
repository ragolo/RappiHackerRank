﻿using System.Collections.Generic;
using Rappi.HackerRank.CubeSummation.Cube3D.Business;
using Rappi.HackerRank.CubeSummation.Cube3D.Business.Interfaces;
using Rappi.HackerRank.CubeSummation.Cube3D.Business.Operations;
using Rappi.HackerRank.CubeSummation.Cube3D.Business.Validation;

namespace Rappi.HackerRank.CubeSummation.Installer
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
            baseContainer = container;
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
            var dependenciesUpdateBusiness = new List<Dependency>
            {
                Dependency.OnValue("updateBusinessValidation",cubeSummationConfigurationSettings.UpdateBusinessValidation),
                Dependency.OnValue("validationModel", cubeSummationConfigurationSettings.ValidationModel)
            };

            var dependenciesCubeSummationCube3D = new List<Dependency>
            {
                Dependency.OnValue("generateInputFormatValidation",cubeSummationConfigurationSettings.GenerateInputFormatValidation),
                Dependency.OnValue("generateCube",cubeSummationConfigurationSettings.GenerateCube),
                Dependency.OnValue("validationModel",cubeSummationConfigurationSettings.ValidationModel)
            };

            baseContainer.Register(
                    Component.For<IGenerateInputFormatValidation>()
                    .ImplementedBy<GenerateInputFormatValidation>()
                    .DependsOn(Dependency.OnValue("validationModel", cubeSummationConfigurationSettings.ValidationModel))
                    .Named("GenerateInputFormatValidation").LifeStyle.Is(defaultLifeStyleType),
                    Component.For<IQueryBusinessValidation>()
                    .ImplementedBy<QueryBusinessValidation>()
                    .Named("QueryBusinessValidation").LifeStyle.Is(defaultLifeStyleType),
                     Component.For<IUpdateBusinessValidation>()
                    .ImplementedBy<UpdateBusinessValidation>()
                    .Named("UpdateBusinessValidation").LifeStyle.Is(defaultLifeStyleType),
                    Component.For<IGenerateInputFormat>()
                    .ImplementedBy<GenerateInputFormatFromText>()
                    .DependsOn(Dependency.OnValue("pathFile", cubeSummationConfigurationSettings.PathFile))
                    .Named("GenerateInputFormatFromText").LifeStyle.Is(defaultLifeStyleType),
                    Component.For<IOperation>()
                    .ImplementedBy<QueryBusiness>()
                    .DependsOn(Dependency.OnValue("queryBusinessValidation", cubeSummationConfigurationSettings.QueryBusinessValidation))
                    .Named("QueryBusiness").LifeStyle.Is(defaultLifeStyleType),
                     Component.For<IOperation>()
                    .ImplementedBy<UpdateBusiness>()
                    .DependsOn(dependenciesUpdateBusiness.ToArray())
                    .Named("UpdateBusiness").LifeStyle.Is(defaultLifeStyleType),
                    Component.For<ICubeSummationCube3D>()
                    .ImplementedBy<CubeSummationCube3D>()
                    .DependsOn(dependenciesCubeSummationCube3D.ToArray())
                    .Named("CubeSummationCube3D").LifeStyle.Is(defaultLifeStyleType),
                    Component.For<IGenerateCube>()
                    .ImplementedBy<GenerateCube>()
                    .Named("GenerateCube").LifeStyle.Is(defaultLifeStyleType)


                );
        }
    }
}