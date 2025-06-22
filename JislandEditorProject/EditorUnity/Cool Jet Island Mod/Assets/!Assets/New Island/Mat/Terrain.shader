// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:34498,y:32666,varname:node_2865,prsc:2|diff-1754-OUT,spec-9852-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:1994,x:32436,y:32623,ptovrint:False,ptlb:R,ptin:_R,varname:node_1994,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f41771a13acbbde4981a86d1ae9dca28,ntxv:0,isnm:False;n:type:ShaderForge.SFN_FragmentPosition,id:20,x:31591,y:32945,varname:node_20,prsc:2;n:type:ShaderForge.SFN_Append,id:9028,x:32694,y:32793,varname:node_9028,prsc:2|A-20-Y,B-20-Z;n:type:ShaderForge.SFN_ChannelBlend,id:179,x:33346,y:32730,varname:node_179,prsc:2,chbt:1|M-308-OUT,R-4545-RGB,G-5860-RGB,B-9819-RGB,BTM-4960-OUT;n:type:ShaderForge.SFN_Append,id:5748,x:32677,y:32895,varname:node_5748,prsc:2|A-20-X,B-20-Z;n:type:ShaderForge.SFN_NormalVector,id:9290,x:32913,y:32427,prsc:2,pt:False;n:type:ShaderForge.SFN_Tex2d,id:4545,x:32968,y:32725,varname:node_4545,prsc:2,tex:f41771a13acbbde4981a86d1ae9dca28,ntxv:0,isnm:False|UVIN-9028-OUT,TEX-1994-TEX;n:type:ShaderForge.SFN_Tex2d,id:5860,x:32958,y:32853,varname:node_5860,prsc:2,tex:f41771a13acbbde4981a86d1ae9dca28,ntxv:0,isnm:False|UVIN-5748-OUT,TEX-1994-TEX;n:type:ShaderForge.SFN_Tex2d,id:9819,x:32945,y:32979,varname:node_9819,prsc:2,tex:f41771a13acbbde4981a86d1ae9dca28,ntxv:0,isnm:False|UVIN-7-OUT,TEX-1994-TEX;n:type:ShaderForge.SFN_Abs,id:308,x:33116,y:32570,varname:node_308,prsc:2|IN-9290-OUT;n:type:ShaderForge.SFN_Tex2d,id:4187,x:32954,y:33307,varname:node_4187,prsc:2,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False|UVIN-9028-OUT,TEX-5945-TEX;n:type:ShaderForge.SFN_Tex2d,id:2732,x:32966,y:33439,varname:_a3,prsc:2,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False|UVIN-5748-OUT,TEX-5945-TEX;n:type:ShaderForge.SFN_Tex2d,id:6376,x:32966,y:33580,varname:_b3,prsc:2,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False|UVIN-7-OUT,TEX-5945-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:5945,x:32373,y:33355,ptovrint:False,ptlb:G,ptin:_G,varname:node_5945,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Append,id:7,x:32658,y:33042,varname:node_7,prsc:2|A-20-X,B-20-Y;n:type:ShaderForge.SFN_ChannelBlend,id:7684,x:33324,y:33168,varname:node_7684,prsc:2,chbt:1|M-308-OUT,R-4187-RGB,G-2732-RGB,B-6376-RGB,BTM-4960-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:1020,x:32417,y:33908,ptovrint:False,ptlb:B,ptin:_B,varname:_G_copy,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False;n:type:ShaderForge.SFN_ChannelBlend,id:2020,x:33797,y:33047,varname:node_2020,prsc:2,chbt:1|M-6620-RGB,R-179-OUT,G-7684-OUT,B-3851-OUT,BTM-179-OUT;n:type:ShaderForge.SFN_VertexColor,id:6620,x:33542,y:32674,varname:node_6620,prsc:2;n:type:ShaderForge.SFN_Lerp,id:1754,x:34179,y:32875,varname:node_1754,prsc:2|A-4830-OUT,B-2020-OUT,T-1369-OUT;n:type:ShaderForge.SFN_Tex2d,id:1980,x:32973,y:33831,varname:node_1980,prsc:2,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False|UVIN-9028-OUT,TEX-1020-TEX;n:type:ShaderForge.SFN_Tex2d,id:8004,x:32973,y:33968,varname:_a4,prsc:2,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False|UVIN-5748-OUT,TEX-1020-TEX;n:type:ShaderForge.SFN_Tex2d,id:3138,x:32973,y:34082,varname:_b4,prsc:2,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False|UVIN-7-OUT,TEX-1020-TEX;n:type:ShaderForge.SFN_ChannelBlend,id:3851,x:33299,y:33661,varname:node_3851,prsc:2,chbt:1|M-308-OUT,R-1980-RGB,G-8004-RGB,B-3138-RGB,BTM-4960-OUT;n:type:ShaderForge.SFN_Tex2d,id:6862,x:32923,y:34282,varname:node_6862,prsc:2,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False|UVIN-9028-OUT,TEX-6981-TEX;n:type:ShaderForge.SFN_Tex2d,id:9948,x:32923,y:34450,varname:_as_copy,prsc:2,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False|UVIN-5748-OUT,TEX-6981-TEX;n:type:ShaderForge.SFN_Tex2d,id:8512,x:32923,y:34640,varname:_bs_copy,prsc:2,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False|UVIN-7-OUT,TEX-6981-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:6981,x:32468,y:34389,ptovrint:False,ptlb:S,ptin:_S,varname:_B_copy,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9b35a2bb99d36fb46ae33c04b350aa8f,ntxv:0,isnm:False;n:type:ShaderForge.SFN_ChannelBlend,id:4830,x:33345,y:34191,varname:node_4830,prsc:2,chbt:1|M-308-OUT,R-6862-RGB,G-9948-RGB,B-8512-RGB,BTM-4960-OUT;n:type:ShaderForge.SFN_Multiply,id:1768,x:33694,y:32317,varname:node_1768,prsc:2|A-737-OUT,B-8511-OUT;n:type:ShaderForge.SFN_Vector1,id:737,x:33444,y:32300,varname:node_737,prsc:2,v1:5;n:type:ShaderForge.SFN_Clamp01,id:1369,x:33908,y:32350,varname:node_1369,prsc:2|IN-1768-OUT;n:type:ShaderForge.SFN_Subtract,id:8511,x:33510,y:32402,varname:node_8511,prsc:2|A-976-OUT,B-8271-OUT;n:type:ShaderForge.SFN_Multiply,id:1997,x:33116,y:32306,varname:node_1997,prsc:2|A-9290-OUT,B-7898-OUT;n:type:ShaderForge.SFN_Vector3,id:7898,x:32884,y:32241,varname:node_7898,prsc:2,v1:0,v2:1,v3:0;n:type:ShaderForge.SFN_Distance,id:976,x:33336,y:32470,varname:node_976,prsc:2|A-1997-OUT,B-5224-OUT;n:type:ShaderForge.SFN_Vector3,id:5224,x:33144,y:32470,varname:node_5224,prsc:2,v1:0,v2:0,v3:0;n:type:ShaderForge.SFN_Vector1,id:8271,x:33318,y:32388,varname:node_8271,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector1,id:9852,x:34161,y:32646,varname:node_9852,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:4960,x:33050,y:33128,varname:node_4960,prsc:2,v1:0;proporder:1994-5945-1020-6981;pass:END;sub:END;*/

