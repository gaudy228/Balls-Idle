using UnityEngine;

public class Tutor : MonoBehaviour
{
    [SerializeField] private GameObject[] _tutorText;
    [SerializeField] private GameObject _tutor;
    private int _tutorIndex;
    [SerializeField] private RefreshBlocks _refreshBlocks;
    public void Next()
    {
        Clear();
        _tutorIndex++;
        if(_tutorIndex >= _tutorText.Length)
        {
            Skip();
        }
        else
        {
            _tutorText[_tutorIndex].SetActive(true);
        }
    }
    private void Clear()
    {
        for (int i = 0; i < _tutorText.Length; i++)
        {
            _tutorText[i].SetActive(false);
        }
    }
    public void Skip()
    {
        Clear();
        _tutorIndex = 0;
        _tutorText[_tutorIndex].SetActive(true);
        _tutor.SetActive(false);
    }
    public void OpenTutor()
    {
        if (!_refreshBlocks.BossIsActive)
        {
            _tutor.SetActive(true);
        }
    }
}
