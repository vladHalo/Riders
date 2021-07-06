using UnityEngine;

public class RefreshLvl : MonoBehaviour
{
	public GameObject hero;
	public GameObject startText;
	public GameObject refreshBtn;
	public TreesCreate treesCreate;

	GameObject gun;
	MoveHero moveHero;
	Vector3 startPos;

	private void Start()
	{
		startPos = hero.transform.position;
		moveHero = hero.GetComponent<MoveHero>();
		gun = hero.transform.GetChild(3).gameObject;
	}

	public void NewLevel()
	{
		treesCreate.CreateTrees();

		gun.SetActive(true);
		startText.SetActive(true);
		moveHero.enabled = true;
		refreshBtn.SetActive(false);
		hero.transform.position = startPos;
	}
}
