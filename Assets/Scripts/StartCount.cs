using System.Collections;
using UnityEngine;

public class StartCount : MonoBehaviour
{
    public GameObject Countdown3;
    public GameObject Countdown2;
    public GameObject Countdown1;
    public GameObject Go;
    public GameObject fade;
    public Player player;

    private bool countdownStarted = false;

    void Start()
    {
        // Ensure countdown objects are initially inactive
        Countdown3.SetActive(false);
        Countdown2.SetActive(false);
        Countdown1.SetActive(false);
        Go.SetActive(false);
    }

    void Update()
    {
        if (!countdownStarted)
        {
            countdownStarted = true;
            StartCoroutine(Countsequence());
        }
    }

    IEnumerator Countsequence()
    {
        yield return new WaitForSeconds(1.5f);
        Countdown3.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown3.SetActive(false);
        Countdown2.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown2.SetActive(false);
        Countdown1.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown1.SetActive(false);
        Go.SetActive(true);
        yield return new WaitForSeconds(1);
        Go.SetActive(false);

        Player.canMove2 = true;
        Player.canMove = true;
    }
}

