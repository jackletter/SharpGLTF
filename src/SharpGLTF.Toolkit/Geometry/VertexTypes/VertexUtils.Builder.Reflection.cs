// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;




namespace SharpGLTF.Geometry.VertexTypes
{
    partial class VertexUtils
    {            
        public static (Type BuilderType, Func<IVertexBuilder> BuilderFactory) GetVertexBuilderType(bool hasNormals, bool hasTangents, int numCols, int numUV, int numJoints)
        {
            switch(numJoints)
            {
                case 0:
                switch(numCols)
                {
                    case 0:
                    switch(numUV)
                    {
                        case 0:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexEmpty,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexEmpty,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexEmpty,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexEmpty,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexEmpty,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexEmpty,VertexEmpty>() );
                        case 1:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture1,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexTexture1,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture1,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture1,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture1,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture1,VertexEmpty>() );
                        case 2:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture2,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexTexture2,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture2,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture2,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture2,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture2,VertexEmpty>() );
                        case 3:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture3,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexTexture3,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture3,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture3,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture3,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture3,VertexEmpty>() );
                        case 4:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture4,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexTexture4,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture4,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture4,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture4,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture4,VertexEmpty>() );
                        default: throw new ArgumentOutOfRangeException(nameof(numUV));
                    }
                    case 1:
                    switch(numUV)
                    {
                        case 0:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexColor1,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1,VertexEmpty>() );
                        case 1:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture1,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture1,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture1,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture1,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture1,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture1,VertexEmpty>() );
                        case 2:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture2,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture2,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture2,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture2,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture2,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture2,VertexEmpty>() );
                        case 3:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture3,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture3,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture3,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture3,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture3,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture3,VertexEmpty>() );
                        case 4:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture4,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture4,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture4,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture4,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture4,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture4,VertexEmpty>() );
                        default: throw new ArgumentOutOfRangeException(nameof(numUV));
                    }
                    case 2:
                    switch(numUV)
                    {
                        case 0:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexColor2,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2,VertexEmpty>() );
                        case 1:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture1,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture1,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture1,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture1,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture1,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture1,VertexEmpty>() );
                        case 2:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture2,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture2,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture2,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture2,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture2,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture2,VertexEmpty>() );
                        case 3:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture3,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture3,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture3,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture3,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture3,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture3,VertexEmpty>() );
                        case 4:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture4,VertexEmpty>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture4,VertexEmpty>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture4,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture4,VertexEmpty>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture4,VertexEmpty>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture4,VertexEmpty>() );
                        default: throw new ArgumentOutOfRangeException(nameof(numUV));
                    }
                    default: throw new ArgumentOutOfRangeException(nameof(numCols));
                }
                case 4:
                switch(numCols)
                {
                    case 0:
                    switch(numUV)
                    {
                        case 0:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexEmpty,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexEmpty,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexEmpty,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexEmpty,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexEmpty,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexEmpty,VertexJoints4>() );
                        case 1:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture1,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexTexture1,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture1,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture1,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture1,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture1,VertexJoints4>() );
                        case 2:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture2,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexTexture2,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture2,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture2,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture2,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture2,VertexJoints4>() );
                        case 3:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture3,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexTexture3,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture3,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture3,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture3,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture3,VertexJoints4>() );
                        case 4:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture4,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexTexture4,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture4,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture4,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture4,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture4,VertexJoints4>() );
                        default: throw new ArgumentOutOfRangeException(nameof(numUV));
                    }
                    case 1:
                    switch(numUV)
                    {
                        case 0:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexColor1,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1,VertexJoints4>() );
                        case 1:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture1,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture1,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture1,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture1,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture1,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture1,VertexJoints4>() );
                        case 2:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture2,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture2,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture2,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture2,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture2,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture2,VertexJoints4>() );
                        case 3:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture3,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture3,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture3,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture3,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture3,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture3,VertexJoints4>() );
                        case 4:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture4,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture4,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture4,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture4,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture4,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture4,VertexJoints4>() );
                        default: throw new ArgumentOutOfRangeException(nameof(numUV));
                    }
                    case 2:
                    switch(numUV)
                    {
                        case 0:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexColor2,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2,VertexJoints4>() );
                        case 1:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture1,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture1,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture1,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture1,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture1,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture1,VertexJoints4>() );
                        case 2:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture2,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture2,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture2,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture2,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture2,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture2,VertexJoints4>() );
                        case 3:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture3,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture3,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture3,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture3,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture3,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture3,VertexJoints4>() );
                        case 4:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture4,VertexJoints4>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture4,VertexJoints4>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture4,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture4,VertexJoints4>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture4,VertexJoints4>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture4,VertexJoints4>() );
                        default: throw new ArgumentOutOfRangeException(nameof(numUV));
                    }
                    default: throw new ArgumentOutOfRangeException(nameof(numCols));
                }
                case 8:
                switch(numCols)
                {
                    case 0:
                    switch(numUV)
                    {
                        case 0:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexEmpty,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexEmpty,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexEmpty,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexEmpty,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexEmpty,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexEmpty,VertexJoints8>() );
                        case 1:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture1,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexTexture1,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture1,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture1,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture1,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture1,VertexJoints8>() );
                        case 2:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture2,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexTexture2,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture2,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture2,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture2,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture2,VertexJoints8>() );
                        case 3:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture3,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexTexture3,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture3,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture3,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture3,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture3,VertexJoints8>() );
                        case 4:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexTexture4,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexTexture4,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexTexture4,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexTexture4,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexTexture4,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexTexture4,VertexJoints8>() );
                        default: throw new ArgumentOutOfRangeException(nameof(numUV));
                    }
                    case 1:
                    switch(numUV)
                    {
                        case 0:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexColor1,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1,VertexJoints8>() );
                        case 1:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture1,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture1,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture1,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture1,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture1,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture1,VertexJoints8>() );
                        case 2:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture2,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture2,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture2,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture2,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture2,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture2,VertexJoints8>() );
                        case 3:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture3,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture3,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture3,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture3,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture3,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture3,VertexJoints8>() );
                        case 4:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor1Texture4,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexColor1Texture4,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor1Texture4,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor1Texture4,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture4,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor1Texture4,VertexJoints8>() );
                        default: throw new ArgumentOutOfRangeException(nameof(numUV));
                    }
                    case 2:
                    switch(numUV)
                    {
                        case 0:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexColor2,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2,VertexJoints8>() );
                        case 1:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture1,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture1,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture1,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture1,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture1,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture1,VertexJoints8>() );
                        case 2:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture2,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture2,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture2,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture2,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture2,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture2,VertexJoints8>() );
                        case 3:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture3,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture3,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture3,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture3,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture3,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture3,VertexJoints8>() );
                        case 4:
                            if (!hasNormals) return (typeof(VertexBuilder<VertexPosition,VertexColor2Texture4,VertexJoints8>), ()=> new VertexBuilder<VertexPosition,VertexColor2Texture4,VertexJoints8>() );
                            if (!hasTangents) return (typeof(VertexBuilder<VertexPositionNormal,VertexColor2Texture4,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormal,VertexColor2Texture4,VertexJoints8>() );
                            return (typeof(VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture4,VertexJoints8>), ()=> new VertexBuilder<VertexPositionNormalTangent,VertexColor2Texture4,VertexJoints8>() );
                        default: throw new ArgumentOutOfRangeException(nameof(numUV));
                    }
                    default: throw new ArgumentOutOfRangeException(nameof(numCols));
                }
                default: throw new ArgumentOutOfRangeException(nameof(numJoints));
            }
            throw new NotImplementedException();
        }
    }    
}