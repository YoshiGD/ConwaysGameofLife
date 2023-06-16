using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using static Conways_Game_of_Life.Properties.Resources;


namespace Conways_Game_of_Life
{
    public class Template
    {
        //Samstag abend.
        public string Name { get; set; } = string.Empty;
        public Point[] Data { get; set; } = new Point[0];

        public Template() 
        {
        
        }

        /// <summary>
        /// Diese Methode wird verwendet, um die Positionen der lebenden Zellen im aktuellen Spielfeld zu speichern.
        /// </summary>
        /// <param name="filePath">Der File-Pfad der gespeicherten Datei</param>
        public static void Save_AliveCellPositions(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(FormMain.name);
                foreach (Point position in FormMain.initialLiveCellPositions)
                {
                    writer.WriteLine($"{position.X},{position.Y}");
                }
            }
        }

        /// <summary>
        /// Diese Methode wird verwendet, um eine bestimmte Zelle als lebendig zu markieren und ihre Position im Spielfeld zu aktualisieren.
        /// </summary>
        /// <param name="template">Das ist das Muster nach dem die Zellen mit Namen und Daten abgespeichert wurden</param>
        public static void SetAliveZells(Template template)
        {
            for (int i = 1; i < template.Data.Length; i++)
            {
                Point position = template.Data[i];
                int x = position.X;
                int y = position.Y;

                try
                {
                    FormMain.grid[x, y] = true;
                    FormMain.initialLiveCellPositions.Add(new Point(x, y));
                }
                catch
                {
                    MessageBox.Show(Error_Text);
                    return;
                }
            }
        }

        /// <summary>
        /// Diese Methode wird verwendet, um eine bestimmte Zelle als lebendig zu markieren und ihre Position im Spielfeld zu aktualisieren.
        /// </summary>
        /// <param name="zeilen">Zeilen ist die Anzahl an Koordinaten</param>
        public static void SetAliveZells(string[] zeilen)
        {
            for (int i = 1; i < zeilen.Length; i++)
            {
                string[] position = zeilen[i].Split(',');
                if (position.Length == 2 && int.TryParse(position[0], out int x) && int.TryParse(position[1], out int y))
                {
                    if (x >= 0 && x < FormMain.grid.GetLength(0) && y >= 0 && y < FormMain.grid.GetLength(1))
                    {
                        try
                        {
                            FormMain.grid[x, y] = true;
                            FormMain.initialLiveCellPositions.Add(new Point(x, y));
                        }
                        catch
                        {
                            MessageBox.Show(Error_Text);
                            return;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Diese Methode wird verwendet, um die Positionen der lebenden Zellen im aktuellen Spielfeld im JSON-Format zu speichern.
        /// </summary>
        /// <param name="filePath">Der File-Pfad der gespeicherten Datei</param>
        public static void Save_LiveCellPositions_Json(string filePath)
        {
            List<Point> liveCellPositions = new List<Point>();
            for (int x = 0; x < FormMain.grid.GetLength(0); x++)
            {
                for (int y = 0; y < FormMain.grid.GetLength(1); y++)
                {
                    if (FormMain.grid[x, y])
                    {
                        liveCellPositions.Add(new Point(x, y));
                    }
                }
            }
            var template = new Template();
            template.Name = FormMain.name;
            template.Data = liveCellPositions.ToArray();
            var json = JsonConvert.SerializeObject(template);
            File.WriteAllText(filePath, json);
        }
    }
}
