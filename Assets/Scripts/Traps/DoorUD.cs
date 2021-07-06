using DG.Tweening;
using UnityEngine;

public class DoorUD : MonoBehaviour
{
    public Material[] materials;
    public float duration;
    public GameObject door;

    Transform targetTra;
    Transform doorTra;
    MeshRenderer targetMat;
    MeshRenderer doorMat;
    bool check;

    void Start()
    {
        targetTra = GetComponent<Transform>();
        doorTra = door.GetComponent<Transform>();
        targetMat = GetComponent<MeshRenderer>();
        doorMat = door.GetComponent<MeshRenderer>();
        check = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        check = !check;
        if (check)
        {
            targetTra.DOMoveY(120, duration).SetAutoKill(false);
            doorTra.DOMoveY(66.28f, duration).SetAutoKill(false);
            doorMat.material = materials[0];
            targetMat.material = materials[0];
        }
        else
        {
            targetTra.DOPlayBackwards();
            doorTra.DOPlayBackwards();
            doorMat.material = materials[1];
            targetMat.material = materials[1];
        }
    }
}
