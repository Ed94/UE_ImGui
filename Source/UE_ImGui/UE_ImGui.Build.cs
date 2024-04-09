using UnrealBuildTool;

public class UE_ImGui : ModuleRules
{
	public UE_ImGui(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new[]
		{
			"Core",
			"ImGui",
			"ImPlot",
			"NetImGui"
		});

		PrivateDependencyModuleNames.AddRange(new[]
		{
			"ApplicationCore",
			"InputCore",
			"Slate",
			"SlateCore"
		});

		if (Target.bCompileAgainstEngine)
		{
			PrivateDependencyModuleNames.AddRange(new[]
			{
				"CoreUObject",
				"Engine"
			});
		}

		if (Target.bBuildEditor)
		{
			PrivateDependencyModuleNames.AddRange(new[]
			{
				"MainFrame",
				"UnrealEd"
			});
		}

		PublicDefinitions.AddRange(new[]
		{
			"IMGUI_USER_CONFIG=\"ImGuiConfig.h\"",
			"IMPLOT_API=IMGUI_API",
			"NETIMGUI_API=IMGUI_API"
		});
	}
}