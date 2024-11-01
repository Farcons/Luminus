using System;
using UnityEngine;

public class Mundo : MonoBehaviour
{
    public int Stage = 1;
    private float sizeReference = 0;
    public GameObject gameObject;
    public int rows;
    public int columns;

    private GeracaoMundo generate;

    void Start()
    {
        var (stageRows, stageColumns) = WorldSize();
        generate = new GeracaoMundo(new Vector3(0, 0, 0), gameObject, stageRows, stageColumns);
        generate.CreateFloor();
    }

    private (int stageRows, int stageColumns) WorldSize()
    {
        sizeReference = Stage * 0.2f;

        var _row = sizeReference + rows;
        var _columns = sizeReference + columns;

        return ((int)Math.Round(_row), (int)Math.Round(_columns));
    }
}
