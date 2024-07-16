using UnityEngine;
using UnityEngine.Serialization;

namespace Unity.Entities
{
    /// <summary>
    /// Component to indicate that a GameObject and its children belong to the specified scene section.
    /// </summary>
    public class CustomSceneSection : MonoBehaviour
    {
        /// <summary>
        /// Index of the scene section where the GameObject and its children belong to.
        /// </summary>
        [FormerlySerializedAs("SectionId")]
        public int SectionIndex;
        
        class SceneSectionComponentBaker : Baker<CustomSceneSection>
        {
            public override void Bake(CustomSceneSection authoring)
            {
                authoring.SectionIndex = Random.Range(0, 100);
                
                // Adding a section doesn't require any transform usage flags
                var entity = GetEntity(TransformUsageFlags.None);
                AddSharedComponent(entity, new SceneSection { SceneGUID = GetSceneGUID(), Section = authoring.SectionIndex });
            }
        }
    }
}