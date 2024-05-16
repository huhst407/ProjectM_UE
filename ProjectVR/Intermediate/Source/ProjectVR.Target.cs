using UnrealBuildTool;

public class ProjectVRTarget : TargetRules
{
	public ProjectVRTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectVR");
	}
}
