using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{
    // game objects for button objects
    public GameObject spaceBar;
    public GameObject Fkey;
    public GameObject Jkey;
    public GameObject Ekey;
    public GameObject Ikey;
    public GameObject Qkey;
    public GameObject Pkey;


    //bools for pressing logic
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

        //to deselect buttons incase user clicks with mouse
        if (Input.GetMouseButtonUp(0))
        {
            spaceBar.GetComponent<Button>().OnDeselect(null);
        }

        //interaction logic for if space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSpacePressed = true;
            spaceBar.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            isSpacePressed = false;
            spaceBar.GetComponent<Button>().interactable = true;
        }

        //interaction logic for if F is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            isFPressed = true;
            Fkey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.F))
        {
            isFPressed = false;
            Fkey.GetComponent<Button>().interactable = true;
        }

        //interaction logic for if J is pressed
        if (Input.GetKeyDown(KeyCode.J))
        {
            isJPressed = true;
            Jkey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.J))
        {
            isJPressed = false;
            Jkey.GetComponent<Button>().interactable = true;
        }

        //interaction logic for if E is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            isEPressed = true;
            Ekey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.E))
        {
            isEPressed = false;
            Ekey.GetComponent<Button>().interactable = true;
        }

        //interaction logic for if I is pressed
        if (Input.GetKeyDown(KeyCode.I))
        {
            isIPressed = true;
            Ikey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.I))
        {
            isIPressed = false;
            Ikey.GetComponent<Button>().interactable = true;
        }

        //interaction logic for if Q is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isQPressed = true;
            Qkey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.Q))
        {
            isQPressed = false;
            Qkey.GetComponent<Button>().interactable = true;
        }


        //interaction logic for if P is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPPressed = true;
            Pkey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.P))
        {
            isPPressed = false;
            Pkey.GetComponent<Button>().interactable = true;
        }

    }

   
   

}
