// Copyright Epic Games, Inc. All Rights Reserved.

//using System.IO;	
using UnrealBuildTool;

public class StreamTwo : ModuleRules
{
	public StreamTwo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		// NB(bt): It might be too early to cargo cult this... (uncomment the system.io import above)
		/*PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
				Path.Combine(ModuleDirectory, "Public")
			});


		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
				Path.Combine(ModuleDirectory, "Private")
			});
		*/

		PublicDependencyModuleNames.AddRange(new string[] { 
			// Preset dependencies
			"Core", "CoreUObject", "Engine", "InputCore", 
			
			// CloudCam
			"ZeroMQ",
			"CloudCamPlugin",

			// EventCenter
			"BlueprintWebSocket",
			"EventCenterPlugin",
		});

		PrivateDependencyModuleNames.AddRange(new string[] {  });
		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
