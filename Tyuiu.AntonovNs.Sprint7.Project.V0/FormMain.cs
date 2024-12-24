using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.AntonovNs.Sprint7.Project.V0.Lib;
using System.Diagnostics.Metrics;
using Tyuiu.AntonovNs.Sprint7.Project.V6;

namespace Tyuiu.AntonovNs.Sprint7.Project.V0
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();

        }
        static int rows, columns;
        static string openFilePath;
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e) 
        {
            try
            {
                this.dataGridView_AntonovNS.Rows.Add(textBoxNumberP_AntonovNS.Text, textBoxSurnameP_AntonovNS.Text, textBoxName_AntonovNS.Text, textBoxPatronymic_AntonovNS.Text, textBoxData_AntonovNS.Text, textBoxFIOV_AntonovNS.Text, textBoxPost_AntonovNS.Text, textBoxDiagnoz_AntonovNS.Text, textBoxHeal_AntonovNS.Text, textBoxWork_AntonovNS.Text, textBoxTab_AntonovNS.Text, textBoxNote_AntonovNS.Text);
            }
            catch 
            {
                
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialogMatrix = new SaveFileDialog();
                saveFileDialogMatrix.FileName = "ddd.csv";
                saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogMatrix.ShowDialog();
                string path = saveFileDialogMatrix.FileName;
                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(path);
                }
                int rows = dataGridView_AntonovNS.RowCount;
                int columns = dataGridView_AntonovNS.ColumnCount;
                string str = "";
                for (int i = 0;i<rows;i++) 
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridView_AntonovNS.Rows[i].Cells[j].Value + ";";
                        }
                        else 
                        {
                            str = str + dataGridView_AntonovNS.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
            catch
            {

            }
        }
        public static string[,] LoadFromFilaData(string filePath)
        {
                string fileData = File.ReadAllText(filePath);
                fileData = fileData.Replace("\n", "\r");
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
                rows = lines.Length;
                columns = lines[0].Split(';').Length;
                string[,] arrayValues = new string[rows, columns];
                for (int r = 0; r < rows; r++)
                {
                    string[] line_r = lines[r].Split(';');
                    for (int c = 0; c < columns; c++)
                    {
                        arrayValues[r, c] = line_r[c];
                    }
                }
                return arrayValues;
            }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialogTask = new OpenFileDialog();
                openFileDialogTask.ShowDialog();
                openFilePath = openFileDialogTask.FileName;
                string[,] arrayValues = LoadFromFilaData(openFilePath);
                dataGridView_AntonovNS.ColumnCount = columns;
                dataGridView_AntonovNS.RowCount = rows;
                for (int i = 0; i < columns; i++)
                {
                    dataGridView_AntonovNS.Columns[i].Width = 100;
                }
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridView_AntonovNS.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                
            }
            catch { }
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            dataGridView_AntonovNS.ClearSelection();

            for (int r = 0; r < dataGridView_AntonovNS.RowCount; r++)
            {
                for (int c = 0; c < dataGridView_AntonovNS.ColumnCount; c++)
                {
                    if (dataGridView_AntonovNS.Rows[r].Cells[c].Value != null &&
                        dataGridView_AntonovNS.Rows[r].Cells[c].Value.ToString().Trim().Equals(
                            textBoxFind_AntonovNS.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        dataGridView_AntonovNS.Rows[r].Selected = true;
                    }
                }
            }
        }
        private void buttonGraf_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                chartMain_AntonovNS.Series.Clear();
                chartMain_AntonovNS.ChartAreas.Clear();
                dataGridView_AntonovNS.ColumnCount = columns;
                dataGridView_AntonovNS.RowCount = rows;
                ChartArea chartArea = new ChartArea("MainArea");
                chartMain_AntonovNS.ChartAreas.Add(chartArea);
                Series series = new Series("Данные");
                series.ChartType = SeriesChartType.Column; // Устанавливаем тип графика "Column"
                series.IsValueShownAsLabel = true; // Показываем значения над столбцами
                chartMain_AntonovNS.Series.Add(series);

                string[] array = new string[columns];
                string y;
                for (int r = 0; r < rows; r++)
                {
                            array[count] = dataGridView_AntonovNS.Rows[r].Cells[9].Value.ToString();
                            count++;
                }

                series.Points.AddXY(10,ds.SumTen(array));
                series.Points.AddXY(20,ds.SumTwo(array));
                series.Points.AddXY(30,ds.SumFre(array));
                series.Points.AddXY(40,ds.SumFour(array));
                series.Points.AddXY(50,ds.SumFive(array));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        private void buttonKol_Click(object sender, EventArgs e) 
        {
            labelKol_AntonovNS.Text = dataGridView_AntonovNS.Rows.Count.ToString();
        }
        private void buttonMax_Click(object sender, EventArgs e)
        {
            int count = 0;
            int y = 0;
            string[] array = new string[columns];
            for (int r = 0; r < rows; r++)
            {
                array[count] = dataGridView_AntonovNS.Rows[r].Cells[9].Value.ToString();
                count++;
            }
            for (int r = 0; r < count; r++)
            {
                if (Int32.Parse(array[r]) > y) 
                {
                    y = Int32.Parse(array[r]);
                }
            }
            labelMax_AntonovNS.Text = y.ToString();
        }
        private void buttonMin_Click(object sender, EventArgs e)
        {
            int count = 0;
            int y = 1000;
            string[] array = new string[columns];
            for (int r = 0; r < rows; r++)
            {
                array[count] = dataGridView_AntonovNS.Rows[r].Cells[9].Value.ToString();
                count++;
            }
            for (int r = 0; r < count; r++)
            {
                if (Int32.Parse(array[r])  < y)
                {
                    y = Int32.Parse(array[r]);
                }
            }
            labelMin_AntonovNS.Text = y.ToString();
        }
        private void buttonHalf_Click(object sender, EventArgs e)
        {
            int count = 0;
            int y = 0,u = 0;
            string[] array = new string[columns];
            for (int r = 0; r < rows; r++)
            {
                array[count] = dataGridView_AntonovNS.Rows[r].Cells[9].Value.ToString();
                count++;
            }
            for (int r = 0; r < count; r++)
            {
                    y += Int32.Parse(array[r]);
                u++;

            }
            labelHalf_AntonovNS.Text = (y/u).ToString();
        }
        private void buttonCont_Click(object sender, EventArgs e) 
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
