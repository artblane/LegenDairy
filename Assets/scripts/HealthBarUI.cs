using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class HealthBarUI : MonoBehaviour
{
public float Health, MaxHealth, Width, Height;

[SerializeField]
private RectTransform healthbar;

public void SetMaxHealth(float maxHealth){
    MaxHealth = maxHealth;
}
public void SetHealth(float health){
    Health = health;
    float newWidth = (Health / MaxHealth) * Width;
    healthbar.sizeDelta = new Vector2(newWidth, Height);
}
}