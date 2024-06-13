using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public float leftside = 55.5f;
    public float rightside = 63.5f;
    public float internalrightside;
    public float internalleftside;

    void Update()
    {
        internalleftside = leftside;
        internalrightside = rightside;
    }
}
