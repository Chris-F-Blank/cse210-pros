using System.ComponentModel.DataAnnotations;

class Course
{
    public string _classCourse;
    public string _className;
    public int _credits;
    public string _color;

    //method
    public void Display(){
        Console.WriteLine ($"{_classCourse} {_className} {_credits} {_color}");
    }
}
