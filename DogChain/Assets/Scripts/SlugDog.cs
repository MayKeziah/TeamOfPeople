using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlugDog : MonoBehaviour
{
    // GameObject can later be replaced with the player object type here, for integration purposes.
    public PlayerDogHelper thePlayer;
    // Note: player object MUST have a RigidBody2D
    private GameObject spaceship;

    public bool followPlayer = false;
    // If another dog is already present in the chain, a new dog should not follow the player but rather the other dog instead.
    public SlugDog followMe;

    public float moveSpeed;
    public float reactionSpeed;
    public float attractRadius;
    public float followRadius;

    public enum dogState 
    {
        Inactive,
        Chained,
        Spin,
        Spaceship
    }
    private dogState currentState = dogState.Inactive;
    
    // Start is called before the first frame update
    void Start() 
    {
        spaceship = thePlayer.spaceship;
    }

    // Update is called once per frame
    void Update() 
    {
        switch (currentState) {
            case dogState.Inactive:
                UpdateInactive();
                break;
            case dogState.Chained:
                Follow();
                break;
            case dogState.Spin:
                Spin();
                break;
            case dogState.Spaceship:
                GoToSpaceship();
                break;
            default:
                Debug.LogWarning("A dog has reached a state of uncertainty.");
                break;
        }

        // An idea for integration: the dog's moveSpeed can be set to that of the player
        // Something like:
        //moveSpeed = thePlayer.moveSpeed;
    }

    void FixedUpdate() 
    {

    }

    void UpdateInactive() 
    {
        if (Vector2.Distance(thePlayer.transform.position, transform.position) < attractRadius) 
        {
            if (thePlayer.dogChain.Count == 0) {
                followPlayer = true; 
            } 
            else
            {
                // Follow the newest dog added to the chain
                followMe = thePlayer.dogChain[thePlayer.dogChain.Count - 1];
            }
            thePlayer.dogChain.Add(this);

            ChangeState(dogState.Spin);
        }
    }

    void Follow() 
    {
        if (followPlayer)
        {
            // Needs to be adjusted to include reactionSpeed, and stop when within a certain radius of the player (probably the same as attractRadius)
            transform.position = Vector2.MoveTowards(transform.position, thePlayer.transform.position, Time.deltaTime * moveSpeed);
        } 
        else if (followMe == null) 
        {
            RemoveFromChain();
        }
        else 
        {
            // Needs to be adjusted in the same ways as the branch above, while considering the fact that a dog is being followed.
            // If the dog being followed goes into an Inactive state, the dog following it should be removed from the chain as well.
            transform.position = Vector2.MoveTowards(transform.position, followMe.transform.position, Time.deltaTime * moveSpeed);
        }
    }

    void Spin() 
    {
        // speen
        // ???

        ChangeState(dogState.Chained);
    }

    void GoToSpaceship() 
    {
        // move towards spaceship
        // on collision (below), delete this dog and increment the amount of dogs the player has saved (?)

    }

    void RemoveFromChain() 
    {
        thePlayer.dogChain.Remove(this);
        ChangeState(dogState.Inactive);
        followPlayer = false;
        followMe = null;
    }

    public void ChangeState(dogState newState) {
        currentState = newState;
    }
}
