using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoors : MonoBehaviour
{
    // public GameController map;
    public GenerateWalls rooms;
    public PlayerDogHelper dogs;

    public List<int> dogsToUnlockDoor = new List<int>();

    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        // rooms = map.GetComponent<GenerateWalls>();
    }

    // Update is called once per frame
    void Update()
    {
        if (doorQualifies()) unlock();
    }

    private bool doorQualifies()
    {
      return Input.GetKeyDown(KeyCode.Space) || (i < dogsToUnlockDoor.Count) && (dogsToUnlockDoor[i] == dogs.GetDogsInPossession());
    }

    private void unlock()
    {
      rooms.destroyDoor();
      ++i;
    }


}
