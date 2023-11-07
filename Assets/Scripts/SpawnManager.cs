using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public SunriseFactory sunriseFactory;
    public DayFactory dayFactory;
    public SunsetFactory sunsetFactory;
    public NightFactory nightFactory;
    private GameObject spawnedObject;
    private void Start()
    {
        sunriseFactory = GetComponentInChildren<SunriseFactory>();
        dayFactory = GetComponentInChildren<DayFactory>();
        sunsetFactory = GetComponentInChildren<SunsetFactory>();
        nightFactory = GetComponentInChildren<NightFactory>();
    }
    public void SpawnBasedOnTimeOfDay(string timeOfDay)
    {
        AbstractFactory factory=null;
        GameObject spawnedPrefab;

        switch (timeOfDay)
        {
            case "Sunrise":
                factory = sunriseFactory;
                break;
            case "Daytime":
                factory = dayFactory;
                break;
            case "Sunset":
                factory = sunsetFactory;
                break;
            case "Night":
                factory = nightFactory;
                break;
        }

        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
        }
        if (factory != null)
        {
            spawnedPrefab = factory.CreateObject();
            spawnedPrefab.transform.position = new Vector3(462.25f, 242.25f, 0f);
            spawnedObject = spawnedPrefab;
        }
    }
}
