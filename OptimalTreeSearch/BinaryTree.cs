
namespace OptimalTreeSearch
{
    class BinaryTree
    {
        private OptimalTreeBuilder builder; //Конструктор ДОП, из которого берется информация для построения  бинарного дерева

        public BinaryTree LeftTree;     //Левый предок
        public BinaryTree RightTree;    //Правый предок
        
        public Point point; //Значение вершины

        // Конструктор узла
        public BinaryTree(OptimalTreeBuilder builder)
        {
            LeftTree = null;
            RightTree = null;
            this.builder = builder;           
            insert(0, this.builder.points.Count - 1);
        }

        // Конструктор для следущих узлов после корня ДОП
        private BinaryTree(int rowTree, int colTree, OptimalTreeBuilder builder)
        {
            LeftTree = null;
            RightTree = null;
            this.builder = builder;
            insert(rowTree, colTree);
        }

        //Вставка новых узлов в дерево
        private void insert(int rowTree, int colTree)
        {
            int iPoint = builder.Tree[rowTree, colTree];
            point = builder.points[iPoint];
            if (iPoint - 1 != rowTree)
                LeftTree = new BinaryTree(rowTree, iPoint - 1, builder);
            if (iPoint != colTree)
                RightTree = new BinaryTree(iPoint, colTree, builder);
        }

        public int GetHeight(BinaryTree node, int value)
        {
            int leftTreeHeight;
            int rightTreeHeight;
            
            if (node == null)
                return (value-1);

            leftTreeHeight  = GetHeight(node.LeftTree, value + 1);
            rightTreeHeight = GetHeight(node.RightTree, value + 1);

            if (leftTreeHeight > rightTreeHeight) return leftTreeHeight;
            else return rightTreeHeight;
        }
    }
}
