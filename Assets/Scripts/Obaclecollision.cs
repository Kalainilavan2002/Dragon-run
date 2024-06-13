using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obaclecollision : MonoBehaviour
{
    public GameObject charmodal;
    public AudioSource crashefx;
    public GameObject levelcontrol;
    public Player player;
    

    private void OnTriggerEnter(Collider other)
    {
        // Get the BoxCollider component
        BoxCollider boxCollider = this.gameObject.GetComponent<BoxCollider>();

        // Check if the BoxCollider is enabled
        if (boxCollider != null && boxCollider.enabled)
        {
            // Disable the BoxCollider
            boxCollider.enabled = false;

            // Stop the player's movement
            Player.canMove1 = false;
            if (Player.canMove1 == false)
            {
                charmodal.GetComponent<Animator>().Play("Stumble Backwards");
                levelcontrol.GetComponent<speedcontrol>().enabled = false;
                crashefx.Play();

                // Ensure Endsequance component is enabled on levelcontrol GameObject
                var endSequence = levelcontrol.GetComponent<Endsequance>();
                if (endSequence != null)
                {   
                    endSequence.enabled = true;
                   
                }
                else
                {
                    Debug.LogWarning("Endsequance component not found on levelcontrol GameObject.");
                }
            }
        }
    }
}



