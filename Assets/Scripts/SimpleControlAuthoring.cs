using UnityEngine;
using Unity.Burst;
using Unity.Mathematics;
using Unity.Entities;

public class SimpleControlAuthoring : MonoBehaviour
{
    public float2   _inputAxis;
    public float    _speedMultiplier;

    private class Baker : Baker<SimpleControlAuthoring>
    {
        public override void Bake(SimpleControlAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic | TransformUsageFlags.WorldSpace);
            AddComponent(entity, new SimpleControl
            {
                inputAxis = authoring._inputAxis,
                speedMultiplier = authoring._speedMultiplier
            });
        }
    }
}

public struct SimpleControl : IComponentData
{
    public float2   inputAxis;
    public float    speedMultiplier;
}