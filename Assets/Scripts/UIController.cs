using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public SpawnManager spawnManager;
    public TextMeshProUGUI timeText;

    private void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
    }

    public void OnSunriseButtonClicked()
    {
        SpawnObjects("Sunrise");
    }

    public void OnDaytimeButtonClicked()
    {
        SpawnObjects("Daytime");
    }

    public void OnSunsetButtonClicked()
    {
        SpawnObjects("Sunset");
    }

    public void OnNightButtonClicked()
    {
        SpawnObjects("Night");
    }

    private void SpawnObjects(string timeOfDay)
    {
        timeText.text = "It's " + timeOfDay;

        spawnManager.SpawnBasedOnTimeOfDay(timeOfDay);
    }
}
