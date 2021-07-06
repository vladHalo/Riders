using UnityEngine;

public class LineTrigger : MonoBehaviour
{
    public LineSpeed lineSpeed;
    public MoveHero moveHero;
    public float speedChange;

    float speedConst;

    private void Start()
    {
        speedConst = moveHero.speed;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        if(lineSpeed.check)
            moveHero.speed = speedConst + speedChange;
        else
            moveHero.speed = speedConst - speedChange;
    }

    private void OnTriggerExit(Collider other) => moveHero.speed = speedConst;
}
