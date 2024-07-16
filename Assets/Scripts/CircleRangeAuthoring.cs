using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class CircleRangeAuthoring : MonoBehaviour
{
    public float2 _radius;

    private class Baker : Baker<CircleRangeAuthoring>
    {
        public override void Bake(CircleRangeAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.None);
            AddComponent(entity, new CircleRange
            {
                radius = authoring._radius,
                center = GetComponent<Transform>().position
            });
        }
    }
}

public struct CircleRange : IComponentData
{
    public float2 radius;
    public float3 center;
}