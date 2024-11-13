using UnityEngine;
using UnityEngine.UI;

public class ChangeTheme : MonoBehaviour
{
    public Camera mainCamera;
    public Color[] backgroundColors;
    public Image backgroundImageUI;

    private int currentThemeIndex = 0;

    public void ChangeThemeChess()
    {
        currentThemeIndex = (currentThemeIndex + 1) % backgroundColors.Length;

        PlayerPrefs.SetInt("BackgroundThemeIndex", currentThemeIndex);
        PlayerPrefs.Save();

        ApplyTheme();
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("BackgroundThemeIndex"))
        {
            currentThemeIndex = PlayerPrefs.GetInt("BackgroundThemeIndex");
            
            if (currentThemeIndex < 0 || currentThemeIndex >= backgroundColors.Length)
            {
                currentThemeIndex = 0;
            }
        }

        ApplyTheme();
    }

    private void ApplyTheme()
    {
        if (backgroundColors.Length > 0)
        {
            mainCamera.backgroundColor = backgroundColors[currentThemeIndex];

        }
        else
        {
            Debug.LogError("Os arrays backgroundColors ou backgroundTextures estão vazios.");
        }
    }
}
