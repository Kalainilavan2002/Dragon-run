using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public  AudioSource menufx;
    public  bool ismenufx = true;
    public GameObject score;
   
    // Start is called before the first frame update
    public void Start()
    {
        menu();

    }
    // Update is called once per frame
  public  void Update()
    {
    }
    public void menu()
    {
         if (ismenufx == true)
        {
            menufx.Play();
        }
    }
    
    public void play()
    {
        Player.canMove = false;
        Player.canMove1 = true;
        Player.canMove2 = false;
        collectingtcoins.coincount = 0;
        SceneManager.LoadScene(1);
        ismenufx = false;
       
    }
    public void credit()
    {
        score.SetActive(true);
    }
  
    public void exit()
    {
            // Exit the application
            Debug.Log("Exiting the game");
            Application.Quit();

            // If running in the Unity editor, stop playing the editor
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

    }




