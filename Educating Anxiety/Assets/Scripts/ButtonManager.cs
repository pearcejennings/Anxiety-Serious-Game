using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{

    public GameObject spaceBar;
    public GameObject Jkey;
    public GameObject Fkey;

    bool isSpacePressed = false;
    bool isJPressed = false;
    bool isFPressed = false;


    // Start is called before the first frame update
    void Start()
    {
        
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

        if (Input.GetKeyDown(KeyCode.J))
        {
            isJPressed = true;
            Jkey.GetComponent<Button>().Select();

        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            isJPressed = false;
            EventSystem.current.SetSelectedGameObject(null);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            isFPressed = true;
            Fkey.GetComponent<Button>().Select();

        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            isFPressed = false;
            EventSystem.current.SetSelectedGameObject(null);
        }

    }

   



}
