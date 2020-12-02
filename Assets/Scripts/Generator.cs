using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public Transform player;
    public Chunk[] Chunks;
    private List<Chunk> spawnedChunks = new List<Chunk>();
    public Chunk firstChunk;
    
    
    void Start()
    {
        spawnedChunks.Add(firstChunk);
    }
    void Update()
    {
        if (player.position.x+15> spawnedChunks[spawnedChunks.Count - 1].endPoint.position.x)
        {
            CreateChunk();
        }
    }
    private void CreateChunk()
    {
        Chunk createdchunk = Instantiate(Chunks[Random.Range(0, Chunks.Length)]);
        createdchunk.transform.position = spawnedChunks[spawnedChunks.Count - 1].endPoint.position - createdchunk.beginpoint.localPosition;
        spawnedChunks.Add(createdchunk);
        if (spawnedChunks.Count >= 5)
        {
            Destroy(spawnedChunks[0].gameObject);
            spawnedChunks.RemoveAt(0);
        }
        
    }
}
