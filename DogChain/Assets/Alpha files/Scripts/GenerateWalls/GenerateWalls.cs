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

    private float xMin;
    private float xMax;
    private float yMin;
    private float yMax;
    private float halfBrick;

    public WorldBounds world;
    public float wallZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        // world = GameObject.Find ("GameController").GetComponent<WorldBounds>();
        calculateDimensions();
        Debug.Log("wall X: " + brickDimensions);
        createBoundaries(xMin, xMax, yMin, yMax);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void calculateDimensions()
    {
        getBrickDimensions();
        getWorldDimensions();
        Debug.Log("WidthInBricks: " +worldWidthInBricks + ", Height: " + worldHeightInBricks);
    }

    private void getBrickDimensions()
    {
        brickDimensions = PermanentWalls[newPermanentBrick()].GetComponent<SpriteRenderer>().bounds.size.x;
        Destroy(PermanentWalls[PermanentWalls.Count - 1]);
        PermanentWalls.RemoveAt(PermanentWalls.Count - 1);
        halfBrick = brickDimensions/2f;
    }

    private void getWorldDimensions()
    {
        worldMin = world.WorldMin;
        worldMax = world.WorldMax;
        worldWidthInBricks =  (int)( ((Mathf.Abs(worldMax.x - worldMin.x)) )/brickDimensions );
        worldHeightInBricks = (int)( ((Mathf.Abs(worldMax.y - worldMin.y)) )/brickDimensions );

        yMin = worldMin.y + halfBrick;
        yMax = yMin + (worldHeightInBricks - 1)*brickDimensions;
        xMin = worldMin.x + halfBrick;
        xMax = xMin + (worldWidthInBricks - 1)*brickDimensions;
    }

    void createBoundaries(float xMn, float xMx, float yMn, float yMx)
    {
        createHorizontalBoundaries(xMn, xMx, yMn, yMx);
        createVerticalBoundaries(xMn, xMx, yMn, yMx);
    }
    
    void createHorizontalBoundaries(float xMn, float xMx, float yMn, float yMx)
    {
        Debug.Log("Horizontal Checkpoint");
        for(float x = xMn; x <= xMx; x+=brickDimensions)
        {
            newPermanentBrick(x, yMn, wallZ);
            newPermanentBrick(x, yMx, wallZ);
        }
    }

    void createVerticalBoundaries(float xMn, float xMx, float yMn, float yMx)
    {
        Debug.Log("Vertical Checkpoint");
        for(float y = yMn; y <= yMx; y+=brickDimensions)
        {
            newPermanentBrick(xMn, y, wallZ);
            newPermanentBrick(xMx, y, wallZ);
        }
    }

    private int newPermanentBrick(float x = 0f, float y = 0f, float z = 0f)
    {
        GameObject brick = Instantiate(Resources.Load("AlphaResources/Prefabs/WallBlock1")) as GameObject;
        brick.transform.position = new Vector3(x, y, z);
        PermanentWalls.Add(brick);
        Debug.Log("Wall added");
        return PermanentWalls.Count - 1;
    }
}
