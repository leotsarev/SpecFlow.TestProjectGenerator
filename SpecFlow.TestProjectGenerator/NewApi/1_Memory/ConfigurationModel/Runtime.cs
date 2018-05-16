﻿using System.Collections.Generic;
using TechTalk.SpecFlow.TestProjectGenerator.NewApi._1_Memory.ConfigurationModel.Dependencies;

namespace TechTalk.SpecFlow.TestProjectGenerator.NewApi._1_Memory.ConfigurationModel
{
    public class Runtime
    {
        private readonly List<IDependency> _dependencies = new List<IDependency>();
        public bool StopAtFirstError { get; set; }
        public MissingOrPendingStepsOutcome MissingOrPendingStepsOutcome { get; set; } = MissingOrPendingStepsOutcome.Inconclusive;
        public IReadOnlyList<IDependency> Dependencies => _dependencies;

        public string ObsoleteBehavior { get; set; }

        public void AddRegisterDependency(string type, string @as, string name = null)
        {
            _dependencies.Add(new RegisterDependency(type, @as, name));
        }
    }
}
