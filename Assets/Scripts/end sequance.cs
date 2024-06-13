using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Endsequance : MonoBehaviour
{
    public GameObject livecoin;
    public GameObject endScreen;
    public GameObject fadeout;
    mainmenu main=new mainmenu();
    
    public void Start()
    {
        StartCoroutine(Endsequnce());
       
    }
    IEnumerator Endsequnce()
    {
        yield return new WaitForSeconds(3);
        livecoin.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        fadeout.SetActive(true);
        yield return new WaitForSeconds(2);
        main.ismenufx = true;
      
        SceneManager.LoadScene(0);
        


    }


} 

   
