using System;

namespace OptimalTreeSearch
{
    class Point
    {
        public string Key { get; set; } //Знаенния ключа вершины
        public double Weight { get; set; } //Значение веса вершины

        //Конструктор вершины
        public Point(string key, string weight)
        {
            Key = key;
            Weight = Double.Parse(weight);
        }
        
    }
}
