using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ColorIDDataList : ScriptableObject
{

    public List<ColorBehaviour> colorIDList;
    public ColorBehaviour currentColor;
    private int num;

    public void SetCurrentColorRandomly()
    {
        num = Random.Range(0, colorIDList.Count);
        currentColor = colorIDList[num];
        Debug.Log(num);
    }
}
