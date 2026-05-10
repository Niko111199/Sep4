// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Sep4 : ModuleRules
{
	public Sep4(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
