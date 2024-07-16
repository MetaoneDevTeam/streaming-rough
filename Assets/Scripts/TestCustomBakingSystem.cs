using UnityEngine;
using Unity.Entities;
using Unity.Entities.Serialization;
using Unity.Mathematics;
using Unity.Transforms;

public struct TestTag : IComponentData
{
}

//[WorldSystemFilter(WorldSystemFilterFlags.BakingSystem)]
partial struct TestCustomBakingSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        //Debug.Log("TESTLOG");
        var queryMissingTag = SystemAPI.QueryBuilder()
            .WithAll<SceneSection>()
            .WithAll<TestTag>()
            .Build();
        
        state.EntityManager.AddComponent<TestTag>(queryMissingTag);

        // Omitting the second part of this function would lead to inconsistent
        // results during live baking. Added tags would remain on the entity even
        // after removing the RotationSpeed component.

        var queryCleanupTag = SystemAPI.QueryBuilder()
            .WithAll<TestTag>()
            .Build();

        //state.EntityManager.RemoveComponent<TestTag>(queryCleanupTag);
    }
}