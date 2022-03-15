using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OptimalTreeSearch
{
    public partial class Main : Form
    {
        List<Point> points;  //Список введенных вершин
        List<Label> labels;  //Список меток для идентификации вершин в будущем ДОП

        const int POINT_SIZE = 5;   //Размер точек

        int pointDistanceX; //Расстояние между точками по X
        int pointDistanceY; //Расстояние между точками по Y


        double treeWeight = 0.0;    //Общий вес дерева
        double optimalWeight = 0.0; //Взвешенная высота ДОП

        Graphics g; //Объект для рисования ДОП

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            points = new List<Point>();
            labels = new List<Label>();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            g = DrawPanel.CreateGraphics();
        }

        //Добавление новой вершины
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtKey.Text) && !String.IsNullOrEmpty(txtWeight.Text))
                {
                    for (int i = 0; i != dgvPoints.Rows.Count; i++)
                    {
                        if (dgvPoints[0, i].Value.ToString() == txtKey.Text)
                        {
                            MessageBox.Show("Ключи не должны повторяться");
                            return;
                        }
                    }
                    treeWeight += Double.Parse(txtWeight.Text);
                    dgvPoints.Rows.Add(txtKey.Text, txtWeight.Text);
                    lblTreeWeight.Text = "Вес дерева: " + (treeWeight).ToString();
                }
                else
                    MessageBox.Show("Заполните поле");
            }
            catch
            {
                MessageBox.Show("Ошибка ввода значений");
            }
        }

        //Очистка таблицы вершин
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvPoints.Rows.Clear();
            treeWeight = 0.0;
            lblTreeWeight.Text = "Вес дерева: ";
        }

        //Удаление двойным нажатием на левую кнопку мыши веришины с таблицы
        private void dgvPoints_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dgvPoints.Rows.Remove(dgvPoints.Rows[dgvPoints.CurrentRow.Index]);
                treeWeight = 0.0;
                for (int i = 0; i != dgvPoints.Rows.Count; i++)
                    treeWeight += Double.Parse(dgvPoints[1, i].Value.ToString());
                lblTreeWeight.Text = "Вес дерева: " + (treeWeight).ToString();
            }
        }

        //Построение дерева
        private void btnBuildTree_Click(object sender, EventArgs e)
        {
            if (dgvPoints.Rows.Count != 0)
            {
                optimalWeight = 0.0;               
                FillPoints();
                
                labels.Clear();
                DrawPanel.Controls.Clear();
                g.Clear(Color.Silver);

                OptimalTreeBuilder optimalTree = new OptimalTreeBuilder(points);
                points = optimalTree.points;
                BinaryTree bTree = new BinaryTree(optimalTree);

                pointDistanceX = DrawPanel.Width / 6;
                pointDistanceY = (DrawPanel.Height - 10) / bTree.GetHeight(bTree, 1);

                DrawTree(bTree, DrawPanel.Size.Width / 2, 10, 1);        
                
                lblOptimalWeight.Text = "Взвешенный вес дерева: " + (optimalWeight).ToString();              
            }
            else
                MessageBox.Show("Список вершин пуст");

        }

        //Ввод вершин из файла
        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> keys = new List<string>();
                openTXTfile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openTXTfile.ShowDialog() == DialogResult.Cancel)
                    return;
                var check_empty = File.ReadAllLines(openTXTfile.FileName);
                if (check_empty.Length == 0)
                {
                    MessageBox.Show("Файл пуст");
                    return;
                }
                dgvPoints.Rows.Clear();
                treeWeight = 0.0;
                foreach (var line in File.ReadLines(openTXTfile.FileName))
                {
                    var array = line.Split();
                    
                    if (keys.Contains(array[0]))
                    {
                        MessageBox.Show("Ключи не должны совпадать");
                        return;
                    }
                    if (Double.Parse(array[1]) > 0)
                    {
                        keys.Add(array[0]);
                        dgvPoints.Rows.Add(array);
                        treeWeight += Double.Parse(array[1]);
                    }
                    else
                    {
                        MessageBox.Show("Значение веса не должно быть меньше или равно 0");
                        return;
                    }
                }
                lblTreeWeight.Text = "Вес дерева: " + (treeWeight).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода значений");
            }
        }

        //Запрет ввода лишних символов
        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar!=44)
                e.Handled = true;
        }

        //Заполнение списка точек
        private void FillPoints()
        {
            points.Clear();
            points.Add(new Point(null, "-1,0"));
            for (int i = 0; i != dgvPoints.Rows.Count; i++)
                points.Add(new Point(dgvPoints[0, i].Value.ToString(), dgvPoints[1, i].Value.ToString()));
           
        }
        
        //Метод отрисовки дерева
        private void DrawTree(BinaryTree binTree, int x, int y, int level)
        {
            int x_next;
            int y_next;

            optimalWeight += binTree.point.Weight * level;
            g.FillRectangle(Brushes.Red, x, y, POINT_SIZE, POINT_SIZE);

            Label lablePoint = new Label
            {
                Text = "(" + binTree.point.Key + "; " + binTree.point.Weight + ")",
                Location = new System.Drawing.Point(x + POINT_SIZE, y - POINT_SIZE),
                Font = new Font("Times New Roman", 7),
                AutoSize = true
            };

            labels.Add(lablePoint);
            lablePoint.BackColor = Color.Transparent;
            DrawPanel.Controls.Add(lablePoint);

            if (binTree.LeftTree!=null)
            {

                x_next = x - (pointDistanceX / level);
                y_next = y + pointDistanceY;
                g.DrawLine(Pens.Black, x, y + POINT_SIZE, x_next + POINT_SIZE, y_next);
                DrawTree(binTree.LeftTree, x_next, y_next, level + 1);
            }

            if (binTree.RightTree != null)
            {
                x_next = x + (pointDistanceX / level);
                y_next = y + pointDistanceY;
                g.DrawLine(Pens.Black, x + POINT_SIZE, y + POINT_SIZE, x_next, y_next);
                DrawTree(binTree.RightTree, x_next, y_next, level + 1);
            }

        }
    }
}
