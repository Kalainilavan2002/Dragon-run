using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcoin : MonoBehaviour
{
    public AudioSource coinfx;
    public int coin;
    private void OnTriggerEnter(Collider other)
    {
        coinfx.Play();
         
        collectingtcoins.coincount += 1;
       
        this.gameObject.SetActive(false);
        
    }
  
}
