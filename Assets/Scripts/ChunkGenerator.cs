using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkGenerator : MonoBehaviour
{
    public static ChunkGenerator instance;
    public Chunk chunkPrefab;
    public Transform startPoint;
    private List<Chunk> chunks = new List<Chunk>();

    void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        GenerateInitialChunks();
    }

    public void AddChunk()
    {
        Chunk newChunk = Instantiate(chunkPrefab);
        newChunk.transform.SetParent(transform, false);

        Vector3 spawnPosition = Vector3.zero;
        float randomY = Random.Range(-2.0f, 2.3f);

        if (chunks.Count == 0)
        {
            spawnPosition = startPoint.position;
        }
        else
        {
            spawnPosition = chunks[chunks.Count - 1].exitPoint.position;
        }

        spawnPosition.y = randomY;

        newChunk.transform.position = spawnPosition;
        newChunk.MoveStart();
        chunks.Add(newChunk);
    }

    public void RemoveOldestChunk()
    {
        Chunk oldestChunk = chunks[0];

        chunks.Remove(oldestChunk);
        Destroy(oldestChunk.gameObject);
    }

    public void GenerateInitialChunks()
    {
        for (int i = 0; i < 2; i++)
        {
            AddChunk();
        }
    }
}