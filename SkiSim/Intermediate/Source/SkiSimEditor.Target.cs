using UnrealBuildTool;

public class SkiSimEditorTarget : TargetRules
{
	public SkiSimEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SkiSim");
	}
}
