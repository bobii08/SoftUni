using _01.Point3D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Paths
{
    public static class Storage
    {
        public static void SavePathToATextFile(Path3D path)
        {
            using (var writer = new StreamWriter("../../path.txt"))
            {
                writer.WriteLine(path.ToString());
            }
        }

        public static Path3D LoadPathFromAtextFile(string filePath)
        {
            Path3D path = new Path3D();

            using (var reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                string pattern = @"X: (\-?[0-9]+\.?[0-9]*), Y: (\-?[0-9]+\.?[0-9]*), Z: (\-?[0-9]+\.?[0-9]*)";
                Regex regex = new Regex(pattern);
                while (line != null)
                {
                    Match match = regex.Match(line);
                    if (match.Success)
                    {
                        Point3D point = new Point3D(double.Parse(match.Groups[1].ToString()), double.Parse(match.Groups[2].ToString()),
                            double.Parse(match.Groups[3].ToString()));
                        path.Add(point);
                    }
                    line = reader.ReadLine();
                }
            }

            return path;
        }
    }
}
