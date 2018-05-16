﻿namespace TechTalk.SpecFlow.TestProjectGenerator.NewApi._1_Memory.ConfigurationModel.Dependencies
{
    public class RegisterDependency : IDependency
    {
        public RegisterDependency(string type, string @as, string name)
        {
            Type = type;
            As = @as;
            Name = name;
        }

        public string Type { get; }

        public string As { get; }

        public string Name { get; }
    }
}