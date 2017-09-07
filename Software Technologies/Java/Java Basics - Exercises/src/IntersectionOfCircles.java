import java.util.Arrays;
import java.util.Scanner;

public class IntersectionOfCircles {
    static class Circle
    {
        private Point Center;
        private int Radius;

        public Point getCenter() {
            return Center;
        }

        public void setCenter(Point center) {
            Center = center;
        }

        public int getRadius() {
            return Radius;
        }

        public void setRadius(int radius) {
            Radius = radius;
        }
    }
    static class Point
    {
        private int X;
        private int Y;

        public int getX() {
            return X;
        }

        public void setX(int x) {
            X = x;
        }

        public int getY() {
            return Y;
        }

        public void setY(int y) {
            Y = y;
        }
    }
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        Circle c1 = ReadCircle(scanner);
        Circle c2 = ReadCircle(scanner);

        System.out.println(Intersect(c1,c2) ? "Yes" : "No");
    }

    private static boolean Intersect(Circle c1, Circle c2)
    {
        double distance = GetDistanceBetweenCircleCenters(c1.Center, c2.Center);

        if (distance <= c1.Radius + c2.Radius)
            return true;
        else
            return false;
    }

    private static double GetDistanceBetweenCircleCenters(Point p, Point q)
    {
        double a = p.X - q.X;
        double b = p.Y - q.Y;
        double distance = Math.sqrt(a * a + b * b);
        return distance;
    }

    private static Circle ReadCircle(Scanner scanner)
    {
        int[] inputLine = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        Circle circle = new Circle();

        circle.Radius = inputLine[2];

        Point point = new Point();
        point.X = inputLine[0];
        point.Y = inputLine[1];

        circle.Center = point;

        return circle;
    }
}

