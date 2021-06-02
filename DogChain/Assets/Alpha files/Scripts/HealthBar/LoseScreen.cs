using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseScreen : MonoBehaviour
{
    // Health
    public Slider oxygen;

    // UI
    public GameObject DarkOverlay;
    private Text Instructions;

    //color used for fadein/out
    private Color fadeColor = Color.black;
    private Color textFadeColor = Color.white;

    //counting ints
    private const int fadeFrames = 120; //number of frames to fade out/in
    private int currentFadeFrame = 0; //current fadeout/in frame
    private float currentWaitTime = 0f; //current time elapsed
    private const float waitUntil = 3f; //number of seconds to wait for dogs to reach the ship


    //enum for FSM
    public enum transitionState
    {
        Waiting, //not currently losing game
        PauseForDogs, //short time spent waiting for player to suffocate, lol
        FadeOut //fade out of seeing stuff
        // FadeIn
    }
    private transitionState currentState = transitionState.Waiting;


    // Start is called before the first frame update
    void Start()
    {
        fadeColor.a = 0f;
        textFadeColor.a = 0f;
        //assumes that the text is under canvas and under obscuring object, and first child in each case
        Instructions = DarkOverlay.transform.GetChild(0).GetChild(0).gameObject.GetComponent<Text>();
        Instructions.text = "Game Over:\nPlayer ran out of oxygen.";
        Instructions.fontSize = 72;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case transitionState.Waiting:
                checkOxygen();
                break;
            case transitionState.PauseForDogs:
                doWaitForDogs();
                break;
            case transitionState.FadeOut:
                doFadeOut();
                break;
            // case transitionState.FadeIn:
            //     doFadeIn();
            //     break;
        }        
    }

    private void checkOxygen()
    {
        if(oxygen.value == 0) currentState = transitionState.PauseForDogs;
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
            textFadeColor.a = fadeColor.a = ((float)currentFadeFrame) / ((float)fadeFrames);
            DarkOverlay.GetComponent<SpriteRenderer>().color = fadeColor;
            Instructions.color = textFadeColor;
        }
        // else
        // {
        //     currentState = transitionState.FadeIn;
        //     activateFadedActions();
        // }
    }
}
