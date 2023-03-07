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
    public GameObject fKey;
    public GameObject jKey;
    public GameObject eKey;
    public GameObject iKey;
    public GameObject qKey;
    public GameObject pKey;

    //gif variables
    public GameObject squareBreathingGif;
    private Animator squareAnim;
    private float animationSpeed;
    private int coroutineCount;
    private int cyclesComplete;

    //bools for pressing logic
    bool isSpacePressed = false;
    bool isJPressed = false;
    bool isFPressed = false;
    bool isEPressed = false;
    bool isIPressed = false;
    bool isQPressed = false;
    bool isPPressed = false;
    bool keysReleased = false;

    // Start is called before the first frame update
    void Start()
    {
        squareAnim = squareBreathingGif.GetComponent<Animator>();
        animationSpeed = squareAnim.speed;
        squareAnim.speed = 0;
        coroutineCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(coroutineCount);
        Debug.Log(cyclesComplete);
        Debug.Log(keysReleased);

        //to deselect buttons incase user clicks with mouse
        if (Input.GetMouseButtonUp(0))
        {
            spaceBar.GetComponent<Button>().OnDeselect(null);
        }

        //resets breathing to base state if player does not follow inputs
        if ((isSpacePressed == false) && (isFPressed == false) && (isJPressed == false) && (isEPressed == false) && (isIPressed == false) && (isQPressed == false) && (isPPressed == false) && (coroutineCount != 8))
        {
            squareAnim.Rebind();
            squareAnim.Update(0f);
            coroutineCount = 0;
        }

        //whenever gif is playing (gif speed more than 0), and any new keys are pressed or released, then reset cycle
        if ((squareAnim.speed > 0) && (Input.anyKeyDown))
        {
            squareAnim.Rebind();
            squareAnim.Update(0f);
            coroutineCount = 0;
        }
        //or released
        if ((Input.GetKeyUp(KeyCode.Space)) || (Input.GetKeyUp(KeyCode.F)) || (Input.GetKeyUp(KeyCode.J)) || (Input.GetKeyUp(KeyCode.E)) || (Input.GetKeyUp(KeyCode.I)) || (Input.GetKeyUp(KeyCode.Q)) || (Input.GetKeyUp(KeyCode.P)))
        {
            keysReleased = true;
        }
        if ((squareAnim.speed > 0) && (keysReleased == true))
        {
            squareAnim.Rebind();
            squareAnim.Update(0f);
            coroutineCount = 0;
        }
        //release key bool
        keysReleased = false;


        SpaceIsPressed();
        FandJkeys();
        EandIkeys();
        QandPkeys();
        RequirementsForGrounding();


        if (cyclesComplete == 3)
        {
            SceneManager.LoadScene("End Screen");
        }

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

        //keep next keys disabled
        if (isSpacePressed == false)
        {
            fKey.SetActive(false);
            jKey.SetActive(false);
        }

    }

    private void FandJkeys()
    {

        //interaction logic for if F is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            isFPressed = true;
            fKey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.F))
        {
            isFPressed = false;
            fKey.GetComponent<Button>().interactable = true;
        }

        //interaction logic for if J is pressed
        if (Input.GetKeyDown(KeyCode.J))
        {
            isJPressed = true;
            jKey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.J))
        {
            isJPressed = false;
            jKey.GetComponent<Button>().interactable = true;
        }

        //keep next keys disabled
        if ((isSpacePressed == false) && (isFPressed == false) && (isJPressed == false))
        {
            eKey.SetActive(false);
            iKey.SetActive(false);
        }

    }

    private void EandIkeys ()
    {
        //interaction logic for if E is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            isEPressed = true;
            eKey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.E))
        {
            isEPressed = false;
            eKey.GetComponent<Button>().interactable = true;
        }

        //interaction logic for if I is pressed
        if (Input.GetKeyDown(KeyCode.I))
        {
            isIPressed = true;
            iKey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.I))
        {
            isIPressed = false;
            iKey.GetComponent<Button>().interactable = true;
        }

        //keep next keys disabled
        if ((isSpacePressed == false) && (isFPressed == false) && (isJPressed == false) && (isEPressed == false) && (isIPressed == false))
        {
            qKey.SetActive(false);
            pKey.SetActive(false);
        }

    }

    private void QandPkeys()
    {
        //interaction logic for if Q is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isQPressed = true;
            qKey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.Q))
        {
            isQPressed = false;
            qKey.GetComponent<Button>().interactable = true;
        }


        //interaction logic for if P is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPPressed = true;
            pKey.GetComponent<Button>().interactable = false;
        }

        else if (Input.GetKeyUp(KeyCode.P))
        {
            isPPressed = false;
            pKey.GetComponent<Button>().interactable = true;
        }
       
    }

    private void RequirementsForGrounding()
    {
       
        //first phase
        if ((isSpacePressed == true) && (isFPressed == false) && (isJPressed == false) && (isEPressed == false) && (isIPressed == false) && (isQPressed == false) && (isPPressed == false) && (coroutineCount == 0))
        {
            StartCoroutine(ContinueGrounding());
        }

        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == false) && (isIPressed == false) && (isQPressed == false) && (isPPressed == false) && (coroutineCount == 1))
        {
            StartCoroutine(ContinueGrounding());
        }

        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == true) && (isIPressed == true) && (isQPressed == false) && (isPPressed == false) && (coroutineCount == 2))
        {
            StartCoroutine(ContinueGrounding());
        }

        //middle phase
        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == true) && (isIPressed == true) && (isQPressed == true) && (isPPressed == true) && (coroutineCount == 3))
        {
            StartCoroutine(MiddleOfGrounding());
        }

        //release phase
        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == true) && (isIPressed == true) && (isQPressed == false) && (isPPressed == false) && (coroutineCount == 4))
        {
            StartCoroutine(ContinueGrounding());
        }

        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == false) && (isIPressed == false) && (isQPressed == false) && (isPPressed == false) && (coroutineCount == 5))
        {
            StartCoroutine(ContinueGrounding());
        }

        if ((isSpacePressed == true) && (isFPressed == false) && (isJPressed == false) && (isEPressed == false) && (isIPressed == false) && (isQPressed == false) && (isPPressed == false) && (coroutineCount == 6))
        {
            StartCoroutine(ContinueGrounding());
        }

        if ((isSpacePressed == false) && (isFPressed == false) && (isJPressed == false) && (isEPressed == false) && (isIPressed == false) && (isQPressed == false) && (isPPressed == false) && (coroutineCount == 7))
        {
            StartCoroutine(EndOfGrounding());
        }

    }



    IEnumerator ContinueGrounding()
    {

        //increase coroutine count for progression requirements
        coroutineCount++;
        //progress animation by 1 seconds
        squareAnim.speed = 1;
        yield return new WaitForSeconds(1);
        //halt animation
        squareAnim.speed = 0;
 


        //disable space
        if ((isSpacePressed == true) && (isFPressed == false) && (isJPressed == false) && (isEPressed == false) && (isIPressed == false) && (isQPressed == false) && (isPPressed == false) && (coroutineCount > 4))
        {
            spaceBar.SetActive(false);
            
        }

        //enable next keys f and j
        if ((isSpacePressed == true) && (coroutineCount < 4))
        {
            fKey.SetActive(true);
            jKey.SetActive(true);

        }
        //re-disable keys f and j
        else if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == false) && (isIPressed == false) && (isQPressed == false) && (isPPressed == false) && (coroutineCount > 4))
        {
            fKey.SetActive(false);
            jKey.SetActive(false);
        }


        //enable next keys e and i
        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (coroutineCount < 4))
        {

            eKey.SetActive(true);
            iKey.SetActive(true);

        }
        //re-disable keys e and i
        else if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == true) && (isIPressed == true) && (isQPressed == false) && (isPPressed == false) && (coroutineCount > 4))
        {
            eKey.SetActive(false);
            iKey.SetActive(false);
        }


        //enable next keys q and p
        if ((isSpacePressed == true) && (isFPressed == true) && (isJPressed == true) && (isEPressed == true) && (isIPressed == true) && (coroutineCount < 4))
        {

            qKey.SetActive(true);
            pKey.SetActive(true);

        }

     
    }

    IEnumerator MiddleOfGrounding()
    {
        //increase coroutine count for progression requirements
        coroutineCount++;
        //progress animation by 5 seconds
        squareAnim.speed = 1;
        yield return new WaitForSeconds(5.2f);
        //halt animation
        squareAnim.speed = 0;
        //disable q and p
        qKey.SetActive(false);
        pKey.SetActive(false);
        

    }

    IEnumerator EndOfGrounding()
    {
        //increase coroutine count for progression requirements
        coroutineCount++;
        //progress animation by 5 seconds
        squareAnim.speed = 1;
        yield return new WaitForSeconds(5.2f);
        //halt animation
        squareAnim.speed = 0;
        //add to cycle count
        cyclesComplete++;
        //reset cycle
        coroutineCount = 0;
        //re-enable space bar
        spaceBar.SetActive(true);
      
    }
}


