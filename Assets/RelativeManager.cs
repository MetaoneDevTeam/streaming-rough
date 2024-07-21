using System;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class RelativeManager : MonoBehaviour
{
    public Entity relativeEntity;
    
    void Awake()
    {
        relativeEntity = World.DefaultGameObjectInjectionWorld.EntityManager.CreateEntity();
        World.DefaultGameObjectInjectionWorld.EntityManager.AddComponent<Relevant>(relativeEntity);
        World.DefaultGameObjectInjectionWorld.EntityManager.AddComponent<LocalToWorld>(relativeEntity);
        World.DefaultGameObjectInjectionWorld.EntityManager.AddComponent<LocalTransform>(relativeEntity);

        Debug.Log("Attempted entity spawn " + relativeEntity);
        
        float3 pos = new float3();
        pos.x = transform.position.x;
        pos.y = transform.position.y;
        pos.z = transform.position.z;
        
        LocalTransform _localTransform = new LocalTransform()
        {
            Position = pos
        };
    }

    private void Update()
    {
        float3 pos = new float3();
        pos.x = transform.position.x;
        pos.y = transform.position.y;
        pos.z = transform.position.z;
        
        LocalTransform _localTransform = new LocalTransform()
        {
            Position = pos
        };
        
        World.DefaultGameObjectInjectionWorld.EntityManager.SetComponentData(relativeEntity, _localTransform);
    }
}
