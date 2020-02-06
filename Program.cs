using System.Linq;
using System.Collections.Generic;
using System.Data.Common;
using System;
using LiteDB;

namespace darkroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.setupGame();
        }

        static void setupGame()
        {
            using(var db = new LiteDatabase(@"Points.db"))
            {
                db.DropCollection("points");
                var points = db.GetCollection<Point>("points");

                for(var i = 1; i <= 10; i++) {
                    List<KeyValuePair<int, String>> list = new List<KeyValuePair<int, String>>();
                    list.Add(new KeyValuePair<int, String>(1, "North"));
                    list.Add(new KeyValuePair<int, String>(2, "East"));
                    list.Add(new KeyValuePair<int, String>(3, "South"));
                    list.Add(new KeyValuePair<int, string>(4, "West"));

                    var point = new Point
                    {
                        id = i,
                        parentId = 1,
                        deadOptions = new List<int>(),
                        choices = list
                    };

                    points.Insert(point);
                    points.EnsureIndex(x => x.id);
                }

                var x = points.FindAll();

                foreach(var result in x) {
                    result.choices.ForEach(x => {
                        Console.WriteLine(x);
                    });
                }
            }
        }
    }
}
