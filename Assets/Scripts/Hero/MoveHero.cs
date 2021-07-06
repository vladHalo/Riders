using UnityEngine;

public class MoveHero : MonoBehaviour
{
    public GameObject startText;
    public GameObject gun;
    public Animator animH;
    public Animator animR;
    public float speed;
    [HideInInspector]
    public bool run = false;

    float startSpeed;

    private void Start()
    {
        startSpeed = speed;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            run = true;
            speed = startSpeed;
            startText.SetActive(false);
            animH.SetBool("Run",true);
            animR.SetBool("Run", true);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
            gun.SetActive(true);

        if (run)
            transform.Translate(new Vector3(0,0,1).normalized * speed);
    }
}
