using UnityEngine;

public class GameManager : MonoBehaviour
{  // 建立欄位標題 
    [Header ("綿羊")]
     public Transform Sheep;

    [Header ("鴨子")]
    public Transform Duck;

    [Header ("虛擬搖桿")]
    public FixedJoystick Joystick;

    [Header ("旋轉速度"),Range(0.1f,10f)]
    public float turn=1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.01f;

    // 開始事件(初始設定)
    private void Start()
    {
        print ("開事件執行");  
    }
    // 更新事件(影格) //控制旋轉、移動、縮放或玩家輸入
    private void Update()
    {   print ("更新事件");
        print (Joystick.Vertical);

        Sheep.Rotate (0, Joystick.Horizontal*turn, 0);
        Duck.Rotate (0, Joystick.Horizontal*turn, 0);

        Sheep.localScale+=new Vector3(1,1,1)*Joystick.Vertical*size;

    }
}
