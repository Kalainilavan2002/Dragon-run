using System.Collections;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private string parentName;

    private void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(120);
        if (parentName != "sectionfeild(Clone)") // Check if the name is correct as per your logic
        {
            if (gameObject != null) // Added null check
            {
                Destroy(gameObject);
            }
        }
    }
}