Shader "Shader Forge/Terrain" {
    Properties {
        _R ("R", 2D) = "white" {}
        _G ("G", 2D) = "white" {}
        _B ("B", 2D) = "white" {}
        _S ("S", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _R; uniform float4 _R_ST;
            uniform sampler2D _G; uniform float4 _G_ST;
            uniform sampler2D _B; uniform float4 _B_ST;
            uniform sampler2D _S; uniform float4 _S_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv1 : TEXCOORD0;
                float2 uv2 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
                float3 normalDir : TEXCOORD3;
                float3 tangentDir : TEXCOORD4;
                float3 bitangentDir : TEXCOORD5;
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD9;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float node_9852 = 0.0;
                float3 specularColor = float3(node_9852,node_9852,node_9852);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 indirectSpecular = (gi.indirect.specular)*specularColor;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 node_308 = abs(i.normalDir);
                float node_4960 = 0.0;
                float2 node_9028 = float2(i.posWorld.g,i.posWorld.b);
                float4 node_6862 = tex2D(_S,TRANSFORM_TEX(node_9028, _S));
                float2 node_5748 = float2(i.posWorld.r,i.posWorld.b);
                float4 _as_copy = tex2D(_S,TRANSFORM_TEX(node_5748, _S));
                float2 node_7 = float2(i.posWorld.r,i.posWorld.g);
                float4 _bs_copy = tex2D(_S,TRANSFORM_TEX(node_7, _S));
                float4 node_4545 = tex2D(_R,TRANSFORM_TEX(node_9028, _R));
                float4 node_5860 = tex2D(_R,TRANSFORM_TEX(node_5748, _R));
                float4 node_9819 = tex2D(_R,TRANSFORM_TEX(node_7, _R));
                float3 node_179 = (lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_4545.rgb, node_308.r ), node_5860.rgb, node_308.g ), node_9819.rgb, node_308.b ));
                float4 node_4187 = tex2D(_G,TRANSFORM_TEX(node_9028, _G));
                float4 _a3 = tex2D(_G,TRANSFORM_TEX(node_5748, _G));
                float4 _b3 = tex2D(_G,TRANSFORM_TEX(node_7, _G));
                float4 node_1980 = tex2D(_B,TRANSFORM_TEX(node_9028, _B));
                float4 _a4 = tex2D(_B,TRANSFORM_TEX(node_5748, _B));
                float4 _b4 = tex2D(_B,TRANSFORM_TEX(node_7, _B));
                float3 diffuseColor = lerp((lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_6862.rgb, node_308.r ), _as_copy.rgb, node_308.g ), _bs_copy.rgb, node_308.b )),(lerp( lerp( lerp( node_179, node_179, i.vertexColor.rgb.r ), (lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_4187.rgb, node_308.r ), _a3.rgb, node_308.g ), _b3.rgb, node_308.b )), i.vertexColor.rgb.g ), (lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_1980.rgb, node_308.r ), _a4.rgb, node_308.g ), _b4.rgb, node_308.b )), i.vertexColor.rgb.b )),saturate((5.0*(distance((i.normalDir*float3(0,1,0)),float3(0,0,0))-0.5))));
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _R; uniform float4 _R_ST;
            uniform sampler2D _G; uniform float4 _G_ST;
            uniform sampler2D _B; uniform float4 _B_ST;
            uniform sampler2D _S; uniform float4 _S_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv1 : TEXCOORD0;
                float2 uv2 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
                float3 normalDir : TEXCOORD3;
                float3 tangentDir : TEXCOORD4;
                float3 bitangentDir : TEXCOORD5;
                float4 vertexColor : COLOR;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float node_9852 = 0.0;
                float3 specularColor = float3(node_9852,node_9852,node_9852);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 node_308 = abs(i.normalDir);
                float node_4960 = 0.0;
                float2 node_9028 = float2(i.posWorld.g,i.posWorld.b);
                float4 node_6862 = tex2D(_S,TRANSFORM_TEX(node_9028, _S));
                float2 node_5748 = float2(i.posWorld.r,i.posWorld.b);
                float4 _as_copy = tex2D(_S,TRANSFORM_TEX(node_5748, _S));
                float2 node_7 = float2(i.posWorld.r,i.posWorld.g);
                float4 _bs_copy = tex2D(_S,TRANSFORM_TEX(node_7, _S));
                float4 node_4545 = tex2D(_R,TRANSFORM_TEX(node_9028, _R));
                float4 node_5860 = tex2D(_R,TRANSFORM_TEX(node_5748, _R));
                float4 node_9819 = tex2D(_R,TRANSFORM_TEX(node_7, _R));
                float3 node_179 = (lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_4545.rgb, node_308.r ), node_5860.rgb, node_308.g ), node_9819.rgb, node_308.b ));
                float4 node_4187 = tex2D(_G,TRANSFORM_TEX(node_9028, _G));
                float4 _a3 = tex2D(_G,TRANSFORM_TEX(node_5748, _G));
                float4 _b3 = tex2D(_G,TRANSFORM_TEX(node_7, _G));
                float4 node_1980 = tex2D(_B,TRANSFORM_TEX(node_9028, _B));
                float4 _a4 = tex2D(_B,TRANSFORM_TEX(node_5748, _B));
                float4 _b4 = tex2D(_B,TRANSFORM_TEX(node_7, _B));
                float3 diffuseColor = lerp((lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_6862.rgb, node_308.r ), _as_copy.rgb, node_308.g ), _bs_copy.rgb, node_308.b )),(lerp( lerp( lerp( node_179, node_179, i.vertexColor.rgb.r ), (lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_4187.rgb, node_308.r ), _a3.rgb, node_308.g ), _b3.rgb, node_308.b )), i.vertexColor.rgb.g ), (lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_1980.rgb, node_308.r ), _a4.rgb, node_308.g ), _b4.rgb, node_308.b )), i.vertexColor.rgb.b )),saturate((5.0*(distance((i.normalDir*float3(0,1,0)),float3(0,0,0))-0.5))));
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform sampler2D _R; uniform float4 _R_ST;
            uniform sampler2D _G; uniform float4 _G_ST;
            uniform sampler2D _B; uniform float4 _B_ST;
            uniform sampler2D _S; uniform float4 _S_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv1 : TEXCOORD0;
                float2 uv2 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
                float3 normalDir : TEXCOORD3;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = 0;
                
                float3 node_308 = abs(i.normalDir);
                float node_4960 = 0.0;
                float2 node_9028 = float2(i.posWorld.g,i.posWorld.b);
                float4 node_6862 = tex2D(_S,TRANSFORM_TEX(node_9028, _S));
                float2 node_5748 = float2(i.posWorld.r,i.posWorld.b);
                float4 _as_copy = tex2D(_S,TRANSFORM_TEX(node_5748, _S));
                float2 node_7 = float2(i.posWorld.r,i.posWorld.g);
                float4 _bs_copy = tex2D(_S,TRANSFORM_TEX(node_7, _S));
                float4 node_4545 = tex2D(_R,TRANSFORM_TEX(node_9028, _R));
                float4 node_5860 = tex2D(_R,TRANSFORM_TEX(node_5748, _R));
                float4 node_9819 = tex2D(_R,TRANSFORM_TEX(node_7, _R));
                float3 node_179 = (lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_4545.rgb, node_308.r ), node_5860.rgb, node_308.g ), node_9819.rgb, node_308.b ));
                float4 node_4187 = tex2D(_G,TRANSFORM_TEX(node_9028, _G));
                float4 _a3 = tex2D(_G,TRANSFORM_TEX(node_5748, _G));
                float4 _b3 = tex2D(_G,TRANSFORM_TEX(node_7, _G));
                float4 node_1980 = tex2D(_B,TRANSFORM_TEX(node_9028, _B));
                float4 _a4 = tex2D(_B,TRANSFORM_TEX(node_5748, _B));
                float4 _b4 = tex2D(_B,TRANSFORM_TEX(node_7, _B));
                float3 diffColor = lerp((lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_6862.rgb, node_308.r ), _as_copy.rgb, node_308.g ), _bs_copy.rgb, node_308.b )),(lerp( lerp( lerp( node_179, node_179, i.vertexColor.rgb.r ), (lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_4187.rgb, node_308.r ), _a3.rgb, node_308.g ), _b3.rgb, node_308.b )), i.vertexColor.rgb.g ), (lerp( lerp( lerp( float3(node_4960,node_4960,node_4960), node_1980.rgb, node_308.r ), _a4.rgb, node_308.g ), _b4.rgb, node_308.b )), i.vertexColor.rgb.b )),saturate((5.0*(distance((i.normalDir*float3(0,1,0)),float3(0,0,0))-0.5))));
                float node_9852 = 0.0;
                float3 specColor = float3(node_9852,node_9852,node_9852);
                o.Albedo = diffColor + specColor * 0.125; // No gloss connected. Assume it's 0.5
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
