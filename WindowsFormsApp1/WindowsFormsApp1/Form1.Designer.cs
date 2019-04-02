namespace WindowsFormsApp1
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
            this.lblNewCar = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCylinder = new System.Windows.Forms.Label();
            this.numCylinder = new System.Windows.Forms.NumericUpDown();
            this.lblArrayResult = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCylinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewCar
            // 
            this.lblNewCar.AutoSize = true;
            this.lblNewCar.Location = new System.Drawing.Point(12, 9);
            this.lblNewCar.Name = "lblNewCar";
            this.lblNewCar.Size = new System.Drawing.Size(48, 13);
            this.lblNewCar.TabIndex = 0;
            this.lblNewCar.Text = "New Car";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(43, 66);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Brand";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(180, 66);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Location = new System.Drawing.Point(15, 115);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(100, 20);
            this.txtCarBrand.TabIndex = 3;
            this.txtCarBrand.TextChanged += new System.EventHandler(this.txtCarBrand_TextChanged);
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(15, 196);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCar.TabIndex = 5;
            this.btnCreateCar.Text = "Create Car";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(15, 261);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 6;
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(143, 115);
            this.numYear.Maximum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(120, 20);
            this.numYear.TabIndex = 7;
            this.numYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(315, 114);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 8;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(339, 66);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color";
            this.lblColor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCylinder
            // 
            this.lblCylinder.AutoSize = true;
            this.lblCylinder.Location = new System.Drawing.Point(482, 66);
            this.lblCylinder.Name = "lblCylinder";
            this.lblCylinder.Size = new System.Drawing.Size(66, 13);
            this.lblCylinder.TabIndex = 11;
            this.lblCylinder.Text = "CylinderNum";
            // 
            // numCylinder
            // 
            this.numCylinder.Location = new System.Drawing.Point(457, 114);
            this.numCylinder.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numCylinder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCylinder.Name = "numCylinder";
            this.numCylinder.Size = new System.Drawing.Size(120, 20);
            this.numCylinder.TabIndex = 12;
            this.numCylinder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCylinder.ValueChanged += new System.EventHandler(this.numCylinder_ValueChanged);
            // 
            // lblArrayResult
            // 
            this.lblArrayResult.AutoSize = true;
            this.lblArrayResult.Location = new System.Drawing.Point(454, 317);
            this.lblArrayResult.Name = "lblArrayResult";
            this.lblArrayResult.Size = new System.Drawing.Size(0, 13);
            this.lblArrayResult.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(619, 114);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "MotelType";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblArrayResult);
            this.Controls.Add(this.numCylinder);
            this.Controls.Add(this.lblCylinder);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCreateCar);
            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblNewCar);
            this.Name = "Form1";
            this.Text = "MyApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCylinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewCar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCylinder;
        private System.Windows.Forms.NumericUpDown numCylinder;
        private System.Windows.Forms.Label lblArrayResult;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

