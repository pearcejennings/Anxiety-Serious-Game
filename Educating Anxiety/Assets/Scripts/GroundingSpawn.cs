using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundingSpawn : MonoBehaviour
{

    public GameObject groundingObject;
    public GameObject anxietytext1;
    public GameObject player;
    public GameObject heartbeat;
    public GameObject breathing;
    public GameObject tip;
    float spawn_time;
    float thoughts_time1;
    float thoughts_time2;
    float tip_timer;
    float timer;
   

    // Start is called before the first frame update
    void Start()
    {

        thoughts_time1 = Time.timeSinceLevelLoad + 15.0f;
        thoughts_time2 = Time.timeSinceLevelLoad + 30.0f;

        spawn_time = Time.timeSinceLevelLoad + 40.0f;
        tip_timer = Time.timeSinceLevelLoad + 50.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > spawn_time)
        {
            groundingObject.SetActive(true);

        }

        if (Time.timeSinceLevelLoad > thoughts_time1)
        {
            anxietytext1.SetActive(true);
            heartbeat.SetActive(true);

        }

        if (Time.timeSinceLevelLoad > thoughts_time2)
        {

            breathing.SetActive(true);

        }


        if (Time.timeSinceLevelLoad > tip_timer)
        {
            tip.SetActive(true);
         

        }

    }
}
