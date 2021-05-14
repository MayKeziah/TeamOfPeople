using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlugDog : MonoBehaviour
{
    // GameObject can later be replaced with the player object type here, for integration purposes.
    public PlayerDogHelper thePlayer;
    // Note: player object MUST have a RigidBody2D
    private GameObject spaceship;
    public Rigidbody2D rb2d;

    private bool followPlayer = false;
    // If another dog is already present in the chain, a new dog should not follow the player but rather the other dog instead.
    private SlugDog followMe;

    public float moveSpeed = 1f;
    public float reactionSpeed = 1f;
    public float attractRadius = 1f;
    public float followRadius = 3f;
    public float spinDuration = 1f;

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
        rb2d = GetComponent<Rigidbody2D>();
        spaceship = thePlayer.spaceship;
    }

    // Update is called once per frame
    void Update() 
    {
        switch (currentState) 
        {
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

        // Another idea: find a way to flip the dog's sprite to match whether it's moving left or right?
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
            // If the dog is still within the range in which it will follow the player (will stop when within the original attractRadius)
            if (Vector2.Distance(thePlayer.transform.position, transform.position) < followRadius && Vector2.Distance(thePlayer.transform.position, transform.position) > attractRadius)
            {
                // If the player is moving, but the dog is not, then we need the dog to "react" before it starts moving.
                if (!(thePlayer.rb2d.IsSleeping()) && rb2d.IsSleeping()) 
                {
                    float reactionTime = Time.time + reactionSpeed;
                    while (Time.time < reactionTime) 
                    {
                        
                    }
                }
                transform.position = Vector2.MoveTowards(transform.position, thePlayer.transform.position, Time.deltaTime * moveSpeed);
            }
            // If the dog gets too far away from the player (probably if it gets stuck behind a wall), stop following
            else if (Vector2.Distance(thePlayer.transform.position, transform.position) > followRadius)
            {
                RemoveFromChain();
            }

        } 
        // Dogs following nothing or other, inactive dogs should become inactive themselves.
        else if (followMe == null || followMe.GetState() == dogState.Inactive) 
        {
            RemoveFromChain();
        }
        // Following an active dog:
        else 
        {
            // If the dog is still within the range in which it will follow the dog (will stop when within the original attractRadius)
            if (Vector2.Distance(followMe.transform.position, transform.position) < followRadius && Vector2.Distance(followMe.transform.position, transform.position) > attractRadius)
            {
                // If the player is moving, but the dog is not, then we need the dog to "react" before it starts moving.
                if (!(followMe.rb2d.IsSleeping()) && rb2d.IsSleeping()) 
                {
                    float reactionTime = Time.time + reactionSpeed;
                    while (Time.time < reactionTime) 
                    {
                        
                    }
                }
                transform.position = Vector2.MoveTowards(transform.position, followMe.transform.position, Time.deltaTime * moveSpeed);
            }
            // If the dog gets too far away from the target dog, stop following
            else if (Vector2.Distance(followMe.transform.position, transform.position) > followRadius)
            {
                RemoveFromChain();
            }
        }
    }

    void Spin() 
    {
        float spinTime = Time.time + spinDuration;
        // speen
        while (Time.time < spinTime) 
        {
            transform.Rotate(4f, 0.0f, 0.0f, Space.Self);
        }
        // Make sure dog's rotation is reset to (0, 0, 0)
        transform.rotation = Quaternion.identity;

        ChangeState(dogState.Chained);
    }

    void GoToSpaceship() 
    {
        // move towards spaceship
        transform.position = Vector2.MoveTowards(transform.position, spaceship.transform.position, Time.deltaTime * moveSpeed);

        // Collision with spaceship is shown in method below
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == spaceship) 
        {
            // Delete this dog object and increment the amount of dogs the player has saved
            thePlayer.dogsRescued += 1;
            thePlayer.dogsThisTrip += 1;
            Destroy(gameObject);
        }
    }

    void RemoveFromChain() 
    {
        thePlayer.dogChain.Remove(this);
        ChangeState(dogState.Inactive);
        followPlayer = false;
        followMe = null;
    }

    public void ChangeState(dogState newState) 
    {
        currentState = newState;
    }

    public dogState GetState()
    {
        return currentState;
    }
}
