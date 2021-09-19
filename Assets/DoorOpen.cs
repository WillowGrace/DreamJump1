using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour
{
    public int travel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collid)
    {
        if (collid.name == "Player")
            Debug.Log("Open Sesame!");
            SceneManager.LoadScene(travel);

    }
}
