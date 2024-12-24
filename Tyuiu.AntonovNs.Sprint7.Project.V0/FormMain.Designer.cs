namespace Tyuiu.AntonovNs.Sprint7.Project.V0
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridView_AntonovNS = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnSurname = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnPatronymic = new DataGridViewTextBoxColumn();
            ColumnData = new DataGridViewTextBoxColumn();
            ColumnSurnameName = new DataGridViewTextBoxColumn();
            ColumnPost = new DataGridViewTextBoxColumn();
            ColumnDiagnosis = new DataGridViewTextBoxColumn();
            ColumnOutpatientTreatment = new DataGridViewTextBoxColumn();
            ColumnWorkingCapacity = new DataGridViewTextBoxColumn();
            ColumnOutpatientRegistration = new DataGridViewTextBoxColumn();
            ColumnNote = new DataGridViewTextBoxColumn();
            textBoxNumberP_AntonovNS = new TextBox();
            textBoxSurnameP_AntonovNS = new TextBox();
            textBoxName_AntonovNS = new TextBox();
            textBoxPatronymic_AntonovNS = new TextBox();
            textBoxData_AntonovNS = new TextBox();
            textBoxFIOV_AntonovNS = new TextBox();
            textBoxPost_AntonovNS = new TextBox();
            textBoxDiagnoz_AntonovNS = new TextBox();
            textBoxHeal_AntonovNS = new TextBox();
            textBoxWork_AntonovNS = new TextBox();
            textBoxTab_AntonovNS = new TextBox();
            textBoxNote_AntonovNS = new TextBox();
            labelNumberP_AntonovNS = new Label();
            labelSurnameP_AntonovNS = new Label();
            labelName_AntonovNS = new Label();
            labelPatronymic_AntonovNS = new Label();
            labelData_AntonovNS = new Label();
            labelFIOV_AntonovNS = new Label();
            labePost_AntonovNS = new Label();
            labelDiagnoz_AntonovNS = new Label();
            labelHeal_AntonovNS = new Label();
            labelWork_AntonovNS = new Label();
            labelTab_AntonovNS = new Label();
            labelNote_AntonovNS = new Label();
            buttonAdd_AntonovNS = new Button();
            buttonRead_AntonovNS = new Button();
            buttonSave_AntonovNS = new Button();
            textBoxFind_AntonovNS = new TextBox();
            buttonFind_AntonovNS = new Button();
            buttonGraf_AntonovNS = new Button();
            chartMain_AntonovNS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonKol_AntonovNS = new Button();
            labelKol_AntonovNS = new Label();
            buttonMax_AntonovNS = new Button();
            labelMax_AntonovNS = new Label();
            buttonMin_AntonovNS = new Button();
            buttonHalf_AntonovNS = new Button();
            labelMin_AntonovNS = new Label();
            labelHalf_AntonovNS = new Label();
            buttonCont_AntonovNS = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AntonovNS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartMain_AntonovNS).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_AntonovNS
            // 
            dataGridView_AntonovNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AntonovNS.Columns.AddRange(new DataGridViewColumn[] { ColumnNumber, ColumnSurname, ColumnName, ColumnPatronymic, ColumnData, ColumnSurnameName, ColumnPost, ColumnDiagnosis, ColumnOutpatientTreatment, ColumnWorkingCapacity, ColumnOutpatientRegistration, ColumnNote });
            dataGridView_AntonovNS.Location = new Point(2, 12);
            dataGridView_AntonovNS.Name = "dataGridView_AntonovNS";
            dataGridView_AntonovNS.RowHeadersVisible = false;
            dataGridView_AntonovNS.Size = new Size(1257, 475);
            dataGridView_AntonovNS.TabIndex = 0;
            // 
            // ColumnNumber
            // 
            ColumnNumber.HeaderText = "Номер пациента";
            ColumnNumber.Name = "ColumnNumber";
            // 
            // ColumnSurname
            // 
            ColumnSurname.HeaderText = "Фамилия пациента";
            ColumnSurname.Name = "ColumnSurname";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Имя пациента";
            ColumnName.Name = "ColumnName";
            // 
            // ColumnPatronymic
            // 
            ColumnPatronymic.HeaderText = "Отчество пациента";
            ColumnPatronymic.Name = "ColumnPatronymic";
            // 
            // ColumnData
            // 
            ColumnData.HeaderText = "Дата Рождения пациента";
            ColumnData.Name = "ColumnData";
            // 
            // ColumnSurnameName
            // 
            ColumnSurnameName.HeaderText = "ФИО врача";
            ColumnSurnameName.Name = "ColumnSurnameName";
            // 
            // ColumnPost
            // 
            ColumnPost.HeaderText = "Специализация врача";
            ColumnPost.Name = "ColumnPost";
            // 
            // ColumnDiagnosis
            // 
            ColumnDiagnosis.HeaderText = "Диагноз";
            ColumnDiagnosis.Name = "ColumnDiagnosis";
            // 
            // ColumnOutpatientTreatment
            // 
            ColumnOutpatientTreatment.HeaderText = "Амбулаторное лечение";
            ColumnOutpatientTreatment.Name = "ColumnOutpatientTreatment";
            // 
            // ColumnWorkingCapacity
            // 
            ColumnWorkingCapacity.FillWeight = 110F;
            ColumnWorkingCapacity.HeaderText = "Срок потери трудоспособности";
            ColumnWorkingCapacity.Name = "ColumnWorkingCapacity";
            ColumnWorkingCapacity.Width = 120;
            // 
            // ColumnOutpatientRegistration
            // 
            ColumnOutpatientRegistration.HeaderText = "Диспансерский учет";
            ColumnOutpatientRegistration.Name = "ColumnOutpatientRegistration";
            // 
            // ColumnNote
            // 
            ColumnNote.HeaderText = "Примечание";
            ColumnNote.Name = "ColumnNote";
            // 
            // textBoxNumberP_AntonovNS
            // 
            textBoxNumberP_AntonovNS.Location = new Point(1265, 30);
            textBoxNumberP_AntonovNS.Name = "textBoxNumberP_AntonovNS";
            textBoxNumberP_AntonovNS.Size = new Size(100, 23);
            textBoxNumberP_AntonovNS.TabIndex = 1;
            // 
            // textBoxSurnameP_AntonovNS
            // 
            textBoxSurnameP_AntonovNS.Location = new Point(1265, 104);
            textBoxSurnameP_AntonovNS.Name = "textBoxSurnameP_AntonovNS";
            textBoxSurnameP_AntonovNS.Size = new Size(100, 23);
            textBoxSurnameP_AntonovNS.TabIndex = 2;
            // 
            // textBoxName_AntonovNS
            // 
            textBoxName_AntonovNS.Location = new Point(1265, 175);
            textBoxName_AntonovNS.Name = "textBoxName_AntonovNS";
            textBoxName_AntonovNS.Size = new Size(100, 23);
            textBoxName_AntonovNS.TabIndex = 3;
            // 
            // textBoxPatronymic_AntonovNS
            // 
            textBoxPatronymic_AntonovNS.Location = new Point(1265, 253);
            textBoxPatronymic_AntonovNS.Name = "textBoxPatronymic_AntonovNS";
            textBoxPatronymic_AntonovNS.Size = new Size(100, 23);
            textBoxPatronymic_AntonovNS.TabIndex = 4;
            // 
            // textBoxData_AntonovNS
            // 
            textBoxData_AntonovNS.Location = new Point(1265, 331);
            textBoxData_AntonovNS.Name = "textBoxData_AntonovNS";
            textBoxData_AntonovNS.Size = new Size(100, 23);
            textBoxData_AntonovNS.TabIndex = 5;
            // 
            // textBoxFIOV_AntonovNS
            // 
            textBoxFIOV_AntonovNS.Location = new Point(1265, 415);
            textBoxFIOV_AntonovNS.Name = "textBoxFIOV_AntonovNS";
            textBoxFIOV_AntonovNS.Size = new Size(100, 23);
            textBoxFIOV_AntonovNS.TabIndex = 6;
            // 
            // textBoxPost_AntonovNS
            // 
            textBoxPost_AntonovNS.Location = new Point(1497, 30);
            textBoxPost_AntonovNS.Name = "textBoxPost_AntonovNS";
            textBoxPost_AntonovNS.Size = new Size(100, 23);
            textBoxPost_AntonovNS.TabIndex = 7;
            // 
            // textBoxDiagnoz_AntonovNS
            // 
            textBoxDiagnoz_AntonovNS.Location = new Point(1497, 104);
            textBoxDiagnoz_AntonovNS.Name = "textBoxDiagnoz_AntonovNS";
            textBoxDiagnoz_AntonovNS.Size = new Size(100, 23);
            textBoxDiagnoz_AntonovNS.TabIndex = 8;
            // 
            // textBoxHeal_AntonovNS
            // 
            textBoxHeal_AntonovNS.Location = new Point(1497, 175);
            textBoxHeal_AntonovNS.Name = "textBoxHeal_AntonovNS";
            textBoxHeal_AntonovNS.Size = new Size(100, 23);
            textBoxHeal_AntonovNS.TabIndex = 9;
            // 
            // textBoxWork_AntonovNS
            // 
            textBoxWork_AntonovNS.Location = new Point(1497, 253);
            textBoxWork_AntonovNS.Name = "textBoxWork_AntonovNS";
            textBoxWork_AntonovNS.Size = new Size(100, 23);
            textBoxWork_AntonovNS.TabIndex = 10;
            // 
            // textBoxTab_AntonovNS
            // 
            textBoxTab_AntonovNS.Location = new Point(1497, 331);
            textBoxTab_AntonovNS.Name = "textBoxTab_AntonovNS";
            textBoxTab_AntonovNS.Size = new Size(100, 23);
            textBoxTab_AntonovNS.TabIndex = 11;
            // 
            // textBoxNote_AntonovNS
            // 
            textBoxNote_AntonovNS.Location = new Point(1497, 415);
            textBoxNote_AntonovNS.Name = "textBoxNote_AntonovNS";
            textBoxNote_AntonovNS.Size = new Size(100, 23);
            textBoxNote_AntonovNS.TabIndex = 12;
            // 
            // labelNumberP_AntonovNS
            // 
            labelNumberP_AntonovNS.AutoSize = true;
            labelNumberP_AntonovNS.Location = new Point(1265, 12);
            labelNumberP_AntonovNS.Name = "labelNumberP_AntonovNS";
            labelNumberP_AntonovNS.Size = new Size(143, 15);
            labelNumberP_AntonovNS.TabIndex = 13;
            labelNumberP_AntonovNS.Text = "Введите номер пациента";
            // 
            // labelSurnameP_AntonovNS
            // 
            labelSurnameP_AntonovNS.AutoSize = true;
            labelSurnameP_AntonovNS.Location = new Point(1265, 86);
            labelSurnameP_AntonovNS.Name = "labelSurnameP_AntonovNS";
            labelSurnameP_AntonovNS.Size = new Size(162, 15);
            labelSurnameP_AntonovNS.TabIndex = 14;
            labelSurnameP_AntonovNS.Text = "Введите фамилию пациента";
            // 
            // labelName_AntonovNS
            // 
            labelName_AntonovNS.AutoSize = true;
            labelName_AntonovNS.Location = new Point(1265, 157);
            labelName_AntonovNS.Name = "labelName_AntonovNS";
            labelName_AntonovNS.Size = new Size(122, 15);
            labelName_AntonovNS.TabIndex = 15;
            labelName_AntonovNS.Text = "Введите имя пацента";
            // 
            // labelPatronymic_AntonovNS
            // 
            labelPatronymic_AntonovNS.AutoSize = true;
            labelPatronymic_AntonovNS.Location = new Point(1265, 235);
            labelPatronymic_AntonovNS.Name = "labelPatronymic_AntonovNS";
            labelPatronymic_AntonovNS.Size = new Size(156, 15);
            labelPatronymic_AntonovNS.TabIndex = 16;
            labelPatronymic_AntonovNS.Text = "Введите отчество пациента";
            // 
            // labelData_AntonovNS
            // 
            labelData_AntonovNS.AutoSize = true;
            labelData_AntonovNS.Location = new Point(1265, 313);
            labelData_AntonovNS.Name = "labelData_AntonovNS";
            labelData_AntonovNS.Size = new Size(134, 15);
            labelData_AntonovNS.TabIndex = 17;
            labelData_AntonovNS.Text = "Введите дату рождения";
            // 
            // labelFIOV_AntonovNS
            // 
            labelFIOV_AntonovNS.AutoSize = true;
            labelFIOV_AntonovNS.Location = new Point(1265, 397);
            labelFIOV_AntonovNS.Name = "labelFIOV_AntonovNS";
            labelFIOV_AntonovNS.Size = new Size(115, 15);
            labelFIOV_AntonovNS.TabIndex = 18;
            labelFIOV_AntonovNS.Text = "Введите ФИО врача";
            // 
            // labePost_AntonovNS
            // 
            labePost_AntonovNS.AutoSize = true;
            labePost_AntonovNS.Location = new Point(1497, 12);
            labePost_AntonovNS.Name = "labePost_AntonovNS";
            labePost_AntonovNS.Size = new Size(176, 15);
            labePost_AntonovNS.TabIndex = 19;
            labePost_AntonovNS.Text = "Введите специализацию врача";
            // 
            // labelDiagnoz_AntonovNS
            // 
            labelDiagnoz_AntonovNS.AutoSize = true;
            labelDiagnoz_AntonovNS.Location = new Point(1497, 86);
            labelDiagnoz_AntonovNS.Name = "labelDiagnoz_AntonovNS";
            labelDiagnoz_AntonovNS.Size = new Size(96, 15);
            labelDiagnoz_AntonovNS.TabIndex = 20;
            labelDiagnoz_AntonovNS.Text = "Введите диагноз";
            // 
            // labelHeal_AntonovNS
            // 
            labelHeal_AntonovNS.AutoSize = true;
            labelHeal_AntonovNS.Location = new Point(1497, 157);
            labelHeal_AntonovNS.Name = "labelHeal_AntonovNS";
            labelHeal_AntonovNS.Size = new Size(194, 15);
            labelHeal_AntonovNS.TabIndex = 21;
            labelHeal_AntonovNS.Text = "Нужно ли амбулаторное лечение";
            // 
            // labelWork_AntonovNS
            // 
            labelWork_AntonovNS.AutoSize = true;
            labelWork_AntonovNS.Location = new Point(1497, 235);
            labelWork_AntonovNS.Name = "labelWork_AntonovNS";
            labelWork_AntonovNS.Size = new Size(227, 15);
            labelWork_AntonovNS.TabIndex = 22;
            labelWork_AntonovNS.Text = "Введите срок потери трудоспособности";
            // 
            // labelTab_AntonovNS
            // 
            labelTab_AntonovNS.AutoSize = true;
            labelTab_AntonovNS.Location = new Point(1497, 313);
            labelTab_AntonovNS.Name = "labelTab_AntonovNS";
            labelTab_AntonovNS.Size = new Size(212, 15);
            labelTab_AntonovNS.TabIndex = 23;
            labelTab_AntonovNS.Text = "Состоит ли на диспансерском учете?";
            // 
            // labelNote_AntonovNS
            // 
            labelNote_AntonovNS.AutoSize = true;
            labelNote_AntonovNS.Location = new Point(1497, 397);
            labelNote_AntonovNS.Name = "labelNote_AntonovNS";
            labelNote_AntonovNS.Size = new Size(122, 15);
            labelNote_AntonovNS.TabIndex = 24;
            labelNote_AntonovNS.Text = "Введите примечание";
            // 
            // buttonAdd_AntonovNS
            // 
            buttonAdd_AntonovNS.Location = new Point(1353, 464);
            buttonAdd_AntonovNS.Name = "buttonAdd_AntonovNS";
            buttonAdd_AntonovNS.Size = new Size(165, 23);
            buttonAdd_AntonovNS.TabIndex = 25;
            buttonAdd_AntonovNS.Text = "Занести данные в таблицу";
            buttonAdd_AntonovNS.UseVisualStyleBackColor = true;
            buttonAdd_AntonovNS.Click += buttonAdd_Click;
            // 
            // buttonRead_AntonovNS
            // 
            buttonRead_AntonovNS.Location = new Point(1115, 504);
            buttonRead_AntonovNS.Name = "buttonRead_AntonovNS";
            buttonRead_AntonovNS.Size = new Size(68, 56);
            buttonRead_AntonovNS.TabIndex = 26;
            buttonRead_AntonovNS.Text = "Выберите файл";
            buttonRead_AntonovNS.UseVisualStyleBackColor = true;
            buttonRead_AntonovNS.Click += buttonRead_Click;
            // 
            // buttonSave_AntonovNS
            // 
            buttonSave_AntonovNS.Location = new Point(918, 505);
            buttonSave_AntonovNS.Name = "buttonSave_AntonovNS";
            buttonSave_AntonovNS.Size = new Size(75, 56);
            buttonSave_AntonovNS.TabIndex = 27;
            buttonSave_AntonovNS.Text = "Сохранить файл";
            buttonSave_AntonovNS.UseVisualStyleBackColor = true;
            buttonSave_AntonovNS.Click += buttonSave_Click;
            // 
            // textBoxFind_AntonovNS
            // 
            textBoxFind_AntonovNS.Location = new Point(712, 504);
            textBoxFind_AntonovNS.Name = "textBoxFind_AntonovNS";
            textBoxFind_AntonovNS.Size = new Size(100, 23);
            textBoxFind_AntonovNS.TabIndex = 28;
            // 
            // buttonFind_AntonovNS
            // 
            buttonFind_AntonovNS.Location = new Point(713, 533);
            buttonFind_AntonovNS.Name = "buttonFind_AntonovNS";
            buttonFind_AntonovNS.Size = new Size(99, 23);
            buttonFind_AntonovNS.TabIndex = 29;
            buttonFind_AntonovNS.Text = "Найти";
            buttonFind_AntonovNS.UseVisualStyleBackColor = true;
            buttonFind_AntonovNS.Click += buttonFind_Click;
            // 
            // buttonGraf_AntonovNS
            // 
            buttonGraf_AntonovNS.Location = new Point(222, 837);
            buttonGraf_AntonovNS.Name = "buttonGraf_AntonovNS";
            buttonGraf_AntonovNS.Size = new Size(75, 73);
            buttonGraf_AntonovNS.TabIndex = 30;
            buttonGraf_AntonovNS.Text = "Сформировать график";
            buttonGraf_AntonovNS.UseVisualStyleBackColor = true;
            buttonGraf_AntonovNS.Click += buttonGraf_Click;
            // 
            // chartMain_AntonovNS
            // 
            chartArea2.Name = "ChartArea1";
            chartMain_AntonovNS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartMain_AntonovNS.Legends.Add(legend2);
            chartMain_AntonovNS.Location = new Point(12, 504);
            chartMain_AntonovNS.Name = "chartMain_AntonovNS";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartMain_AntonovNS.Series.Add(series2);
            chartMain_AntonovNS.Size = new Size(552, 300);
            chartMain_AntonovNS.TabIndex = 31;
            chartMain_AntonovNS.Text = "Необходимость абулаторного лечения";
            // 
            // buttonKol_AntonovNS
            // 
            buttonKol_AntonovNS.Location = new Point(1513, 553);
            buttonKol_AntonovNS.Name = "buttonKol_AntonovNS";
            buttonKol_AntonovNS.Size = new Size(141, 73);
            buttonKol_AntonovNS.TabIndex = 32;
            buttonKol_AntonovNS.Text = "Нажмите чтобы узнать количество пацинтов";
            buttonKol_AntonovNS.UseVisualStyleBackColor = true;
            buttonKol_AntonovNS.Click += buttonKol_Click;
            // 
            // labelKol_AntonovNS
            // 
            labelKol_AntonovNS.AutoSize = true;
            labelKol_AntonovNS.Location = new Point(1581, 660);
            labelKol_AntonovNS.Name = "labelKol_AntonovNS";
            labelKol_AntonovNS.Size = new Size(0, 15);
            labelKol_AntonovNS.TabIndex = 33;
            // 
            // buttonMax_AntonovNS
            // 
            buttonMax_AntonovNS.Location = new Point(1295, 553);
            buttonMax_AntonovNS.Name = "buttonMax_AntonovNS";
            buttonMax_AntonovNS.Size = new Size(141, 73);
            buttonMax_AntonovNS.TabIndex = 34;
            buttonMax_AntonovNS.Text = "Нажмите чтобы узнать максимальный срок потери трудоспособности";
            buttonMax_AntonovNS.UseVisualStyleBackColor = true;
            buttonMax_AntonovNS.Click += buttonMax_Click;
            // 
            // labelMax_AntonovNS
            // 
            labelMax_AntonovNS.AutoSize = true;
            labelMax_AntonovNS.Location = new Point(1353, 660);
            labelMax_AntonovNS.Name = "labelMax_AntonovNS";
            labelMax_AntonovNS.Size = new Size(0, 15);
            labelMax_AntonovNS.TabIndex = 35;
            // 
            // buttonMin_AntonovNS
            // 
            buttonMin_AntonovNS.Location = new Point(1295, 715);
            buttonMin_AntonovNS.Name = "buttonMin_AntonovNS";
            buttonMin_AntonovNS.Size = new Size(141, 73);
            buttonMin_AntonovNS.TabIndex = 36;
            buttonMin_AntonovNS.Text = "Нажмите чтобы узнать минимальный срок потери трудоспособности";
            buttonMin_AntonovNS.UseVisualStyleBackColor = true;
            buttonMin_AntonovNS.Click += buttonMin_Click;
            // 
            // buttonHalf_AntonovNS
            // 
            buttonHalf_AntonovNS.Location = new Point(1513, 715);
            buttonHalf_AntonovNS.Name = "buttonHalf_AntonovNS";
            buttonHalf_AntonovNS.Size = new Size(141, 73);
            buttonHalf_AntonovNS.TabIndex = 37;
            buttonHalf_AntonovNS.Text = "Нажмите чтобы узнать средний срок потери трудоспособности";
            buttonHalf_AntonovNS.UseVisualStyleBackColor = true;
            buttonHalf_AntonovNS.Click += buttonHalf_Click;
            // 
            // labelMin_AntonovNS
            // 
            labelMin_AntonovNS.AutoSize = true;
            labelMin_AntonovNS.Location = new Point(1365, 837);
            labelMin_AntonovNS.Name = "labelMin_AntonovNS";
            labelMin_AntonovNS.Size = new Size(0, 15);
            labelMin_AntonovNS.TabIndex = 38;
            // 
            // labelHalf_AntonovNS
            // 
            labelHalf_AntonovNS.AutoSize = true;
            labelHalf_AntonovNS.Location = new Point(1581, 837);
            labelHalf_AntonovNS.Name = "labelHalf_AntonovNS";
            labelHalf_AntonovNS.Size = new Size(0, 15);
            labelHalf_AntonovNS.TabIndex = 39;
            // 
            // buttonCont_AntonovNS
            // 
            buttonCont_AntonovNS.Location = new Point(1649, 894);
            buttonCont_AntonovNS.Name = "buttonCont_AntonovNS";
            buttonCont_AntonovNS.Size = new Size(75, 57);
            buttonCont_AntonovNS.TabIndex = 40;
            buttonCont_AntonovNS.Text = "Справка";
            buttonCont_AntonovNS.UseVisualStyleBackColor = true;
            buttonCont_AntonovNS.Click += buttonCont_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1742, 963);
            Controls.Add(buttonCont_AntonovNS);
            Controls.Add(labelHalf_AntonovNS);
            Controls.Add(labelMin_AntonovNS);
            Controls.Add(buttonHalf_AntonovNS);
            Controls.Add(buttonMin_AntonovNS);
            Controls.Add(labelMax_AntonovNS);
            Controls.Add(buttonMax_AntonovNS);
            Controls.Add(labelKol_AntonovNS);
            Controls.Add(buttonKol_AntonovNS);
            Controls.Add(chartMain_AntonovNS);
            Controls.Add(buttonGraf_AntonovNS);
            Controls.Add(buttonFind_AntonovNS);
            Controls.Add(textBoxFind_AntonovNS);
            Controls.Add(buttonSave_AntonovNS);
            Controls.Add(buttonRead_AntonovNS);
            Controls.Add(buttonAdd_AntonovNS);
            Controls.Add(labelNote_AntonovNS);
            Controls.Add(labelTab_AntonovNS);
            Controls.Add(labelWork_AntonovNS);
            Controls.Add(labelHeal_AntonovNS);
            Controls.Add(labelDiagnoz_AntonovNS);
            Controls.Add(labePost_AntonovNS);
            Controls.Add(labelFIOV_AntonovNS);
            Controls.Add(labelData_AntonovNS);
            Controls.Add(labelPatronymic_AntonovNS);
            Controls.Add(labelName_AntonovNS);
            Controls.Add(labelSurnameP_AntonovNS);
            Controls.Add(labelNumberP_AntonovNS);
            Controls.Add(textBoxNote_AntonovNS);
            Controls.Add(textBoxTab_AntonovNS);
            Controls.Add(textBoxWork_AntonovNS);
            Controls.Add(textBoxHeal_AntonovNS);
            Controls.Add(textBoxDiagnoz_AntonovNS);
            Controls.Add(textBoxPost_AntonovNS);
            Controls.Add(textBoxFIOV_AntonovNS);
            Controls.Add(textBoxData_AntonovNS);
            Controls.Add(textBoxPatronymic_AntonovNS);
            Controls.Add(textBoxName_AntonovNS);
            Controls.Add(textBoxSurnameP_AntonovNS);
            Controls.Add(textBoxNumberP_AntonovNS);
            Controls.Add(dataGridView_AntonovNS);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Антонов Н.С. | Sprint 7| Project | V0";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_AntonovNS).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartMain_AntonovNS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_AntonovNS;
        private DataGridViewTextBoxColumn ColumnNumber;
        private DataGridViewTextBoxColumn ColumnSurname;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnPatronymic;
        private DataGridViewTextBoxColumn ColumnData;
        private DataGridViewTextBoxColumn ColumnSurnameName;
        private DataGridViewTextBoxColumn ColumnPost;
        private DataGridViewTextBoxColumn ColumnDiagnosis;
        private DataGridViewTextBoxColumn ColumnOutpatientTreatment;
        private DataGridViewTextBoxColumn ColumnWorkingCapacity;
        private DataGridViewTextBoxColumn ColumnOutpatientRegistration;
        private DataGridViewTextBoxColumn ColumnNote;
        private TextBox textBoxNumberP_AntonovNS;
        private TextBox textBoxSurnameP_AntonovNS;
        private TextBox textBoxName_AntonovNS;
        private TextBox textBoxPatronymic_AntonovNS;
        private TextBox textBoxData_AntonovNS;
        private TextBox textBoxFIOV_AntonovNS;
        private TextBox textBoxPost_AntonovNS;
        private TextBox textBoxDiagnoz_AntonovNS;
        private TextBox textBoxHeal_AntonovNS;
        private TextBox textBoxWork_AntonovNS;
        private TextBox textBoxTab_AntonovNS;
        private TextBox textBoxNote_AntonovNS;
        private Label labelNumberP_AntonovNS;
        private Label labelSurnameP_AntonovNS;
        private Label labelName_AntonovNS;
        private Label labelPatronymic_AntonovNS;
        private Label labelData_AntonovNS;
        private Label labelFIOV_AntonovNS;
        private Label labePost_AntonovNS;
        private Label labelDiagnoz_AntonovNS;
        private Label labelHeal_AntonovNS;
        private Label labelWork_AntonovNS;
        private Label labelTab_AntonovNS;
        private Label labelNote_AntonovNS;
        private Button buttonAdd_AntonovNS;
        private Button buttonRead_AntonovNS;
        private Button buttonSave_AntonovNS;
        private TextBox textBoxFind_AntonovNS;
        private Button buttonFind_AntonovNS;
        private Button buttonGraf_AntonovNS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain_AntonovNS;
        private Button buttonKol_AntonovNS;
        private Label labelKol_AntonovNS;
        private Button buttonMax_AntonovNS;
        private Label labelMax_AntonovNS;
        private Button buttonMin_AntonovNS;
        private Button buttonHalf_AntonovNS;
        private Label labelMin_AntonovNS;
        private Label labelHalf_AntonovNS;
        private Button buttonCont_AntonovNS;
    }
}
