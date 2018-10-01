using System;
using WixSharp;
using WixSharp.CommonTasks;

namespace PngOutlinerInstaller
{
    internal static class Program
    {
        #region Properties

        private static string CompanyName { get; } = @"PngOutlinerCompany";
        private static string ProgramName { get; } = @"PngOutliner";
        private static string ProgramShortName { get; } = @"PngOutliner";
        private static string ProgramFilesPath { get; } = $@"%ProgramFiles%\{CompanyName}\{ProgramName}";
        private static string ApplicationPath { get; } = @"..\Application\bin\Release\";

        #endregion

        #region Main

        private static void Main()
        {
            try
            {
                CreateMsi();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region Methods

        private static void CreateMsi()
        {
            var mainExe = new File(ApplicationPath + ProgramShortName + ".exe")
            {
                Shortcuts = new[]
                {
                    new FileShortcut(ProgramName, "%ProgramMenu%"),
                    new FileShortcut(ProgramName, "%Desktop%")
                }
            };
            var project = new Project(
                ProgramShortName,
                new Dir(
                    ProgramFilesPath,
                    new DirFiles(ApplicationPath + "*.dll"),
                    new DirFiles(ApplicationPath + "*.config"),
                    new Dir("x86", new DirFiles(ApplicationPath + @"x86\*.*")),
                    new Dir("x64", new DirFiles(ApplicationPath + @"x64\*.*")),
                    mainExe
                )
            )
            {
                GUID = new Guid("E03223BE-8050-40B7-A08C-B6DDDE7B3A52"),
                ControlPanelInfo =
                {
                    Manufacturer = CompanyName,
                    ProductIcon = @"..\Application\icon.ico",
                },
                Version = new Version(1, 0, 0),
                UI = WUI.WixUI_ProgressOnly,
                MajorUpgrade = MajorUpgrade.Default
            };

            project.SetNetFxPrerequisite(Condition.Net461_Installed, "Please install .NET 4.6.1 first.");

            Compiler.WixLocation = @"..\packages\WixSharp.wix.bin.3.11.0\tools\bin";
            Compiler.BuildMsi(project);
        }

        #endregion
    }
}