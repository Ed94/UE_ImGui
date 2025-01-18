using UnrealBuildTool;
using System.IO;

public class NetImGui : ModuleRules
{
    public NetImGui(ReadOnlyTargetRules Target) : base(Target)
    {
        Type = ModuleType.External;
        PublicSystemIncludePaths.Add(ModuleDirectory);

		PublicDependencyModuleNames.Add("Sockets");
    }
}
