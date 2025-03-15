using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class playerstat : MonoBehaviour
{
    public float health = 100;
    public float maxHealth = 100;
    public Slider healthSlider;

    public TextMeshProUGUI InfoText;
    void Start()
    {
        health = maxHealth;
        healthSlider.value = 1;
    }

    public void TakeDamage(float damage, string reason)
    {
        health -= damage;
        healthSlider.value = health / maxHealth;
        if (health <= 0)
        {
            Die(reason);
        }
    }
    void Die(string reason)
    {
        Debug.Log("Player died due to "+reason);
        //restart level
    }
    public void UpdateInfoText(string text){
        InfoText.text = text;
    }
}
