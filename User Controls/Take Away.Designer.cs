namespace Sales.User_Controls
{
    partial class Take_Away
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Take_Away));
            this.button2 = new System.Windows.Forms.Button();
            this.nm_nettotal = new System.Windows.Forms.NumericUpDown();
            this.nm_discount = new System.Windows.Forms.NumericUpDown();
            this.nm_disratio = new System.Windows.Forms.NumericUpDown();
            this.nm_total = new System.Windows.Forms.NumericUpDown();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nm_quantity = new System.Windows.Forms.NumericUpDown();
            this.lb_product = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_cat = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nettotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_disratio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_quantity)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(156)))), ((int)(((byte)(0)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(156)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(297, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(435, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "اضف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nm_nettotal
            // 
            this.nm_nettotal.DecimalPlaces = 2;
            this.nm_nettotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nm_nettotal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.nm_nettotal.Location = new System.Drawing.Point(2, 122);
            this.nm_nettotal.Margin = new System.Windows.Forms.Padding(2);
            this.nm_nettotal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nm_nettotal.Name = "nm_nettotal";
            this.nm_nettotal.ReadOnly = true;
            this.nm_nettotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nm_nettotal.Size = new System.Drawing.Size(335, 25);
            this.nm_nettotal.TabIndex = 18;
            // 
            // nm_discount
            // 
            this.nm_discount.DecimalPlaces = 2;
            this.nm_discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nm_discount.Font = new System.Drawing.Font("Tahoma", 11F);
            this.nm_discount.Location = new System.Drawing.Point(2, 62);
            this.nm_discount.Margin = new System.Windows.Forms.Padding(2);
            this.nm_discount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nm_discount.Name = "nm_discount";
            this.nm_discount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nm_discount.Size = new System.Drawing.Size(335, 25);
            this.nm_discount.TabIndex = 17;
            this.nm_discount.ValueChanged += new System.EventHandler(this.nm_discount_ValueChanged);
            // 
            // nm_disratio
            // 
            this.nm_disratio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nm_disratio.Font = new System.Drawing.Font("Tahoma", 11F);
            this.nm_disratio.Location = new System.Drawing.Point(2, 32);
            this.nm_disratio.Margin = new System.Windows.Forms.Padding(2);
            this.nm_disratio.Name = "nm_disratio";
            this.nm_disratio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nm_disratio.Size = new System.Drawing.Size(335, 25);
            this.nm_disratio.TabIndex = 16;
            this.nm_disratio.ValueChanged += new System.EventHandler(this.nm_disratio_ValueChanged);
            // 
            // nm_total
            // 
            this.nm_total.DecimalPlaces = 2;
            this.nm_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nm_total.Font = new System.Drawing.Font("Tahoma", 11F);
            this.nm_total.Location = new System.Drawing.Point(2, 2);
            this.nm_total.Margin = new System.Windows.Forms.Padding(2);
            this.nm_total.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nm_total.Name = "nm_total";
            this.nm_total.ReadOnly = true;
            this.nm_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nm_total.Size = new System.Drawing.Size(335, 25);
            this.nm_total.TabIndex = 15;
            this.nm_total.ValueChanged += new System.EventHandler(this.nm_total_ValueChanged);
            // 
            // txt_notes
            // 
            this.txt_notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_notes.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_notes.Location = new System.Drawing.Point(3, 93);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_notes.Size = new System.Drawing.Size(333, 25);
            this.txt_notes.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(342, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 30);
            this.label9.TabIndex = 12;
            this.label9.Text = "الملاحظات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(342, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "مجموع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(370, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "العدد";
            // 
            // nm_quantity
            // 
            this.nm_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nm_quantity.Font = new System.Drawing.Font("Tahoma", 12F);
            this.nm_quantity.Location = new System.Drawing.Point(2, 2);
            this.nm_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.nm_quantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nm_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_quantity.Name = "nm_quantity";
            this.nm_quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nm_quantity.Size = new System.Drawing.Size(363, 27);
            this.nm_quantity.TabIndex = 2;
            this.nm_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_product
            // 
            this.lb_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_product.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lb_product.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_product.FormattingEnabled = true;
            this.lb_product.ItemHeight = 23;
            this.lb_product.Location = new System.Drawing.Point(148, 21);
            this.lb_product.Margin = new System.Windows.Forms.Padding(1);
            this.lb_product.Name = "lb_product";
            this.lb_product.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel8.SetRowSpan(this.lb_product, 6);
            this.lb_product.Size = new System.Drawing.Size(145, 430);
            this.lb_product.TabIndex = 3;
            this.lb_product.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_product_DrawItem);
            this.lb_product.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_product_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "الفئات";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(148, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "المنتجات";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_cat
            // 
            this.lb_cat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_cat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lb_cat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lb_cat.FormattingEnabled = true;
            this.lb_cat.ItemHeight = 25;
            this.lb_cat.Location = new System.Drawing.Point(1, 21);
            this.lb_cat.Margin = new System.Windows.Forms.Padding(1);
            this.lb_cat.Name = "lb_cat";
            this.lb_cat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel8.SetRowSpan(this.lb_cat, 6);
            this.lb_cat.Size = new System.Drawing.Size(145, 430);
            this.lb_cat.TabIndex = 12;
            this.lb_cat.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_cat_DrawItem);
            this.lb_cat.SelectedIndexChanged += new System.EventHandler(this.lb_cat_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.14322F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85678F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.nm_quantity, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(296, 224);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(437, 28);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.Quantity,
            this.UnitPrice,
            this.Total,
            this.Delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(294, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(441, 194);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.10811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.89189F));
            this.tableLayoutPanel1.Controls.Add(this.nm_nettotal, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nm_discount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nm_disratio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nm_total, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_notes, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(297, 298);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 151);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(342, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "الخصم (%) ج ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(342, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "الخصم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(342, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "الإجمالى";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "اطبع";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 493);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(735, 42);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 35);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("HSN Shahd Regular", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(43, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(689, 41);
            this.label6.TabIndex = 6;
            this.label6.Text = "تيك اواي";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(735, 41);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel8.Controls.Add(this.bunifuSeparator2, 2, 5);
            this.tableLayoutPanel8.Controls.Add(this.bunifuSeparator1, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.button2, 2, 4);
            this.tableLayoutPanel8.Controls.Add(this.lb_product, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel1, 2, 6);
            this.tableLayoutPanel8.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel4, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.dataGridView1, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.lb_cat, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 7;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.72467F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.880788F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.120811F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.27373F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(735, 452);
            this.tableLayoutPanel8.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(295, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(439, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "عرض البيانات";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(297, 217);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(435, 2);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(297, 290);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(435, 2);
            this.bunifuSeparator2.TabIndex = 23;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "كود المنتح";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 99.0752F;
            this.ItemName.HeaderText = "اسم المنتج";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 98.44588F;
            this.Quantity.HeaderText = "الكميه";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.FillWeight = 97.13326F;
            this.UnitPrice.HeaderText = "سعر الوحده";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 100.5025F;
            this.Total.HeaderText = "الاجمالي";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 104.8432F;
            this.Delete.HeaderText = "حذف";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // Take_Away
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel8);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Take_Away";
            this.Size = new System.Drawing.Size(735, 535);
            this.Load += new System.EventHandler(this.Take_Away_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nm_nettotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_disratio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_quantity)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nm_nettotal;
        private System.Windows.Forms.NumericUpDown nm_discount;
        private System.Windows.Forms.NumericUpDown nm_disratio;
        private System.Windows.Forms.NumericUpDown nm_total;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nm_quantity;
        private System.Windows.Forms.ListBox lb_product;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lb_cat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
