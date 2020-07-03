using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public int maxMapWidth = 10;
    public int maxMapHeight = 10;
    public List<List<GameObject>> map = new List<List<GameObject>>();
    public Transform tilesWrapper;

    public Transform prefab;
    
    void Start()
    {
        CreateMap();
    }

    void CreateMap()
    {
        for(float h = 0; h < maxMapHeight; h++)
            for(float w = 0; w < maxMapWidth; w++)
            {
                Transform newTile = Instantiate(prefab, new Vector3(w + (h % 2 / 2), 0, h * 0.866f), Quaternion.identity);
                newTile.parent = tilesWrapper;
            }
    }

    void Update()
    {
        
    }
}
