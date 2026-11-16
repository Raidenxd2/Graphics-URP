using Unity.Profiling.LowLevel;

namespace UnityEngine.Rendering.Universal
{
    /// <summary>
    /// Static profiler marker declarations for the Universal Render Pipeline.
    /// Each field is a pre-allocated <see cref="ProfilingSampler"/>.
    /// </summary>
    internal static class URPProfilingSamplers
    {
        // Full Record Render Graph

        /// <summary>
        /// Computes Screen-Space Ambient Occlusion by sampling depth-normals to estimate how much
        /// ambient light reaches each pixel, then applies bilateral blur for noise reduction.
        /// </summary>
        public static readonly ProfilingSampler SSAO = new(nameof(SSAO));
    }
}
