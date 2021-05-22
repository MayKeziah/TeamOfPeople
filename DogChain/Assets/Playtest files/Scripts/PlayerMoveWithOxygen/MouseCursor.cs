using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    //this class is meant to track the mouse cursor when updated via the static method.
    //there should be one instance of this script in order to set the transform of the
    //object which will be representing the cursor
    private static Transform cursorPosition;
    // Start is called before the first frame update
    void Start()
    {
        cursorPosition = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void setPosition(Vector3 pos)
    {
        cursorPosition.position = pos;
    }
}
