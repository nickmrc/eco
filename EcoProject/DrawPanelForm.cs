using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace EcoProject
{
    public partial class DrawPanelForm : Form
    {

        
        Graph graph;
        Drawing draw;
        List<Vertex> V;
        private BindingList<Vertex> VV;
        private BindingSource bs;
        private List<Edge> E; 
        int selected1; //выбранные вершины, для соединения линиями
        int selected2;
        Bitmap bmp;

        private Monitoring monitor;

        public DrawPanelForm()
        {
          
            InitializeComponent();
            //sheet.Size = new Size(1000,1000);
            double d = Math.Sqrt(4) - (double)2; 

            
            coordinatesTable.Visible = false;
            V = new List<Vertex>();
            VV = new BindingList<Vertex>();
            draw = new Drawing(sheet.Width, sheet.Height);
            E = new List<Edge>();
            //graph = new Graph();
            sheet.Image = draw.GetBitmap();
            mainTab_dataGridView.AutoGenerateColumns = false;

            mainTab_dataGridView.Columns.Add("num", "№ вершины");
            mainTab_dataGridView.Columns.Add("xVertex", "X вершины");
            mainTab_dataGridView.Columns.Add("yVertex", "Y вершины");
            mainTab_dataGridView.Columns.Add("xVector", "X вектора");
            mainTab_dataGridView.Columns.Add("xVector", "Y вектора");

            mainTab_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mainTab_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mainTab_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mainTab_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mainTab_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            //создание столбца кнопок
            DataGridViewButtonColumn button_column = new DataGridViewButtonColumn();
            button_column.Name = "deleteVertex";
            button_column.HeaderText = "Удалить";
            button_column.FlatStyle = FlatStyle.Popup;
            button_column.DefaultCellStyle.BackColor = Color.Tomato;
            button_column.Text = "✕";



            mainTab_dataGridView.Columns.Add(button_column);

            mainTab_dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            mainTab_dataGridView.Columns[1].DataPropertyName = "x";
            mainTab_dataGridView.Columns[2].DataPropertyName = "y";
            mainTab_dataGridView.Columns[3].DataPropertyName = "xVector";
            mainTab_dataGridView.Columns[4].DataPropertyName = "yVector";

            // mainTab_dataGridView.Columns[3].DataPropertyName = "";

            //// Bind the list to the BindingSource.
            //this.customersBindingSource.DataSource = VV;

            //// Attach the BindingSource to the DataGridView.
            //this.coordinate_dGV.DataSource = this.customersBindingSource;
            TriangleInfo_dgv.AutoGenerateColumns = false;
            TriangleInfo_dgv.Columns.Add("num", "№ треугольника");
            TriangleInfo_dgv.Columns.Add("density", "Плотность");
            TriangleInfo_dgv.Columns.Add("edge1", "Ребро 1");
            TriangleInfo_dgv.Columns.Add("edge2", "Ребро 2");
            TriangleInfo_dgv.Columns.Add("edge3", "Ребро 3");

            
            TriangleInfo_dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TriangleInfo_dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TriangleInfo_dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TriangleInfo_dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TriangleInfo_dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TriangleInfo_dgv.Columns[2].DataPropertyName = "sE1";
            TriangleInfo_dgv.Columns[3].DataPropertyName = "sE2";
            TriangleInfo_dgv.Columns[4].DataPropertyName = "sE3";
            TriangleInfo_dgv.Columns[1].DataPropertyName = "DensityOfTriangle";

            monitor = new Monitoring();
            monitor.TriangulationHappened += Triangulation_On;


            ScaleNUD.ValueChanged += ScaleNUD_ValueChanged;

        }

        void ScaleNUD_ValueChanged(object sender, EventArgs e)
        {
            sheet.Size = new Size(540, 400);
            int score = (int)numericUpDown1.Value;
            sheet.Size = new Size(sheet.Size.Width * score, sheet.Size.Height * score);

            int X = (sheet.Size.Width/100)*(int) ScaleNUD.Value;
            int Y = (sheet.Size.Height/100)*(int) ScaleNUD.Value;

            if (X >= 540 && Y >= 400)
            {
                if (X<3000&& Y<3000)
                {
                    sheet.Size = new Size(X, Y);
                }
                else sheet.Size = new Size(2999, 2999);
            }

            draw = null;

            draw = new Drawing(sheet.Width, sheet.Height,score );

            UpdatePictureBox();
        }

        //void DrawScaled(float scaleX, float scaleY)
        //{
        //    bmp = (Bitmap)sheet.Image;

        //    if (bmp != null) bmp.Dispose();
        //    bmp = new Bitmap(sheet.ClientSize.Width, sheet.ClientSize.Height);
        //    using (Matrix m = new Matrix())
        //    {
        //        using (Graphics g = Graphics.FromImage(bmp))
        //        {
        //            m.Scale(scaleX, scaleY);
        //            g.Transform = m;
        //            DrawSomething(g);
        //        }
        //    }
        //}

        //для взаимодействия 
        private static bool IsTriangulated;
        
        private static void Triangulation_On()
        {
            IsTriangulated = true;
        }

        private static void Triangulation_Off()
        {
            IsTriangulated = false;
        }

        private void UpdatePictureBox()
        {
            ClearPictureBox();
            //int max=sheet.Size.Height;

            //if (V.Max()!=null) max = Math.Max((int)this.V.Max().x + 50, sheet.Width);

            //Size newSize = new Size(max, max);

            //this.sheet.Size = newSize;
            //draw = new Drawing(sheet.Width, sheet.Height, (int)numericUpDown1.Value);
            if (IsTriangulated)
            {
                //Size newSize = new Size(Math.Max( (int)this.monitor.triangles.Max().MaxSide()+1000, sheet.Size.Width),(int)this.monitor.triangles.Max().MaxSide()+1000);

                //this.sheet.Size = newSize;



                //строим треугольник
                int trianglenumber = 1;
                foreach (Triangle t in monitor.triangles)
                {
                    draw.drawTriangle(t, (float)ScaleNUD.Value / 100, (float)ScaleNUD.Value / 100);
                    draw.BrushTriangle(t);
                    draw.drawString(trianglenumber++.ToString(), t.Сentroid);
                    //внешние стороны
                    for (int i = 0; i < t.edgemas.Length; i++)
                    {
                        if (t.edgemas[i].isOutside) draw.drawEdge(t.edgemas[i]);
                    }  
                }

                //строим вершины и вектора
                int j = 1;
                foreach (Vertex item in V)
                {
                    draw.drawVertex(item, j++.ToString());
                    draw.drawVector(item);
                }




                sheet.Image = draw.GetBitmap();
            }

            if (!IsTriangulated)
            {
                int j = 1;

                //строим вершины и вектора
                foreach (Vertex item in V)
                {
                    draw.drawVertexScale(item, j++.ToString(), (float)ScaleNUD.Value / 100, (float)ScaleNUD.Value / 100);
                    draw.drawVector(item);
                }
                sheet.Image = draw.GetBitmap();
            }

         sheet.SizeMode = PictureBoxSizeMode.CenterImage;

        }




        //кнопка - выбрать вершину
        private void selectButton_Click(object sender, EventArgs e)
        {
            selectButton.Enabled = false;
            drawVertexButton.Enabled = true;
            deleteButton.Enabled = true;
            draw.clearSheet();
            draw.drawALLGraph(graph);
            sheet.Image = draw.GetBitmap();
            selected1 = -1;
        }

        //кнопка - рисовать вершину
        private void drawVertexButton_Click(object sender, EventArgs e)
        {
            drawVertexButton.Enabled = false;
            selectButton.Enabled = true;
            deleteButton.Enabled = true;
            draw.clearSheet();
            //draw.drawALLGraph(graph);
            sheet.Image = draw.GetBitmap();
        }

        //кнопка - удалить элемент
        private void deleteButton_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
        }

        private void ClearPictureBox()
        {
            draw.clearSheet();
            sheet.Image = draw.GetBitmap();
        }

        //кнопка - удалить граф
        private void deleteALLButton_Click(object sender, EventArgs e)
        {
            selectButton.Enabled = true;
            drawVertexButton.Enabled = true;
            deleteButton.Enabled = true;
            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                V.Clear();
                E.Clear();
                draw.clearSheet();
                sheet.Image = draw.GetBitmap();
            }
        }

       

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            //нажата кнопка "выбрать вершину"
            if (selectButton.Enabled == false)
            {
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= draw.R * draw.R) // Поиск нажатой вершины
                    {
                        // Написать метод, чтобы при нажатии вершины всплывало окошко, где можно было бы изменить координаты вершины и вектора
                    }
                }
            }
            //нажата кнопка "рисовать вершину"
            if (drawVertexButton.Enabled == false)
            {
                Vertex vert = new Vertex(e.X, e.Y);
                V.Add(vert);

                Update_mainTab_dgv();
                UpdatePictureBox();
            }

            //нажата кнопка "удалить элемент"
            if (deleteButton.Enabled == false)
            {
                bool flag = false; //удалили ли что-нибудь по ЭТОМУ клику
                //ищем, возможно была нажата вершина
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= draw.R * draw.R) // Поиск нажатой вершины
                    {
                        // Написать метод удаления вершны
                    }
                }
                //если что-то было удалено, то обновляем граф на экране
                if (flag)
                {
                    draw.clearSheet();
                    draw.drawALLGraph(graph);
                    sheet.Image = draw.GetBitmap();
                }
            }
        }

       

        private void Update_mainTab_dgv()
        {
            mainTab_dataGridView.DataSource = null;
            mainTab_dataGridView.DataSource = V;
          
          
            for (int i = 0; i < mainTab_dataGridView.RowCount; i++)
            {
               
                mainTab_dataGridView.Rows[i].Cells[0].Value = i + 1;
                //mainTab_dataGridView.Rows[i].Cells["deleteVertex"].Value = "✕";
            }
        }

        private void Update_TriangleInfo_dgv()
        {
            TriangleInfo_dgv.DataSource = null;
            TriangleInfo_dgv.DataSource = monitor.triangles;

            //BindingSource source1 = new BindingSource();
            //source1.DataSource = TriangleInfo_dgv;

            //source1.Filter = "are = 'ds' ";

            for (int i = 0; i < TriangleInfo_dgv.RowCount; i++)
            {

                TriangleInfo_dgv.Rows[i].Cells[0].Value = i + 1;
                //mainTab_dataGridView.Rows[i].Cells["deleteVertex"].Value = "✕";
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            //if (IsTableFilled())
            //{
            //Triangulator triangulate = new Triangulator();
            //List<Vertex> listvertex = new List<Vertex>();

            //SetVectors();
            //List<Triangle> tr = triangulate.Triangulation(V);
            //monitor.GetArrayOfOutsideEdge();
            //monitor.AllDensities();



            if (IsTriangulated)
            {
                monitor.Update_NonStaticData();
            }
            else
            {
                monitor.Update_StaticData(V);
            }    
            


            //foreach (Triangle t in monitor.triangles)
            //    {
            //        draw.BrushTriangle(t);
            //        draw.drawTriangle(t);
            //        for (int i = 0; i < t.edgemas.Length; i++)
            //        {
            //            if (t.edgemas[i].isOutside) draw.drawEdge(t.edgemas[i]);
            //            //if (t.edgemas[i].brother != null) G.drawEdge(t.edgemas[i].brother, new Pen(Color.Aqua));
            //        }
            //        richTextBox1.Text += t.ToString();
            //    }
            //    for (int i = 0; i < V.Count; i++)
            //    {
            //        draw.drawVertex(V[i], (i + 1).ToString());
            //    }

            //    //переписать не под вызов конструктора, а под вызов метода, который будет сравнивать треугольники.
            //    //т.е. Equals для треугольников, который сравнивает по вершинам.

            //    foreach (Vertex vert in V)
            //    {
            //        draw.drawVector(vert);
            //    }
            //    sheet.Image = draw.GetBitmap();

            UpdatePictureBox();
            Update_TriangleInfo_dgv();
            
            //}
            //else
            //{
            //    MessageBox.Show("Заполните значения векторов", "Ошибка заполнения");
            //}

        }



        private void SetVectors()
        {
            for (int i = 0; i < V.Count; i++)
            {
                //дописать tryparse-условие
                float x = Convert.ToSingle(coordinatesTable.Rows[i].Cells[2].Value.ToString());
                float y = Convert.ToSingle(coordinatesTable.Rows[i].Cells[3].Value.ToString());
                V[i].Vector = new Vector(x, y);
            }
        }

        private bool IsTableFilled()
        {
            if (coordinatesTable.Rows.Count > 0)
            {
                for (int i = 0; i < coordinatesTable.Rows.Count; i++)
                {
                    if (coordinatesTable.Rows[i].Cells[2].Value == null || coordinatesTable.Rows[i].Cells[3].Value == null)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

       

        private void example_button_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
            // умножаем все значения на 20
            float multipl = 20f;
            V.Add(new Vertex(2 * multipl, 8 * multipl));
            V[0].Vector = new Vector(0 * multipl, 0 * multipl);
            V.Add(new Vertex(100, 300));
            V[1].Vector = new Vector(1 * multipl, -1 * multipl);
            V.Add(new Vertex(120, 40));
            V[2].Vector = new Vector(1 * multipl, 1 * multipl);
            V.Add(new Vertex(160, 200));
            V[3].Vector = new Vector(2 * multipl, 1 * multipl);
            V.Add(new Vertex(220, 320));
            V[4].Vector = new Vector(3 * multipl, 0 * multipl);
            V.Add(new Vertex(240, 100));
            V[5].Vector = new Vector(0 * multipl, 0 * multipl);
            V.Add(new Vertex(260, 180));
            V[6].Vector = new Vector(2 * multipl, 1 * multipl);
            V.Add(new Vertex(17 * multipl, 1 * multipl));
            V[7].Vector = new Vector(1 * multipl, 0 * multipl);
            V.Add(new Vertex(17 * multipl, 7 * multipl));
            V[8].Vector = new Vector(1 * multipl, 2 * multipl);
            V.Add(new Vertex(18 * multipl, 13 * multipl));
            V[9].Vector = new Vector(3 * multipl, 1 * multipl);
            V.Add(new Vertex(20 * multipl, 9 * multipl));
            V[10].Vector = new Vector(2 * multipl, 2 * multipl);
            for (int i = 0; i < V.Count; i++)
            {
                draw.drawVertex(V[i], (i + 1).ToString());
                draw.drawVector(V[i]);
                coordinatesTable.Rows.Add(i + 1, V[i], V[i].Vector.x, V[i].Vector.y);
            }
            UpdatePictureBox();
            Update_mainTab_dgv();

            Update_TriangleInfo_dgv();
            sheet.Image = draw.GetBitmap();

        }

        private void Example()
        {
            coordinatesTable.Rows.Clear();
            V.Clear();
            E.Clear();
            // умножаем все значения на 20
            float multipl = 20f;
            Random r1 = new Random();
            Random r2 = new Random();
            V.Add(new Vertex(132, 155));

            V[0].Vector = new Vector(1 * multipl * r1.Next(-2, 2), -1 * multipl * r2.Next(-1, 2));
            Thread.Sleep(12);

            V.Add(new Vertex(345, 180));
            V[1].Vector = new Vector(1 * multipl * r1.Next(-1, 2), 1 * multipl * r2.Next(-2, 2));
            Thread.Sleep(12);

            V.Add(new Vertex(158, 234));
            V[2].Vector = new Vector(2 * multipl * r1.Next(-1, 2), 1 * multipl * r2.Next(-1, 2));
            Thread.Sleep(12);

            V.Add(new Vertex(393, 358));
            V[3].Vector = new Vector(3 * multipl * r1.Next(-1, 2), 0 * multipl * r2.Next(-1, 2));
            Thread.Sleep(12);

            V.Add(new Vertex(492, 312));
            V[4].Vector = new Vector(0 * multipl, 0 * multipl * r2.Next(-1, 2));
            Thread.Sleep(12);

            V.Add(new Vertex(469, 250));
            V[5].Vector = new Vector(2 * multipl * r1.Next(-1, 2), 1 * multipl * r2.Next(-1, 2));
            Thread.Sleep(12);

            V.Add(new Vertex(478, 165));
            V[6].Vector = new Vector(1 * multipl * r1.Next(-1, 2), 0 * multipl * r2.Next(-1, 2));
            Thread.Sleep(12);

            V.Add(new Vertex(398, 217));
            V[7].Vector = new Vector(1 * multipl * r1.Next(-1, 2), 2 * multipl * r2.Next(-1, 2));
            Thread.Sleep(12);

            V.Add(new Vertex(315, 258));
            V[8].Vector = new Vector(3 * multipl * r1.Next(-1, 2), 1 * multipl * r2.Next(-1, 2));
            Thread.Sleep(12);
            for (int i = 0; i < V.Count; i++)
            {
                draw.drawVertex(V[i], (i + 1).ToString());
                draw.drawVector(V[i]);
                coordinatesTable.Rows.Add(i + 1, V[i], V[i].Vector.x, V[i].Vector.y);
            }
            sheet.Image = draw.GetBitmap();


        }

       

        private void DrawPanelForm_Load(object sender, EventArgs e)
        {
            this.Size = AutoScaleBaseSize;

            Size panelSize = this.panel1.Size;
            //panelSize.Width = panelSize.Width - 1;
            //panelSize.Height = panelSize.Height - 1;
            
            //вынести условия
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ReverseVisible(Control c)
        {
            if (c.Visible) c.Visible = false;
            else c.Visible = true;
        }



        private void mainTab_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == 5) //индекс столбца, в которой находится кнопка.

                {
                    V.RemoveAt(e.RowIndex);
                    this.monitor.triangles = null;
                    Update_mainTab_dgv();
                    Update_TriangleInfo_dgv();

                    UpdatePictureBox();
                }
            }

        }

        private void mainTab_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int check = e.ColumnIndex;

            switch (check)
            {
                case 1: //изменение координаты X вершины
                    {
                        float number;
                        string cellsValue = mainTab_dataGridView.Rows[e.RowIndex].Cells[check].Value.ToString();
                        if (float.TryParse(cellsValue, out number))
                        {
                            V[e.RowIndex].x = number;
                        }
                        //дописать для Update_StaticData!!!&&&&&????????????
                        IsTriangulated = false;
                       
                        break;
                    }
                case 2: //изменение координаты Y вершины
                    {
                        float number;
                        string cellsValue = mainTab_dataGridView.Rows[e.RowIndex].Cells[check].Value.ToString();
                        if (float.TryParse(cellsValue, out number))
                        {
                            V[e.RowIndex].y = number;
                        }
                        //дописать для Update_StaticData!!!????????
                        IsTriangulated = false;
                       
                        break;
                    }
                case 3: //изменение координаты X вектора
                    {
                        float number;
                        string cellsValue = mainTab_dataGridView.Rows[e.RowIndex].Cells[check].Value.ToString();
                        if (float.TryParse(cellsValue, out number))
                        {
                            V[e.RowIndex].xVector = number;
                        }
                       if(IsTriangulated) monitor.Update_NonStaticData();
                        break;
                    }
                case 4: //изменение координаты Y вектора
                    {
                        float number;
                        string cellsValue = mainTab_dataGridView.Rows[e.RowIndex].Cells[check].Value.ToString();
                        if (float.TryParse(cellsValue, out number))
                        {
                            V[e.RowIndex].yVector = number;
                        }

                        if (IsTriangulated) monitor.Update_NonStaticData();
                        break;
                    }
                case 5: //удаление вершины
                    {
                        IsTriangulated = false;
                        break;
                    }
                default: //добавление вершины
                    {
                        IsTriangulated = false;
                        break;
                    }

            }

            UpdatePictureBox();
            Update_TriangleInfo_dgv();
            float a = V[0].x;
        }

        private void addEmptyVertex_btn_Click(object sender, EventArgs e)
        {
            Vertex vert = new Vertex();
            V.Add(vert);
            Update_mainTab_dgv();
            this.monitor.triangles = null;
            Update_TriangleInfo_dgv();
        }

        private void coordinatesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ScaleNUD_ValueChanged_1(object sender, EventArgs e)
        {
            trackBar1.Value = (int)ScaleNUD.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ScaleNUD.Value = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           sheet.Size = new Size(540,400);
            
            //this.draw.Score = (int) numericUpDown1.Value;

            int score = (int) numericUpDown1.Value;

            sheet.Size= new Size(sheet.Size.Width*score, sheet.Size.Height*score);
          

          
            
            draw = new Drawing(sheet.Width, sheet.Height, score);
            UpdatePictureBox();
        }

        private void zoomPercent_label_Click(object sender, EventArgs e)
        {
            ScaleNUD.Value = 100;
        }

        

        private void zoomPercent_label_Click_1(object sender, EventArgs e)
        {
            ScaleNUD.Value = 100;
        }

        private void zoomX_label_Click_1(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
        }
    }
}
