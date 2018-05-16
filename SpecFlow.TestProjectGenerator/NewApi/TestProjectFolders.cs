﻿using System;
using System.IO;
using TechTalk.SpecFlow.TestProjectGenerator.Helpers;

namespace TechTalk.SpecFlow.TestProjectGenerator.NewApi
{
    public class TestProjectFolders
    {
        private string _pathToSolutionFile;
        public string ProjectFolder { get; set; }
        public string ProjectBinOutputPath { get; set; }
        public string CompiledAssemblyPath { get; set; }
        public string PathToSolutionDirectory => Path.GetDirectoryName(PathToSolutionFile);
        public string TestAssemblyFileName { get; set; }

        public string PathToSolutionFile
        {
            get
            {
                if (_pathToSolutionFile.IsNullOrWhiteSpace())
                {
                    throw new Exception($"{nameof(PathToSolutionFile)} is empty. Solution wasn't written yet to the file system");
                }

                return _pathToSolutionFile;
            }
            set { _pathToSolutionFile = value; }
        }

        public string SolutionFileName => Path.GetFileName(PathToSolutionFile);

        public string PathToNuGetPackages { get; set; }
    }
}
