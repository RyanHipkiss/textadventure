using System;
using System.Linq;
using LiteDB;

namespace darkroom
{
    class DB
    {
        public void setup()
        {
            using(var db = new LiteDatabase(@"MyData.db")) 
            {
                db.DropCollection("point");
                var points = db.GetCollection<Point>("point");

                var point = new Point
                {
                    id = 2,
                    parentId = 1
                };

                points.Insert(point);

                var result = points.Find(x => x.id == 2).FirstOrDefault();
                Console.WriteLine(result.id);

                point.id = 4;
                points.Update(point);

                points.EnsureIndex(x => x.id);
            }
        }
    }
}