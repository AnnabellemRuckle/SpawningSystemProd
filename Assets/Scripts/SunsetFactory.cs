using UnityEngine;

public class SunsetFactory : AbstractFactory
{
    public GameObject sunsetPrefab;
    public override GameObject CreateObject()
    {
        GameObject spawnedObject = Instantiate(sunsetPrefab);
        return spawnedObject;
    }
}
