using System.Collections.Generic;
using System.Diagnostics;

namespace OptimalTreeSearch
{
    class OptimalTreeBuilder
    {

        private double[,] weights; //Матрица весов поддеревьев
        private double[,] p_weight; //Матрица взвешенных весов поддеревьев

        public List<Point> points { get; }  //Список вершин будущего ДОП
        public int size { get; }    //Размерность матриц для работы с вершинами
        public int[,] Tree { get; } //Дерево индексов вершин ДОП

        public long ProcTime;

        //Конструктор конструктора ДОП
        public OptimalTreeBuilder(List<Point> points)
        {           
            this.points = points;
            size = points.Count;
            weights = new double[size, size];
            p_weight = new double[size, size];
            Tree = new int[size, size];
            KnutAlgorithm();
        }
        
        //Реализация алгоритма Кнута
        public int[,] KnutAlgorithm()
        {            
            sort();           
            FillArrays();
            BuildTree();
            p_weight = null;
            weights = null;
            return Tree;
        }
        
        //Предварительная подготовка массивов для создания ДОП
        private void FillArrays()
        {
            double sumPointsWeights;
            for (int rowWeight = 0; rowWeight != size; rowWeight++)
            {
                for (int columnWeight = rowWeight + 1; columnWeight != size; columnWeight++)
                {
                    sumPointsWeights = 0;

                    for (int iPoint = rowWeight + 1; iPoint <= columnWeight; iPoint++)
                        sumPointsWeights += points[iPoint].Weight;

                    weights[rowWeight, columnWeight] = sumPointsWeights;
                }
                weights[rowWeight, rowWeight] = 0;
                p_weight[rowWeight, rowWeight] = 0;
                Tree[rowWeight, rowWeight] = 0;
            }          
        }


        //Построение массива индексов ДОП
        private void BuildTree()
        {
            int step;
            int _column;
            for(int column = 1; column != size; column++)
            {
                for (step = 0; step != size - column; step++)
                {
                    _column = column + step;
                    p_weight[step, _column] = weights[step, _column] + min(step, _column);
                }
            }
        }


        //Нахождение минимального значения в массиве взвешенных вершин поддеревьев
        private double min(int i, int j)
        {
            double P_min = 0;
            for(int k = i+1; k<= j; k++)
            {
                if ((p_weight[i, k-1] + p_weight[k, j])<P_min || k == i + 1)
                {
                    P_min = p_weight[i, k-1] + p_weight[k, j];
                    Tree[i, j] = k;
                }               
            }
            return P_min;
        }

        //Сортировка списка вершин позначению веса
        private void sort()
        {
            for (var i = 1; i < points.Count; i++)
            {
                for (var j = i; j > 0 && points[j - 1].Weight > points[j].Weight; j--)
                {
                    var temp = points[j - 1];
                    points[j - 1] = points[j];
                    points[j] = temp;
                }
            }
        }

    }

}
