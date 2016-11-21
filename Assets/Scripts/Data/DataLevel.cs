using UnityEngine;
using System.Collections;

public class DataLevel : SingletonBehaviour<DataLevel>
{
    public GameObject MenuIconSate;
    public GameObject MenuSate;
    public GameObject MenuIconSate2;
    public GameObject MenuSate2;
    public GameObject InstructionPanel;
    public GameObject Oxford;
    public GameObject Bond;
    public GameObject Zeus;
    public GameObject Queens;
    public Material[] Matrerials;
    public GameObject ChangedPoparada ;
    public GameObject ChangedFlower_UP;
    public GameObject ChangedFlower_Down;
    public GameObject ChangedComfort_UP;
    public GameObject ChangedComfort_Down;
    public GameObject ChangedSofa_UP;
    public GameObject ChangedSofa_Down;
    public int StateOrientationScreen;
    public GameObject CurrentModel;
    public GameObject Target;
    public GameObject Hold;

    public int CountBlockPanel2;
    public GameObject ScrollPanel2;
    public GameObject ScrollPanel3;
    public GameObject Panel_1;
    public GameObject Panel_2;
    public GameObject Panel_3;
    public GameObject Screen1;
    public GameObject Screen2;
    public GameObject Screen3;
    public GameObject screenFoto;
    public GameObject sreenCamera;
    public GameObject screenExit_App;
    public GameObject []Label_Text_Panel2;
    public GameObject[] Label_Text_Panel3;
    public GameObject Arrow_Top_Right_Panel1;
    public GameObject Arrow_Top_Left_Panel2;
    public GameObject Arrow_Top_Left_Panel3;
    public GameObject ArrowLeftScrollPanel2;
    public GameObject ArrowRightScrollPanel2;
    public GameObject ArrowLeftScrollPanel3;
    public GameObject ArrowRightScrollPanel3;
    public GameObject Foto_panel2;
    public GameObject Foto_panel3;
    public GameObject Mail_panel2;
    public GameObject Mail_panel3;
    public GameObject Web_panel2;
    public GameObject Web_panel3;
    public int Count_Shaders;
    public int NumberModel;
    public GameObject Arrow_Up_Panel_1;
    public GameObject Arrow_Up_Panel_2;
    public GameObject Arrow_Up_Panel_3;
    public float Y_start_Panel1;
    public float Y_start_Panel2;
    public float Y_start_Panel3;
    public GameObject[] check_box_Panel1;
    public GameObject[] check_box_Panel2;
    public GameObject[] check_box_Panel3_UP;
    public GameObject[] check_box_Panel3_Down;
    private ContextStatePanel statePositionPanel1;
    private ContextStatePanel statePositionPanel2;
    private ContextStatePanel statePositionPanel3;
    private ContextStateSelectedPanel1 stateSelectedPanel1;
    private ContextStateSelectedPanel2 stateSelectedPanel2;
    private ContextStateSelectedPanel3_UP stateSelectedPanel3_UP;
    private ContextStateSelectedPanel3_Down stateSelectedPanel3_Down;
    private ContextStatePanel stateActivePanel1;
    private ContextStatePanel stateActivePanel2;
    private ContextStatePanel stateActivePanel3;
    private ContextStatePanel stateActivePanel_Foto;
    private ContextStatePanel stateActivePanel_Camera;
    private ContextStatePanel stateScrollPanel2;
    private ContextStatePanel stateArrowscrollPanel2;
    private ContextStatePanel stateActionPanel_ExitApp;

    private ContextStatePanel stateScrollPanel3;
    private ContextStatePanel stateArrowscrollPanel3;
    private ContextStatePanel stateMemuSate;
    private ContextStatePanel stateMemuSate2;
    
    public int CurrentNumberModel;
    public int CurrentShaderPanel2;
    public int CurrentShader_Flower_UP;
    public int CurrentShader_Flower_Down;
    public int CurrentShader_Comfort_UP;
    public int CurrentShader_Comfort_Down;
    public int CurrentShader_Sofa_UP;
    public int CurrentShader_Sofa_Down;
    public int CurrentBlockPanel_2;
    public int CurrentBlockPanel_3;

