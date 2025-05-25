using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   
    void Start()
    {
        InvokeRepeating("RestartGame", 60f, 60f); // ��������� ������ 60 ������
    }

   
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


//�� ������� �� ������

//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Restart : MonoBehaviour
//{
//   
//    public void RestartGame()
//    {
//        // ��������� ������� ����� ������ �� � �������
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//    }
//}
