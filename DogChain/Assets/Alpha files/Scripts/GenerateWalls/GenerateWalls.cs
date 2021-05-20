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
    // Start is called before the first frame update
    void Start()
    {
        // world = GameObject.Find ("GameController").GetComponent<WorldBounds>();
        calculateDimensions();
        Debug.Log("wall X: " + brickDimensions);
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
        worldWidthInBricks =  (int)( (worldMax.x - worldMin.x)/brickDimensions );
        worldHeightInBricks = (int)( (worldMax.y - worldMin.y)/brickDimensions );
    }

    void createBoundaries()
    {

    }
    
    void createHorizontalBoundaries()
    {
        for(int i = 0; i < worldWidthInBricks; ++i)
        {

        }
    }

    private int newPermanentBrick(int x = 0, int y = 0, int z = 0)
    {
        GameObject brick = Instantiate(Resources.Load("AlphaResources/Prefabs/WallBlock1")) as GameObject;
        brick.transform.position = new Vector3(x, y, z);
        PermanentWalls.Add(brick);
        return PermanentWalls.Count - 1;
    }
}
