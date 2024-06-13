using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedcontrol : MonoBehaviour
{
   public int disRun;
    public bool addrun=false;
    public float disdelay = 0.4f;
    private void Update()
    {
        if (addrun == false)
        {
            addrun = true;
            StartCoroutine(Addrun());
        }
    }
    IEnumerator Addrun()

    {
        disRun += 1;
        yield return new WaitForSeconds(disdelay);
        addrun = false;
        Debug.Log(disRun);
    }


}
