using UnityEngine;

public class FinishCheck : MonoBehaviour
{
	public GameObject hero;
	public GameObject refreshBtn;
	
	Animator animH;
	Animator animR;
	GameObject gun;
	MoveHero moveHero;

	private void Start()
	{
		moveHero = hero.GetComponent<MoveHero>();
		animH = hero.transform.GetChild(0).GetComponent<Animator>();
		animR = hero.transform.GetChild(1).GetComponent<Animator>();
		gun = hero.transform.GetChild(2).gameObject;
	}


	private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.layer==7)
        {
			moveHero.speed = 0;
			moveHero.run = false;

			animH.SetBool("Run", false);
			animR.SetBool("Run", false);
			
			gun.SetActive(false);
            refreshBtn.SetActive(true);
			moveHero.enabled = false;
        }
    }
}