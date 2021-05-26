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

    public float moveSpeed = 5f;
    public float reactionSpeed = 1f;
    private float reactionTime;
    private bool isReacting = false;
    private bool isChasing = false;
    public float attractRadius = 2f;
    public float followRadius = 8f;
    public float spinDuration = 0.5f;
    public float spinSpeed = 1f;
    private float spinTime;
    private bool isSpinning = false;

    private Color originalColor;

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
        originalColor = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = Color.grey;
        spaceship = thePlayer.spaceship;

        if (followRadius <= attractRadius) {
            Debug.LogWarning("Warning: followRadius is less than attractRadius for a dog.");
        }
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
                // If the dog is the sweet spot range between the attract and follow radius, then we need the dog to "react" before it starts moving.
                if (!isReacting && !isChasing) 
                {
                    isReacting = true;
                    reactionTime = Time.time + reactionSpeed;
                }

                if (isReacting && Time.time > reactionTime) 
                {
                    isChasing = true;
                    isReacting = false;
                }

                if (isChasing) 
                {
                    //transform.position = Vector2.MoveTowards(transform.position, thePlayer.transform.position, Time.deltaTime * moveSpeed);
                    transform.position = Vector2.MoveTowards(transform.position, Vector2.Lerp(transform.position, thePlayer.transform.position, 0.5f), Time.deltaTime * moveSpeed);
                }
                
            }
            // If the dog gets too far away from the player (probably if it gets stuck behind a wall), stop following it completely
            else if (Vector2.Distance(thePlayer.transform.position, transform.position) >= followRadius)
            {
                RemoveFromChain();
            }
            // If the dog gets as close as it can to the player, it is still chained but should no longer chase.
            else if (Vector2.Distance(thePlayer.transform.position, transform.position) <= attractRadius) 
            {
                isChasing = false;
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
                // If the dog is the sweet spot range between the attract and follow radius, then we need the dog to "react" before it starts moving.
                if (!isReacting && !isChasing) 
                {
                    isReacting = true;
                    reactionTime = Time.time + reactionSpeed;
                }

                if (isReacting && Time.time > reactionTime) 
                {
                    isChasing = true;
                    isReacting = false;
                }

                if (isChasing) 
                {
                    //transform.position = Vector2.MoveTowards(transform.position, followMe.transform.position, Time.deltaTime * moveSpeed);
                    transform.position = Vector2.MoveTowards(transform.position, Vector2.Lerp(transform.position, followMe.transform.position, 0.5f), Time.deltaTime * moveSpeed);
                }
                
            }
            // If the dog gets too far away from the target dog, stop following
            else if (Vector2.Distance(followMe.transform.position, transform.position) >= followRadius)
            {
                RemoveFromChain();
            }
            // If the dog gets as close as it can to the other dog, it is still chained but should no longer chase.
            else if (Vector2.Distance(followMe.transform.position, transform.position) <= attractRadius) 
            {
                isChasing = false;
            }
        }
    }

    void Spin() 
    {
        if (!isSpinning) {
            isSpinning = true;
            spinTime = Time.time + spinDuration;
            // Dog becomes its natural "green" color as it follows you.
            GetComponent<SpriteRenderer>().color = originalColor;
        }

        // speen
        if (isSpinning && Time.time < spinTime)
        {
            transform.Rotate(0f, 0f, spinSpeed, Space.Self);
        }
        else if (isSpinning)
        {
            isSpinning = false;
            spinTime = 0f;

            // Make sure dog's rotation is reset to (0, 0, 0)
            transform.rotation = Quaternion.identity;

            ChangeState(dogState.Chained);
        }
        
    }

    void GoToSpaceship() 
    {
        // move towards spaceship
        transform.position = Vector2.MoveTowards(transform.position, spaceship.transform.position, Time.deltaTime * moveSpeed);

        // Collision with spaceship is shown in method below
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (currentState == dogState.Spaceship && collision.gameObject == spaceship) 
        {
            // Delete this dog object and increment the amount of dogs the player has saved
            thePlayer.dogsRescued += 1;
            thePlayer.dogsThisTrip += 1;
            Destroy(gameObject);
        }
    }

    void RemoveFromChain() 
    {
        // Change color to grey as a visual cue for the player that they have lost the dog
        GetComponent<SpriteRenderer>().color = Color.grey;

        // The dog is removed from the dogChain/List and reverts to an inactive state.
        thePlayer.dogChain.Remove(this);
        ChangeState(dogState.Inactive);

        // Reset some private variables to avoid future issues
        followPlayer = false;
        followMe = null;
        isReacting = false;
        isChasing = false;
        isSpinning = false;
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
