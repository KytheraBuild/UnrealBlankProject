// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealBlankProjectClientTarget : TargetRules
{
	public UnrealBlankProjectClientTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Client;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.AddRange( new string[] { "UnrealBlankProject" } );

		bUseLoggingInShipping = true;

		// Installed (binary) engines share the engine's build environment and
		// reject modified properties like bUseLoggingInShipping; force the
		// override instead. No effect on source-built engines.
		bOverrideBuildEnvironment = true;
	}
}
