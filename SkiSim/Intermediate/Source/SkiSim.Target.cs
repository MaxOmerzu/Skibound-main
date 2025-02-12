using UnrealBuildTool;

public class SkiSimTarget : TargetRules
{
	public SkiSimTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SkiSim");
	}
}
