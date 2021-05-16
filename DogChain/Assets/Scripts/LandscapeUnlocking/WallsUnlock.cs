using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsUnlock : MonoBehaviour
{
    public GameObject[] unlockingWalls;
    int index = 0;
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && unlockingWalls.Length > index)
        {
            Destroy(unlockingWalls[index++]);
        }
    }
}
