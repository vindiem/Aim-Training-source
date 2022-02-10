using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public static TargetSpawner Instance;

    [SerializeField] public GameObject target;

    [SerializeField] Sensetivy sens;

    private void Awake()
    {
        Instance = this;
    }


    public void Start()
    {
        for (int i = 0; i <= sens.TargetValue; i++)
        {
            Instantiate(target);
        }
    }




    [SerializeField] BoxCollider col;

    public Vector3 GetRandomPosition()
    {
        Vector3 center = col.center + transform.position;

        float minX = center.x - col.size.x ;
        float maxX = center.x + col.size.x ;

        float minY = center.y - col.size.y ;
        float maxY = center.y + col.size.x ;

        float minZ = center.z - col.size.z ;
        float maxZ = center.z + col.size.z ;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);

        Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

        return randomPosition;
    }
}
