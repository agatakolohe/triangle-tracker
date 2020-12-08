namespace Triangle
{
  public class TriangleSides
  {
    public bool TriangleChecker(int side1, int side2, int side3)
    {
      if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
      {
        return true; //not a triangle
      }
      else if (side1 != side2 && side1 != side3 && side2 != side3)
      {
        return true; //scalene
      }     
      else if (side1 == side2 && side1 == side3)
      {
        return true; //equilateral
      } 
      else 
      {
        return (side1 == side2 || side1 == side3 || side2 == side3);
      }
    }      
  }
}

// (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)