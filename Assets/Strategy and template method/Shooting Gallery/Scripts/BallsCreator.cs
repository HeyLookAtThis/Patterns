using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BallsStorage))]
public class BallsCreator : MonoBehaviour
{
    [SerializeField] private VictoryInitializer _victorySetter;
    [SerializeField] private Ball[] _prefabs;

    private ShootGalleryGrid _grid;
    private UnityAction<Ball> _oneDone;
    private BallsStorage _storage;

    public event UnityAction<Ball> OneDone
    {
        add => _oneDone = value;
        remove => _oneDone = value;
    }

    private void Awake()
    {
        _grid = new ShootGalleryGrid();
        _storage = GetComponent<BallsStorage>();
    }

    private void OnEnable()
    {
        _victorySetter.Done += Run;
    }

    private void OnDisable()
    {
        _victorySetter.Done -= Run;
    }

    private void Run()
    {
        while (_grid.CellsCount > 0)
        {
            Ball ball = Instantiate(GetRandomBrefab(), _grid.GetCell(), Quaternion.identity, this.transform);
            _oneDone?.Invoke(ball);
            _storage.Add(ball);
        }
    }

    private Ball GetRandomBrefab()
    {
        Ball ball = _prefabs[Random.Range(0, _prefabs.Length)];

        if (_storage.Content.Count < _prefabs.Length)
            ball = GetUniqueBall(ball);

        return ball;
    }

    private Ball GetUniqueBall(Ball ball)
    {
        bool isRepeat = true;

        while (isRepeat)
        {
            ball = _prefabs[Random.Range(0, _prefabs.Length)];

            if (_storage.Content.FirstOrDefault(ballInList => ballInList.Color == ball.Color) == null)
                isRepeat = false;
        }

        return ball;
    }
}
