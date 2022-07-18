using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawn : MonoBehaviour
{
    public GameObject CollectibleGameObject;
    public int Count = 3;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCubes();
    }

    public void SpawnCubes()
    {
        for(int i=0; i < Count; i++)
        {
            Instantiate(CollectibleGameObject, transform);
        }
    }
}
