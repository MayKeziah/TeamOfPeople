using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenPuffDecay : MonoBehaviour
{
    public float lifespan;
    public float moveSpeed;
    public int spread;
    private float timeOfBirth;
    private Vector3 destinationPos;
    // Start is called before the first frame update
    void Start()
    {
        timeOfBirth = Time.time;
        destinationPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        destinationPos.x += Random.Range(-spread, spread);
        destinationPos.y += Random.Range(-spread, spread);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeOfBirth + lifespan)
            Destroy(gameObject);
        
        transform.position = Vector2.MoveTowards(transform.position, Vector2.Lerp(transform.position, destinationPos, 0.5f), Time.deltaTime * moveSpeed);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
