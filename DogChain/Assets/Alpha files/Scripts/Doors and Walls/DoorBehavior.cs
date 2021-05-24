using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{

    public int dogsRequired = 999; //number of dogs needed to open the door

    private PlayerDogHelper dogCounter;

    private const string PlayerName = "Player";

    // Start is called before the first frame update
    // this function finds the playerdoghelper by object name, so if
    // the name of the player in the scene changes the PlayerName
    // string needs to change too
    void Start()
    {
        dogCounter = GameObject.Find(PlayerName).GetComponent<PlayerDogHelper>();
        StartCoroutine("checkForDogs");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator checkForDogs()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            if(dogCounter.GetDogsInPossession() >= dogsRequired)
            {
                dogsMet();
                break;
            }
        }
    }

    //get and set methods for dogsRequired
    public int getDogsRequired()
    {
        return dogsRequired;
    }
    public void setDogsRequired(int newRequirement)
    {
        dogsRequired = newRequirement;
    }

    //method called when the number of required dogs has been met to open the door
    private void dogsMet()
    {
        //currently just deletes the object, this may be changed in the future
        Destroy(gameObject);
    }
}
