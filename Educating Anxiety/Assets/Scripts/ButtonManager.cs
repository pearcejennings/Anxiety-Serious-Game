using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //game objects for button objects
    public GameObject spaceBar;
    public GameObject Fkey;
    public GameObject Jkey;
    public GameObject Ekey;
    public GameObject Ikey;
    public GameObject Qkey;
    public GameObject Pkey;

    //gif variables
    public GameObject SquareBreathingGif;
    private Animator gif;
    private float animationspeed;
    private int coroutinecount;

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
        gif = SquareBreathingGif.GetComponent<Animator>();
        animationspeed = gif.speed;
        gif.speed = 0;
        coroutinecount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //to deselect buttons incase user clicks with mouse
        if (Input.GetMouseButtonUp(0))
        {
            spaceBar.GetComponent<Button>().OnDeselect(null);
        }

        SpaceIsPressed();
        FandJkeys();
        EandIkeys();
        QandPkeys();

    }

   
    private void SpaceIsPressed()
    {
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

        //enable next keys
        if (isSpacePressed == true)
        {
            Fkey.SetActive(true);
            Jkey.SetActive(true);
            
        }
        else
        {
            Fkey.SetActive(false);
            Jkey.SetActive(false);
        }

        //continue gif
        if ((isSpacePressed == true) && (coroutinecount == 0))
        {
            StartCoroutine(continuegif());
        }
    }

    private void FandJkeys()
    {

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

        //enable next keys
        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true))
        {
           
            Ekey.SetActive(true);
            Ikey.SetActive(true);
         
        }
        else
        {
            Ekey.SetActive(false);
            Ikey.SetActive(false);
        }

        //continue gif
        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (coroutinecount == 1))
        {
            StartCoroutine(continuegif());
        }
    }

    private void EandIkeys ()
    {
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

        //enable next keys
        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == true) && (isIPressed == true))
        {
            
            Qkey.SetActive(true);
            Pkey.SetActive(true);

        }
        else
        {
            Qkey.SetActive(false);
            Pkey.SetActive(false);
        }

        //continue gif
        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == true) && (isIPressed == true) && (coroutinecount == 2))
        {
            StartCoroutine(continuegif());
        }

    }

    private void QandPkeys()
    {
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

        //keep gif going
        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == true) && (isIPressed == true) && (isQPressed == true) && (isPPressed == true) && (coroutinecount == 3))
        {
            StartCoroutine(holdfor4continue());
        }
       
    }

    IEnumerator continuegif()
    {
        coroutinecount++;
        gif.speed = 1;
        yield return new WaitForSeconds(1);
        gif.speed = 0;
        
    }

    IEnumerator holdfor4continue()
    {
        coroutinecount++;
        gif.speed = 1;
        yield return new WaitForSeconds(4);
        gif.speed = 0;
       
    }


}
