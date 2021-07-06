using DG.Tweening;
using UnityEngine;

public class BlockUp : MonoBehaviour
{
    public Material[] materials;
    public float duration;

    MeshRenderer targetMat;
    MeshRenderer blockMat;
    Transform blockTra;
    bool check;

    void Start()
    {
        var childBlock = transform.GetChild(0).gameObject;
        targetMat = GetComponent<MeshRenderer>();
        blockMat = childBlock.GetComponent<MeshRenderer>();
        blockTra = childBlock.GetComponent<Transform>();
        check = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        check = !check;
        if (check)
        {
            blockTra.DOLocalRotate(new Vector3(-22.2f,0f,0f),duration).SetAutoKill(false);
            blockMat.material = materials[0];
            targetMat.material = materials[0];
        }
        else
        {
            blockTra.DOPlayBackwards();
            blockMat.material = materials[1];
            targetMat.material = materials[1];
        }
    }
}
