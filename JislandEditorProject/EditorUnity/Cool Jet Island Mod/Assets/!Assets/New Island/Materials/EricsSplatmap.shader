Shader "EricsSplatmap" {
	Properties {
		_Splatmap ("Splatmap (RGB)", 2D) = "white" {}
		_SplatSmoothness ("Fade Smoothness", Range(0, 1)) = 0.5
		_LerpToCutoff ("Fade To Cutoff", Range(0, 1)) = 0.5
		_LerpToOrigSplat ("Fade To Original Splat", Range(0, 1)) = 0.5
		[Space(30)] _TiledDarken ("Tiled Darken", 2D) = "black" {}
		_TiledDarkenAmount ("Darken Amount", Range(0, 1)) = 0.5
		_TiledHighlight ("Tiled Highlight", 2D) = "black" {}
		_TiledHighlightAmount ("Highlight Amount", Range(0, 1)) = 0.5
		_TiledNormal ("Tiled Normal", 2D) = "bump" {}
		_TiledNormalAmount ("Normal Amount", Range(0, 3)) = 0.5
		[Space(30)] _NonTiledNormal ("Non-Tiled Normal", 2D) = "bump" {}
		_NonTiledNormalAmount ("Non-Tiled Normal Amount", Range(0, 3)) = 0.5
		[Space(30)] _AOMap ("Ambient Occlusion map", 2D) = "white" {}
		_AOMultiplier ("Ambient Occlusion darkness", Range(0, 10)) = 0.5
		[Space(30)] _RedTex ("Red Texture", 2D) = "white" {}
		_RedNormal ("Red Normal", 2D) = "bump" {}
		_RedNormalAmount ("Red Normal Multiplier", Range(0, 5)) = 1
		_RedGlossiness ("Red Smoothness", Range(0, 1)) = 0.5
		_RedMetalic ("Red Metalic", Range(0, 1)) = 0
		_RedColor ("Red Color Tint", Vector) = (1,1,1,1)
		_RedHeight ("Red Height Blend Multiplier", Range(0, 5)) = 1
		_RedBrightness ("Red Brightness Multiplier", Range(0, 20)) = 1
		[Space(30)] _GreenTex ("Green Texture", 2D) = "white" {}
		_GreenNormal ("Green Normal", 2D) = "bump" {}
		_GreenNormalAmount ("Green Normal Multiplier", Range(0, 5)) = 1
		_GreenGlossiness ("Green Smoothness", Range(0, 1)) = 0.5
		_GreenMetalic ("Green Metalic", Range(0, 1)) = 0
		_GreenColor ("Green Color Tint", Vector) = (1,1,1,1)
		_GreenHeight ("Green Height Blend Multiplier", Range(0, 5)) = 1
		_GreenBrightness ("Green Brightness Multiplier", Range(0, 20)) = 1
		[Space(30)] _BlueTex ("Blue Texture", 2D) = "white" {}
		_BlueNormal ("Blue Normal", 2D) = "bump" {}
		_BlueNormalAmount ("Blue Normal Multiplier", Range(0, 5)) = 1
		_BlueGlossiness ("Blue Smoothness", Range(0, 1)) = 0.5
		_BlueMetalic ("Blue Metalic", Range(0, 1)) = 0
		_BlueColor ("Blue Color Tint", Vector) = (1,1,1,1)
		_BlueHeight ("Blue Height Blend Multiplier", Range(0, 5)) = 1
		_BlueBrightness ("Blue Brightness Multiplier", Range(0, 20)) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_MatrixMVP;

			struct Vertex_Stage_Input
			{
				float3 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixMVP, float4(input.pos, 1.0));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
}