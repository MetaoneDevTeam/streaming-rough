using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class GOHAuthoring : MonoBehaviour
{
    public GameObject _prefab;
    
    class Baker : Baker<GOHAuthoring>
    {
        public override void Bake(GOHAuthoring authoring)
        {
            AddComponentObject(new GOHMaker()
            {
                prefab = authoring._prefab,
                position = authoring.transform.position
            });
        }
    }
}

public class GOHMaker : IComponentData
{
    public GameObject prefab;
    public float3 position;
}

public class GOHControl : ICleanupComponentData
{
    public GameObject gameObject;
    public TriggerControl triggerControl;
}

//public class 