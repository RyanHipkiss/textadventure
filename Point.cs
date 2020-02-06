using System.Collections.Generic;
using System;
namespace darkroom
{
    class Point
    {
        public int id { get; set; }
        public int parentId { get; set; }

        public List<int> deadOptions { get; set; }
    }
}