using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDogHelper : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public HeroHealth playerHealth; //needs to be set in editor
    public GameObject spaceship;
    public Text dogsObtainedText = null;
    public List<SlugDog> dogChain = new List<SlugDog>();
    //                          ^
    // HA get it because that's the name of the game

    public int dogsRescued = 0;
    public int dogsThisTrip = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dogsObtainedText.text = "Dogs Obtained: " + GetDogsInPossession();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == spaceship)
            TouchSpaceship();
    }

    void TouchSpaceship() 
    {
        if(dogChain.Count > 0) //need to replenish oxygen
        {
            playerHealth.replenishFullHealth();
        }

        // This is a new trip. Reset the # of dogs we saved this trip to 0 before we count more dogs. Total # stays untouched.
        dogsThisTrip = 0;

        // Put all dogs into "spaceship" mode before clearing the GameObject list of all dogs.
        foreach (SlugDog dog in dogChain) {
            dog.ChangeState(SlugDog.dogState.Spaceship);
        }

        dogChain.Clear();
    }

    public int GetDogsInPossession() 
    {
        return (dogsRescued + dogChain.Count);
    }

}
