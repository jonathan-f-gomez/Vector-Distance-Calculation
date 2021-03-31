using System;
using System.Collections;

namespace Vector_Distance_Calculation
{
    class Program
    {
        public static Random rand = new Random();

        //Used as a reference
        public static double Hypotenuse(int x, int y) => (double)Math.Sqrt((x * x) + (y * y));


        /*2 Point (x, y) Euclidean distance      
        ============================*/

        //Creates an array or 100 two point vectors (x, y)
        public static Points[] PointsArray(Random point)
        {
            Points[] vectors = new Points[100];

            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new Points(point);                
            }
            
            return vectors;
        }

        //Uses the array of 100 objects to find the Euclidean distance
        public static Tuple<Points[], Points[], double> EuclideanDistance(Points[] vectors)
        {
            int length = vectors.Length;

            Points[] PointA = new Points[1];
            Points[] PointB = new Points[1];

            double curDistance = int.MaxValue;

            foreach (var item in vectors)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    int xs = vectors[i + 1].x - vectors[i].x;
                    int ys = vectors[i + 1].y - vectors[i].y;
                    
                    double distance = (double)Math.Sqrt((xs * xs) + (ys * ys));

                    if (distance <= curDistance)
                    {
                        PointA[0].x = vectors[i].x;
                        PointA[0].y = vectors[i].y;
                        
                        PointB[0].x = vectors[i + 1].x;
                        PointB[0].y = vectors[i + 1].y;
                        
                        curDistance = distance;
                    }
                }
            }

            return Tuple.Create(PointA, PointB, curDistance);
        }

        //Prints the two closest vectors and the distance between them
        public static void PrintArr(Tuple<Points[], Points[], double> point)
        {
            Console.WriteLine($"100 random (x, y) vectors\n" +
               $"Closest:   ({point.Item1[0].x}, {point.Item1[0].y}) & ({point.Item2[0].x}, {point.Item2[0].y})\n" +
               $"Distance:  {point.Item3}");
        }




        /*3 Point (x, y, z) Euclidean distance      
        ============================*/

        //Creates an array or 1000 three point vectors (x, y, z)
        public static ThreePoints[] ThreePointsArray(Random point)
        {
            ThreePoints[] vectors = new ThreePoints[1000];

            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new ThreePoints(point);
            }

            return vectors;
        }

        //Uses the array of 1000 objects to find the Euclidean distance
        public static Tuple<ThreePoints[], ThreePoints[], double> EuclideanDistance(ThreePoints[] vectors)
        {
            int length = vectors.Length;

            double[] result = new double[length - 1];

            ThreePoints[] threePointA = new ThreePoints[1];
            ThreePoints[] threePointB = new ThreePoints[1];


            double curDistance = int.MaxValue;

            foreach (var item in vectors)
            {
                for (int i = 0; i < length - 1; i++)
                {
                    int xs = vectors[i + 1].x - vectors[i].x;
                    int ys = vectors[i + 1].y - vectors[i].y;
                    int zs = vectors[i + 1].z - vectors[i].z;

                    double distance = (double)Math.Sqrt((xs * xs) + (ys * ys) + (zs * zs));

                    if (distance <= curDistance)
                    {
                        threePointA[0].x = vectors[i].x;
                        threePointA[0].y = vectors[i].y;
                        threePointA[0].z = vectors[i].z;

                        threePointB[0].x = vectors[i + 1].x;
                        threePointB[0].y = vectors[i + 1].y;
                        threePointB[0].z = vectors[i + 1].z;

                        curDistance = distance;
                    }
                }
            }

            return Tuple.Create(threePointA, threePointB, curDistance);
        }

        //Prints the two closest vectors and the distance between them
        public static void PrintArr(Tuple<ThreePoints[], ThreePoints[], double> point)
        {
            Console.WriteLine($"\n1000 random (x, y, z) vectors\n" +
                $"Closest:   ({point.Item1[0].x}, {point.Item1[0].y}, {point.Item1[0].z}) & ({point.Item2[0].x}, {point.Item2[0].y}, {point.Item2[0].z})\n" +
                $"Distance:  {point.Item3}");
        }


        public static void RunMe()
        {
            var twoPoint = EuclideanDistance(PointsArray(rand));
            var threePoint = EuclideanDistance(ThreePointsArray(rand));

            PrintArr(twoPoint);
            PrintArr(threePoint);
        }

        

        static void Main(string[] args)
        {
            //This is a combined effort by the 3 Amigos. Bradley, Brenden and Jon G
            RunMe();
        }
    }
}
