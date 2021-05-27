using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipTransition : MonoBehaviour
{
    //these variables need to be set in the editor
    public Camera mainCam;
    public PlayerMovementController player;
    public GameObject obscuringCube; //a little vague, this is the object over the camera which is used for the fadeout

    //current state
    private transitionState currentState = transitionState.Waiting;

    //counting floats
    private const float waitUntil = 3f; //number of seconds to wait for dogs to reach the ship
    private float currentWaitTime = 0f; //current time elapsed

    //counting ints
    private const int fadeFrames = 120; //number of frames to fade out/in
    private int currentFadeFrame = 0; //current fadeout/in frame

    //color used for fadein/out
    private Color fadeColor = Color.black;


    //enum for FSM
    public enum transitionState
    {
        Waiting, //not currently in a transition state
        PauseForDogs, //short time spent waiting for dogs to reach the ship
        FadeOut, //fade out of seeing stuff
        FadeIn
    }


    // Start is called before the first frame update
    void Start()
    {
        fadeColor.a = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case transitionState.Waiting:
                break;
            case transitionState.PauseForDogs:
                doWaitForDogs();
                break;
            case transitionState.FadeOut:
                doFadeOut();
                break;
            case transitionState.FadeIn:
                doFadeIn();
                break;
        }
    }

    //actions to perform while in the PauseForDogs state
    private void doWaitForDogs()
    {
        currentWaitTime += Time.deltaTime;
        if(currentWaitTime >= waitUntil)
        {
            currentState = transitionState.FadeOut;
            currentFadeFrame = 0;
        }
    }

    //actions to perform while in the fadeout state
    private void doFadeOut()
    {
        if(currentFadeFrame < fadeFrames)
        {
            currentFadeFrame++;
            fadeColor.a = ((float)currentFadeFrame) / ((float)fadeFrames);
            obscuringCube.GetComponent<SpriteRenderer>().color = fadeColor;
        }
        else
        {
            currentState = transitionState.FadeIn;
            activateFadedActions();
        }
    }

    //this function does everything that needs to be done during the time where the camera is fully
    //faded out, like respawning oxygen pickups or spawning friction zones
    private void activateFadedActions()
    {

    }

    private void doFadeIn()
    {
        if (currentFadeFrame > 0)
        {
            currentFadeFrame--;
            fadeColor.a = ((float)currentFadeFrame) / ((float)fadeFrames);
            obscuringCube.GetComponent<SpriteRenderer>().color = fadeColor;
        }
        else
        {
            currentState = transitionState.Waiting;
            currentFadeFrame = 0;
            player.Unfreeze();
        }
    }

    //this function will activate the fadeout-fadein transition when you touch the
    //spaceship
    public void activate()
    {
        if(currentState == transitionState.Waiting)
        {
            currentState = transitionState.PauseForDogs;
            currentWaitTime = 0f;
            player.Freeze();
        }
    }
}
