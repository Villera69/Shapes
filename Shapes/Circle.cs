public class Circle : Shape
{
    double radius = 1;

    public Circle(){}

    public override void Draw(){
    }

    public override void Erase(){
    }
    public double GetRadius(){
        return radius;
    }

    public void SetRadius(double radius){
        this.radius = radius;
    }

    public override void Zoom (double amount){
    }
}