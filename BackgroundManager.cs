using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    public static BackgroundManager Instance;
    public Camera mainCamera;
    public Color[] backgroundColors;
    private int currentThemeIndex = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if (PlayerPrefs.HasKey("BackgroundThemeIndex"))
        {
            currentThemeIndex = PlayerPrefs.GetInt("BackgroundThemeIndex");
        }

        ApplyTheme();
    }

    private void ApplyTheme()
    {
        mainCamera.backgroundColor = backgroundColors[currentThemeIndex];

    }
}
