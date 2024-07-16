using System;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;

public class RelativeManager : MonoBehaviour
{
    public Entity relativeEntity;
    
    void Start()
    {
        relativeEntity = World.DefaultGameObjectInjectionWorld.EntityManager.CreateEntity();
        Debug.Log("Attempted entity spawn " + relativeEntity);
    }

    private void Update()
    {
        LocalToWorld _ltw = new LocalToWorld()
        {
            // add position here (transform.position to LTW)
            // relativeEntity.ltw into SetComponentData
        };
        
        World.DefaultGameObjectInjectionWorld.EntityManager.SetComponentData(relativeEntity, _ltw);
    }
}
