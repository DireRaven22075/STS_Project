using UnityEngine;

public class TestGUI : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _objects = new GameObject[2];

    private LineRenderer _lineRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _lineRenderer = this.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _lineRenderer.SetPosition(0, _objects[0].transform.position);
        _lineRenderer.SetPosition(1, _objects[1].transform.position);
    }
}
