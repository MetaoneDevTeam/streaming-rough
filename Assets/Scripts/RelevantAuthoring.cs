using System;
using UnityEngine;
using Unity.Entities;

public class RelevantAuthoring : MonoBehaviour
{
    private void Awake()
    {
        //GameObject charCon = GameObject.Find("CharacterContainer");
        //transform.SetParent(charCon.transform);
    }

    private class Baker : Baker<RelevantAuthoring>
    {
        public override void Bake(RelevantAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent<Relevant>(entity);
        }
    }
}

public struct Relevant : IComponentData
{
    
}