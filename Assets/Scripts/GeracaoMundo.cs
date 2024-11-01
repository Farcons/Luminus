using UnityEngine;

public class GeracaoMundo : MonoBehaviour
{
    private readonly GameObject tile;
    private readonly int rows, columns;
    private Vector3 position;

    public GeracaoMundo(Vector3 p,
                        GameObject g,
                        int r,
                        int c)
    {
        position = p;
        tile = g;
        rows = r;
        columns = c;
    }

    public void CreateFloor()
    {
        for (int r = 0; r < rows * 2; r += 2)
        {
            position = new Vector3(position.x, position.y, r);

            for (int c = 0; c < columns * 2; c += 2)
            {
                position = new Vector3(c, position.y, position.z);
                Instantiate(tile, position, Quaternion.identity);
            }
        }
    }
}
