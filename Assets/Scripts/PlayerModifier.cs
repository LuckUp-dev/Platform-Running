using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifier : MonoBehaviour
{

    [SerializeField] int _widht;
    [SerializeField] int _height;

    float _widthMuliplier = 0.0005f;
    float _heightMuliplier = 0.01f;


    [SerializeField] Renderer _renderer;

    [SerializeField] Transform _topspine;
    [SerializeField] Transform _bottomspine;

    [SerializeField] Transform _colliderTransform;


    private void Start()
    {
        SetWidth(Progress.Instance.Width);
        SetHeight(Progress.Instance.Height);
    }

    // Update is called once per frame
    void Update()
    {
       float _offsetY = _height * _heightMuliplier + 0.17f;

        _topspine.position = _bottomspine.position + new Vector3(0, _offsetY, 0);
        _colliderTransform.localScale = new Vector3(1, 1.84f + _height * _heightMuliplier, 1);

        if (Input.GetKeyDown(KeyCode.W))
        {
            AddWith(20);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            AddHeight(20);
        }

    }

    public void AddWith(int value)
    {
        _widht += value;
        UpdateWidth();
    }

    public void AddHeight(int value)
    {
        _height += value;

    }

    public void SetWidth(int value)
    {
        _widht = value;
        UpdateWidth();
    }

    public void SetHeight(int value)
    {
        _height = value;
    }

    public void HitBarrier()
    {
        if (_height>0)
        {
            _height -= 50;
        }
        else if (_widht > 0)
        {
            _widht -= 50;
            UpdateWidth();
        }
        else
        {
            Die();
        }
    }

    void UpdateWidth()
    {
        _renderer.material.SetFloat("_PushValue", _widht * _widthMuliplier);
    }

    void Die()
    {
        FindObjectOfType<GameManager>().ShowFinishWindow();
        Destroy(gameObject);
    }

}
