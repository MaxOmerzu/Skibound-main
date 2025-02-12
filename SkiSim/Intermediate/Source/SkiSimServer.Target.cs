using UnrealBuildTool;

public class SkiSimServerTarget : TargetRules
{
	public SkiSimServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SkiSim");
	}
}