    public string PathScreenShot;
    // Use this for initialization
    private void Start()
    {
        CurrentBlockPanel_2 = 1;
        CurrentBlockPanel_3 = 1;
        CurrentShader_Flower_UP=46;
        CurrentShader_Flower_Down=67;
        CurrentShader_Comfort_UP=34;
        CurrentShader_Comfort_Down=49;
        CurrentShader_Sofa_UP=34;
        CurrentShader_Sofa_Down=12;
        Y_start_Panel1 = Panel_1.transform.localPosition.y;
        Y_start_Panel2 = Panel_2.transform.localPosition.y;
        Y_start_Panel3 = Panel_3.transform.localPosition.y;
        for (int i = 0; i < check_box_Panel2.Length; i++)
        {
            check_box_Panel2[i].GetComponentInParent<ButtonSelectedPanel_2>().Mode = i;
        }
        for (int i = 0; i < check_box_Panel3_Down.Length; i++)
        {
            check_box_Panel3_Down[i].GetComponentInParent<ButtonSelectedPanel_3_Down>().Mode = i;
        }
        for (int i = 0; i < check_box_Panel3_UP.Length; i++)
        {
            check_box_Panel3_UP[i].GetComponentInParent<ButtonSelectedPanel_3_UP>().Mode = i;
        }
        statePositionPanel1 = new ContextStatePanel(new StatePositionUpForPanel1());
        //statePositionPanel2 = new ContextStatePanel(new StatePositionUpForPanel2());
       // statePositionPanel3 = new ContextStatePanel(new StatePositionUpForPanel3());

       
        stateSelectedPanel2 = new ContextStateSelectedPanel2(new ConcretStateSelectedPanel2(12));
      //  stateSelectedPanel3_UP = new ContextStateSelectedPanel3_UP(new ConcretStateSelectedPanel3_UP(0));
      //  stateSelectedPanel3_Down = new ContextStateSelectedPanel3_Down(new ConcretStateSelectedPanel3_Down(0));

       

        stateScrollPanel2=new ContextStatePanel(new StateRightScrollShaderPanel2());
        stateArrowscrollPanel2=new ContextStatePanel(new StateArrowRightPanel2());

        stateScrollPanel3 = new ContextStatePanel(new StateRightScrollShaderPanel3());
        stateArrowscrollPanel3 = new ContextStatePanel(new StateArrowRightPanel3());
        stateActivePanel1 = new ContextStatePanel(new StateActivePanel_1_Off());
        stateActivePanel2 = new ContextStatePanel(new StateActivePanel_2_Off());
        stateActivePanel3 = new ContextStatePanel(new StateActivePanel_3_Off());
        stateActivePanel_Foto=new ContextStatePanel(new StateActivePanel_Foto_Off());
        stateActivePanel_Camera=new ContextStatePanel(new StateActivePanel_Camera_Off());
        stateActionPanel_ExitApp=new ContextStatePanel(new StateActivePanel_Exit_Off());
        stateMemuSate=new ContextStatePanel(new StateActivePanel_MenuSite_Off());
        stateMemuSate2 = new ContextStatePanel(new StateActivePanel_MenuSite2_Off());
    }

    public void SetStartStatePanel1()
    {
        stateSelectedPanel1 = new ContextStateSelectedPanel1(new ConcretStateSelectedPanel1(0));
        InstructionPanel.SetActive(false);
    }
    public void SetSelectedPanel3(int up, int down)
    {
        stateSelectedPanel3_UP = new ContextStateSelectedPanel3_UP(new ConcretStateSelectedPanel3_UP(up));
        stateSelectedPanel3_Down = new ContextStateSelectedPanel3_Down(new ConcretStateSelectedPanel3_Down(down));
    }
    public void SetPositionPanel2()
    {
        statePositionPanel2 = new ContextStatePanel(new StatePositionUpForPanel2());
    }
    public void SetPositionPanel3()
    {
        statePositionPanel3 = new ContextStatePanel(new StatePositionUpForPanel3());
    }

    public void SetMenuSateOff()
    {
        stateMemuSate = new ContextStatePanel(new StateActivePanel_MenuSite_Off());
    }
    public void SetMenuSateOn()
    {
        stateMemuSate = new ContextStatePanel(new StateActivePanel_MenuSite_On());
    }
    public void SetMenuSateOff2()
    {
        stateMemuSate2 = new ContextStatePanel(new StateActivePanel_MenuSite2_Off());
    }
    public void SetMenuSateOn2()
    {
        stateMemuSate2 = new ContextStatePanel(new StateActivePanel_MenuSite2_On());
    }
    public void ReguestArrowPanel2()
    {
        stateArrowscrollPanel2.Reguest();
    }
    public void ReguestMenuSatePanel()
    {
        stateMemuSate.Reguest();
    }
    public void ReguestMenuSatePanel2()
    {
        stateMemuSate2.Reguest();
    }
    public void ReguestScrollPanel2()
    {
        stateScrollPanel2.Reguest();
    }
    public void ReguestArrowPanel3()
    {
        stateArrowscrollPanel3.Reguest();
    }

    public void ReguestScrollPanel3()
    {
        stateScrollPanel3.Reguest();
    }
    public void ReguestPositionPanel_1()
    {
        statePositionPanel1.Reguest();
    }
    public void ReguestPositionPanel_2()
    {
        statePositionPanel2.Reguest();
    }
    public void ReguestPositionPanel_3()
    {
        statePositionPanel3.Reguest();
    }
    public void ReguestSelectedPanel_1(int mode)
    {
        stateSelectedPanel1.Reguest(mode);
    }
    public void ReguestSelectedPanel_2(int mode)
    {
        stateSelectedPanel2.Reguest(mode);
    }
    public void ReguestSelectedPanel_3_Dow(int mode)
    {
        stateSelectedPanel3_Down.Reguest(mode);
    }
    public void ReguestSelectedPanel_3_UP(int mode)
    {
        stateSelectedPanel3_UP.Reguest(mode);
    }
    public void ReguestSetActivePanel_1()
    {
        stateActivePanel1.Reguest();
    }
    public void ReguestSetActivePanel_2()
    {
        stateActivePanel2.Reguest();
    }
    public void ReguestSetActivePanel_3()
    {
        stateActivePanel3.Reguest();
    }
    public void ReguestSetActivePanel_Foto()
    {
        stateActivePanel_Foto.Reguest();
    }
    public void ReguestSetActivePanel_CAmera()
    {
        stateActivePanel_Camera.Reguest();
    }
    public void ReguestSetActivePanel_ExitApp()
    {
        stateActionPanel_ExitApp.Reguest();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
