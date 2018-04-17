﻿using System;
using FluentAssertions;
using SpecFlow.TestProjectGenerator.NewApi._1_Memory.BindingsGenerator;
using Xunit;

// ReSharper disable InconsistentNaming

namespace SpecFlow.TestProjectGenerator.Tests
{
    public class BindingsGeneratorTests
    {
        [Theory(DisplayName = "BindingsGenerator should generate step definitions")]
        [InlineData(ProgrammingLanguage.CSharp, @"[Given(""Some method"")]public void SomeMethod(){}")]
        [InlineData(ProgrammingLanguage.FSharp, @"let [<Given>] `Some method` () = ()")]
        [InlineData(ProgrammingLanguage.VB, "<Given(\"Some method\")> _\r\n    Public Sub SomeMethod\\(\\)\r\n    End Sub")]
        public void BindingsGenerator_ShouldGenerateStepDefinition(
            ProgrammingLanguage targetLanguage,
            string stepDefinition)
        {
            // ARRANGE
            BaseBindingsGenerator generator;
            switch (targetLanguage)
            {
                case ProgrammingLanguage.CSharp:
                    generator = new CSharpBindingsGenerator();
                    break;

                case ProgrammingLanguage.FSharp:
                    generator = new FSharpBindingsGenerator();
                    break;

                case ProgrammingLanguage.VB:
                    generator = new VbBindingsGenerator();
                    break;

                default:
                    throw new ArgumentException(
                        $"Target language generator not defined for {targetLanguage}.",
                        nameof(targetLanguage));
            }

            // ACT
            var bindingsFile = generator.GenerateStepDefinition(stepDefinition);

            // ASSERT
            bindingsFile.Content.Should().Contain(stepDefinition);
        }

        [Theory(DisplayName = "BindingsGenerator's result have 'Compile' as build action")]
        [InlineData(ProgrammingLanguage.CSharp, @"[Given(""Some method"")]public void SomeMethod(){}")]
        [InlineData(ProgrammingLanguage.FSharp, @"let [<Given>] `Some method` () = ()")]
        [InlineData(ProgrammingLanguage.VB, "<Given(\"Some method\")> _\r\n    Public Sub SomeMethod\\(\\)\r\n    End Sub")]
        public void BindingsGenerator_Result_ShouldHaveCompileAction(
            ProgrammingLanguage targetLanguage,
            string stepDefinition)
        {
            // ARRANGE
            BaseBindingsGenerator generator;
            switch (targetLanguage)
            {
                case ProgrammingLanguage.CSharp:
                    generator = new CSharpBindingsGenerator();
                    break;

                case ProgrammingLanguage.FSharp:
                    generator = new FSharpBindingsGenerator();
                    break;

                case ProgrammingLanguage.VB:
                    generator = new VbBindingsGenerator();
                    break;

                default:
                    throw new ArgumentException(
                        $"Target language generator not defined for {targetLanguage}.",
                        nameof(targetLanguage));
            }

            // ACT
            var bindingsFile = generator.GenerateStepDefinition(stepDefinition);

            // ASSERT
            bindingsFile.BuildAction.Should().Be("Compile");
        }
    }
}
