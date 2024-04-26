using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class SpawnCircles : MonoBehaviour
{
    public GameObject circlePrefab; 
    public float spawnRadius = 5f; 
    public float spawnInterval = 1.5f; 

    void Start()
    {
        StartCoroutine(SpawnCircleRoutine());
    }

    IEnumerator SpawnCircleRoutine()
    {
        while (true)
        {
            Vector2 randomPosition = (Random.insideUnitCircle * spawnRadius) + (Vector2)transform.position;

            GameObject newCircle = Instantiate(circlePrefab, randomPosition, Quaternion.identity);

            Color randomColor = GetRandomColor();
            newCircle.GetComponent<SpriteRenderer>().color = randomColor;

            char randomChar = GetRandomLetter();
            newCircle.GetComponentInChildren<TextMeshProUGUI>().text = randomChar.ToString();

            yield return new WaitForSeconds(spawnInterval);
        }
    }
    Color GetRandomColor()
    {
        Color[] colors = { Color.red, Color.blue, Color.green };
        return colors[Random.Range(0, colors.Length)];
    }

    char GetRandomLetter()
    {
        return (char)Random.Range(97, 123);
    }
}






