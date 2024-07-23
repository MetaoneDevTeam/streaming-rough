using UnityEngine;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public partial struct GOHSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        //var query = SystemAPI.QueryBuilder().WithAll<GOHMaker>().Build();
        //state.EntityManager.RemoveComponent<GOHMaker>(query);
        
        // Base system
        var ecbBOS = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);
        
        foreach (var (goh, localTransform, entity) in SystemAPI.Query<GOHMaker, RefRO<LocalTransform>>().WithEntityAccess())
        {
            Debug.Log("GOH created");
            
            GameObject go = GameObject.Instantiate(goh.prefab, goh.position, quaternion.identity);

            ecbBOS.AddComponent(entity, new GOHControl()
            {
                gameObject = go,
                triggerControl = go.GetComponent<TriggerControl>()
            });
            ecbBOS.RemoveComponent<GOHMaker>(entity);
        }
        
        var cleanupQuery = SystemAPI.QueryBuilder().WithAllRW<GOHControl>()
            .WithNone<LocalTransform>().Build();

        foreach (var goh in cleanupQuery.ToComponentDataArray<GOHControl>())
        {
            GameObject.Destroy(goh.gameObject);
        }

        foreach (var entity in cleanupQuery.ToEntityArray(Allocator.Temp))
        {
            ecbBOS.RemoveComponent<GOHControl>(entity);
            ecbBOS.DestroyEntity(entity);
        }
        
        // doesn't work?
        //state.EntityManager.DestroyEntity(cleanupQuery);

        //state.EntityManager.DestroyEntity(cleanupQuery.ToEntityArray(Allocator.Temp));
        
        //ecbBOS.Playback(state.EntityManager);
        //ecbBOS.Dispose();
        
        // ECB based system
        /*
        var ecb = new EntityCommandBuffer(Allocator.Temp);

        foreach (var entity in SystemAPI.Query<GOHMaker>())
        {
            GameObject.Instantiate(entity.prefab);
            //GameObject.Instantiate(prefab.ValueRO.value);
            //ecb.AddComponent<LocalTransform>(instance);

            Debug.Log("ECB attempted");
        }
        
        ecb.Playback(state.EntityManager);
        ecb.Dispose();
        */
    }

    public void OnDestroy(ref SystemState state)
    {
        var ecbBOS = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);

        foreach (var control in SystemAPI.Query<GOHControl>())
        {
            Debug.Log("DESTROY");
            //GameObject.Destroy(control.gameObject);
        }
    }
}
