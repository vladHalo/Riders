using DG.Tweening;
using UnityEngine;

public class Hammers : MonoBehaviour
{
    public Material[] materials;
    public float duration;

    MeshRenderer targetMat;
    MeshRenderer hammerOneMat;
    MeshRenderer hammerTwoMat;
    Transform hammerOneTra;
    Transform hammerTwoTra;
    bool check;

    void Start()
    {
        var childHammerOne = transform.GetChild(0).gameObject;
        var childHammerTwo = transform.GetChild(1).gameObject;
        targetMat = GetComponent<MeshRenderer>();
        hammerOneMat = childHammerOne.GetComponent<MeshRenderer>();
        hammerTwoMat = childHammerTwo.GetComponent<MeshRenderer>();
        hammerOneTra = childHammerOne.GetComponent<Transform>();
        hammerTwoTra = childHammerTwo.GetComponent<Transform>();
        check = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        check = !check;
        if (check) 
        {
            hammerOneTra.transform.DOPause();
            hammerOneTra.transform.DORotate(new Vector3(0, 0, 0), duration);
            hammerTwoTra.transform.DOPause();
            hammerTwoTra.transform.DORotate(new Vector3(0, 0, 0), duration);
            hammerOneMat.material = materials[0];
            hammerTwoMat.material = materials[0];
            targetMat.material = materials[0];
        }
        else
        {
            hammerOneTra.transform.DORotate(new Vector3(0, 0, 160), duration)
            .SetLoops(-1, LoopType.Yoyo);
            hammerTwoTra.transform.DORotate(new Vector3(0, 0, 160), duration)
                   .SetLoops(-1, LoopType.Yoyo);
            hammerOneMat.material = materials[1];
            hammerTwoMat.material = materials[1];
            targetMat.material = materials[1];
        }
    }
}