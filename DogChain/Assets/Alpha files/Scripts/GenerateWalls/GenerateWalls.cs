using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWalls : MonoBehaviour
{
    private List<GameObject> PermanentWalls = new List<GameObject>();
    private List<GameObject> TempWalls = new List<GameObject>();

    private float brickDimensions;
    private int worldWidthInBricks;
    private int worldHeightInBricks;

    private Vector2 worldMin;
    private Vector2 worldMax;

    public WorldBounds world;
    public float wallZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        // world = GameObject.Find ("GameController").GetComponent<WorldBounds>();
        calculateDimensions();
        Debug.Log("wall X: " + brickDimensions);
        createBoundaries();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void calculateDimensions()
    {
        getBrickDimensions();
        getWorldDimensions();
        Debug.Log("WidthInBricks: " +worldWidthInBricks + ", Height: " + worldWidthInBricks);
    }

    private void getBrickDimensions()
    {
        brickDimensions = PermanentWalls[newPermanentBrick()].GetComponent<SpriteRenderer>().bounds.size.x;
        PermanentWalls.RemoveAt(PermanentWalls.Count - 1);
    }

    private void getWorldDimensions()
    {
        worldMin = world.WorldMin;
        worldMax = world.WorldMax;
        worldWidthInBricks =  (int)( ((Mathf.Abs(worldMax.x - worldMin.x))/brickDimensions )/2 );
        worldHeightInBricks = (int)( ((Mathf.Abs(worldMax.y - worldMin.y))/brickDimensions )/2 );
    }

    void createBoundaries()
    {
        createHorizontalBoundaries();
    }
    
    void createHorizontalBoundaries()
    {
        float halfBrick = brickDimensions/2f;
        for(float x = worldMin.x + halfBrick*3; x < worldWidthInBricks; x+=brickDimensions)
        {
            newPermanentBrick(x, worldMin.y + halfBrick, wallZ);
            newPermanentBrick(x, worldMax.y - halfBrick, wallZ);
        }
    }

    private int newPermanentBrick(float x = 0f, float y = 0f, float z = 0f)
    {
        GameObject brick = Instantiate(Resources.Load("AlphaResources/Prefabs/WallBlock1")) as GameObject;
        brick.transform.position = new Vector3(x, y, z);
        PermanentWalls.Add(brick);
        return PermanentWalls.Count - 1;
    }
}
