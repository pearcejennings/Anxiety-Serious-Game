using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{

    public GameObject spaceBar;

    bool isSpacePressed = false;
    bool isJPressed = false;
    bool isFPressed = false;


    // Start is called before the first frame update
    void Start()
    {
        spaceBar.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSpacePressed = true;
            spaceBar.GetComponent<Button>().Select();
            
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isSpacePressed = false;
            EventSystem.current.SetSelectedGameObject(null);
        }
    }

   



}
