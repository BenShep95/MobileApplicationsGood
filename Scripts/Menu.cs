using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

    public Canvas MainMenu;
    public Canvas LeaderBoard;
    public Canvas Game;

	public GameObject countdown;

	void Start () {
        MainMenu.enabled = true;
        LeaderBoard.enabled = false;
        Game.enabled = false;
	}

    public void StartPress()
    {
        MainMenu.enabled = false;
        LeaderBoard.enabled = false;
        Game.enabled = true;

		countdown.SetActive (true);

        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().GameState = true;
    }

    public void LeaderBoardPress()
    {
        MainMenu.enabled = false;
        LeaderBoard.enabled = true;
        Game.enabled = false;
    }

    public void ExitPress()
    {
        Application.Quit();
    }

    public void BackPress()
    {
        MainMenu.enabled = true;
        LeaderBoard.enabled = false;
        Game.enabled = false;
    }
}
