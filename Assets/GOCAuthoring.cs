using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class GOCAuthoring : MonoBehaviour
{
    public GameObject _prefab;
    public int _fireTimes = 1;
    
    private class Baker : Baker<GOCAuthoring>
    {
        public override void Bake(GOCAuthoring authoring)
        {
            var entityPrefab = GetEntity(authoring._prefab, TransformUsageFlags.Dynamic);
            
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new GOCMaker
            {
                value = entityPrefab,
                fireTimes = authoring._fireTimes
            });
        }
    }
    
}

public struct GOCMaker : IComponentData
{
    public Entity value;
    public int fireTimes;
}