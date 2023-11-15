﻿using SharpGLTF.Validation;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace SharpGLTF.Schema2
{
    public partial class MeshExtMeshFeatures
    {
        private MeshPrimitive _meshPrimitive;

        internal MeshExtMeshFeatures(MeshPrimitive meshPrimitive)
        {
            _meshPrimitive = meshPrimitive;
            _featureIds = new List<MeshExtMeshFeatureID>();
        }

        public List<MeshExtMeshFeatureID> FeatureIds
        {
            get => _featureIds;
            set
            {
                if (value == null) { _featureIds = null; return; }
                _featureIds = value;
            }
        }

        protected override void OnValidateContent(ValidationContext validate)
        {
            var extMeshFeatures = (MeshExtMeshFeatures)_meshPrimitive.Extensions.FirstOrDefault();

            validate.NotNull(nameof(FeatureIds), extMeshFeatures.FeatureIds);
            validate.IsTrue(nameof(FeatureIds), extMeshFeatures.FeatureIds.Count > 0, "FeatureIds has items");

            base.OnValidateContent(validate);
        }
    }

    public partial class MeshExtMeshFeatureIDTexture
    {
        public MeshExtMeshFeatureIDTexture(List<int> channels, int? index = null, int? texCoord = null)
        {
            _channels = channels;
            if (index.HasValue) _LogicalTextureIndex = (int)index;
            if (texCoord.HasValue) TextureCoordinate = (int)texCoord;
        }
    }

    public partial class MeshExtMeshFeatureID
    {
        public MeshExtMeshFeatureID(int featureCount, int? attribute = null, int? propertyTable = null, string label = null, int? nullFeatureId = null, MeshExtMeshFeatureIDTexture texture = null)
        {
            _featureCount = featureCount;
            _attribute = attribute;
            _label = label;
            _propertyTable = propertyTable;
            _nullFeatureId = nullFeatureId;
            _texture = texture;
        }

        /// <summary>
        /// The number of unique features in the attribute or texture.
        /// </summary>
        public int? FeatureCount { get => _featureCount; }

        /// <summary>
        /// A value that indicates that no feature is associated with this vertex or texel.
        /// </summary>
        public int? NullFeatureId { get => _nullFeatureId; }

        /// <summary>
        /// An attribute containing feature IDs. When `attribute` and `texture` are omitted the 
        /// feature IDs are assigned to vertices by their index.
        /// </summary>
        public int? Attribute { get => _attribute; }

        /// <summary>
        /// A label assigned to this feature ID set. Labels must be alphanumeric identifiers 
        /// matching the regular expression `^[a-zA-Z_][a-zA-Z0-9_]*$`.
        /// </summary>
        public string Label { get => _label; }

        /// <summary>
        /// A texture containing feature IDs.
        /// </summary>
        public MeshExtMeshFeatureIDTexture Texture { get => _texture; }

        /// <summary>
        /// The index of the property table containing per-feature property values. Only applicable when using the `EXT_structural_metadata` extension.
        /// </summary>
        public int? PropertyTable { get => _propertyTable; }
    }

    public static class ExtMeshFeatures
    {
        public static void SetFeatureIds(this MeshPrimitive primitive, List<MeshExtMeshFeatureID> list)
        {
            if (list == null) { primitive.RemoveExtensions<MeshExtMeshFeatures>(); return; }

            Guard.NotNullOrEmpty(list, nameof(list));

            foreach (var item in list)
            {
                ValidateFeature(primitive, item);
            };

            var ext = primitive.UseExtension<MeshExtMeshFeatures>();
            ext.FeatureIds = list;
        }

        private static void ValidateFeature(MeshPrimitive primitive, MeshExtMeshFeatureID item)
        {
            if (item.FeatureCount.HasValue)
            {
                Guard.MustBeGreaterThanOrEqualTo((int)item.FeatureCount, 1, nameof(item.FeatureCount));
            }
            if (item.NullFeatureId.HasValue)
            {
                Guard.MustBeGreaterThanOrEqualTo((int)item.NullFeatureId, 0, nameof(item.NullFeatureId));
            }
            if (item.Label != null)
            {
                var regex = "^[a-zA-Z_][a-zA-Z0-9_]*$";
                Guard.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(item.Label, regex), nameof(item.Label));
            }
            if (item.Attribute.HasValue)
            {
                Guard.MustBeGreaterThanOrEqualTo((int)item.Attribute, 0, nameof(item.Attribute));
                // Guard that the custom vertex attribute (_FEATURE_ID_{attribute}) exists when FeatureID has attribute set
                var expectedVertexAttribute = $"_FEATURE_ID_{item.Attribute}";
                Guard.NotNull(primitive.GetVertexAccessor(expectedVertexAttribute), expectedVertexAttribute);
            }
            if (item.Texture != null)
            {
                // todo check the texture
            }
            if (item.PropertyTable.HasValue)
            {
                // The index of the property table containing per-feature property values.
                // Only applicable when using the `EXT_structural_metadata` extension.
                Guard.MustBeGreaterThanOrEqualTo((int)item.PropertyTable, 0, nameof(item.PropertyTable));
            }
        }
    }

}