// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class P_GAS : ModuleRules
{
	public P_GAS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"P_GAS",
			"P_GAS/Variant_Platforming",
			"P_GAS/Variant_Platforming/Animation",
			"P_GAS/Variant_Combat",
			"P_GAS/Variant_Combat/AI",
			"P_GAS/Variant_Combat/Animation",
			"P_GAS/Variant_Combat/Gameplay",
			"P_GAS/Variant_Combat/Interfaces",
			"P_GAS/Variant_Combat/UI",
			"P_GAS/Variant_SideScrolling",
			"P_GAS/Variant_SideScrolling/AI",
			"P_GAS/Variant_SideScrolling/Gameplay",
			"P_GAS/Variant_SideScrolling/Interfaces",
			"P_GAS/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
