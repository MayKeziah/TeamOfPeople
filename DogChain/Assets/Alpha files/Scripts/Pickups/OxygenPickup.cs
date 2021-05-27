using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenPickup : MonoBehaviour
{
    //boolean indicating whether or not the oxygen pickup is active
    public bool isActive = true;

    //amount of oxygen to restore on pickup
    public int OxygenToRestore = 150;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //these functions will activate or deactivate the pickup, which
    //will change the state of the isActive bool, and will make the
    //pickup visible or invisible
    public void activate()
    {
        isActive = true;
        gameObject.GetComponent<Renderer>().enabled = true;
    }
    public void deactivate()
    {
        isActive = false;
        gameObject.GetComponent<Renderer>().enabled = false;
    }
}
