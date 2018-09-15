# 贝塞尔曲线
文件分为两部分：
Bezier.cs：计算部分，返回的结果是曲线上的一个个点
BezierCurveDisplayer.cs：显示部分，通过OnDrawGizmos把计算返回的点连成线
实际使用时可以自写显示部分，或不使用显示部分，贝塞尔曲线也常用于数学计算
