using UnrealBuildTool;

public class Top_Down_TTarget : TargetRules
{
	public Top_Down_TTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Top_Down_T");
	}
}
