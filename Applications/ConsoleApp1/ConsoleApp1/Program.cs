using System;
using System.Collections.Generic;
class Polygone1
{
    /*
                          Structure Point
    */

    /*
    Structure d'un point en 2D contenant ses coordonnees
    @champ x : abscisse (double) du point
    @champ y : ordonnee (double) du point
    */
    public struct Point
    {
        public double x;
        public double y;
        public double z;
    }

    /*
      affiche un polygone
      @param poly: le polygone a afficher
    */
    public static void afficher_polygone(List<Point> polygone)
    {
        if (polygone.Count != 0)
        {
            Console.Write("(" + polygone[0].x + "," + polygone[0].y + "," + polygone[0].y+")");
        }
        for (int i = 1; i < polygone.Count; i++)
        {
            Console.Write("--(" + polygone[i].x + "," + polygone[i].y + "," + polygone[0].y + ")");
        }
        Console.WriteLine();
    }

    /*
      retourne le perimetre d un polygone
      @param poly: le polygone
      @return : le perimetre de poly
    */
    public static double longueur_polygone(List<Point> polygone)
    {
        double somme = 0;
        for (int i = 0; i < polygone.Count - 1; i++)
        {
            somme += Math.Sqrt((polygone[i + 1].x - polygone[i].x) * (polygone[i + 1].x - polygone[i].x)
                          + (polygone[i + 1].y - polygone[i].y) * (polygone[i + 1].y - polygone[i].y)
                          + (polygone[i + 1].z - polygone[i].z) * (polygone[i + 1].z - polygone[i].z));
        }
        somme += Math.Sqrt((polygone[0].x - polygone[polygone.Count - 1].x) * (polygone[0].x - polygone[polygone.Count - 1].x)
                      + (polygone[0].y - polygone[polygone.Count - 1].y) * (polygone[0].y - polygone[polygone.Count - 1].y)
                      + (polygone[0].z - polygone[polygone.Count - 1].z) * (polygone[0].z - polygone[polygone.Count - 1].z));
        return somme;
    }

    /*
      deplace un polygone
      @param poly: le polygone qui est translate par vecteur
      @param vecteur : le vecteur de translation
    */
    public static void deplacer(List<Point> polygone, Point vecteur)
    {
        for (int i = 0; i < polygone.Count; i++)
        {
            Point un = polygone[i];
            un.x += vecteur.x;
            un.y += vecteur.y;
            un.z += vecteur.z;
            polygone[i] = un;
        }
    }

    /*
      verifie si tous les cotes du polygone sont de meme longueur
      @param poly: le polygone qui est translate par vecteur
    */
    public static bool est_equilateral(List<Point> polygone)
    {
        double distance = Math.Sqrt((polygone[1].x - polygone[0].x) * (polygone[1].x - polygone[0].x)
                                + (polygone[1].y - polygone[0].y) * (polygone[1].y - polygone[0].y)
                                + (polygone[1].z - polygone[0].z) * (polygone[1].z - polygone[0].z));
        for (int i = 1; i < polygone.Count - 1; i++)
        {
            if (Math.Sqrt((polygone[i + 1].x - polygone[i].x) * (polygone[i + 1].x - polygone[i].x)
                       + (polygone[i + 1].y - polygone[i].y) * (polygone[i + 1].y - polygone[i].y)
                       + (polygone[i + 1].z - polygone[i].z) * (polygone[i + 1].z - polygone[i].z))
                          != distance)
            {
                return false;
            }
        }
        return Math.Sqrt((polygone[0].x - polygone[polygone.Count - 1].x) * (polygone[0].x - polygone[polygone.Count - 1].x)
                   + (polygone[0].y - polygone[polygone.Count - 1].y) * (polygone[0].y - polygone[polygone.Count - 1].y)
                   + (polygone[0].z - polygone[polygone.Count - 1].z) * (polygone[0].z - polygone[polygone.Count - 1].z))
                   == distance;
    }

    static void Main()
    {
        //creation d un carre
        List<Point> carre = new List<Point>();
        carre.Add(new Point { x = 1, y = 0, z = 1});
        carre.Add(new Point { x = 0, y = 1, z = 1 });
        carre.Add(new Point { x = -1, y = 0, z = 1 });
        carre.Add(new Point { x = 0, y = -1, z = 1 });
        afficher_polygone(carre);
        

        //creation triangle rectangle
        List<Point> triangleRectangle = new List<Point>(3);
        triangleRectangle.Add(new Point { x = 0, y = 1, z = 1 });
        triangleRectangle.Add(new Point { x = 0, y = 0, z = 1 });
        triangleRectangle.Add(new Point { x = 1, y = 0, z = 1 });
        afficher_polygone(triangleRectangle);


        // perimetres
        Console.WriteLine("Perimetre du carre = " + 4 * Math.Sqrt(2) + " = " + longueur_polygone(carre));
        Console.WriteLine("Perimetre du triangle rectangle = " + (2 + Math.Sqrt(2)) + " = " + longueur_polygone(triangleRectangle));

        //deplacement du carre
        deplacer(carre, new Point { x = 1, y = 1, z = 1 });
        afficher_polygone(carre);

        //test equilateral
        Console.WriteLine("Le carre est un polygone equilateral:" + est_equilateral(carre));
        Console.WriteLine("Le triangle est un polygone equilateral:" + est_equilateral(triangleRectangle));
        Console.ReadKey();
    }
}
