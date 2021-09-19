using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    private Tower _placedTower;
    private Tower tower;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_placedTower != null)
        {
            return;

        }
        Tower tower = collision.GetComponent<Tower>();

        if (tower != null)
        {
            tower.SetPlacePosition(transform.position);
            _placedTower = tower;
            LevelManager.Instance.BuyTower(tower);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)

    {

        if (_placedTower == null)

        {

            return;

        }

        
        _placedTower.SetPlacePosition(null);

        _placedTower = null;

    }
}
