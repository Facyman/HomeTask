using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtask1
{
    public static class AreaOfShapes
    {
        private static Dictionary<string, Delegate> Area;
        static AreaOfShapes()
        {
            Area =
            new Dictionary<string, Delegate> // Словарь с названиями фигур и их формулами площадей
             {
             {"Circle",new Func<double, double>((R) =>  R*R*Math.PI )}, // Площадь круга
             {"Triangle",new Func<double, double, double, double>(AreaOfShapes.TriangleArea)},
             };
        }
        public static void AddFigure(string figure, Delegate method) // добавление новой формулы
        {
            if (Area.ContainsKey(figure))
                throw new ArgumentException(string.Format("Фигура {0} уже существует", figure));
            Area.Add(figure, method);
        }

        public static double Operation(string figure, params double [] args) // получение площади фигуры
        {
            var parametres = Area[figure].Method.GetParameters();

            if (!Area.ContainsKey(figure))
                throw new ArgumentException(string.Format("Фигуры {0} не существует", figure));
            if (args.Length>parametres.Length)
            {
                throw new ArgumentException(string.Format("Введены неправильные данные"));
            }
            try
            {
                var b = Area[figure].DynamicInvoke(args[0], args[1], args[2]);
                return (double)Convert.ChangeType(b, typeof(double));
            }
            catch (Exception e)
            {
                try
                {
                    var b = Area[figure].DynamicInvoke(args[0], args[1]);
                    return (double)Convert.ChangeType(b, typeof(double));
                }
                catch (Exception g)
                {
                    try
                    {
                        var b = Area[figure].DynamicInvoke(args[0]);
                        return (double)Convert.ChangeType(b, typeof(double));
                    }
                    catch(Exception d)
                    {
                        throw new ArgumentException(string.Format("Введены неправильные данные"));
                    }                    
                }
            }
        }

        private static double TriangleArea(double a, double b, double c) //площадь треугольника
        {
            double p = (a + b + c) / 2;
            return (p * (p - a) * (p - b) * (p - c));
        }
        public static bool IsTriangleRight(double a, double b, double c) //Условия прямоугольности треугольника
        {
            bool first = a * a + b * b == c * c; 
            bool second = c * c + b * b == a * a; 
            bool third = a * a + c * c == b * b; 

            if (first)
            {
                return true;
            }
            else if (second)
            {
                return true;
            }
            else if (third)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}