using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSpecificSceneButton : MonoBehaviour
{
    public int ToScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Object must have a collider to use this method!!
    void OnMouseDown() 
    {
        SceneManager.LoadScene(ToScene);
    }
}
