using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph
{
    private static List<Vector2Int> neighbours4directions = new List<Vector2Int>
    {
        new Vector2Int(0, 1), //UP
        new Vector2Int(1, 0), //RIGHT
        new Vector2Int(0, -1), //DOWN
        new Vector2Int(-1, 0) //LEFT
    };

    private static List<Vector2Int> neighbours8directions = new List<Vector2Int>
    {
        new Vector2Int(0, 1), //UP
        new Vector2Int(1, 0), //RIGHT
        new Vector2Int(0, -1), //DOWN
        new Vector2Int(-1, 0), //LEFT

        new Vector2Int(1, 1), //DIAGONAl
        new Vector2Int(1, -1), //DIAGONAl
        new Vector2Int(-1, 1), //DIAGONAl
        new Vector2Int(-1, -1) //DIAGONAl
    };

    List<Vector2Int> graph;

    public Graph(IEnumerable<Vector2Int> vertices) 
    {
        graph = new List<Vector2Int>(vertices);
    }

    public List<Vector2Int> GetNeighbours4directions(Vector2Int startPosition)
    {
        return GetNeighbours(startPosition, neighbours4directions);
    }

    public List<Vector2Int> GetNeighbours8directions(Vector2Int startPosition)
    {

        return GetNeighbours(startPosition, neighbours8directions);

    }

    private List<Vector2Int> GetNeighbours(Vector2Int startPosition, List<Vector2Int> neighbourOffsetList)
    {
        List<Vector2Int> neighbours = new List<Vector2Int>();
        foreach (var neighbourDirection in neighbourOffsetList)
        {
            Vector2Int potentialNeighbour = startPosition + neighbourDirection;
            if (graph.Contains(potentialNeighbour))
                neighbours.Add(potentialNeighbour);
        }
        return neighbours;
    }
}
