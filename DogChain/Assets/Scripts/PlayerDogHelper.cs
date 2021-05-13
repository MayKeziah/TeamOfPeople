using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDogHelper : MonoBehaviour
{
    public GameObject spaceship;
    public List<SlugDog> dogChain = new List<SlugDog>();
    //                          ^
    // HA get it because that's the name of the game

    public int dogsRescued = 0;
    public int dogsThisTrip = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == spaceship)
            TouchSpaceship();
    }

    void TouchSpaceship() 
    {
        // This is a new trip. Reset the # of dogs we saved this trip to 0 before we count more dogs. Total # stays untouched.
        dogsThisTrip = 0;

        // Put all dogs into "spaceship" mode before clearing the GameObject list of all dogs.
        foreach (SlugDog dog in dogChain) {
            dog.ChangeState(SlugDog.dogState.Spaceship);
        }

        dogChain.Clear();
    }

}
