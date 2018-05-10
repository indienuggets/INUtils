using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ColorCycler))]
class ColorCyclerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();


        if (GUILayout.Button("Cycle"))
        {
            ColorCycler cycler = (ColorCycler)target;
            cycler.Cycle();
        }
    }
}
