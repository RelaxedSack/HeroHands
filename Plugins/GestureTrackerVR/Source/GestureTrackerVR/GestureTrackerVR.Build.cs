// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GestureTrackerVR : ModuleRules
{
    public GestureTrackerVR(TargetInfo Target)
    {
        PublicIncludePaths.AddRange(
            new string[] {
                "GestureTrackerVR/Public"
            }
            );


        PrivateIncludePaths.AddRange(
            new string[] {
                "GestureTrackerVR/Private"
            }
            );


        PublicDependencyModuleNames.AddRange(
            new string[]
            {

            }
            );


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "CoreUObject",
                "Engine",
                // ... add private dependencies that you statically link with here ...	
            }
            );


        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
                // ... add any modules that your module loads dynamically here ...
            }
            );
    }
}
