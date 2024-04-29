using System.Collections.Generic;
using UnityEngine;

public class ShootGalleryGrid
{
    private const int Size = 3;

    private Queue<Vector3> _cells;

    public int CellsCount => _cells.Count;

    public ShootGalleryGrid()
    {
        Initialize();
    }

    public Vector3 GetCell()
    {
        return _cells.Dequeue();
    }

    private void Initialize()
    {
        float zero = 0f;

        _cells = new Queue<Vector3>();

        for (int i = -Size; i <= Size; i += Size)
            for(int j = -Size; j <= Size; j += Size)
                _cells.Enqueue(new Vector3(i, zero, j));
    }
}
