using UnityEngine;

public class TreesCreate : MonoBehaviour
{
    GameObject[] treesFence;
    int j;

    void Start()
    {
        treesFence=new GameObject[transform.childCount];
        for(int i=0; i<treesFence.Length; i++)
            treesFence[i] = transform.GetChild(i).gameObject;
        CreateTrees();
    }

    public void CreateTrees()
    {
        treesFence[j].SetActive(false);
        treesFence[j+1].SetActive(false);
        j += 2;
        if (j == 6) j = 0;
        treesFence[j].SetActive(true);
        treesFence[j + 1].SetActive(true);
    }
}
