using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{
    public GameObject spaceBar;
    public GameObject Fkey;
    public GameObject Jkey;
    public GameObject Ekey;
    public GameObject Ikey;
    public GameObject Qkey;
    public GameObject Pkey;

    bool isSpacePressed = false;
    bool isJPressed = false;
    bool isFPressed = false;
    bool isEPressed = false;
    bool isIPressed = false;
    bool isQPressed = false;
    bool isPPressed = false;

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

        if (Input.GetKeyDown(KeyCode.E))
        {
            isEPressed = true;
            Ekey.GetComponent<Button>().Select();

        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            isEPressed = false;
            EventSystem.current.SetSelectedGameObject(null);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            isIPressed = true;
            Ikey.GetComponent<Button>().Select();

        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            isIPressed = false;
            EventSystem.current.SetSelectedGameObject(null);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            isQPressed = true;
            Qkey.GetComponent<Button>().Select();

        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            isQPressed = false;
            EventSystem.current.SetSelectedGameObject(null);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            isPPressed = true;
            Pkey.GetComponent<Button>().Select();

        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            isPPressed = false;
            EventSystem.current.SetSelectedGameObject(null);
        }
    }

   
   

}
