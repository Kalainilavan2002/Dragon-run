using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectingtcoins : MonoBehaviour
{
    // Start is called before the first frame update
    public static int coincount;
    public GameObject coincountdisplay;
    public GameObject coinenddisplay;
    public int coin=0;
   
    // Update is called once per frame
    void Update()
    {   
        coincountdisplay.GetComponent<Text>().text = "" + coincount;
        coinenddisplay.GetComponent<Text>().text = "" + coincount;
        if (coincount >= 1)
        {
            coin = coincount ;
        }
        
    }
    
}
