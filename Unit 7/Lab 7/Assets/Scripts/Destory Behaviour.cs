using System.Collections;
using UnityEngine;

public class DestoryBehaviour : MonoBehaviour
{

    public float seconds = 1;
    private WaitForSeconds wfsObj;

    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        yield return wfsObj;
        Destroy(gameObject);
    }
}
