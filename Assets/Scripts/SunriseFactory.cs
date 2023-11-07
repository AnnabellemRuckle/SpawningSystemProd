using UnityEngine;

public class SunriseFactory : AbstractFactory
{
   public GameObject sunrisePrefab;

    public override GameObject CreateObject()
    {
        GameObject spawnedObject = Instantiate(sunrisePrefab);
        return spawnedObject;
    }
}
