using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceshipTransition : MonoBehaviour
{
    //these variables need to be set in the editor
    public Camera mainCam;
    public PlayerMovementController player;
    public GameObject obscuringCube; //a little vague, this is the object over the camera which is used for the fadeout
    public List<OxygenPickup> pickupsToRefresh;
    //friction zones in order of appearance (1-5 trips)
    public List<GameObject> frictionZones;

    //references not set in editor
    private Text dateText;
    private PlayerDogHelper dogCounter;
    private const string PlayerName = "Player";
    private const int numOfDogs = 18; //needs to be set to the amount of dogs in the scene

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
    private Color textFadeColor = Color.white;

    //number of trips made to the ship
    private int numberOfTrips = 0;


    //enum for FSM
    public enum transitionState
    {
        Waiting, //not currently in a transition state
        PauseForDogs, //short time spent waiting for dogs to reach the ship
        FadeOut, //fade out of seeing stuff
        FadeIn,
        FinalFadeOut, //fadeout for when all dogs are in
        Done //final state when player wins
    }


    // Start is called before the first frame update
    void Start()
    {
        dogCounter = GameObject.Find(PlayerName).GetComponent<PlayerDogHelper>();
        fadeColor.a = 0f;
        textFadeColor.a = 0f;
        //assumes that the text is under canvas and under obscuring object, and first child in each case
        dateText = obscuringCube.transform.GetChild(0).GetChild(0).gameObject.GetComponent<Text>();
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
            case transitionState.FinalFadeOut:
                doFinalFadeOut();
                break;
            case transitionState.Done:
                break;
            default:
                break;
        }
    }

    //actions to perform while in the PauseForDogs state
    private void doWaitForDogs()
    {
        currentWaitTime += Time.deltaTime;
        if (currentWaitTime >= waitUntil)
        {
            if (dogCounter.GetDogsInPossession() >= numOfDogs) //if we're done with the dogs end the game
            {
                currentState = transitionState.FinalFadeOut;
            }
            else 
            {
                currentState = transitionState.FadeOut;
            }
            currentFadeFrame = 0;
        }
    }

    //actions to perform while in the fadeout state
    private void doFadeOut()
    {
        if(currentFadeFrame < fadeFrames)
        {
            currentFadeFrame++;
            textFadeColor.a = fadeColor.a = ((float)currentFadeFrame) / ((float)fadeFrames);
            obscuringCube.GetComponent<SpriteRenderer>().color = fadeColor;
            dateText.color = textFadeColor;
        }
        else
        {
            currentState = transitionState.FadeIn;
            activateFadedActions();
        }
    }

    private void doFinalFadeOut()
    {
        if (currentFadeFrame < fadeFrames)
        {
            currentFadeFrame++;
            fadeColor.a = ((float)currentFadeFrame) / ((float)fadeFrames);
            obscuringCube.GetComponent<SpriteRenderer>().color = fadeColor;
        }
        else
        {
            currentState = transitionState.Done;
            activateEndActions();
        }
    }

    //this function does everything that needs to be done during the time where the camera is fully
    //faded out, like respawning oxygen pickups or spawning friction zones
    private void activateFadedActions()
    {
        for(int i = 0; i < pickupsToRefresh.Count; i++) //foreach pickup in the list
        {
            pickupsToRefresh[i].activate(); //reactivate pickup
        }
        if(numberOfTrips - 1 < frictionZones.Count) //activates friction zones as you go
        {
            frictionZones[numberOfTrips - 1].SetActive(true);
        }
    }

    //sets the final win text based on how many days it took the player to complete it
    private void activateEndActions()
    {
        textFadeColor.a = 1f;
        dateText.color = textFadeColor;
        if(numberOfTrips == 1)
        {
            dateText.text = "WOWZA! you did that in just one day!? Fantastic job!";
        }
        else
        {
            dateText.text = "Congratulations! you got all the slugdogs in only " + numberOfTrips + " days!";
        }
    }

    private void doFadeIn()
    {
        if (currentFadeFrame > 0)
        {
            currentFadeFrame--;
            textFadeColor.a = fadeColor.a = ((float)currentFadeFrame) / ((float)fadeFrames);
            obscuringCube.GetComponent<SpriteRenderer>().color = fadeColor;
            dateText.color = textFadeColor;
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
            numberOfTrips++;
            dateText.text = "Day " + numberOfTrips;
            currentState = transitionState.PauseForDogs;
            currentWaitTime = 0f;
            player.Freeze();
        }
    }
}
