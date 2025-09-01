using UnityEditor;
using UnityEngine;

// 指定这是一个自定义绘制器，目标是 HexCoordinates 类型
// 每当 Inspector 里出现 HexCoordinates 字段时，就自动使用这个来绘制
[CustomPropertyDrawer(typeof(HexCoordinates))]
public class HexCoordinatesDrawer : PropertyDrawer
{
    // 在 Inspector 上绘制字段时会调用这个方法
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // 通过 SerializedProperty 取出 HexCoordinates 里的 x 和 z 值
        HexCoordinates coordinates = new HexCoordinates(
            property.FindPropertyRelative("x").intValue,
            property.FindPropertyRelative("z").intValue
        );

        // 给 Inspector 里加上前缀（比如变量名）
        position = EditorGUI.PrefixLabel(position, label);

        // 在 Inspector 面板里显示坐标的字符串
        EditorGUI.LabelField(position, coordinates.ToString());
    }
}