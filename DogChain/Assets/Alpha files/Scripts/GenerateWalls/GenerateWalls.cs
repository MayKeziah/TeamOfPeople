using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWalls : MonoBehaviour
{
    // testing mode on/off
    public bool testingMode = false;    
    public int numOfWalls = 1;


    // World Boundaries
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;    
    public float wallZ = 0;


    // Lists of walls
    private List<List<GameObject>> PermanentWalls = new List<List<GameObject>>();
    private List<List<GameObject>> TempWalls = new List<List<GameObject>>();
    private List<List<GameObject>> Boundaries = new List<List<GameObject>>();

    // Stored rooms and doors
    private List<List<GameObject>> Walls = new List<List<GameObject>>();
    private List<List<GameObject>> Doors = new List<List<GameObject>>();





    // inner map
    public List<int> lengths = new List<int>();
    public List<int> xCoords = new List<int>();
    public List<int> yCoords = new List<int>();
    public List<Direction> directions = new List<Direction>();
    public List<Material> types = new List<Material>();


    // Brick-grid dimensions
    private float brickDimensions;
    private float halfBrick;
    public int worldWidthInBricks;
    public int worldHeightInBricks;


    // world min/max coordinates
    private Vector2 worldMin;
    private Vector2 worldMax;

    
    // Main Camera data
    public CameraSupport world;


    //
    public StoredMaps storedMaps = new StoredMaps();


    // Serialization of testmode map configurations for future use
    private SerializeList map = new SerializeList();


    // Wall brick prefab names
    private const string permanent = "Wall";
    private const string temporary = "Door";

    // serialization files
    private const string pDest = "permanent.txt";
    private const string tDest = "temp.txt";

    // Brick Types
    public enum Material
    {
        Wall,
        Door
    }


    // calculates the dimensions of the brick and the main camera, creates a boundary and map of walls
    void Start()
    {
        calculateDimensions();
        deserialize();
        generateWalls();
        Debug.Log("Length of Permanent: " + PermanentWalls.Count);
        // to create a wall, use newWall(brickCount, x, y, direction, type)
    }

    // Allows realtime testing of wall variables
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.P)) 
        // {
        //     map.serialize(PermanentWalls, pDest);
        //     map.serialize(TempWalls, tDest);
        // }
        if(testingMode) generateWalls();
        if(Input.GetKeyDown(KeyCode.L)){
            destroyDoor();
        }
        // Debug.Log("Length of Permanent: " + PermanentWalls.Count);
        // to test different configurations:
        //  run the scene, click GameController, select "TestingMode".
        //  Now you can adjust the wall dimensions, perimeter dimensions, & the position of the perimeter. 
        // To generate new maps:
        //  put in test mode, add walls by increasing "numOfWalls"
        //  change its attributes by adjusting the different arrays
    }

    private void deserialize()
    {
        foreach (Vector2[][] room in storedMaps.getPermanent()){
            foreach (Vector2[] wall in room)
            {
                List<GameObject> current = new List<GameObject>();
                for (int i = 0; i < wall.Length; ++i)
                {
                    current.Add(newBrick(wall[i].x, wall[i].y, permanent));
                }
                Walls.Add(current);
            }
        }
        
        foreach (Vector2[][] room in storedMaps.getTemporary()){
            foreach (Vector2[] wall in room)
            {
                List<GameObject> current = new List<GameObject>();
                for (int i = 0; i < wall.Length; ++i)
                {
                current.Add(newBrick(wall[i].x, wall[i].y, temporary));
                }
                Doors.Add(current);
            }
        }
            
    }

    private void starterWalls()
    {
        for (int i = PermanentWalls.Count; i < numOfWalls; ++i)
        {
            newStandardWall(permanent);
        }
        
    }

    // Destroys all walls in the map, creates boundaries and map of walls
    private void generateWalls()
    {   
        if(testingMode){
            destroyWalls();
            // deserialize();
            getBrickDimensions();
            newWorldDimensions();
            updateWalls();
        }
        // createBoundaries(0, worldWidthInBricks - 1, 0, worldHeightInBricks - 1);
    }

    void newStandardWall(string type)
    {
        addInnerWall(10, 0, 0, Direction.Up, type);
    }
    void addInnerWall(int brickCount, int fromX, int fromY, Direction to, string type)
    {
        lengths.Add(brickCount);
        xCoords.Add(fromX);
        yCoords.Add(fromY);
        directions.Add(to);
        if(type.Equals(permanent)){
            types.Add(Material.Wall);
        }
        else if(type.Equals(temporary)){
            types.Add(Material.Door);
        }
        
    }

    private void createWalls()
    {
        for (int i = 0; i < lengths.Count; ++i)
        {
            if(types[i] == Material.Wall) PermanentWalls.Add(newWall(lengths[i], xCoords[i], yCoords[i], directions[i], permanent));
            else if(types[i] == Material.Door) TempWalls.Add(newWall(lengths[i], xCoords[i], yCoords[i], directions[i], temporary));
        }
    }

    private void updateWalls()
    {
        while(numOfWalls > lengths.Count)
        {
            newStandardWall(permanent);
        }
        createWalls();
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
        foreach(List<GameObject> list in PermanentWalls)
            foreach (GameObject brick in list) Destroy(brick);
        foreach(List<GameObject> list in Boundaries)
            foreach (GameObject brick in list) Destroy(brick);

        PermanentWalls.Clear();
        Boundaries.Clear();
    }

    // Destroys all temporary walls
    private void destroyTemp()
    {
        foreach(List<GameObject> list in TempWalls)
            foreach (GameObject brick in list) Destroy(brick);
        TempWalls.Clear();
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
        GameObject brick = newBrick();
        brickDimensions = brick.GetComponent<SpriteRenderer>().bounds.size.x;
        Destroy(brick);
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
        worldWidthInBricks =  (int)( ((Mathf.Abs(xMax - xMin)) )/brickDimensions ) + 1;
        worldHeightInBricks = (int)( ((Mathf.Abs(yMax - yMin)) )/brickDimensions ) + 1;
    }

    // creates the perimeter of the main camera
    void createBoundaries(int xMn, int xMx, int yMn, int yMx)
    {
        Boundaries.Add(newWall(worldHeightInBricks, xMn, yMn, Direction.Up, permanent));
        Boundaries.Add(newWall(worldHeightInBricks, xMx, yMn, Direction.Up, permanent));
        Boundaries.Add(newWall(worldWidthInBricks, xMn, yMn, Direction.Right, permanent));
        Boundaries.Add(newWall(worldWidthInBricks, xMn, yMx, Direction.Right, permanent));
    }

    // Creates a new wall of brickCount length 
    //  in 'to' direction 
    //  from (x, y) coordinates of the brick-grid (not the world)
    //  made of type bricks
    private List<GameObject> newWall(int brickCount, int fromX, int fromY, Direction to, string type)
    {
        float xStart = xToGrid(fromX);
        float yStart = yToGrid(fromY);
        List<GameObject> wall = new List<GameObject>();
        for (int brick = 0; brick < brickCount; ++brick)
        {
            float x = xStart + calcX(to) * brick * brickDimensions;
            float y = yStart +  calcY(to) * brick * brickDimensions;
            wall.Add(newBrick(x, y, type));
        }
        return wall;
    }

    // Calculates whether a wall goes in positive x, negative x, or a y direction
    private int calcX(Direction to)
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
    private int calcY(Direction to)
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
    private GameObject newBrick(float x = 0f, float y = 0f, string type = permanent)
    {
        GameObject brick = Instantiate(Resources.Load("AlphaResources/Prefabs/" + type)) as GameObject;
        brick.transform.position = new Vector3(x, y, wallZ);
        return brick;
    }

    private void destroyDoor()
    {
        if (Doors.Count == 0) return;
        foreach (GameObject Brick in Doors[0])
        {
            Destroy(Brick);
        }
        Doors.RemoveAt(0);
    }
}
