using UnityEngine;

public class LineSpeed : MonoBehaviour
{
    public Material[] materials;
    [HideInInspector]
    public bool check;
    public MeshRenderer lineMat;

    MeshRenderer target;

    void Start()
    {
        target = GetComponent<MeshRenderer>();
        check = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        check = !check;
        if (check)
        {
            lineMat.material = materials[2];
            target.material = materials[0];
        }
        else
        {
            lineMat.material = materials[3];
            target.material = materials[1];
        }
    }
}
