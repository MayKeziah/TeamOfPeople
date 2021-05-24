using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWalls : MonoBehaviour
{
    private List<GameObject> PermanentWalls = new List<GameObject>();
    private List<List<GameObject>> TempWalls = new List<List<GameObject>>();

    private float brickDimensions;
    public int worldWidthInBricks;
    public int worldHeightInBricks;

    private Vector2 worldMin;
    private Vector2 worldMax;

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    private float halfBrick;

    public CameraSupport world;
    public float wallZ = 0;
    public bool testingMode = false;

    private const string permanent = "Wall";
    private const string temporary = "WallBlock1";

    enum Direction 
    {
    Up,
    Down,
    Left,
    Right
    }

    // calculates the dimensions of the brick and the main camera, creates a boundary and map of walls
    void Start()
    {
        calculateDimensions();
        generateWalls();
        // to create a wall, use newWall(brickCount, x, y, direction, type)
    }

    // Allows realtime testing of wall variables
    void Update()
    {
        if(testingMode) generateWalls();
        // to test different configurations:
        //  run the scene, click GameController, select "TestingMode".
        //  Now you can adjust the wall dimensions, perimeter dimensions, & the position of the perimeter. 
    }

    // Destroys all walls in the map, creates boundaries and map of walls
    private void generateWalls()
    {   
        if(testingMode){
            destroyWalls();
            getBrickDimensions();
            newWorldDimensions();
        }
        createBoundaries(0, worldWidthInBricks - 1, 0, worldHeightInBricks - 1);
    }

    // Destroys all walls
    private void destroyWalls()
    {
      destroyPermanent();
      destroyTemp();
    }

    // Destroys all permanent walls
    private void destroyPermanent()
    {
        foreach(GameObject brick in PermanentWalls) Destroy(brick);       
    }

    // Destroys all temporary walls
    private void destroyTemp()
    {
        foreach(List<GameObject> list in TempWalls)
            foreach (GameObject brick in list) Destroy(brick);
         
    }

    // calculates the dimensions of the brick and the world, updates state
    private void calculateDimensions()
    {
        getBrickDimensions();
        getWorldDimensions();
        Debug.Log("WidthInBricks: " +worldWidthInBricks + ", Height: " + worldHeightInBricks);
    }

    // calculated the dimensions of a brick
    private void getBrickDimensions()
    {
        brickDimensions = PermanentWalls[newBrick()].GetComponent<SpriteRenderer>().bounds.size.x;
        Destroy(PermanentWalls[PermanentWalls.Count - 1]);
        PermanentWalls.RemoveAt(PermanentWalls.Count - 1);
        halfBrick = brickDimensions/2f;
    }

    // calculates the dimensions of the main camera
    private void getWorldDimensions()
    {
        worldMin = world.WorldMin;
        worldMax = world.WorldMax;
        worldWidthInBricks =  (int)( ((Mathf.Abs(worldMax.x - worldMin.x)) )/brickDimensions );
        worldHeightInBricks = (int)( ((Mathf.Abs(worldMax.y - worldMin.y)) )/brickDimensions );
        Debug.Log("Min: (" + worldMin.x + ", " + worldMin.y + "), Max: (" + worldMax.x + ", " + worldMax.y + ")");

        yMin = worldMin.y + halfBrick;
        yMax = yMin + (worldHeightInBricks - 1)*brickDimensions;
        xMin = worldMin.x + halfBrick;
        xMax = xMin + (worldWidthInBricks - 1)*brickDimensions;
    }

    private void newWorldDimensions()
    {
        worldWidthInBricks =  (int)( ((Mathf.Abs(xMax - xMin)) )/brickDimensions );
        worldHeightInBricks = (int)( ((Mathf.Abs(yMax - yMin)) )/brickDimensions );
    }

    // creates the perimeter of the main camera
    void createBoundaries(int xMn, int xMx, int yMn, int yMx)
    {
        newWall(worldHeightInBricks, xMn, yMn, Direction.Up, permanent);
        newWall(worldHeightInBricks, xMx, yMn, Direction.Up, permanent);
        newWall(worldWidthInBricks, xMn, yMn, Direction.Right, permanent);
        newWall(worldWidthInBricks, xMn, yMx, Direction.Right, permanent);
    }

    // Creates a new wall of brickCount length 
    //  in 'to' direction 
    //  from (x, y) coordinates of the brick-grid (not the world)
    //  made of type bricks
    private void newWall(int brickCount, int fromX, int fromY, Direction to, string type)
    {
        float xStart = xToGrid(fromX);
        float yStart = yToGrid(fromY);
        // float xEnd = calcX(brickCount, fromX, to);
        for (int brick = 0; brick < brickCount; ++brick)
        {
            float x = xStart + calcX(to) * brick * brickDimensions;
            float y = yStart +  calcY(to) * brick * brickDimensions;
            newBrick(x, y, type);
        }
    }

    // Calculates whether a wall goes in positive x, negative x, or a y direction
    private float calcX(Direction to)
    {
        if(to == Direction.Left)
        {
            return -1;
        }
        else if (to == Direction.Right)
        {
            return 1;
        }
        else return 0;
    }

    // Calculates whether a wall goes in positive y, negative y, or an x direction
    private float calcY(Direction to)
    {
        if(to == Direction.Down)
        {
            return -1;
        }
        else if (to == Direction.Up)
        {
            return 1;
        }
        else return 0;
    }

    // Takes a brick-grid x coordinate and returns the world coordinate equivilant
    private float xToGrid(int x)
    {
        return xMin + x*brickDimensions;
    }

    // Takes a brick-grid y coordinate and returns the world coordinate equivilant
    private float yToGrid(int y)
    {
        return yMin + y*brickDimensions;
    }

    // creates a new brick of type at (x, y) world coordinates
    private int newBrick(float x = 0f, float y = 0f, string type = permanent)
    {
        GameObject brick = Instantiate(Resources.Load("AlphaResources/Prefabs/" + type)) as GameObject;
        brick.transform.position = new Vector3(x, y, wallZ);
        PermanentWalls.Add(brick);
        Debug.Log("Wall added");
        return PermanentWalls.Count - 1;
    }
}
