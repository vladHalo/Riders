using DG.Tweening;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Material[] materials;
    public float duration;
    public GameObject doorLeft;
    public GameObject doorRight;

    MeshRenderer doorLeftMat;
    MeshRenderer doorRightMat;
    Transform doorLeftTra;
    Transform doorRightTra;
    MeshRenderer target;
    bool check;

    void Start()
    {
        doorLeftMat = doorLeft.GetComponent<MeshRenderer>();
        doorRightMat = doorRight.GetComponent<MeshRenderer>();
        doorLeftTra = doorLeft.GetComponent<Transform>();
        doorRightTra = doorRight.GetComponent<Transform>();
        target = GetComponent<MeshRenderer>();
        check = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        check = !check;
        if (check)
        {
            doorLeftTra.DOLocalRotate(new Vector3(0, -90, 0), duration).SetAutoKill(false);
            doorRightTra.DOLocalRotate(new Vector3(0, 90, 0), duration).SetAutoKill(false);
            doorLeftMat.material = materials[0];
            doorRightMat.material = materials[0];
            target.material = materials[0];
        }
        else
        {
            doorLeftTra.DOPlayBackwards();
            doorRightTra.DOPlayBackwards();
            doorLeftMat.material = materials[1];
            doorRightMat.material = materials[1];
            target.material = materials[1];
        }
    }
}
