using UnityEngine.UI;
using UnityEngine;

public class CharacterHp : MonoBehaviour
{
    public WinLoseScreen winLoseScreen;
    public Slider hpSlider;
    public float hpValue;

    private void Start()
    {
        hpSlider.maxValue = hpValue;
        hpSlider.value = hpSlider.maxValue;
    }

    public void GetDamage(float damage)
    {
        hpValue -= damage;
        winLoseScreen.CheckHP(hpValue, true);
        hpSlider.value = hpValue;
    }
}
