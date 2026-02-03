#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
[InitializeOnLoad]
#endif
public static class BeanShootoutURP
{
#if UNITY_EDITOR
    static BeanShootoutURP()
    {
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    private static void OnPlayModeStateChanged(PlayModeStateChange obj)
    {
        if (obj == PlayModeStateChange.ExitingPlayMode)
        {
            EnableEarlyCmd = false;
        }
    }
#endif

    /// <summary>
    /// Determines if XR rendering should be done.
    /// </summary>
    public static bool EnableXRRenderingSupport;
    /// <summary>
    /// Determines if HDR Display Output should be supported.
    /// </summary>
    public static bool EnableHDROutputSupport;
    /// <summary>
    /// Determines if Motion Vectors should be supported.
    /// </summary>
    public static bool EnableMotionVectorsSupport;
#if KILLITMYSELF_URP
    /// <summary>
    /// Determines if EarlyCmd should be rendered. (EarlyCmd is the dark gray backgrond rendered behind everything to prevent nothing from being repainted)
    /// </summary>
    public static bool EnableEarlyCmd;
#endif
}