using UnityEngine;

namespace EnumTypes
{
    public enum LookDirection { Straight, Up, Down }
    public enum BodyPosture { Stand, Running, InTheAir, Crouch }
    public enum Layers
    {
        Default,
        TransparentFX,
        IgnoreRaycast,
        Reserved1,
        Water,
        UI,
        Reserved2,
        Reserved3,
        Player,
        World,
        Enemy,
        EnemySolid,
        FreeMan,
        Building,
        Walkable,
    }

    public enum Missions { Home = 0, Mission1, Mission2, Mission3, Mission3Boss }

    public enum LauncherType
    {
        Player,
        Enemy
    };

    public enum ThrowableType
    {
        Grenade,
        BossBomb,
        BossHeavyBomb,
        EnemyGrenade,
    };

    public class EnumTypes : MonoBehaviour { }
}