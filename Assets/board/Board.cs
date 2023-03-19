using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    private int width = 8;
    private int height = 5;

    public GameObject[,] Tiles;
    public GameObject TilePrefab;

    
    void generateTiles(int width, int height)
    {
        Tiles = new GameObject[width, height];
        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                Vector3 pos = new Vector3(-7+i*2, 4-j*2, 0);
                Tiles[i, j] = Instantiate(TilePrefab, pos, transform.rotation) as GameObject;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        generateTiles(width, height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
