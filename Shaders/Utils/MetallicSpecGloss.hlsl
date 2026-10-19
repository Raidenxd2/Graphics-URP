#ifndef UNIVERSAL_METALLIC_SPEC_GLOSS_INCLUDED
#define UNIVERSAL_METALLIC_SPEC_GLOSS_INCLUDED

#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Macros.hlsl"

// Returns true if the _SPECULAR_SETUP variant is active.
bool IsSpecularSetup()
{
#if defined(_SPECULAR_SETUP_KEYWORD_DECLARED)
    return _SPECULAR_SETUP;
#elif DEFINED_NONZERO(_SPECULAR_SETUP)
    return true;
#else
    return false;
#endif
}

// Returns true if the _METALLICSPECGLOSSMAP variant is active.
bool UseMetallicSpecGlossMap()
{
#if defined(_METALLICSPECGLOSSMAP_KEYWORD_DECLARED)
    return _METALLICSPECGLOSSMAP;
#elif DEFINED_NONZERO(_METALLICSPECGLOSSMAP)
    return true;
#else
    return false;
#endif
}

// Returns true if the _SMOOTHNESS_TEXTURE_ALBEDO_CHANNEL_A variant is active.
bool UseSmoothnessTextureAlbedoChannelA()
{
#if defined(_SMOOTHNESS_TEXTURE_ALBEDO_CHANNEL_A_KEYWORD_DECLARED)
    return _SMOOTHNESS_TEXTURE_ALBEDO_CHANNEL_A;
#elif DEFINED_NONZERO(_SMOOTHNESS_TEXTURE_ALBEDO_CHANNEL_A)
    return true;
#else
    return false;
#endif
}

// Simple getters the including material's input file must define.
half4 SampleMetallicGlossMap(float2 uv);
half4 SampleSpecGlossMap(float2 uv);

#endif // UNIVERSAL_METALLIC_SPEC_GLOSS_INCLUDED