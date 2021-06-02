using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public Camera mainCam; //this should be set to the main camera of the scene

    public AudioSource bounceSource; //this is the audiosource that plays the bounce noise

    public HeroHealth health; //this needs to be set in the editor

    public float accelerationSpeed = 10f; //this is the rate at which the player accelerates

    private Vector3 velocity;

    private bool inFrictionZone = false;

    private AlphaFrictionZone currentZone = null;

    private bool wallThisFrame = false; //boolean for multiple wall collision prevention

    private bool isFreezed = false; //whether or not to freeze player movement
    public ObjectFacingLeftRight playerLeftRight;
    public GameObject oxygenPuff;

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (isFreezed)
        {
            wallThisFrame = false;
            return;
        }
        if (health.currentHealth > 0) //player only has control if alive
        {
            Vector3 mousePos = GetMouseWorldPosition();
            if (Input.GetMouseButton(0))
            {
                AcceleratePlayer(mousePos);

                // spawn oxygen puffs as an indicator
                GameObject puff = Instantiate(oxygenPuff, transform.position, Quaternion.identity);
            }
        }
        MovePlayer();
        wallThisFrame = false;
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
        velocity += ((diff.normalized) * accelerationSpeed) * Time.deltaTime;
    }

    //moves the player according to velocity and slows down velocity slightly
    private void MovePlayer()
    {
        // begin area where Talon flippa the sprite
        if (velocity.x < 0) // left
        {
            playerLeftRight.FaceLeft();
        }
        else if (velocity.x > 0)// right
        {
            playerLeftRight.FaceRight();
        }
        // end area where Talon flippa the sprite

        Vector3 newPos = transform.position;
        newPos += velocity * Time.deltaTime;
        transform.position = newPos;
        if (!inFrictionZone)
        {
            //velocity *= (0.99f + (0.01f * Time.deltaTime)); //slow down by 1% of current speed
            velocity -= (velocity * 0.30f) * Time.deltaTime; //slow down by 30% every second
        }
        else
        {
            //velocity *= (currentZone.frictionModifier + ((1f - currentZone.frictionModifier) * Time.deltaTime));
            velocity -= (velocity * (1f - currentZone.frictionModifier)) * Time.deltaTime; //slow down by 1/frictionmodifier every second (.95 would be a 5% loss every second)
        }
        //Debug.Log(velocity);
    }

    //returns the ratio of the displayed screen in W/H
    public float getScreenRatio()
    {
        return ((float)Screen.width) / Screen.height;
    }

    //aligns the X and Y position of the camera with the player
    private void moveCameraToPlayer()
    {
        Vector3 newPos = mainCam.transform.position;
        newPos.x = transform.position.x;
        newPos.y = transform.position.y;
        mainCam.transform.position = newPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("in zone");
        if (collision.gameObject.GetComponent<AlphaFrictionZone>() != null)
        {
            //Debug.Log("not null");
            currentZone = collision.gameObject.GetComponent<AlphaFrictionZone>();
            inFrictionZone = true;
        }
        if(collision.gameObject.GetComponent<SpaceshipTransition>() != null)
        {
            if (gameObject.GetComponent<PlayerDogHelper>().dogChain.Count != 0)
            {
                collision.gameObject.GetComponent<SpaceshipTransition>().activate();
            }
        }
        if (collision.gameObject.GetComponent<AlphaWallController>() != null)
        {
            switch (collision.gameObject.GetComponent<AlphaWallController>().getWallType())
            {
                case AlphaWallController.WallType.Bouncy:
                    if (!wallThisFrame)
                    {
                        velocity = -velocity;
                        wallThisFrame = true;
                    }
                    break;
                case AlphaWallController.WallType.Reflective:
                    //in essence, this bounce type is supposed to do two things.
                    //1. to figure out what "side" of the wall the player collided with (the hard part)
                    //2. to reflect the correct portion of the player's velocity (the easy part).
                    //for the four surfaces to reflect off of:
                    //R = +-
                    //U = ++
                    //L = -+
                    //D = --
                    //where the first +/- is the UR vector comparison (cosUR)
                    //and the second is the UL vector comparison. (cosUL)
                    //
                    //Math done:
                    //
                    //essentially, what I'm doing here is finding the vector between the player
                    //and the wall (displacement is the variable name), and then comparing that
                    //to two static vector directions in order to find the side of the wall that
                    //the player collided with.
                    //what the dot product finds here is the product of both vector's magnitudes,
                    //as well as the cosine of the angle between the two, what having two of these
                    //reference vectors allows is to basically put a big X in the wall box, which
                    //gives four seperate possible combinations of cos(theta) being positive or negative,
                    //which translates as shown above.
                    //
                    //for reflecting the player I just reverse the x or y component of the velocity
                    //vector based on which quadrant the player is in.
                    //
                    //worth noting is that this solution only works when the wall is a perfect square.
                    //otherwise some more math needs to be done in order to account for the height/width
                    //of the wall
                    if (!wallThisFrame)
                    {
                        Vector2 simplePlayer = this.transform.position;
                        Vector2 simpleCollide = collision.transform.position;
                        Vector2 displacement = (simplePlayer - simpleCollide); //vector from wall to player
                        Vector2 UR = Vector2.up + Vector2.right; //diagonal up-right vector
                        Vector2 UL = Vector2.up + Vector2.left; //diagonal up-left vector
                        float cosUR = Vector2.Dot(displacement, UR) / (displacement.magnitude * UR.magnitude);// 
                        float cosUL = Vector2.Dot(displacement, UL) / (displacement.magnitude * UL.magnitude); // 
                                                                                                               //Debug.Log(cosUR);
                                                                                                               //Debug.Log(cosUL);
                        if (cosUR > 0f && cosUL < 0f || cosUR < 0f && cosUL > 0f) //hit the right or left side of the wall
                        {
                            velocity.x = -velocity.x;
                            bounceSource.time = 0.4f;
                            bounceSource.Play();
                            bounceSource.SetScheduledEndTime(AudioSettings.dspTime + 0.6f);
                        }
                        else if (cosUR > 0f && cosUL > 0f || cosUR < 0f && cosUL < 0f) //hit the up or down side of the wall
                        {
                            velocity.y = -velocity.y;
                            bounceSource.time = 0.4f;
                            bounceSource.Play();
                            bounceSource.SetScheduledEndTime(AudioSettings.dspTime + 0.6f);
                        }
                        wallThisFrame = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<AlphaWallController>() != null)//means the player is in the wall
        {
            //this uses the same math as the reflective wall collision does, and pushes the player to the side they should be on
            Vector2 simplePlayer = this.transform.position;
            Vector2 simpleCollide = collision.transform.position;
            Vector2 displacement = (simplePlayer - simpleCollide); //vector from wall to player
            Vector2 UR = Vector2.up + Vector2.right; //diagonal up-right vector
            Vector2 UL = Vector2.up + Vector2.left; //diagonal up-left vector
            float cosUR = Vector2.Dot(displacement, UR) / (displacement.magnitude * UR.magnitude);// 
            float cosUL = Vector2.Dot(displacement, UL) / (displacement.magnitude * UL.magnitude); // 
                                                                                                   //Debug.Log(cosUR);
                                                                                                   //Debug.Log(cosUL);
            if (cosUR > 0f && cosUL < 0f) //hit the right
            {
                //first, get the distance of the center of the wall to the right of the wall,
                //plus the distance of the center of the player to the left of the player.
                float xTohit = (collision.transform.localScale.x/2f) + (this.transform.localScale.x/2f);
                //then add that to the wall's current position (plus a little boundary for consistency)
                xTohit += simpleCollide.x + 0.01f;
                //xtohit is now the x position we want the player in to get them out of the wall
                Vector3 newpos = transform.position;
                newpos.x = xTohit;
                transform.position = newpos;
            }
            else if (cosUR < 0f && cosUL > 0f)//hit left
            {
                //same as hit right but negated in some parts to place to the left
                float xTohit = -(collision.transform.localScale.x / 2f) - (this.transform.localScale.x / 2f);
                xTohit += simpleCollide.x - 0.01f;
                Vector3 newpos = transform.position;
                newpos.x = xTohit;
                transform.position = newpos;
            }
            else if (cosUR > 0f && cosUL > 0f) //hit the up
            {
                //first, get the distance of the center of the wall to the top of the wall,
                //plus the distance of the center of the player to the bottom of the player.
                float yTohit = (collision.transform.localScale.y / 2f) + (this.transform.localScale.y / 2f);
                //then add that to the wall's current position (plus a little boundary for consistency)
                yTohit += simpleCollide.y + 0.01f;
                //xtohit is now the x position we want the player in to get them out of the wall
                Vector3 newpos = transform.position;
                newpos.y = yTohit;
                transform.position = newpos;
            }
            else if (cosUR < 0f && cosUL < 0f) //hit down
            {
                //same as hit top but with some parts negated
                float yTohit = -(collision.transform.localScale.y / 2f) - (this.transform.localScale.y / 2f);
                yTohit += simpleCollide.y - 0.01f;
                Vector3 newpos = transform.position;
                newpos.y = yTohit;
                transform.position = newpos;
            }
        }
        if (collision.gameObject.GetComponent<OxygenPickup>() != null)
        {
            OxygenPickup pickup = collision.gameObject.GetComponent<OxygenPickup>();
            if (pickup.isActive)
            {
                health.replenishHealth(pickup.OxygenToRestore);
                pickup.deactivate();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<AlphaFrictionZone>() != null)
        {
            inFrictionZone = false;
        }
    }

    //functions for freezing and unfreezing the player
    public void Freeze()
    {
        isFreezed = true;
    }
    public void Unfreeze()
    {
        isFreezed = false;
    }
}
