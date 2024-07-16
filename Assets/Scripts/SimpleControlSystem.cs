using UnityEngine;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public partial struct SimpleControlSystem : ISystem
{
    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        float2 inputs;
        float2 inputsNormalized;

        inputs.x = Input.GetAxis("Horizontal");
        inputs.y = Input.GetAxis("Vertical");
        inputsNormalized = math.normalizesafe(inputs);

        foreach (var (transform, control) in
                 SystemAPI.Query<RefRW<LocalTransform>, RefRW<SimpleControl>>())
        {
            var multiplier = control.ValueRO.speedMultiplier * SystemAPI.Time.DeltaTime;

            transform.ValueRW.Position.x += inputsNormalized.x * multiplier;
            transform.ValueRW.Position.z += inputsNormalized.y * multiplier;
        }
    }
}