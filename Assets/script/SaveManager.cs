using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    //Variables
    
    [SerializeField] Text _userNameText;
    [SerializeField] Text _userScoreText;
    [SerializeField] Text _userPositionText;

    [SerializeField] string _userName;
    [SerializeField] int _userScore;
    [SerializeField] Vector3 _userPosition;

    [SerializeField] Transform _player;

    [SerializeField] Transform _checkPoint1;
    [SerializeField] Transform _checkPoint2;
    [SerializeField] Transform _checkPoint3;
    [SerializeField] Transform _checkPoint4;

    [SerializeField] float _checkradius = 2f;

    bool _checked1;
    bool _checked2;
    bool _checked3;
    bool _checked4;







    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        
        _checked1 = Physics.CheckSphere(_checkPoint1.position, _checkradius);
        _checked2 = Physics.CheckSphere(_checkPoint2.position, _checkradius);
        _checked3 = Physics.CheckSphere(_checkPoint3.position, _checkradius);
        _checked4 = Physics.CheckSphere(_checkPoint4.position, _checkradius);
        
        
    }

    
    void Update()
    {
        if (_checked1 == true)
        {
            LoadData();
        }

        if (_checked2 == true)
        {
            LoadData();
        }

        if (_checked3 == true)
        {
            LoadData();
        }
        if (_checked4 == true)
        {
            LoadData();
        }
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("Name", _userName);
        PlayerPrefs.SetInt("Score", _userScore);
        PlayerPrefs.SetFloat("positionX", _userPosition.x);
        PlayerPrefs.SetFloat("positionY", _userPosition.y);
        PlayerPrefs.SetFloat("positionZ", _userPosition.z);
        
        LoadData();
    }

    void LoadData ()
    {
        _userNameText.text = "User Name: " + PlayerPrefs.GetString("Name","no name");
        _userScoreText.text = "Player Score: " + PlayerPrefs.GetInt("Score", 000).ToString();
        _userPositionText.text = "Player position: " + PlayerPrefs.GetFloat("positionX", 0).ToString() + "x " +
                                 PlayerPrefs.GetFloat("positionY", 0).ToString() + "y " +
                                 PlayerPrefs.GetFloat("positionZ", 0).ToString() + "z";
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("Name");
        PlayerPrefs.DeleteKey("Score");
        PlayerPrefs.DeleteKey("PositionX");
        PlayerPrefs.DeleteKey("positionY");
        PlayerPrefs.DeleteKey("positionZ");

        LoadData();
    }
}
