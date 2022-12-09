using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrass : MonoBehaviour
{
    public GameObject GrassPrefab;
    public int grassSize = 20;
   
    void Start()
    {
        for(int z = -grassSize; z<=20; z++)
        {
            for(int x = -grassSize; x<=grassSize; x++)
            {
                Vector3 position = new Vector3(x/4.0f /*+ Random.Range(-0.25f, 0.25f)*/, 2, z/4.0f);
                GameObject grass = Instantiate(GrassPrefab, position, Quaternion.identity);
                grass.transform.localScale = new Vector3(1, Random.Range(0.8f, 1.2f),1);
            }
        }
    }

    void Update()
    {
        
    }
}
