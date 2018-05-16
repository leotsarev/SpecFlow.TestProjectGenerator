﻿namespace TechTalk.SpecFlow.TestProjectGenerator.NewApi._2_Filesystem.Commands.Dotnet
{
    public abstract class BaseCommandBuilder
    {
        protected readonly IOutputWriter _outputWriter;
        private const string ExecutablePath = "dotnet";

        protected BaseCommandBuilder(IOutputWriter outputWriter)
        {
            _outputWriter = outputWriter;
        }

        public CommandBuilder Build()
        {
            return new CommandBuilder(_outputWriter, ExecutablePath, BuildArguments());
        }

        protected abstract string BuildArguments();

        protected string AddArgument(string argumentsFormat, string option, string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                argumentsFormat += $" {option} {value}";
            }

            return argumentsFormat;
        }
    }
}
