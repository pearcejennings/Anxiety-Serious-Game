using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Archway : MonoBehaviour
{
    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            SceneManager.LoadScene("Generalised Anxiety");
        }

    }
}
