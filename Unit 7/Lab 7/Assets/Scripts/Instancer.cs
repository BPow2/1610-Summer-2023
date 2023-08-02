using System.Dynamic;
using UnityEngine;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{

    public GameObject prefab;
    private int num;

    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value,Quaternion.identity);
    }

    public void CreateInstanceFromList(Vectory3DataList obj)
    {

        for (var i = 0; i < obj.vector3DList.Count; i++)
        {
            Instantiate(prefab, obj.vector3DList[i].value, Quaternion.identity);
        } 
    }

    public void CreateInstanceFromListCounting(Vectory3DataList obj)
    {
        Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
        num++;
        if(num == obj.vector3DList.Count)
        {
            num = 0;
        }
    }

    public void CreateInstanceListRandomly(Vectory3DataList obj)
    {
        num = Random.Range(0, obj.vector3DList.Count );
        Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
    }

}
