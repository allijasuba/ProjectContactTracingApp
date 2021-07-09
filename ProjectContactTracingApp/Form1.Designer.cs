
namespace ProjectContactTracingApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFn = new System.Windows.Forms.Label();
            this.lblCn = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLn = new System.Windows.Forms.Label();
            this.lblMi = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHc = new System.Windows.Forms.Label();
            this.lblFever = new System.Windows.Forms.Label();
            this.lblDc = new System.Windows.Forms.Label();
            this.lblHa = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.lblAyav = new System.Windows.Forms.Label();
            this.lblSt = new System.Windows.Forms.Label();
            this.lblHcc = new System.Windows.Forms.Label();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.txtMi = new System.Windows.Forms.TextBox();
            this.txtLn = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtCn = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFever = new System.Windows.Forms.TextBox();
            this.txtDc = new System.Windows.Forms.TextBox();
            this.txtHa = new System.Windows.Forms.TextBox();
            this.txtSt = new System.Windows.Forms.TextBox();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.txtAyav = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectContactTracingAppDataSet = new ProjectContactTracingApp.ProjectContactTracingAppDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new ProjectContactTracingApp.ProjectContactTracingAppDataSetTableAdapters.PersonsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIDDLEINITIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPERATUREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEVERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRYCOUGHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEADACHEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sORETHROATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTHERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aREYOUALREADYVACCINATEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectContactTracingAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFn
            // 
            this.lblFn.AutoSize = true;
            this.lblFn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFn.Location = new System.Drawing.Point(25, 28);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(110, 25);
            this.lblFn.TabIndex = 0;
            this.lblFn.Text = "FIRSTNAME";
            // 
            // lblCn
            // 
            this.lblCn.AutoSize = true;
            this.lblCn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCn.Location = new System.Drawing.Point(25, 118);
            this.lblCn.Name = "lblCn";
            this.lblCn.Size = new System.Drawing.Size(172, 25);
            this.lblCn.TabIndex = 1;
            this.lblCn.Text = "CONTACT NUMBER";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(627, 76);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(140, 25);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.Text = "TEMPERATURE";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(350, 74);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(45, 25);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "SEX";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(25, 75);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(47, 25);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "AGE";
            // 
            // lblLn
            // 
            this.lblLn.AutoSize = true;
            this.lblLn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLn.Location = new System.Drawing.Point(627, 28);
            this.lblLn.Name = "lblLn";
            this.lblLn.Size = new System.Drawing.Size(104, 25);
            this.lblLn.TabIndex = 5;
            this.lblLn.Text = "LASTNAME";
            // 
            // lblMi
            // 
            this.lblMi.AutoSize = true;
            this.lblMi.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMi.Location = new System.Drawing.Point(350, 28);
            this.lblMi.Name = "lblMi";
            this.lblMi.Size = new System.Drawing.Size(132, 25);
            this.lblMi.TabIndex = 6;
            this.lblMi.Text = "MIDDLEINITIAL";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(25, 158);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddress.Size = new System.Drawing.Size(92, 25);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "ADDRESS";
            // 
            // lblHc
            // 
            this.lblHc.AutoSize = true;
            this.lblHc.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHc.Location = new System.Drawing.Point(25, 200);
            this.lblHc.Name = "lblHc";
            this.lblHc.Size = new System.Drawing.Size(182, 25);
            this.lblHc.TabIndex = 8;
            this.lblHc.Text = "HEALTH CONDITION:";
            // 
            // lblFever
            // 
            this.lblFever.AutoSize = true;
            this.lblFever.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFever.Location = new System.Drawing.Point(25, 250);
            this.lblFever.Name = "lblFever";
            this.lblFever.Size = new System.Drawing.Size(68, 25);
            this.lblFever.TabIndex = 10;
            this.lblFever.Text = "FEVER";
            // 
            // lblDc
            // 
            this.lblDc.AutoSize = true;
            this.lblDc.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDc.Location = new System.Drawing.Point(213, 250);
            this.lblDc.Name = "lblDc";
            this.lblDc.Size = new System.Drawing.Size(115, 25);
            this.lblDc.TabIndex = 11;
            this.lblDc.Text = "DRY COUGH";
            // 
            // lblHa
            // 
            this.lblHa.AutoSize = true;
            this.lblHa.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHa.Location = new System.Drawing.Point(492, 250);
            this.lblHa.Name = "lblHa";
            this.lblHa.Size = new System.Drawing.Size(104, 25);
            this.lblHa.TabIndex = 12;
            this.lblHa.Text = "HEADACHE";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers.Location = new System.Drawing.Point(25, 298);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(82, 25);
            this.lblOthers.TabIndex = 13;
            this.lblOthers.Text = "OTHERS";
            // 
            // lblAyav
            // 
            this.lblAyav.AutoSize = true;
            this.lblAyav.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyav.Location = new System.Drawing.Point(25, 347);
            this.lblAyav.Name = "lblAyav";
            this.lblAyav.Size = new System.Drawing.Size(294, 25);
            this.lblAyav.TabIndex = 14;
            this.lblAyav.Text = "ARE YOU ALREADY VACCINATED?";
            // 
            // lblSt
            // 
            this.lblSt.AutoSize = true;
            this.lblSt.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSt.Location = new System.Drawing.Point(699, 250);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(134, 25);
            this.lblSt.TabIndex = 15;
            this.lblSt.Text = "SORE THROAT";
            // 
            // lblHcc
            // 
            this.lblHcc.AutoSize = true;
            this.lblHcc.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHcc.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblHcc.Location = new System.Drawing.Point(213, 200);
            this.lblHcc.Name = "lblHcc";
            this.lblHcc.Size = new System.Drawing.Size(520, 25);
            this.lblHcc.TabIndex = 16;
            this.lblHcc.Text = "(Please type YES if you had experience those health conditions)";
            // 
            // txtFn
            // 
            this.txtFn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "FIRSTNAME", true));
            this.txtFn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFn.Location = new System.Drawing.Point(141, 27);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(203, 26);
            this.txtFn.TabIndex = 17;
            // 
            // txtMi
            // 
            this.txtMi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "MIDDLEINITIAL", true));
            this.txtMi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMi.Location = new System.Drawing.Point(488, 27);
            this.txtMi.Name = "txtMi";
            this.txtMi.Size = new System.Drawing.Size(133, 26);
            this.txtMi.TabIndex = 18;
            // 
            // txtLn
            // 
            this.txtLn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "LASTNAME", true));
            this.txtLn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLn.Location = new System.Drawing.Point(737, 27);
            this.txtLn.Name = "txtLn";
            this.txtLn.Size = new System.Drawing.Size(222, 26);
            this.txtLn.TabIndex = 19;
            // 
            // txtAge
            // 
            this.txtAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "AGE", true));
            this.txtAge.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(78, 74);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(266, 26);
            this.txtAge.TabIndex = 20;
            // 
            // txtSex
            // 
            this.txtSex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "SEX", true));
            this.txtSex.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.Location = new System.Drawing.Point(401, 75);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(220, 26);
            this.txtSex.TabIndex = 21;
            // 
            // txtTemp
            // 
            this.txtTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "TEMPERATURE", true));
            this.txtTemp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(769, 73);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(190, 26);
            this.txtTemp.TabIndex = 22;
            // 
            // txtCn
            // 
            this.txtCn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "CONTACT NUMBER", true));
            this.txtCn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCn.Location = new System.Drawing.Point(203, 117);
            this.txtCn.Name = "txtCn";
            this.txtCn.Size = new System.Drawing.Size(756, 26);
            this.txtCn.TabIndex = 23;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "ADDRESS", true));
            this.txtAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(123, 157);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(836, 26);
            this.txtAddress.TabIndex = 24;
            // 
            // txtFever
            // 
            this.txtFever.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "FEVER", true));
            this.txtFever.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFever.Location = new System.Drawing.Point(99, 249);
            this.txtFever.Name = "txtFever";
            this.txtFever.Size = new System.Drawing.Size(108, 26);
            this.txtFever.TabIndex = 25;
            // 
            // txtDc
            // 
            this.txtDc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "DRY COUGH", true));
            this.txtDc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDc.Location = new System.Drawing.Point(334, 249);
            this.txtDc.Name = "txtDc";
            this.txtDc.Size = new System.Drawing.Size(152, 26);
            this.txtDc.TabIndex = 26;
            // 
            // txtHa
            // 
            this.txtHa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "HEADACHE", true));
            this.txtHa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHa.Location = new System.Drawing.Point(602, 249);
            this.txtHa.Name = "txtHa";
            this.txtHa.Size = new System.Drawing.Size(91, 26);
            this.txtHa.TabIndex = 27;
            // 
            // txtSt
            // 
            this.txtSt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "SORE THROAT", true));
            this.txtSt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSt.Location = new System.Drawing.Point(839, 249);
            this.txtSt.Name = "txtSt";
            this.txtSt.Size = new System.Drawing.Size(120, 26);
            this.txtSt.TabIndex = 28;
            // 
            // txtOthers
            // 
            this.txtOthers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "OTHERS", true));
            this.txtOthers.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOthers.Location = new System.Drawing.Point(113, 297);
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(846, 26);
            this.txtOthers.TabIndex = 29;
            // 
            // txtAyav
            // 
            this.txtAyav.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "ARE YOU ALREADY VACCINATED?", true));
            this.txtAyav.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAyav.Location = new System.Drawing.Point(325, 346);
            this.txtAyav.Name = "txtAyav";
            this.txtAyav.Size = new System.Drawing.Size(634, 26);
            this.txtAyav.TabIndex = 30;
            this.txtAyav.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(25, 574);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 44);
            this.btnNew.TabIndex = 31;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 574);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 44);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(264, 574);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 44);
            this.btnRemove.TabIndex = 33;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(379, 574);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(87, 44);
            this.btnFirst.TabIndex = 34;
            this.btnFirst.Text = "FIRST";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(495, 574);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(87, 44);
            this.btnLast.TabIndex = 35;
            this.btnLast.Text = "LAST";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(622, 574);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 44);
            this.btnNext.TabIndex = 36;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(743, 574);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(87, 44);
            this.btnPrevious.TabIndex = 37;
            this.btnPrevious.Text = "PREVIOUS";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(872, 574);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 44);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.mIDDLEINITIALDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.sEXDataGridViewTextBoxColumn,
            this.tEMPERATUREDataGridViewTextBoxColumn,
            this.cONTACTNUMBERDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.fEVERDataGridViewTextBoxColumn,
            this.dRYCOUGHDataGridViewTextBoxColumn,
            this.hEADACHEDataGridViewTextBoxColumn,
            this.sORETHROATDataGridViewTextBoxColumn,
            this.oTHERSDataGridViewTextBoxColumn,
            this.aREYOUALREADYVACCINATEDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(929, 150);
            this.dataGridView1.TabIndex = 39;
            // 
            // projectContactTracingAppDataSet
            // 
            this.projectContactTracingAppDataSet.DataSetName = "ProjectContactTracingAppDataSet";
            this.projectContactTracingAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.projectContactTracingAppDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // mIDDLEINITIALDataGridViewTextBoxColumn
            // 
            this.mIDDLEINITIALDataGridViewTextBoxColumn.DataPropertyName = "MIDDLEINITIAL";
            this.mIDDLEINITIALDataGridViewTextBoxColumn.HeaderText = "MIDDLEINITIAL";
            this.mIDDLEINITIALDataGridViewTextBoxColumn.Name = "mIDDLEINITIALDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            // 
            // sEXDataGridViewTextBoxColumn
            // 
            this.sEXDataGridViewTextBoxColumn.DataPropertyName = "SEX";
            this.sEXDataGridViewTextBoxColumn.HeaderText = "SEX";
            this.sEXDataGridViewTextBoxColumn.Name = "sEXDataGridViewTextBoxColumn";
            // 
            // tEMPERATUREDataGridViewTextBoxColumn
            // 
            this.tEMPERATUREDataGridViewTextBoxColumn.DataPropertyName = "TEMPERATURE";
            this.tEMPERATUREDataGridViewTextBoxColumn.HeaderText = "TEMPERATURE";
            this.tEMPERATUREDataGridViewTextBoxColumn.Name = "tEMPERATUREDataGridViewTextBoxColumn";
            // 
            // cONTACTNUMBERDataGridViewTextBoxColumn
            // 
            this.cONTACTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "CONTACT NUMBER";
            this.cONTACTNUMBERDataGridViewTextBoxColumn.HeaderText = "CONTACT NUMBER";
            this.cONTACTNUMBERDataGridViewTextBoxColumn.Name = "cONTACTNUMBERDataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // fEVERDataGridViewTextBoxColumn
            // 
            this.fEVERDataGridViewTextBoxColumn.DataPropertyName = "FEVER";
            this.fEVERDataGridViewTextBoxColumn.HeaderText = "FEVER";
            this.fEVERDataGridViewTextBoxColumn.Name = "fEVERDataGridViewTextBoxColumn";
            // 
            // dRYCOUGHDataGridViewTextBoxColumn
            // 
            this.dRYCOUGHDataGridViewTextBoxColumn.DataPropertyName = "DRY COUGH";
            this.dRYCOUGHDataGridViewTextBoxColumn.HeaderText = "DRY COUGH";
            this.dRYCOUGHDataGridViewTextBoxColumn.Name = "dRYCOUGHDataGridViewTextBoxColumn";
            // 
            // hEADACHEDataGridViewTextBoxColumn
            // 
            this.hEADACHEDataGridViewTextBoxColumn.DataPropertyName = "HEADACHE";
            this.hEADACHEDataGridViewTextBoxColumn.HeaderText = "HEADACHE";
            this.hEADACHEDataGridViewTextBoxColumn.Name = "hEADACHEDataGridViewTextBoxColumn";
            // 
            // sORETHROATDataGridViewTextBoxColumn
            // 
            this.sORETHROATDataGridViewTextBoxColumn.DataPropertyName = "SORE THROAT";
            this.sORETHROATDataGridViewTextBoxColumn.HeaderText = "SORE THROAT";
            this.sORETHROATDataGridViewTextBoxColumn.Name = "sORETHROATDataGridViewTextBoxColumn";
            // 
            // oTHERSDataGridViewTextBoxColumn
            // 
            this.oTHERSDataGridViewTextBoxColumn.DataPropertyName = "OTHERS";
            this.oTHERSDataGridViewTextBoxColumn.HeaderText = "OTHERS";
            this.oTHERSDataGridViewTextBoxColumn.Name = "oTHERSDataGridViewTextBoxColumn";
            // 
            // aREYOUALREADYVACCINATEDDataGridViewTextBoxColumn
            // 
            this.aREYOUALREADYVACCINATEDDataGridViewTextBoxColumn.DataPropertyName = "ARE YOU ALREADY VACCINATED?";
            this.aREYOUALREADYVACCINATEDDataGridViewTextBoxColumn.HeaderText = "ARE YOU ALREADY VACCINATED?";
            this.aREYOUALREADYVACCINATEDDataGridViewTextBoxColumn.Name = "aREYOUALREADYVACCINATEDDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtAyav);
            this.Controls.Add(this.txtOthers);
            this.Controls.Add(this.txtSt);
            this.Controls.Add(this.txtHa);
            this.Controls.Add(this.txtDc);
            this.Controls.Add(this.txtFever);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCn);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLn);
            this.Controls.Add(this.txtMi);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.lblHcc);
            this.Controls.Add(this.lblSt);
            this.Controls.Add(this.lblAyav);
            this.Controls.Add(this.lblOthers);
            this.Controls.Add(this.lblHa);
            this.Controls.Add(this.lblDc);
            this.Controls.Add(this.lblFever);
            this.Controls.Add(this.lblHc);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMi);
            this.Controls.Add(this.lblLn);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblCn);
            this.Controls.Add(this.lblFn);
            this.Name = "Form1";
            this.Text = "Contact Tracing ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectContactTracingAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFn;
        private System.Windows.Forms.Label lblCn;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLn;
        private System.Windows.Forms.Label lblMi;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHc;
        private System.Windows.Forms.Label lblFever;
        private System.Windows.Forms.Label lblDc;
        private System.Windows.Forms.Label lblHa;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.Label lblAyav;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.Label lblHcc;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.TextBox txtMi;
        private System.Windows.Forms.TextBox txtLn;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtCn;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFever;
        private System.Windows.Forms.TextBox txtDc;
        private System.Windows.Forms.TextBox txtHa;
        private System.Windows.Forms.TextBox txtSt;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.TextBox txtAyav;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectContactTracingAppDataSet projectContactTracingAppDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private ProjectContactTracingAppDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDLEINITIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPERATUREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEVERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRYCOUGHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEADACHEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sORETHROATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTHERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aREYOUALREADYVACCINATEDDataGridViewTextBoxColumn;
    }
}

