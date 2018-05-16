﻿using TechTalk.SpecFlow.TestProjectGenerator.NewApi._1_Memory;

namespace TechTalk.SpecFlow.TestProjectGenerator.NewApi
{
    public class TestRunConfiguration
    {
        public TestRunConfiguration(ProgrammingLanguage programmingLanguage, ProjectFormat projectFormat, TargetFramework targetFramework, UnitTestProvider unitTestProvider)
        {
            ProgrammingLanguage = programmingLanguage;
            ProjectFormat = projectFormat;
            TargetFramework = targetFramework;
            UnitTestProvider = unitTestProvider;
        }

        public ProgrammingLanguage ProgrammingLanguage { get; set; }
        public ProjectFormat ProjectFormat { get; set; }

        public TargetFramework TargetFramework { get; set; }

        public UnitTestProvider UnitTestProvider { get; set; }
    }
}