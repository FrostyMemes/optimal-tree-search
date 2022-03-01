
namespace OptimalTreeSearch
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFile = new System.Windows.Forms.Button();
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.lblTreeWeight = new System.Windows.Forms.Label();
            this.dgvPoints = new System.Windows.Forms.DataGridView();
            this.clmnKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnBuildTree = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.openTXTfile = new System.Windows.Forms.OpenFileDialog();
            this.lblOptimalWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(882, 171);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(140, 66);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Данные из файла txt";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // DrawPanel
            // 
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawPanel.Location = new System.Drawing.Point(12, 12);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(569, 426);
            this.DrawPanel.TabIndex = 1;
            // 
            // lblTreeWeight
            // 
            this.lblTreeWeight.AutoSize = true;
            this.lblTreeWeight.Location = new System.Drawing.Point(587, 395);
            this.lblTreeWeight.Name = "lblTreeWeight";
            this.lblTreeWeight.Size = new System.Drawing.Size(68, 13);
            this.lblTreeWeight.TabIndex = 2;
            this.lblTreeWeight.Text = "Вес дерева:";
            // 
            // dgvPoints
            // 
            this.dgvPoints.AllowUserToAddRows = false;
            this.dgvPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnKey,
            this.clmnWeight});
            this.dgvPoints.Location = new System.Drawing.Point(590, 12);
            this.dgvPoints.Name = "dgvPoints";
            this.dgvPoints.RowHeadersVisible = false;
            this.dgvPoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoints.Size = new System.Drawing.Size(283, 380);
            this.dgvPoints.TabIndex = 3;
            this.dgvPoints.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPoints_CellMouseDoubleClick);
            // 
            // clmnKey
            // 
            this.clmnKey.HeaderText = "Ключ";
            this.clmnKey.Name = "clmnKey";
            this.clmnKey.ReadOnly = true;
            this.clmnKey.Width = 170;
            // 
            // clmnWeight
            // 
            this.clmnWeight.HeaderText = "Вес";
            this.clmnWeight.Name = "clmnWeight";
            this.clmnWeight.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(882, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 66);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить вершину";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(882, 73);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(140, 20);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(882, 28);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(140, 20);
            this.txtKey.TabIndex = 6;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(879, 12);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(36, 13);
            this.lblKey.TabIndex = 7;
            this.lblKey.Text = "Ключ:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(879, 57);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(29, 13);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Вес:";
            // 
            // btnBuildTree
            // 
            this.btnBuildTree.Location = new System.Drawing.Point(587, 415);
            this.btnBuildTree.Name = "btnBuildTree";
            this.btnBuildTree.Size = new System.Drawing.Size(286, 23);
            this.btnBuildTree.TabIndex = 9;
            this.btnBuildTree.Text = "Построить";
            this.btnBuildTree.UseVisualStyleBackColor = true;
            this.btnBuildTree.Click += new System.EventHandler(this.btnBuildTree_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(882, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 66);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Очистить вершины";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // openTXTfile
            // 
            this.openTXTfile.FileName = "openFileDialog1";
            // 
            // lblOptimalWeight
            // 
            this.lblOptimalWeight.AutoSize = true;
            this.lblOptimalWeight.Location = new System.Drawing.Point(12, 441);
            this.lblOptimalWeight.Name = "lblOptimalWeight";
            this.lblOptimalWeight.Size = new System.Drawing.Size(135, 13);
            this.lblOptimalWeight.TabIndex = 11;
            this.lblOptimalWeight.Text = "Взвешенный вес дерева:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(914, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOptimalWeight);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBuildTree);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPoints);
            this.Controls.Add(this.lblTreeWeight);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.btnFile);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Label lblTreeWeight;
        private System.Windows.Forms.DataGridView dgvPoints;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnBuildTree;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.OpenFileDialog openTXTfile;
        private System.Windows.Forms.Label lblOptimalWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWeight;
        private System.Windows.Forms.Label label1;
    }
}

