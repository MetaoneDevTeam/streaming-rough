using Unity.Burst;
using UnityEngine;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.Serialization;
using Unity.Scenes;

[WorldSystemFilter(WorldSystemFilterFlags.BakingSystem)]
public partial struct CircleRangeBakingSystem : ISystem
{
    //[BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        /*
        // create scene sections
        var TestTagArray = SystemAPI.QueryBuilder().WithAll<TestTag>().Build();
        var TestTagEntities = TestTagArray.ToEntityArray(Allocator.Temp);

        //var hash = new Hash128();
        //hash.Append(sceneuid);
        
        for (int i = 0; i < TestTagEntities.Length; ++i)
        {
            //state.EntityManager.AddSharedComponent(TestTagEntities[i],
                //new SceneSection { SceneGUID = new Hash128(), Section = i });
        }
        
        */
        var cleanupQuery = SystemAPI.QueryBuilder().WithAll<CircleRange, SectionMetadataSetup>().Build();
        state.EntityManager.RemoveComponent<CircleRange>(cleanupQuery);

        var circleQuery = SystemAPI.QueryBuilder().WithAll<CircleRange, SceneSection>().Build();
        var circles = circleQuery.ToComponentDataArray<CircleRange>(Allocator.Temp);
        var circleEntities = circleQuery.ToEntityArray(Allocator.Temp);

        var sectionQuery = SystemAPI.QueryBuilder().WithAll<SectionMetadataSetup>().Build();

        /*
        for (int i = 0; i < circleEntities.Length; ++i)
        {
            var sceneSectionTemp = state.EntityManager.GetSharedComponent<SceneSection>(circleEntities[i]);
            sceneSectionTemp.Section = i;
        }
        */
        
        /*
        cleanupQuery = SystemAPI.QueryBuilder().WithAll<CircleRange, SectionMetadataSetup>().Build();
        state.EntityManager.RemoveComponent<CircleRange>(cleanupQuery);

        circleQuery = SystemAPI.QueryBuilder().WithAll<CircleRange, SceneSection>().Build();
        circles = circleQuery.ToComponentDataArray<CircleRange>(Allocator.Temp);
        circleEntities = circleQuery.ToEntityArray(Allocator.Temp);

        sectionQuery = SystemAPI.QueryBuilder().WithAll<SectionMetadataSetup>().Build();
        */
        
        for (int index = 0; index < circleEntities.Length; ++index)
        {
            var sceneSection = state.EntityManager.GetSharedComponent<SceneSection>(circleEntities[index]);
            var sectionEntity = SerializeUtility.GetSceneSectionEntity(sceneSection.Section, state.EntityManager,
                ref sectionQuery, true);
            
            state.EntityManager.AddComponentData(sectionEntity, circles[index]);
        }
    }
}

