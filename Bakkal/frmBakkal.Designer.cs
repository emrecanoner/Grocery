namespace Bakkal
{
    partial class frmBakkal
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
            this.Ürünler = new System.Windows.Forms.ListBox();
            this.Alınanlar = new System.Windows.Forms.ListBox();
            this.se1 = new DevExpress.XtraEditors.SpinEdit();
            this.se2 = new DevExpress.XtraEditors.SpinEdit();
            this.se3 = new DevExpress.XtraEditors.SpinEdit();
            this.se4 = new DevExpress.XtraEditors.SpinEdit();
            this.se5 = new DevExpress.XtraEditors.SpinEdit();
            this.se6 = new DevExpress.XtraEditors.SpinEdit();
            this.se7 = new DevExpress.XtraEditors.SpinEdit();
            this.btnyazdır = new System.Windows.Forms.Button();
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.tbox2 = new System.Windows.Forms.TextBox();
            this.tbox3 = new System.Windows.Forms.TextBox();
            this.tbox4 = new System.Windows.Forms.TextBox();
            this.tbox5 = new System.Windows.Forms.TextBox();
            this.tbox6 = new System.Windows.Forms.TextBox();
            this.tbox7 = new System.Windows.Forms.TextBox();
            this.btnfiş = new System.Windows.Forms.Button();
            this.tboxtarih = new System.Windows.Forms.TextBox();
            this.tboxzaman = new System.Windows.Forms.TextBox();
            this.tboxtoplam = new System.Windows.Forms.TextBox();
            this.gboxfiş = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxyazıyla = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.se1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se7.Properties)).BeginInit();
            this.gboxfiş.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ürünler
            // 
            this.Ürünler.FormattingEnabled = true;
            this.Ürünler.Items.AddRange(new object[] {
            "Ekmek",
            "",
            "Süt",
            " ",
            "Sakız",
            "",
            "Yoğurt",
            " ",
            "Doritos",
            " ",
            "Süzme Peynir",
            "",
            "Pepsi"});
            this.Ürünler.Location = new System.Drawing.Point(12, 33);
            this.Ürünler.Name = "Ürünler";
            this.Ürünler.Size = new System.Drawing.Size(142, 199);
            this.Ürünler.TabIndex = 0;
            this.Ürünler.DoubleClick += new System.EventHandler(this.Ürünler_DoubleClick);
            // 
            // Alınanlar
            // 
            this.Alınanlar.FormattingEnabled = true;
            this.Alınanlar.Location = new System.Drawing.Point(314, 33);
            this.Alınanlar.Name = "Alınanlar";
            this.Alınanlar.Size = new System.Drawing.Size(142, 199);
            this.Alınanlar.TabIndex = 0;
            // 
            // se1
            // 
            this.se1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se1.Location = new System.Drawing.Point(108, 33);
            this.se1.Name = "se1";
            this.se1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se1.Properties.DisplayFormat.FormatString = "0";
            this.se1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.se1.Properties.EditFormat.FormatString = "0";
            this.se1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.se1.Size = new System.Drawing.Size(35, 20);
            this.se1.TabIndex = 1;
            // 
            // se2
            // 
            this.se2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se2.Location = new System.Drawing.Point(108, 59);
            this.se2.Name = "se2";
            this.se2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se2.Size = new System.Drawing.Size(35, 20);
            this.se2.TabIndex = 1;
            // 
            // se3
            // 
            this.se3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se3.Location = new System.Drawing.Point(108, 85);
            this.se3.Name = "se3";
            this.se3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se3.Size = new System.Drawing.Size(34, 20);
            this.se3.TabIndex = 1;
            // 
            // se4
            // 
            this.se4.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se4.Location = new System.Drawing.Point(108, 111);
            this.se4.Name = "se4";
            this.se4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se4.Size = new System.Drawing.Size(34, 20);
            this.se4.TabIndex = 1;
            // 
            // se5
            // 
            this.se5.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se5.Location = new System.Drawing.Point(108, 137);
            this.se5.Name = "se5";
            this.se5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se5.Size = new System.Drawing.Size(34, 20);
            this.se5.TabIndex = 1;
            // 
            // se6
            // 
            this.se6.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se6.Location = new System.Drawing.Point(108, 163);
            this.se6.Name = "se6";
            this.se6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se6.Size = new System.Drawing.Size(34, 20);
            this.se6.TabIndex = 1;
            // 
            // se7
            // 
            this.se7.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se7.Location = new System.Drawing.Point(108, 189);
            this.se7.Name = "se7";
            this.se7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se7.Size = new System.Drawing.Size(34, 20);
            this.se7.TabIndex = 1;
            // 
            // btnyazdır
            // 
            this.btnyazdır.Location = new System.Drawing.Point(198, 101);
            this.btnyazdır.Name = "btnyazdır";
            this.btnyazdır.Size = new System.Drawing.Size(75, 82);
            this.btnyazdır.TabIndex = 2;
            this.btnyazdır.Text = "Okut";
            this.btnyazdır.UseVisualStyleBackColor = true;
            this.btnyazdır.Click += new System.EventHandler(this.btnyazdır_Click);
            // 
            // tbox1
            // 
            this.tbox1.Enabled = false;
            this.tbox1.Location = new System.Drawing.Point(392, 36);
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(54, 20);
            this.tbox1.TabIndex = 3;
            // 
            // tbox2
            // 
            this.tbox2.Enabled = false;
            this.tbox2.Location = new System.Drawing.Point(392, 63);
            this.tbox2.Name = "tbox2";
            this.tbox2.Size = new System.Drawing.Size(54, 20);
            this.tbox2.TabIndex = 3;
            // 
            // tbox3
            // 
            this.tbox3.Enabled = false;
            this.tbox3.Location = new System.Drawing.Point(392, 89);
            this.tbox3.Name = "tbox3";
            this.tbox3.Size = new System.Drawing.Size(54, 20);
            this.tbox3.TabIndex = 3;
            // 
            // tbox4
            // 
            this.tbox4.Enabled = false;
            this.tbox4.Location = new System.Drawing.Point(392, 115);
            this.tbox4.Name = "tbox4";
            this.tbox4.Size = new System.Drawing.Size(54, 20);
            this.tbox4.TabIndex = 3;
            // 
            // tbox5
            // 
            this.tbox5.Enabled = false;
            this.tbox5.Location = new System.Drawing.Point(392, 141);
            this.tbox5.Name = "tbox5";
            this.tbox5.Size = new System.Drawing.Size(54, 20);
            this.tbox5.TabIndex = 3;
            // 
            // tbox6
            // 
            this.tbox6.Enabled = false;
            this.tbox6.Location = new System.Drawing.Point(392, 167);
            this.tbox6.Name = "tbox6";
            this.tbox6.Size = new System.Drawing.Size(54, 20);
            this.tbox6.TabIndex = 3;
            // 
            // tbox7
            // 
            this.tbox7.Enabled = false;
            this.tbox7.Location = new System.Drawing.Point(392, 193);
            this.tbox7.Name = "tbox7";
            this.tbox7.Size = new System.Drawing.Size(54, 20);
            this.tbox7.TabIndex = 3;
            // 
            // btnfiş
            // 
            this.btnfiş.Location = new System.Drawing.Point(83, 163);
            this.btnfiş.Name = "btnfiş";
            this.btnfiş.Size = new System.Drawing.Size(85, 43);
            this.btnfiş.TabIndex = 4;
            this.btnfiş.Text = "Yazdır";
            this.btnfiş.UseVisualStyleBackColor = true;
            this.btnfiş.Click += new System.EventHandler(this.btnfiş_Click);
            // 
            // tboxtarih
            // 
            this.tboxtarih.Enabled = false;
            this.tboxtarih.Location = new System.Drawing.Point(69, 30);
            this.tboxtarih.Name = "tboxtarih";
            this.tboxtarih.Size = new System.Drawing.Size(129, 20);
            this.tboxtarih.TabIndex = 5;
            // 
            // tboxzaman
            // 
            this.tboxzaman.Enabled = false;
            this.tboxzaman.Location = new System.Drawing.Point(69, 65);
            this.tboxzaman.Name = "tboxzaman";
            this.tboxzaman.Size = new System.Drawing.Size(129, 20);
            this.tboxzaman.TabIndex = 6;
            // 
            // tboxtoplam
            // 
            this.tboxtoplam.Enabled = false;
            this.tboxtoplam.Location = new System.Drawing.Point(69, 100);
            this.tboxtoplam.Name = "tboxtoplam";
            this.tboxtoplam.Size = new System.Drawing.Size(129, 20);
            this.tboxtoplam.TabIndex = 7;
            // 
            // gboxfiş
            // 
            this.gboxfiş.Controls.Add(this.tboxyazıyla);
            this.gboxfiş.Controls.Add(this.label3);
            this.gboxfiş.Controls.Add(this.tboxtoplam);
            this.gboxfiş.Controls.Add(this.label2);
            this.gboxfiş.Controls.Add(this.tboxzaman);
            this.gboxfiş.Controls.Add(this.label1);
            this.gboxfiş.Controls.Add(this.tboxtarih);
            this.gboxfiş.Controls.Add(this.btnfiş);
            this.gboxfiş.Location = new System.Drawing.Point(508, 33);
            this.gboxfiş.Name = "gboxfiş";
            this.gboxfiş.Size = new System.Drawing.Size(238, 220);
            this.gboxfiş.TabIndex = 8;
            this.gboxfiş.TabStop = false;
            this.gboxfiş.Text = "Fiş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Toplam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tarih :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zaman :";
            // 
            // tboxyazıyla
            // 
            this.tboxyazıyla.Enabled = false;
            this.tboxyazıyla.Location = new System.Drawing.Point(6, 134);
            this.tboxyazıyla.Name = "tboxyazıyla";
            this.tboxyazıyla.Size = new System.Drawing.Size(226, 20);
            this.tboxyazıyla.TabIndex = 12;
            // 
            // frmBakkal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 313);
            this.Controls.Add(this.gboxfiş);
            this.Controls.Add(this.tbox7);
            this.Controls.Add(this.tbox6);
            this.Controls.Add(this.tbox5);
            this.Controls.Add(this.tbox4);
            this.Controls.Add(this.tbox3);
            this.Controls.Add(this.tbox2);
            this.Controls.Add(this.tbox1);
            this.Controls.Add(this.btnyazdır);
            this.Controls.Add(this.se7);
            this.Controls.Add(this.se6);
            this.Controls.Add(this.se5);
            this.Controls.Add(this.se4);
            this.Controls.Add(this.se3);
            this.Controls.Add(this.se2);
            this.Controls.Add(this.se1);
            this.Controls.Add(this.Alınanlar);
            this.Controls.Add(this.Ürünler);
            this.Name = "frmBakkal";
            this.Text = "Bakkal";
            this.Load += new System.EventHandler(this.frmBakkal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.se1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se7.Properties)).EndInit();
            this.gboxfiş.ResumeLayout(false);
            this.gboxfiş.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Ürünler;
        private System.Windows.Forms.ListBox Alınanlar;
        private DevExpress.XtraEditors.SpinEdit se1;
        private DevExpress.XtraEditors.SpinEdit se2;
        private DevExpress.XtraEditors.SpinEdit se3;
        private DevExpress.XtraEditors.SpinEdit se4;
        private DevExpress.XtraEditors.SpinEdit se5;
        private DevExpress.XtraEditors.SpinEdit se6;
        private DevExpress.XtraEditors.SpinEdit se7;
        private System.Windows.Forms.Button btnyazdır;
        private System.Windows.Forms.TextBox tbox1;
        private System.Windows.Forms.TextBox tbox2;
        private System.Windows.Forms.TextBox tbox3;
        private System.Windows.Forms.TextBox tbox4;
        private System.Windows.Forms.TextBox tbox5;
        private System.Windows.Forms.TextBox tbox6;
        private System.Windows.Forms.TextBox tbox7;
        private System.Windows.Forms.Button btnfiş;
        private System.Windows.Forms.TextBox tboxtarih;
        private System.Windows.Forms.TextBox tboxzaman;
        private System.Windows.Forms.TextBox tboxtoplam;
        private System.Windows.Forms.GroupBox gboxfiş;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxyazıyla;
    }
}

