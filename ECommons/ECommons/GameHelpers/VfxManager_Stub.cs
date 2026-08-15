using ECommons.GameFunctions;
using System.Collections.Generic;
using System.Linq;

namespace ECommons.GameHelpers;

// API12 gap-fill: VfxManager/VfxInfo added to ECommons HEAD after walk-back 3.0.0.7.
// Stub provides compile-time types; TrackedEffects always empty (VFX hooks not set up).
public class VfxInfo
{
    public string Path = "";
    public uint VfxID;
    public ulong TargetID = ulong.MaxValue;
    public ulong CasterID = ulong.MaxValue;
    public float AgeSeconds;
}

public static class VfxManager
{
    public static readonly List<VfxInfo> TrackedEffects = [];

    public static bool TryGetVfxFor(ulong objectID, out List<VfxInfo> vfxList, bool searchCasterAsWell = false)
    {
        vfxList = [];
        return false;
    }
}

public static class VfxManagerExtensions
{
    public static List<VfxInfo> FilterToTargeted(this List<VfxInfo> list) =>
        list.Where(x => x.TargetID != ulong.MaxValue).ToList();

    public static List<VfxInfo> FilterToTarget(this List<VfxInfo> list, ulong targetId) =>
        list.Where(x => x.TargetID == targetId).ToList();

    public static List<VfxInfo> FilterToTargetRole(this List<VfxInfo> list, CombatRole role) => [];
}
