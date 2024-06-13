using System.Collections;
using UnityEngine;

public class GenerateSection : MonoBehaviour
{
    public GameObject[] sections; // Fixed typo
    public int zPos = 50; // Changed variable naming for better clarity
    private bool creatingSection = false; // Changed variable naming for better clarity
    public int secNum;
    void Update()
    {
        if (!creatingSection)
        {
            creatingSection = true;
            StartCoroutine(GenerateSectionCoroutine());
        }
    }

    IEnumerator GenerateSectionCoroutine()
    {
         secNum = Random.Range(0, 3);
        if (sections[secNum] != null) // Added null check
        {
            Instantiate(sections[secNum], new Vector3(56.12786f, -166.1726f, zPos), Quaternion.identity);
            zPos += 50;
        }
        yield return new WaitForSeconds(10);
        creatingSection = false;
    }
}

