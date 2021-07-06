using UnityEngine;

public class DeadHero : MonoBehaviour
{
    public Collider [] col;
    public Rigidbody[] rb;
    public Animator animH;
    public MeshCollider horse;
    public MoveHero moveHero;
    //public MeshCollider rider;

    private void OnTriggerEnter(Collider other)
    {
        animH.enabled = false;
        //animR.enabled = false;

        horse.enabled = false;
        //rider.enabled = false;

        for (int i = 0; i < rb.Length; i++)
        {
            rb[i].isKinematic = false;
            col[i].enabled = true;
        }
        moveHero.speed = 0;
    }
}
