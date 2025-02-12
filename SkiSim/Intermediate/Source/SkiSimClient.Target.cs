using UnrealBuildTool;

public class SkiSimClientTarget : TargetRules
{
	public SkiSimClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SkiSim");
	}
}
