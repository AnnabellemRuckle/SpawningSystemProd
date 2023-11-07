using UnityEngine;

public class NightFactory : AbstractFactory
{
    public GameObject nightPrefab;

    public override GameObject CreateObject()
    {
        GameObject spawnedObject = Instantiate(nightPrefab);
        return spawnedObject;
    }
}
