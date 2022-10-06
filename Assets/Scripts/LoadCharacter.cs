using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;
    private GameObject lastCharacter;


    public void GoCharacter()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = characterPrefabs[selectedCharacter];
        if (lastCharacter != null)
        Destroy(lastCharacter);
        lastCharacter = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
    }
}
