using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class healthBar : MonoBehaviour
{
public float currentHealth, maxHealth, Width, Height;

[SerializeField]
private RectTransform healthbar;

public void SetMaxHealth(float maxHealth){
    maxHealth = maxHealth;
}
public void SetHealth(float currentHealth){
    currentHealth = currentHealth;
    float newWidth = (currentHealth / maxHealth) * Width;
    healthbar.sizeDelta = new Vector2(newWidth, Height);
}
}