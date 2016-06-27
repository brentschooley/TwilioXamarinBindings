using ObjCRuntime;

[assembly: LinkWith ("libTwilioConversationsClient.a", 
    LinkTarget.ArmV7 | LinkTarget.x86_64 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64 | LinkTarget.i386,
    Frameworks = "CoreTelephony VideoToolbox CoreMedia CoreVideo QuartzCore ImageIO CoreText AssetsLibrary MobileCoreServices CoreImage GLKit OpenGLES QuickLook UIKit Foundation CoreGraphics AudioToolbox CFNetwork SystemConfiguration AVFoundation",
    LinkerFlags = "-lstdc++ -lc++ -lz -dead_strip",
    IsCxx = true,
    SmartLink = true, 
    ForceLoad = true)]
