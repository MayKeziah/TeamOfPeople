using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaWallController : MonoBehaviour
{

    //enum for the type of wall this is.
    //Hard walls kill momentum when hit.
    //Bouncy walls reflect the player when hit.
    public enum WallType
    {
        Hard,
        Bouncy
    }

    private WallType currentType = WallType.Hard;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //get and set methods for the wall type
    public WallType getWallType()
    {
        return currentType;
    }
    public void setWallType(WallType nextType)
    {
        currentType = nextType;
    }
}
