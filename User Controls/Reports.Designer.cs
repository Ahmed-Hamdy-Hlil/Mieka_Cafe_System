namespace Sales.User_Controls
{
    partial class Reports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_shift = new System.Windows.Forms.ListBox();
            this.lb_order = new System.Windows.Forms.ListBox();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.btn_shiftcash = new System.Windows.Forms.Button();
            this.btn_shiftsales = new System.Windows.Forms.Button();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_datesales = new System.Windows.Forms.Button();
            this.btn_datecash = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 35);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_shift
            // 
            this.lb_shift.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_shift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_shift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lb_shift.FormattingEnabled = true;
            this.lb_shift.ItemHeight = 25;
            this.lb_shift.Location = new System.Drawing.Point(0, 20);
            this.lb_shift.Margin = new System.Windows.Forms.Padding(0, 0, 1, 2);
            this.lb_shift.Name = "lb_shift";
            this.lb_shift.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.SetRowSpan(this.lb_shift, 9);
            this.lb_shift.Size = new System.Drawing.Size(146, 407);
            this.lb_shift.TabIndex = 7;
            this.lb_shift.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_shift_DrawItem);
            this.lb_shift.SelectedIndexChanged += new System.EventHandler(this.lb_shift_SelectedIndexChanged);
            // 
            // lb_order
            // 
            this.lb_order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_order.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lb_order.FormattingEnabled = true;
            this.lb_order.ItemHeight = 25;
            this.lb_order.Location = new System.Drawing.Point(148, 20);
            this.lb_order.Margin = new System.Windows.Forms.Padding(1, 0, 2, 2);
            this.lb_order.Name = "lb_order";
            this.lb_order.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.SetRowSpan(this.lb_order, 9);
            this.lb_order.Size = new System.Drawing.Size(144, 407);
            this.lb_order.TabIndex = 8;
            this.lb_order.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_order_DrawItem_1);
            this.lb_order.SelectedIndexChanged += new System.EventHandler(this.lb_order_SelectedIndexChanged);
            // 
            // dgv_details
            // 
            this.dgv_details.AllowUserToAddRows = false;
            this.dgv_details.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HSN Shahd Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.dgv_details.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_details.BackgroundColor = System.Drawing.Color.White;
            this.dgv_details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_details.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HSN Shahd Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_details.Location = new System.Drawing.Point(296, 22);
            this.dgv_details.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.ReadOnly = true;
            this.dgv_details.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_details.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableLayoutPanel1.SetRowSpan(this.dgv_details, 3);
            this.dgv_details.RowTemplate.Height = 24;
            this.dgv_details.Size = new System.Drawing.Size(437, 261);
            this.dgv_details.TabIndex = 9;
            // 
            // btn_invoice
            // 
            this.btn_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.btn_invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_invoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice.ForeColor = System.Drawing.Color.White;
            this.btn_invoice.Location = new System.Drawing.Point(2, 2);
            this.btn_invoice.Margin = new System.Windows.Forms.Padding(2);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(141, 36);
            this.btn_invoice.TabIndex = 11;
            this.btn_invoice.Text = "طباعه الفاتوره";
            this.btn_invoice.UseVisualStyleBackColor = false;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // btn_shiftcash
            // 
            this.btn_shiftcash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.btn_shiftcash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_shiftcash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.btn_shiftcash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shiftcash.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shiftcash.ForeColor = System.Drawing.Color.White;
            this.btn_shiftcash.Location = new System.Drawing.Point(292, 2);
            this.btn_shiftcash.Margin = new System.Windows.Forms.Padding(2);
            this.btn_shiftcash.Name = "btn_shiftcash";
            this.btn_shiftcash.Size = new System.Drawing.Size(141, 36);
            this.btn_shiftcash.TabIndex = 12;
            this.btn_shiftcash.Text = "طباعه تقرير الماليه";
            this.btn_shiftcash.UseVisualStyleBackColor = false;
            this.btn_shiftcash.Click += new System.EventHandler(this.btn_shiftcash_Click);
            // 
            // btn_shiftsales
            // 
            this.btn_shiftsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.btn_shiftsales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_shiftsales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.btn_shiftsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shiftsales.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shiftsales.ForeColor = System.Drawing.Color.White;
            this.btn_shiftsales.Location = new System.Drawing.Point(147, 2);
            this.btn_shiftsales.Margin = new System.Windows.Forms.Padding(2);
            this.btn_shiftsales.Name = "btn_shiftsales";
            this.btn_shiftsales.Size = new System.Drawing.Size(141, 36);
            this.btn_shiftsales.TabIndex = 13;
            this.btn_shiftsales.Text = "طباعه تقرير تفصيلي";
            this.btn_shiftsales.UseVisualStyleBackColor = false;
            this.btn_shiftsales.Click += new System.EventHandler(this.btn_shiftsales_Click);
            // 
            // dt_from
            // 
            this.dt_from.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dt_from.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(156)))), ((int)(((byte)(0)))));
            this.dt_from.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.dt_from.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dt_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_from.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dt_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_from.Location = new System.Drawing.Point(121, 2);
            this.dt_from.Margin = new System.Windows.Forms.Padding(2);
            this.dt_from.Name = "dt_from";
            this.dt_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dt_from.RightToLeftLayout = true;
            this.dt_from.Size = new System.Drawing.Size(224, 24);
            this.dt_from.TabIndex = 14;
            // 
            // dt_to
            // 
            this.dt_to.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dt_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_to.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dt_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_to.Location = new System.Drawing.Point(121, 42);
            this.dt_to.Margin = new System.Windows.Forms.Padding(2);
            this.dt_to.Name = "dt_to";
            this.dt_to.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dt_to.RightToLeftLayout = true;
            this.dt_to.Size = new System.Drawing.Size(224, 24);
            this.dt_to.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(360, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(56, 40);
            this.label2.TabIndex = 16;
            this.label2.Text = "التاريخ من:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(357, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(59, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "التاريخ الي:";
            // 
            // btn_datesales
            // 
            this.btn_datesales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.btn_datesales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_datesales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.btn_datesales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datesales.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datesales.ForeColor = System.Drawing.Color.White;
            this.btn_datesales.Location = new System.Drawing.Point(2, 2);
            this.btn_datesales.Margin = new System.Windows.Forms.Padding(2);
            this.btn_datesales.Name = "btn_datesales";
            this.btn_datesales.Size = new System.Drawing.Size(115, 36);
            this.btn_datesales.TabIndex = 18;
            this.btn_datesales.Text = "طباعه تقرير تفصيلي";
            this.btn_datesales.UseVisualStyleBackColor = false;
            this.btn_datesales.Click += new System.EventHandler(this.btn_datesales_Click);
            // 
            // btn_datecash
            // 
            this.btn_datecash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.btn_datecash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_datecash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(13)))));
            this.btn_datecash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datecash.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datecash.ForeColor = System.Drawing.Color.White;
            this.btn_datecash.Location = new System.Drawing.Point(2, 42);
            this.btn_datecash.Margin = new System.Windows.Forms.Padding(2);
            this.btn_datecash.Name = "btn_datecash";
            this.btn_datecash.Size = new System.Drawing.Size(115, 37);
            this.btn_datecash.TabIndex = 17;
            this.btn_datecash.Text = "طباعه تقرير الماليه";
            this.btn_datecash.UseVisualStyleBackColor = false;
            this.btn_datecash.Click += new System.EventHandler(this.btn_datecash_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lb_shift, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_order, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_details, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.bunifuSeparator1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bunifuSeparator2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.33173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.09027F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.163122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.41488F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 429);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel3.Controls.Add(this.btn_invoice, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_shiftsales, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_shiftcash, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(297, 296);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(435, 39);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.dt_from, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.dt_to, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_datecash, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_datesales, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(317, 348);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel4, 3);
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(418, 81);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(297, 288);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(435, 2);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 200;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(297, 341);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(435, 4);
            this.bunifuSeparator2.TabIndex = 22;
            this.bunifuSeparator2.Transparency = 200;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "شفتات";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(148, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "طلبات";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(295, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "عرض البيانات";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(735, 41);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("HSN Shahd Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(43, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "التقارير";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(735, 470);
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lb_shift;
        private System.Windows.Forms.ListBox lb_order;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.Button btn_invoice;
        private System.Windows.Forms.Button btn_shiftcash;
        private System.Windows.Forms.Button btn_shiftsales;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.DateTimePicker dt_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_datesales;
        private System.Windows.Forms.Button btn_datecash;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
