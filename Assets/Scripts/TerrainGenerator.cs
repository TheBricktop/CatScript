using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject terrainChunk;

    public Vector2 mapSize;

    // Start is called before the first frame update
    void Start()
    {

        for (int x = 0; x < mapSize.x; x++)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
              var newGroundObject = Instantiate(terrainChunk, new Vector3(x, 0, y), Quaternion.Euler(90,0,0));
                
            }

        }


      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
