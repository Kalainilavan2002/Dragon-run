using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class credit : MonoBehaviour
{
    collectingtcoins cred=new collectingtcoins();
    public GameObject highscore;
    


    // Update is called once per frame
    void Update()
    {
       int coin = 0;
        Debug.Log("coin"+cred.coin);
        if (coin < cred.coin)
        {
           coin = cred.coin;
        }
        highscore.GetComponent<Text>().text = "" + coin;

    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
