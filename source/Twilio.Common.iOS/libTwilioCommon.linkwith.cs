using ObjCRuntime;

[assembly: LinkWith ("libTwilioCommon.a", 
    LinkTarget.ArmV7 | LinkTarget.x86_64 | LinkTarget.ArmV7s| LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64 | LinkTarget.i386,
    Frameworks = "",
    LinkerFlags = "-ObjC -lstdc++ -lc++ -lz -dead_strip",
    SmartLink = true, 
    ForceLoad = true)]
