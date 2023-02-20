using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundingSpawn : MonoBehaviour
{

    public GameObject groundingObject;

    float spawn_time;

    // Start is called before the first frame update
    void Start()
    {
        spawn_time = Time.time + 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawn_time)
        {
            groundingObject.SetActive(true);

        }

    }
}
