using UnityEngine;

public class WinLoseScreen : MonoBehaviour
{
    public GameObject loseScreen;
    public GameObject winScreen;
    public void CheckHP(float hp, bool isPlayer)
    {
        if (hp <= 0 && isPlayer) { loseScreen.SetActive(true); Time.timeScale = 0; }
        else if (hp <= 0 && !isPlayer) { winScreen.SetActive(true); Time.timeScale = 0; }
    }
}
