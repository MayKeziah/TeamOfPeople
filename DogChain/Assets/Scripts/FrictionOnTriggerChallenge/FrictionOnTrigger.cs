using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionOnTrigger : MonoBehaviour
{
    public Vector3[] f1 = {new Vector3(0, 0, 0)};
    public Vector3[] f2 = {new Vector3(10, 10, 0)};
    public Vector3[] f3 = {new Vector3(-10, -10, 0)};
    private Vector3[][] frictionCoords;
    // private string[] assetNames = {"friction1", "friction2", "friction3"};
    private int challengeLevel = 0;
    // Start is called before the first frame update
    void Start()
    {
        frictionCoords = new Vector3[][] {f1, f2, f3};
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger()) generateFrictionZones();
    }

    private bool trigger()
    {
        return Input.GetKeyDown(KeyCode.Space) && challengeLevel < frictionCoords.Length;
    }

    private void generateFrictionZones()
    {
        Debug.Log("GenerateFZ!!");
        for (int i = 0; i < frictionCoords[challengeLevel].Length; ++i)
        {
            GameObject e = Instantiate(Resources.Load("friction" + (challengeLevel + 1)) as GameObject);
            e.transform.position = frictionCoords[challengeLevel][i];
            Debug.Log("Created friction: " + "Prefabs/friction" + (challengeLevel + 1) + " at: (" + 
            frictionCoords[challengeLevel][i].x + ", " + 
            frictionCoords[challengeLevel][i].y + ", " + 
            frictionCoords[challengeLevel][i].z + ")");
        }
        challengeLevel++;
    }
}
