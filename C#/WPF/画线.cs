//xaml
<Canvas Name="Canvas" Grid.Row="1" Margin="5" MouseWheel="Canvas_OnMouseWheel" Background="White" MouseLeftButtonDown="Canvas_OnMouseLeftButtonDown" MouseLeftButtonUp="Canvas_OnMouseLeftButtonUp"></Canvas>

//cs
protected void DrawLine(Point startPoint,Point endPoint)
{
    LineGeometry coodLineGeometry = new LineGeometry();
    coodLineGeometry.StartPoint = startPoint;
    coodLineGeometry.EndPoint = endPoint;

    Path coodPath = new Path();
    coodPath.Stroke = Brushes.Black;
    coodPath.StrokeThickness = 1;
    coodPath.Data = coodLineGeometry;

    Canvas.Children.Add(coodPath);
}