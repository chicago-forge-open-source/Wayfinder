using System.Collections;
using UnityEngine;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using Mapbox.Unity.MeshGeneration.Factories;
using Mapbox.Unity.Utilities;
using System.Collections.Generic;
using System.Linq;
using Mapbox.Directions;
using Mapbox.Unity;
using Mapbox.Unity.Ar.Utilities;
using Mapbox.Unity.MeshGeneration.Data;
using Mapbox.Unity.MeshGeneration.Modifiers;

public class CameraScript : MonoBehaviour
{
    
    [SerializeField]
    AbstractMap _map;
    

    private GameObject _player;

    protected virtual void Awake()
    {
        _player = GameObject.Find("Player");
        
        if (_map == null)
        {
            _map = FindObjectOfType<AbstractMap>();
        }
    }

    void Start()
    {
//        _map
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private Vector2d GetPlayerPos(GameObject player)
    {
        var pos = player.transform.position;
        return new Vector2d(pos.x, pos.y);
    }

    public bool IsNotValidTouch(int touchCount, TouchPhase phase)
    {
        return touchCount < 1 || phase != TouchPhase.Began;
    }
}