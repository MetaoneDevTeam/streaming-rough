using UnityEngine;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public partial struct GOCSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        var ecb = new EntityCommandBuffer(Allocator.Temp);

        foreach (var prefab in SystemAPI.Query<RefRW<GOCMaker>>())
        {
            if (prefab.ValueRO.fireTimes > 0)
            {
                var instance = ecb.Instantiate(prefab.ValueRO.value);
                //GameObject.Instantiate(prefab.ValueRO.value);
                //ecb.AddComponent<LocalTransform>(instance);

                Debug.Log("ECB attempted");
                //ecb.RemoveComponent<GOCMaker>(instance);
                prefab.ValueRW.fireTimes--;
            }
        }
        
        ecb.Playback(state.EntityManager);
        ecb.Dispose();
    }
}
