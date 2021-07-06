using UnityEngine;
using DG.Tweening;

public class DoorLR : MonoBehaviour
{
    public Material []materials;
    public float duration;
    public GameObject door;

    MeshRenderer doorMat;
    Transform doorTra;
    MeshRenderer target;
    bool check;

    void Start() 
    {
        doorMat = door.GetComponent<MeshRenderer>();
        doorTra = door.GetComponent<Transform>();
        target = GetComponent<MeshRenderer>();
        check = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        check = !check;
        if (check)
        {
            doorTra.DOPlayBackwards();
            doorMat.material = materials[1];
            target.material = materials[1];
        }
        else
        {
            doorTra.DOLocalRotate(new Vector3(0, -180, 0), duration).SetAutoKill(false);
            doorMat.material = materials[0];
            target.material = materials[0];
        }
    }
}
