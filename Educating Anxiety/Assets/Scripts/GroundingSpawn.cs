using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundingSpawn : MonoBehaviour
{

    public GameObject groundingObject;
    public GameObject anxietytext;
    public GameObject player;
    float spawn_time;
    float timer;
   

    // Start is called before the first frame update
    void Start()
    {
        spawn_time = Time.timeSinceLevelLoad + 60.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > spawn_time)
        {
            groundingObject.SetActive(true);

        }
        

        if ((Time.timeSinceLevelLoad > 15) && (Time.timeSinceLevelLoad < 15.1))
        {
            player.transform.position = new Vector3(1f, 1.5f, 5f);
        }

        if (Time.timeSinceLevelLoad > 15)
        {
            anxietytext.SetActive(true);
        }
    }
}
