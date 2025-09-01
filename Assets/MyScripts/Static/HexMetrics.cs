using UnityEngine;

public class HexMetrics
{
    // 六边形中心到外接圆的半径
    public const float outerRadius = 10f;

    // 六边形中心到六边形边的距离
    public const float innerRadius = outerRadius * 0.866025404f;

    // 这是构建的一个尖顶六边形，从顶部开始顺时针设置
    public static Vector3[] corners =
    {
        new Vector3(0, 0, outerRadius),                     // 正上方的点
        new Vector3(innerRadius, 0, 0.5f * outerRadius),    // 右上方的点
        new Vector3(innerRadius, 0, -0.5f * outerRadius),   // 右下方的点
        new Vector3(0, 0, -outerRadius),                    // 正下方的点
        new Vector3(-innerRadius, 0, -0.5f * outerRadius),  // 左下方的点
        new Vector3(-innerRadius, 0, 0.5f * outerRadius),   // 左上方的点
        new Vector3(0f, 0f, outerRadius)                    // 在之后的循环时防止IndexOutOfRangeException异常
    };

}
