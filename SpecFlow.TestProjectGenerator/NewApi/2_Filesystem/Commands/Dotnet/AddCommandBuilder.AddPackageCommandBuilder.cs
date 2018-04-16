﻿namespace SpecFlow.TestProjectGenerator.NewApi._2_Filesystem.Commands.Dotnet
{
    public partial class AddCommandBuilder
    {
        public class AddPackageCommandBuilder : BaseCommandBuilder
        {
            private string _projectFilePath;
            private string _packageName;
            private string _packageVersion;


            public AddPackageCommandBuilder ToProject(string projectFilePath)
            {
                _projectFilePath = projectFilePath;
                return this;
            }

            public AddPackageCommandBuilder WithPackageName(string packageName)
            {
                _packageName = packageName;
                return this;
            }

            public AddPackageCommandBuilder WithPackageVersion(string packageVersion)
            {
                _packageVersion = packageVersion;
                return this;
            }

            protected override string BuildArguments()
            {
                string arguments = $"add {_projectFilePath} package {_packageName}";
                arguments = AddArgument(arguments, "-v", _packageVersion);

                return arguments;
            }
        }
    }
}