using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Camera mainCam; //this should be set to the main camera of the scene

    public float accelerationSpeed = 0.01f; //this is the rate at which the player accelerates

    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = GetMouseWorldPosition();
        MouseCursor.setPosition(mousePos);
        if (Input.GetMouseButton(0))
        {
            AcceleratePlayer(mousePos);
        }
        MovePlayer();
    }

    //gets the mouse's relative world position in xy coordinates
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0;

        mousePosition.y = ((mousePosition.y / Screen.height) * 100) - 50;
        mousePosition.y += mainCam.transform.position.y;


        //ratio isolated here in order to preserve function regardless of aspect ratio
        float screenRatio = getScreenRatio();
        mousePosition.x = ((mousePosition.x / Screen.width) * 100 * screenRatio) - (50 * screenRatio);
        mousePosition.x += mainCam.transform.position.x;
        return mousePosition;
    }

    //change the velocity according to position
    private void AcceleratePlayer(Vector3 mousePos)
    {
        Vector3 diff = transform.position - mousePos;
        velocity += ((diff.normalized) * accelerationSpeed);
    }

    //moves the player according to velocity and slows down velocity slightly
    private void MovePlayer()
    {
        Vector3 newPos = transform.position;
        newPos += velocity;
        transform.position = newPos;
        velocity *= 0.99f; //slow down by 1% of current speed
        Debug.Log(velocity);
    }

    //returns the ratio of the displayed screen in W/H
    public float getScreenRatio()
    {
        return ((float)Screen.width) / Screen.height;
    }
}
